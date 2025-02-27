using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{

    public partial class Form1 : Form
    {
        private string generatedOperationType = null;
        private int generatedOperationSum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BankAccount account = new BankAccount();
                Owner owner = new Owner();
                OperationHistory history = new OperationHistory();

                if (accountNumber.ToString() == "")
                {
                    throw new Exception("Введите номер счёта!");
                }

                try
                {
                    account.Number = int.Parse(accountNumber.Text);
                }
                catch
                {
                    throw new Exception("Не корректный номер счёта");
                }
                if (account.Number < 0)
                {
                    throw new Exception("Некорректный номер счёта!");
                }



                if (radioButtonRevocable.Checked)
                {
                    account.Type = radioButtonRevocable.Text;
                }
                else if (radioButtonIrrevocable.Checked)
                {
                    account.Type = radioButtonIrrevocable.Text;
                }
                else
                {
                    throw new Exception("Выберите тип вклада");
                }

                account.Balance = (int)Balance.Value;


                if ((DateTime)openingDate.Value == null)
                {
                    throw new Exception("Введите дату открытия счёта!");
                }
                account.OpeningDate = (DateTime)openingDate.Value;
                
                if ((DateTime)birthDay.Value == null)
                {
                    throw new Exception("Введите дату рождения!");
                }
                owner.Birthday = (DateTime)birthDay.Value;


                TimeSpan difference = account.OpeningDate - owner.Birthday;
                if (difference.TotalDays < 0)
                {
                    throw new Exception("Некорректная дата открытия счёта!");
                }
                

                if ((string)fullName.Text == "")
                {
                    throw new Exception("Введите имя!");
                }
                owner.Name = (string)fullName.Text;

                if (!ContainsOnlyLetters(owner.Name))
                {
                    throw new Exception("Некорректное имя!");
                }


                if ((string)passportData.Text == "")
                {
                    throw new Exception("Введите паспортные данные!");
                }
                owner.PasportData = (string)passportData.Text;

                if (internetBank.Value == 0)
                {
                    account.InternetBanking = "Подключён";
                }
                else
                {
                    account.InternetBanking = "Не подключён";
                }


                if (smsNotification.SelectedItem == null)
                {
                    throw new Exception("Выберите ответ для смс оповещений!");
                }
                account.SmsNotification = smsNotification.SelectedItem.ToString();

                account.Owner = owner;
                
                history.OperationDate = (DateTime)openingDate.Value;
                history.Balance = generatedOperationSum;
                history.OperationType = generatedOperationType;

                account.History = history;


                SaveDataToFile(account, "accountData.json");

                string fileContent = File.ReadAllText("accountData.json");
                var accounts = JsonSerializer.Deserialize<List<BankAccount>>(fileContent);

                DisplayData(fileContent, accounts);

                ClearData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
        }


        public static bool ContainsOnlyLetters(string input)
        {
            foreach (char c in input)
            {
                if (!(char.IsLetter(c) || c == ' '))
                {
                    return false;
                }
            }
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

            accounts.Add(account);

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(filePath, JsonSerializer.Serialize(accounts, options));
        }

        private void DisplayData(string fileContent, List<BankAccount> accounts)
        {

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

                outputBox.Items.Add($"Тип операции: {acc.History.OperationType}\n");

                outputBox.Items.Add($"Дата операции: {acc.History.OperationDate.ToShortDateString()}\n");

                outputBox.Items.Add($"Сумма операции: {acc.History.Balance}\n");

                outputBox.Items.Add("\n");

            }

        }

        public void ClearData()
        {
            generatedOperationType = null;
            generatedOperationSum = 0;
            accountNumber.Clear();
            radioButtonRevocable.Checked = false;
            radioButtonIrrevocable.Checked = false;
            Balance.Value = 0;
            fullName.Clear();
            passportData.Clear();
            internetBank.Value = 0;
            smsNotification.SelectedIndex = 0;
            generatedOperationSum = 0;
            generatedOperationType = null;
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
                foreach(var acc in accounts)
                {
                    budget = acc.Balance;
                    if(acc.Type == "Отзывной")
                    {
                        A = 0.09F;
                    }
                    if(acc.InternetBanking == "Подключён")
                    {
                        B = 0.01F;
                    }
                    if(acc.SmsNotification == "Да")
                    {
                        C = 0.001F;
                    }
                    coeff = rate * (1 - A + B - C);
                    budget = budget * (1 + coeff * 2);
                    infoBox.Items.Add("Бюджет для " + acc.Owner.Name + " с балансом " + acc.Balance + " равен "+ budget);
                    A = 0; B = 0; C = 0;
                }
            }
            else
            {
                MessageBox.Show("Нет данных!");
            }
        }

        private void operationDate_ValueChanged(object sender, EventArgs e)
        {
            if(!isValid())
            {
                return;
            }

            operationDate.MinDate = (DateTime)openingDate.Value;
            operationDate.MaxDate = (DateTime)openingDate.Value;

            if (generatedOperationType != null && generatedOperationSum != 0)
            {
                operationType.Text = generatedOperationType;
                operationSum.Text = generatedOperationSum.ToString();
                return;
            }

            Random random = new Random();

            int guess = random.Next(0, 3);

            if (guess == 1)
            {
                generatedOperationType = "Перевод";
            }
            else if (guess == 2)
            {
                generatedOperationType = "Пополнение";
            }
            else
            {
                generatedOperationType = "Снятие";
            }

            generatedOperationSum = random.Next(1, 1000);
        }

        public bool isValid()
        {
            if (accountNumber.Text == "")
            {
                return false;
            }

            //try
            //{
            //    int accountNum = int.Parse(accountNumber.Text);
            //    if (accountNum < 0)
            //    {
            //        return false;
            //    }
            //}
            //catch
            //{
            //    return false;
            //}

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

            if (!ContainsOnlyLetters(fullName.Text))
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

    }
    [Serializable]
    public class BankAccount
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public int Balance { get; set; }
        public DateTime OpeningDate { get; set; }
        public Owner Owner { get; set; }
        public OperationHistory History { get; set; }
        public string SmsNotification { get; set; }
        public string InternetBanking { get; set; }
    }

    public class Owner
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string PasportData { get; set; }
    }

    public class OperationHistory
    {
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public int Balance { get; set; }
    }
}
