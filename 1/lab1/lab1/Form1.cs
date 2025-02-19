using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
      
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void buttonCalc_Click(object sender, EventArgs e)
        {

            try
            {
                int first = Convert.ToInt32(firstNumb.Text);
                int second = Convert.ToInt32(secondNumb.Text);
                long resultOfCalc = 0;
                if(operation.SelectedItem == null)
                {
                    throw new Exception("Выберите операцию!");
                }
                string oper = operation.SelectedItem.ToString();

                switch (oper)
                {
                    case "AND":
                        resultOfCalc = first & second;
                        break;
                    case "OR":
                        resultOfCalc = first | second;
                        break;
                    case "XOR":
                        resultOfCalc = first ^ second;
                        break;
                    case "NOT":
                        resultOfCalc = ~first;
                        break;
                    default:
                        MessageBox.Show("Некорректная операция!");
                        return;
                }

                string formattedResult = "";

                if (notation.SelectedItem == null)
                {
                    throw new Exception("Выберите систему счисления!");
                }

                string numberSystem = notation.SelectedItem.ToString();
                switch (numberSystem)
                {
                    case "Двоичная":
                        formattedResult = Convert.ToString(resultOfCalc, 2);
                        break;
                    case "Восьмеричная":
                        formattedResult = Convert.ToString(resultOfCalc, 8);
                        break;
                    case "Десятичная":
                        formattedResult = Convert.ToString(resultOfCalc, 10);
                        break;
                    case "Шестнадцатеричная":
                        formattedResult = Convert.ToString(resultOfCalc, 16).ToUpper();
                        break;
                    default:
                        MessageBox.Show("Выберите систему счисления!");
                        return;
                }

                result.Text = formattedResult;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка! "+ ex.Message);
            }







        }


        private void firstNumb_TextChanged(object sender, EventArgs e)
        {

        }

        private void operation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void secondNumb_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void notation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
