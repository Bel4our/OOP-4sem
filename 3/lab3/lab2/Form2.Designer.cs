namespace lab2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.accNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.passportDataCheckBox = new System.Windows.Forms.CheckBox();
            this.fullNameCheckBox = new System.Windows.Forms.CheckBox();
            this.balanceCheckBox = new System.Windows.Forms.CheckBox();
            this.accNumbSearchBox = new System.Windows.Forms.TextBox();
            this.passportDataSearchBox = new System.Windows.Forms.TextBox();
            this.fullNameSearchBox = new System.Windows.Forms.TextBox();
            this.balanceSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите критерии";
            // 
            // resultBox
            // 
            this.resultBox.FormattingEnabled = true;
            this.resultBox.HorizontalScrollbar = true;
            this.resultBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultBox.ItemHeight = 16;
            this.resultBox.Location = new System.Drawing.Point(283, 242);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(256, 132);
            this.resultBox.TabIndex = 29;
            // 
            // accNumberCheckBox
            // 
            this.accNumberCheckBox.AutoSize = true;
            this.accNumberCheckBox.Location = new System.Drawing.Point(25, 66);
            this.accNumberCheckBox.Name = "accNumberCheckBox";
            this.accNumberCheckBox.Size = new System.Drawing.Size(113, 20);
            this.accNumberCheckBox.TabIndex = 30;
            this.accNumberCheckBox.Text = "Номер счёта";
            this.accNumberCheckBox.UseVisualStyleBackColor = true;
            this.accNumberCheckBox.CheckedChanged += new System.EventHandler(this.accNumberCheckBox_CheckedChanged);
            // 
            // passportDataCheckBox
            // 
            this.passportDataCheckBox.AutoSize = true;
            this.passportDataCheckBox.Location = new System.Drawing.Point(25, 93);
            this.passportDataCheckBox.Name = "passportDataCheckBox";
            this.passportDataCheckBox.Size = new System.Drawing.Size(162, 20);
            this.passportDataCheckBox.TabIndex = 31;
            this.passportDataCheckBox.Text = "Паспортные данные";
            this.passportDataCheckBox.UseVisualStyleBackColor = true;
            this.passportDataCheckBox.CheckedChanged += new System.EventHandler(this.passportDataCheckBox_CheckedChanged);
            // 
            // fullNameCheckBox
            // 
            this.fullNameCheckBox.AutoSize = true;
            this.fullNameCheckBox.Location = new System.Drawing.Point(25, 119);
            this.fullNameCheckBox.Name = "fullNameCheckBox";
            this.fullNameCheckBox.Size = new System.Drawing.Size(60, 20);
            this.fullNameCheckBox.TabIndex = 32;
            this.fullNameCheckBox.Text = "ФИО";
            this.fullNameCheckBox.UseVisualStyleBackColor = true;
            this.fullNameCheckBox.CheckedChanged += new System.EventHandler(this.fullNameCheckBox_CheckedChanged);
            // 
            // balanceCheckBox
            // 
            this.balanceCheckBox.AutoSize = true;
            this.balanceCheckBox.Location = new System.Drawing.Point(25, 145);
            this.balanceCheckBox.Name = "balanceCheckBox";
            this.balanceCheckBox.Size = new System.Drawing.Size(77, 20);
            this.balanceCheckBox.TabIndex = 33;
            this.balanceCheckBox.Text = "Баланс";
            this.balanceCheckBox.UseVisualStyleBackColor = true;
            this.balanceCheckBox.CheckedChanged += new System.EventHandler(this.balanceCheckBox_CheckedChanged);
            // 
            // accNumbSearchBox
            // 
            this.accNumbSearchBox.Enabled = false;
            this.accNumbSearchBox.Location = new System.Drawing.Point(199, 66);
            this.accNumbSearchBox.Name = "accNumbSearchBox";
            this.accNumbSearchBox.Size = new System.Drawing.Size(122, 22);
            this.accNumbSearchBox.TabIndex = 34;
            // 
            // passportDataSearchBox
            // 
            this.passportDataSearchBox.Enabled = false;
            this.passportDataSearchBox.Location = new System.Drawing.Point(199, 93);
            this.passportDataSearchBox.Name = "passportDataSearchBox";
            this.passportDataSearchBox.Size = new System.Drawing.Size(122, 22);
            this.passportDataSearchBox.TabIndex = 35;
            // 
            // fullNameSearchBox
            // 
            this.fullNameSearchBox.Enabled = false;
            this.fullNameSearchBox.Location = new System.Drawing.Point(199, 119);
            this.fullNameSearchBox.Name = "fullNameSearchBox";
            this.fullNameSearchBox.Size = new System.Drawing.Size(122, 22);
            this.fullNameSearchBox.TabIndex = 36;
            // 
            // balanceSearchBox
            // 
            this.balanceSearchBox.Enabled = false;
            this.balanceSearchBox.Location = new System.Drawing.Point(199, 145);
            this.balanceSearchBox.Name = "balanceSearchBox";
            this.balanceSearchBox.Size = new System.Drawing.Size(122, 22);
            this.balanceSearchBox.TabIndex = 37;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.searchButton.Location = new System.Drawing.Point(25, 179);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(186, 35);
            this.searchButton.TabIndex = 38;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.searchToolStripMenuItem.Text = "Поиск";
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accNumberToolStripMenuItem,
            this.balanceToolStripMenuItem});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.сортировкаПоToolStripMenuItem.Text = "Сортировка по";
            // 
            // accNumberToolStripMenuItem
            // 
            this.accNumberToolStripMenuItem.Name = "accNumberToolStripMenuItem";
            this.accNumberToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.accNumberToolStripMenuItem.Text = "Номеру счёта";
            this.accNumberToolStripMenuItem.Click += new System.EventHandler(this.accNumberToolStripMenuItem_Click);
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.balanceToolStripMenuItem.Text = "Балансу";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.balanceToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.balanceSearchBox);
            this.Controls.Add(this.fullNameSearchBox);
            this.Controls.Add(this.passportDataSearchBox);
            this.Controls.Add(this.accNumbSearchBox);
            this.Controls.Add(this.balanceCheckBox);
            this.Controls.Add(this.fullNameCheckBox);
            this.Controls.Add(this.passportDataCheckBox);
            this.Controls.Add(this.accNumberCheckBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox resultBox;
        private System.Windows.Forms.CheckBox accNumberCheckBox;
        private System.Windows.Forms.CheckBox passportDataCheckBox;
        private System.Windows.Forms.CheckBox fullNameCheckBox;
        private System.Windows.Forms.CheckBox balanceCheckBox;
        private System.Windows.Forms.TextBox accNumbSearchBox;
        private System.Windows.Forms.TextBox passportDataSearchBox;
        private System.Windows.Forms.TextBox fullNameSearchBox;
        private System.Windows.Forms.TextBox balanceSearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
    }
}