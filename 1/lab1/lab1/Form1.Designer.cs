namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNumb = new System.Windows.Forms.TextBox();
            this.secondNumb = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.notation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumb
            // 
            this.firstNumb.Location = new System.Drawing.Point(54, 74);
            this.firstNumb.Name = "firstNumb";
            this.firstNumb.Size = new System.Drawing.Size(125, 22);
            this.firstNumb.TabIndex = 0;
            this.firstNumb.TextChanged += new System.EventHandler(this.firstNumb_TextChanged);
            // 
            // secondNumb
            // 
            this.secondNumb.Location = new System.Drawing.Point(369, 74);
            this.secondNumb.Name = "secondNumb";
            this.secondNumb.Size = new System.Drawing.Size(125, 22);
            this.secondNumb.TabIndex = 1;
            this.secondNumb.TextChanged += new System.EventHandler(this.secondNumb_TextChanged);
            // 
            // operation
            // 
            this.operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "AND",
            "OR",
            "XOR",
            "NOT"});
            this.operation.Location = new System.Drawing.Point(219, 74);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(121, 24);
            this.operation.TabIndex = 3;
            this.operation.SelectedIndexChanged += new System.EventHandler(this.operation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "1 число";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "операция";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "2 число";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(659, 76);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 8;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(532, 63);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(85, 45);
            this.buttonCalc.TabIndex = 9;
            this.buttonCalc.Text = "=";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результат";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // notation
            // 
            this.notation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.notation.FormattingEnabled = true;
            this.notation.Items.AddRange(new object[] {
            "Двоичная",
            "Восьмеричная",
            "Десятичная",
            "Шестнадцатеричная"});
            this.notation.Location = new System.Drawing.Point(336, 217);
            this.notation.Name = "notation";
            this.notation.Size = new System.Drawing.Size(193, 24);
            this.notation.TabIndex = 11;
            this.notation.SelectedIndexChanged += new System.EventHandler(this.notation_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Система счисления";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.notation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.secondNumb);
            this.Controls.Add(this.firstNumb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumb;
        private System.Windows.Forms.TextBox secondNumb;
        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox notation;
        private System.Windows.Forms.Label label5;
    }
}

