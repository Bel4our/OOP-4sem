namespace lab3
{
    partial class InputAccNumber
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер счёта для удаления";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(83, 57);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(120, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOk.Location = new System.Drawing.Point(87, 114);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(116, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Подтвердить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // InputAccNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 176);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "InputAccNumber";
            this.Text = "InputAccNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button buttonOk;
    }
}