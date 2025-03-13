using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class InputAccNumber : Form
    {
        public string EnteredText { get; private set; }
        public InputAccNumber()
        {
            InitializeComponent();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            EnteredText = inputTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
