using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace lab3
{
    public partial class Form1 : Form
    {
        private List<BankAccount> bankAccounts = new List<BankAccount>();
        private List<BankAccount> sortedAccounts = new List<BankAccount>();
        private Dictionary<DateTime, (string OperationType, int OperationSum)> operations = new Dictionary<DateTime, (string, int)>();

        private Stack<State> undoStack = new Stack<State>();
        private Stack<State> redoStack = new Stack<State>();

        private Timer timer;
        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();

            accountNumber.TextChanged += ValidateFields;
            radioButtonRevocable.CheckedChanged += ValidateFields;
            radioButtonIrrevocable.CheckedChanged += ValidateFields;
            Balance.ValueChanged += ValidateFields;
            openingDate.ValueChanged += ValidateFields;
            birthDay.ValueChanged += ValidateFields;
            fullName.TextChanged += ValidateFields;
            passportData.TextChanged += ValidateFields;
            smsNotification.SelectedIndexChanged += ValidateFields;
            LoadAccountsFromFile();
            UpdateLastAction("Форма загружена");
        }

        private void LoadAccountsFromFile()
        {
            string filePath = "accountData.json";

            if (File.Exists(filePath))
            {
                try
                {
                    string fileContent = File.ReadAllText(filePath);

                    var accounts = JsonSerializer.Deserialize<List<BankAccount>>(fileContent);

                    if (accounts != null)
                    {
                        bankAccounts = accounts; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных из файла: {ex.Message}");
                }
            }
            else
            {
                bankAccounts = new List<BankAccount>();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDateTime.Text = $"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm:ss}";
        }

        private void backToolStripButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(new State(bankAccounts));

                var previousState = undoStack.Pop();
                bankAccounts = previousState.Accounts;

                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText("accountData.json", JsonSerializer.Serialize(bankAccounts, options));

                DisplayData(bankAccounts);
                UpdateLastAction("Назад");
            }
            else
            {
                MessageBox.Show("Нет действий для отмены.");
            }
        }

        private void forwardToolStripButton_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(new State(bankAccounts));

                var nextState = redoStack.Pop();
                bankAccounts = nextState.Accounts;

                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText("accountData.json", JsonSerializer.Serialize(bankAccounts, options));
      
                DisplayData(bankAccounts);
                UpdateLastAction("Вперёд");
            }
            else
            {
                MessageBox.Show("Нет действий для повторения.");
            }
        }

        private void toggleToolStripButton_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            UpdateLastAction("Скрыть/показать меню");
        }

        private void ValidateFields(object sender, EventArgs e)
        {
            bool isValidated = isValid();
            operationDate.Enabled = isValidated;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (int.TryParse(accountNumber.Text, out int accountNumberValue))
                {
                    if (bankAccounts.Any(acc => acc.Number == accountNumberValue))
                    {
                        MessageBox.Show("Счёт с таким номером уже существует!");
                        return;
                    }
                }
                
                BankAccount account = new BankAccount();
                Owner owner = new Owner();
                List<OperationHistory> history = new List<OperationHistory>();

                if (int.TryParse(accountNumber.Text, out accountNumberValue))
                {
                    account.Number = accountNumberValue;
                }

                account.Type = radioButtonRevocable.Checked ? radioButtonRevocable.Text : radioButtonIrrevocable.Checked ? radioButtonIrrevocable.Text : null;
                account.Balance = (int)Balance.Value;
                account.OpeningDate = (DateTime)openingDate?.Value;
                owner.Birthday = (DateTime)birthDay?.Value;
                owner.Name = fullName.Text;
                owner.PasportData = passportData.Text;
                account.InternetBanking = internetBank.Value == 0 ? "Подключён" : "Не подключён";

                account.SmsNotification = smsNotification.SelectedItem?.ToString();
                account.Owner = owner;
                account.History = history;

                var validationContextAcc = new ValidationContext(account);
                var validationContextOwner = new ValidationContext(owner);
                var validationContextHistory = new ValidationContext(history);
                var validationResults = new List<ValidationResult>();

                if (!ValidateObject(account, new ValidationContext(account), out string accountError))
                {
                    MessageBox.Show(accountError);
                    return;
                }

                if (!ValidateObject(owner, new ValidationContext(owner), out string ownerError))
                {
                    MessageBox.Show(ownerError);
                    return;
                }

                if (!ValidateObject(history, new ValidationContext(history), out string historyError))
                {
                    MessageBox.Show(historyError);
                    return;
                }

                SaveDataToFile(account, "accountData.json");

                string fileContent = File.ReadAllText("accountData.json");
                var accounts = JsonSerializer.Deserialize<List<BankAccount>>(fileContent);

                undoStack.Push(new State(bankAccounts));
                redoStack.Clear();

                bankAccounts = accounts.ToList();

                DisplayData(accounts);

                ClearData();

                UpdateLastAction("Добавлен новый счёт");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
        }

        private bool ValidateObject(object obj, ValidationContext context, out string errorMessage)
        {
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(obj, context, validationResults, true);

            if (!isValid)
            {
                errorMessage = string.Join("\n", validationResults.Select(vr => vr.ErrorMessage));
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private void SaveDataToFile(BankAccount account, string filePath)
        {
            List<BankAccount> accounts;

            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);
                accounts = JsonSerializer.Deserialize<List<BankAccount>>(existingData) ?? new List<BankAccount>();
            }
            else
            {
                accounts = new List<BankAccount>();
            }

            foreach (var operation in operations)
            {
                account.History.Add(new OperationHistory
                {
                    OperationDate = operation.Key,
                    OperationType = operation.Value.OperationType,
                    Balance = operation.Value.OperationSum
                });
            }

            accounts.Add(account);

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(filePath, JsonSerializer.Serialize(accounts, options));
        }

        private void DisplayData(List<BankAccount> accounts)
        {
            outputBox.Items.Clear();

            foreach (var acc in accounts)
            {
                outputBox.Items.Add($"Номер счёта: {acc.Number}\n");
                outputBox.Items.Add($"Тип счёта: {acc.Type}\n");
                outputBox.Items.Add($"Баланс: {acc.Balance}\n");
                outputBox.Items.Add($"Дата открытия: {acc.OpeningDate.ToShortDateString()}\n");
                outputBox.Items.Add($"Владелец: {acc.Owner.Name}\n");
                outputBox.Items.Add($"Дата рождения владельца: {acc.Owner.Birthday.ToShortDateString()}\n");
                outputBox.Items.Add($"Паспортные данные: {acc.Owner.PasportData}\n");
                outputBox.Items.Add($"СМС оповещения: {acc.SmsNotification}\n");
                outputBox.Items.Add($"Интернет-банкинг: {acc.InternetBanking}\n");
                outputBox.Items.Add($"История операций:\n");
                foreach (var operation in acc.History)
                {
                    outputBox.Items.Add($"Тип операции: {operation.OperationType}\n");
                    outputBox.Items.Add($"Дата операции: {operation.OperationDate.ToShortDateString()}\n");
                    outputBox.Items.Add($"Сумма операции: {operation.Balance}\n");
                    outputBox.Items.Add("\n");
                }
                outputBox.Items.Add("\n");
            }
        }

        public void ClearData()
        {
            accountNumber.Clear();
            radioButtonRevocable.Checked = false;
            radioButtonIrrevocable.Checked = false;
            Balance.Value = 0;
            fullName.Clear();
            passportData.Clear();
            internetBank.Value = 0;
            smsNotification.SelectedIndex = 0;
            operationDate.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "accountData.json";
            List<BankAccount> accounts;
            if (File.Exists(filePath))
            {
                infoBox.Items.Clear();
                string existingData = File.ReadAllText(filePath);
                accounts = JsonSerializer.Deserialize<List<BankAccount>>(existingData) ?? new List<BankAccount>();
                float budget = 0, coeff = 0, rate = 0.15F;
                float A = 0, B = 0, C = 0;
                foreach (var acc in accounts)
                {
                    budget = acc.Balance;
                    if (acc.Type == "Отзывной")
                    {
                        A = 0.09F;
                    }
                    if (acc.InternetBanking == "Подключён")
                    {
                        B = 0.01F;
                    }
                    if (acc.SmsNotification == "Да")
                    {
                        C = 0.001F;
                    }
                    coeff = rate * (1 - A + B - C);
                    budget = budget * (1 + coeff * 2);
                    infoBox.Items.Add("Бюджет для " + acc.Owner.Name + " с балансом " + acc.Balance + " равен " + budget);
                    A = 0; B = 0; C = 0;
                }
            }
            else
            {
                MessageBox.Show("Нет данных!");
            }

            UpdateLastAction("Расчёт дохода");
        }

        private void operationDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = operationDate.Value;

            if (operations.ContainsKey(selectedDate))
            {
                operationType.Text = operations[selectedDate].OperationType;
                operationSum.Text = operations[selectedDate].OperationSum.ToString();
            }
            else
            {
                string operationTypeText;
                int operationSumValue;

                GenerateOperation(out operationTypeText, out operationSumValue);

                operations[selectedDate] = (operationTypeText, operationSumValue);

                operationType.Text = operationTypeText;
                operationSum.Text = operationSumValue.ToString();
            }
        }

        private void GenerateOperation(out string operationTypeText, out int operationSumValue)
        {
            Random random = new Random();
            int guess = random.Next(0, 3);

            if (guess == 1)
            {
                operationTypeText = "Перевод";
            }
            else if (guess == 2)
            {
                operationTypeText = "Пополнение";
            }
            else
            {
                operationTypeText = "Снятие";
            }

            operationSumValue = random.Next(1, 1000);
        }

        public bool isValid()
        {
            if (accountNumber.Text == "")
            {
                return false;
            }

            if (!radioButtonRevocable.Checked && !radioButtonIrrevocable.Checked)
            {
                return false;
            }

            if (openingDate.Value == null)
            {
                return false;
            }

            if (birthDay.Value == null)
            {
                return false;
            }

            TimeSpan difference = openingDate.Value - birthDay.Value;
            if (difference.TotalDays < 0)
            {
                return false;
            }

            if (fullName.Text == "")
            {
                return false;
            }

            if (passportData.Text == "")
            {
                return false;
            }

            if (smsNotification.SelectedItem == null)
            {
                return false;
            }

            return true;
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Семёнов Даниил Вячеславович: v 0.0.0.2", "Разработчик и версия");
            UpdateLastAction("О программе");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab2.Form2 form = new lab2.Form2();
            form.ShowDialog();
            UpdateLastAction("Поиск");
        }

        private void operationDate_DropDown(object sender, EventArgs e)
        {
            operationDate.MinDate = openingDate.Value;
            operationDate.MaxDate = DateTime.Now;
        }

        private void accountNumber_TextChanged(object sender, EventArgs e)
        {
            operations.Clear();
        }

        internal void accNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bankAccounts == null || !bankAccounts.Any())
            {
                MessageBox.Show("Нет данных для сортировки!");
                return;
            }

            sortedAccounts = bankAccounts.OrderBy(acc => acc.Number).ToList();
            outputBox.Items.Clear();
            DisplayData(sortedAccounts);
            UpdateLastAction("Сортировка");
        }

        private void showAllObjects_Click(object sender, EventArgs e)
        {
            string fileContent = File.ReadAllText("accountData.json");
            var accounts = JsonSerializer.Deserialize<List<BankAccount>>(fileContent);
            bankAccounts = accounts;
            outputBox.Items.Clear();
            DisplayData(accounts);
            UpdateLastAction("Показать все аккаунты");
        }

        internal void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bankAccounts == null || !bankAccounts.Any())
            {
                MessageBox.Show("Нет данных для сортировки!");
                return;
            }

            sortedAccounts = bankAccounts.OrderBy(acc => acc.Balance).ToList();
            outputBox.Items.Clear();
            DisplayData(sortedAccounts);
            UpdateLastAction("Сортировка");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortedAccounts == null || !sortedAccounts.Any())
            {
                MessageBox.Show("Нет данных для сохранения!");
                return;
            }
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText("sortedAccounts.json", JsonSerializer.Serialize(sortedAccounts, options));
            MessageBox.Show("Данные сохранены!");
            UpdateLastAction("Сохранение");
        }

        private void clearToolStripButton_Click(object sender, EventArgs e)
        {
            //undoStack.Push(new State(bankAccounts));
            //redoStack.Clear();
            ClearData();
            UpdateLastAction("Данные очищены");
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                InputAccNumber inputBox = new InputAccNumber();

                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    string accountNumberToDelete = inputBox.EnteredText;

                    if (string.IsNullOrEmpty(accountNumberToDelete))
                    {
                        MessageBox.Show("Номер счета не введен!");
                        return;
                    }

                    if (!int.TryParse(accountNumberToDelete, out int accountNumber))
                    {
                        MessageBox.Show("Номер счета должен быть числом!");
                        return;
                    }

                    string filePath = "accountData.json";
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("Файл с данными не найден!");
                        return;
                    }

                    string fileContent = File.ReadAllText(filePath);
                    var accounts = JsonSerializer.Deserialize<List<BankAccount>>(fileContent);

                    var accountToDelete = accounts.FirstOrDefault(acc => acc.Number == accountNumber);
                    if (accountToDelete == null)
                    {
                        MessageBox.Show("Счет с указанным номером не найден!");
                        return;
                    }

                    accounts.Remove(accountToDelete);

                    var options = new JsonSerializerOptions { WriteIndented = true };
                    File.WriteAllText(filePath, JsonSerializer.Serialize(accounts, options));

                    MessageBox.Show("Счет успешно удален!");

                    undoStack.Push(new State(bankAccounts));
                    redoStack.Clear();
                    bankAccounts = accounts;

                    DisplayData(accounts);

                    UpdateLastAction("Удалён счёт");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении счета: " + ex.Message);
            }
        }

        private void sortToolStripButton_Click(object sender, EventArgs e)
        {
            sortByToolStripMenuItem.ShowDropDown();
        }


        private void UpdateStatusStrip()
        {
            toolStripStatusLabelCount.Text = $"Количество объектов: {bankAccounts.Count}";

            toolStripStatusLabelDateTime.Text = $"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm:ss}";
        }

        private void UpdateLastAction(string action)
        {
            toolStripStatusLabelLastAction.Text = $"Последнее действие: {action}";
            UpdateStatusStrip(); 
        }
    }


    public class PassportAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string passport = value.ToString();

                if (passport.Length == 10 && Regex.IsMatch(passport, @"^MP\d{8}$"))
                {
                    return true;
                }
                else
                {
                    this.ErrorMessage = "Номер паспорта должен начинаться с MP,\nсостоять из цифр и быть длиной в 10 символов!";
                    return false;
                }
            }

            this.ErrorMessage = "Отсутствует номер паспорта!";
            return false;
        }
    }

    [Serializable]
    public class BankAccount
    {
        [Required(ErrorMessage = "Отсутствует номер счёта!")]
        [Range(1, int.MaxValue, ErrorMessage = "Номер счёта должен быть положительным числом!")]
        public int Number { get; set; }
        [Required(ErrorMessage = "Отсутствует тип вклада!")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Баланс не выбран!")]
        [Range(0, int.MaxValue, ErrorMessage = "Баланс не может быть отрицательным!")]
        public int Balance { get; set; }
        [Required(ErrorMessage = "Отсутствует дата открытия счёта!")]
        public DateTime OpeningDate { get; set; }

        public Owner Owner { get; set; }
        public List<OperationHistory> History { get; set; }

        [Required(ErrorMessage = "Отсутствует ответ для подключения смс оповещения!")]
        public string SmsNotification { get; set; }

        [Required(ErrorMessage = "Отсутствует ответ для подключения интернет-банкинга!")]
        public string InternetBanking { get; set; }
    }

    public class Owner
    {
        [Required(ErrorMessage = "Отсутствует имя!")]
        [RegularExpression(@"^(?:[a-zA-Zа-яА-ЯёЁ]{2,20}\s){2}[a-zA-Zа-яА-ЯёЁ]{2,20}$", ErrorMessage = "ФИО может содержать только буквы и должно состоять из 3-ёх слов!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Отсутствует дата рождения!")]
        public DateTime Birthday { get; set; }

        [Passport]
        public string PasportData { get; set; }
    }

    public class OperationHistory
    {
        [Required(ErrorMessage = "Отсутствует тип операции!")]
        public string OperationType { get; set; }

        [Required(ErrorMessage = "Отсутствует дата операции!")]
        public DateTime OperationDate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Баланс не может быть отрицательным!")]
        public int Balance { get; set; }
    }

    public class State
    {
        public List<BankAccount> Accounts { get; set; }

        public State(List<BankAccount> accounts)
        {
            Accounts = new List<BankAccount>(accounts);
        }
    }

}