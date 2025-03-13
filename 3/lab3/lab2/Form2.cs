using lab3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class Form2 : Form
    {

        List<BankAccount> searchResults = new List<BankAccount>();
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void accNumberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (accNumberCheckBox.Checked)
            {
                accNumbSearchBox.Enabled = true;
            }
            else
            {
                accNumbSearchBox.Enabled = false;
            }
        }

        private void passportDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passportDataCheckBox.Checked)
            {
                passportDataSearchBox.Enabled = true;
            }
            else
            {
                passportDataSearchBox.Enabled = false;
            }
        }

        private void fullNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fullNameCheckBox.Checked)
            {
                fullNameSearchBox.Enabled = true;
            }
            else
            {
                fullNameSearchBox.Enabled = false;
            }
        }

        private void balanceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (balanceCheckBox.Checked)
            {
                balanceSearchBox.Enabled = true;
            }
            else
            {
                balanceSearchBox.Enabled = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string filePath = "accountData.json";
            searchResults.Clear();

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                List<BankAccount> accounts = JsonSerializer.Deserialize<List<BankAccount>>(jsonData) ?? new List<BankAccount>();

                foreach (var account in accounts)
                {
                    bool matchesCriteria = true;

                    if (accNumberCheckBox.Checked)
                    {
                        if (string.IsNullOrEmpty(accNumbSearchBox.Text))
                        {
                            matchesCriteria = false; 
                        }
                        else
                        {
                            string accNumberPattern = accNumbSearchBox.Text;
                            if (IsRegexPattern(accNumberPattern))
                            {
                                matchesCriteria &= Regex.IsMatch(account.Number.ToString(), accNumberPattern);
                            }
                            else
                            {
                                matchesCriteria &= account.Number.ToString() == accNumberPattern;
                            }
                        }
                    }

                    if (passportDataCheckBox.Checked)
                    {
                        if (string.IsNullOrEmpty(passportDataSearchBox.Text))
                        {
                            matchesCriteria = false; 
                        }
                        else
                        {
                            string passportPattern = passportDataSearchBox.Text;
                            if (IsRegexPattern(passportPattern))
                            {
                                matchesCriteria &= Regex.IsMatch(account.Owner.PasportData, passportPattern);
                            }
                            else
                            {
                                matchesCriteria &= account.Owner.PasportData == passportPattern;
                            }
                        }
                    }

                    if (fullNameCheckBox.Checked)
                    {
                        if (string.IsNullOrEmpty(fullNameSearchBox.Text))
                        {
                            matchesCriteria = false; 
                        }
                        else
                        {
                            string fullNamePattern = fullNameSearchBox.Text;
                            if (IsRegexPattern(fullNamePattern))
                            {
                                matchesCriteria &= Regex.IsMatch(account.Owner.Name, fullNamePattern);
                            }
                            else
                            {
                                matchesCriteria &= account.Owner.Name == fullNamePattern;
                            }
                        }
                    }

                    if (balanceCheckBox.Checked)
                    {
                        if (string.IsNullOrEmpty(balanceSearchBox.Text))
                        {
                            matchesCriteria = false; 
                        }
                        else
                        {
                            string balancePattern = balanceSearchBox.Text;
                            if (IsRegexPattern(balancePattern))
                            {
                                matchesCriteria &= Regex.IsMatch(account.Balance.ToString(), balancePattern);
                            }
                            else
                            {
                                matchesCriteria &= account.Balance.ToString() == balancePattern;
                            }
                        }
                    }

                    if (matchesCriteria)
                    {
                        searchResults.Add(account);
                    }
                }

                DisplayResults(searchResults);
            }
            else
            {
                MessageBox.Show("Файл с данными не найден.");
            }
        }

        private bool IsRegexPattern(string input)
        {
            string regexSpecialChars = @".*+?^${}()|[]\";

            foreach (char c in regexSpecialChars)
            {
                if (input.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }

        private void DisplayResults(List<BankAccount> results)
        {
            resultBox.Items.Clear(); 

            if (results.Count == 0)
            {
                resultBox.Items.Add("Ничего не найдено.");
                return;
            }

            foreach (var account in results)
            {
                resultBox.Items.Add($"Номер счета: {account.Number}");
                resultBox.Items.Add($"Тип счета: {account.Type}");
                resultBox.Items.Add($"Баланс: {account.Balance}");
                resultBox.Items.Add($"Дата открытия: {account.OpeningDate.ToShortDateString()}");
                resultBox.Items.Add($"Владелец: {account.Owner.Name}");
                resultBox.Items.Add($"Паспортные данные: {account.Owner.PasportData}");
                resultBox.Items.Add($"Дата рождения: {account.Owner.Birthday.ToShortDateString()}");
                resultBox.Items.Add($"SMS уведомления: {account.SmsNotification}");
                resultBox.Items.Add($"Интернет-банкинг: {account.InternetBanking}");
                resultBox.Items.Add("История операций:");

                foreach (var operation in account.History)
                {
                    resultBox.Items.Add($"  Тип операции: {operation.OperationType}");
                    resultBox.Items.Add($"  Дата операции: {operation.OperationDate.ToShortDateString()}");
                    resultBox.Items.Add($"  Баланс после операции: {operation.Balance}");
                }

                resultBox.Items.Add("------");
            }
        }

        private void accNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchResults == null || !searchResults.Any())
            {
                MessageBox.Show("Нет данных для сортировки!");
                return;
            }

            searchResults = searchResults.OrderBy(acc => acc.Number).ToList();
            resultBox.Items.Clear();
            DisplayResults(searchResults);
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchResults == null || !searchResults.Any())
            {
                MessageBox.Show("Нет данных для сортировки!");
                return;
            }

            searchResults = searchResults.OrderBy(acc => acc.Balance).ToList();
            resultBox.Items.Clear();
            DisplayResults(searchResults);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (searchResults == null || !searchResults.Any())
            {
                MessageBox.Show("Нет данных для сохранения!");
                return;
            }
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText("searchResult.json", JsonSerializer.Serialize(searchResults, options));
            MessageBox.Show("Данные сохранены!");
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Семёнов Даниил Вячеславович: v 0.0.0.2", "Разработчик и версия");
        }
    }
}
