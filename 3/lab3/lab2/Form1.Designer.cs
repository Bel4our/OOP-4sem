namespace lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonRevocable = new System.Windows.Forms.RadioButton();
            this.radioButtonIrrevocable = new System.Windows.Forms.RadioButton();
            this.Balance = new System.Windows.Forms.NumericUpDown();
            this.openingDate = new System.Windows.Forms.DateTimePicker();
            this.smsNotification = new System.Windows.Forms.ComboBox();
            this.internetBank = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.birthDay = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.passportData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.operationSum = new System.Windows.Forms.Label();
            this.operationType = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.operationDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.infoBox = new System.Windows.Forms.ListBox();
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.sortToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.forwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.showAllObjects = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetBank)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип вклада";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Баланс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата открытия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Подключение смс оповещения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Подключение интернет банкинга";
            // 
            // radioButtonRevocable
            // 
            this.radioButtonRevocable.AutoSize = true;
            this.radioButtonRevocable.Location = new System.Drawing.Point(168, 99);
            this.radioButtonRevocable.Name = "radioButtonRevocable";
            this.radioButtonRevocable.Size = new System.Drawing.Size(94, 20);
            this.radioButtonRevocable.TabIndex = 8;
            this.radioButtonRevocable.TabStop = true;
            this.radioButtonRevocable.Text = "Отзывной";
            this.radioButtonRevocable.UseVisualStyleBackColor = true;
            // 
            // radioButtonIrrevocable
            // 
            this.radioButtonIrrevocable.AutoSize = true;
            this.radioButtonIrrevocable.Location = new System.Drawing.Point(268, 99);
            this.radioButtonIrrevocable.Name = "radioButtonIrrevocable";
            this.radioButtonIrrevocable.Size = new System.Drawing.Size(117, 20);
            this.radioButtonIrrevocable.TabIndex = 9;
            this.radioButtonIrrevocable.TabStop = true;
            this.radioButtonIrrevocable.Text = "Безотзывной";
            this.radioButtonIrrevocable.UseVisualStyleBackColor = true;
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(168, 134);
            this.Balance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(169, 22);
            this.Balance.TabIndex = 11;
            // 
            // openingDate
            // 
            this.openingDate.Location = new System.Drawing.Point(168, 177);
            this.openingDate.MaxDate = new System.DateTime(2025, 2, 18, 0, 0, 0, 0);
            this.openingDate.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.openingDate.Name = "openingDate";
            this.openingDate.Size = new System.Drawing.Size(169, 22);
            this.openingDate.TabIndex = 12;
            this.openingDate.Value = new System.DateTime(2025, 2, 18, 0, 0, 0, 0);
            // 
            // smsNotification
            // 
            this.smsNotification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smsNotification.FormattingEnabled = true;
            this.smsNotification.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.smsNotification.Location = new System.Drawing.Point(291, 375);
            this.smsNotification.Name = "smsNotification";
            this.smsNotification.Size = new System.Drawing.Size(169, 24);
            this.smsNotification.TabIndex = 13;
            // 
            // internetBank
            // 
            this.internetBank.LargeChange = 1;
            this.internetBank.Location = new System.Drawing.Point(322, 428);
            this.internetBank.Maximum = 1;
            this.internetBank.Name = "internetBank";
            this.internetBank.Size = new System.Drawing.Size(104, 56);
            this.internetBank.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Да";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Нет";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.birthDay);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.passportData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fullName);
            this.groupBox1.Location = new System.Drawing.Point(43, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 147);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Владелец";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Дата рождения";
            // 
            // birthDay
            // 
            this.birthDay.Location = new System.Drawing.Point(167, 64);
            this.birthDay.MaxDate = new System.DateTime(2005, 2, 18, 0, 0, 0, 0);
            this.birthDay.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(100, 22);
            this.birthDay.TabIndex = 21;
            this.birthDay.Value = new System.DateTime(2005, 2, 18, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Паспортные данные";
            // 
            // passportData
            // 
            this.passportData.Location = new System.Drawing.Point(167, 101);
            this.passportData.Name = "passportData";
            this.passportData.Size = new System.Drawing.Size(100, 22);
            this.passportData.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "ФИО";
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(167, 27);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(100, 22);
            this.fullName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.operationSum);
            this.groupBox2.Controls.Add(this.operationType);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.operationDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(405, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 147);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "История операций";
            // 
            // operationSum
            // 
            this.operationSum.AutoSize = true;
            this.operationSum.Location = new System.Drawing.Point(168, 104);
            this.operationSum.Name = "operationSum";
            this.operationSum.Size = new System.Drawing.Size(0, 16);
            this.operationSum.TabIndex = 26;
            // 
            // operationType
            // 
            this.operationType.AutoSize = true;
            this.operationType.Location = new System.Drawing.Point(168, 66);
            this.operationType.Name = "operationType";
            this.operationType.Size = new System.Drawing.Size(0, 16);
            this.operationType.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Дата";
            // 
            // operationDate
            // 
            this.operationDate.Enabled = false;
            this.operationDate.Location = new System.Drawing.Point(167, 28);
            this.operationDate.MaxDate = new System.DateTime(2025, 3, 4, 0, 0, 0, 0);
            this.operationDate.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.operationDate.Name = "operationDate";
            this.operationDate.Size = new System.Drawing.Size(100, 22);
            this.operationDate.TabIndex = 21;
            this.operationDate.Value = new System.DateTime(2025, 2, 18, 0, 0, 0, 0);
            this.operationDate.ValueChanged += new System.EventHandler(this.operationDate_ValueChanged);
            this.operationDate.DropDown += new System.EventHandler(this.operationDate_DropDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Сумма";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Тип операции";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(492, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(636, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(411, 35);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 16);
            this.labelOutput.TabIndex = 26;
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.HorizontalScrollbar = true;
            this.outputBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.outputBox.ItemHeight = 16;
            this.outputBox.Location = new System.Drawing.Point(405, 67);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(333, 132);
            this.outputBox.TabIndex = 0;
            // 
            // infoBox
            // 
            this.infoBox.FormattingEnabled = true;
            this.infoBox.HorizontalScrollbar = true;
            this.infoBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.infoBox.ItemHeight = 16;
            this.infoBox.Location = new System.Drawing.Point(757, 222);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(256, 148);
            this.infoBox.TabIndex = 28;
            // 
            // accountNumber
            // 
            this.accountNumber.Location = new System.Drawing.Point(168, 64);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(169, 22);
            this.accountNumber.TabIndex = 29;
            this.accountNumber.TextChanged += new System.EventHandler(this.accountNumber_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.sortByToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.searchToolStripMenuItem.Text = "Поиск";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accNumberToolStripMenuItem,
            this.balanceToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.sortByToolStripMenuItem.Text = "Сортировка по";
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.sortToolStripButton,
            this.clearToolStripButton,
            this.deleteToolStripButton,
            this.forwardToolStripButton,
            this.backToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1034, 27);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Поиск";
            this.toolStripButton1.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // sortToolStripButton
            // 
            this.sortToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("sortToolStripButton.Image")));
            this.sortToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortToolStripButton.Name = "sortToolStripButton";
            this.sortToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.sortToolStripButton.Text = "Сортировка";
            this.sortToolStripButton.Click += new System.EventHandler(this.sortToolStripButton_Click);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripButton.Image")));
            this.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripButton.Name = "clearToolStripButton";
            this.clearToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.clearToolStripButton.Text = "очистить";
            this.clearToolStripButton.Click += new System.EventHandler(this.clearToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.deleteToolStripButton.Text = "удалить";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // forwardToolStripButton
            // 
            this.forwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardToolStripButton.Image")));
            this.forwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardToolStripButton.Name = "forwardToolStripButton";
            this.forwardToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.forwardToolStripButton.Text = "вперёд";
            this.forwardToolStripButton.Click += new System.EventHandler(this.forwardToolStripButton_Click);
            // 
            // backToolStripButton
            // 
            this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripButton.Image")));
            this.backToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backToolStripButton.Name = "backToolStripButton";
            this.backToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.backToolStripButton.Text = "назад";
            this.backToolStripButton.Click += new System.EventHandler(this.backToolStripButton_Click);
            // 
            // showAllObjects
            // 
            this.showAllObjects.BackColor = System.Drawing.SystemColors.Info;
            this.showAllObjects.Location = new System.Drawing.Point(785, 428);
            this.showAllObjects.Name = "showAllObjects";
            this.showAllObjects.Size = new System.Drawing.Size(104, 23);
            this.showAllObjects.TabIndex = 32;
            this.showAllObjects.Text = "Показать всё";
            this.showAllObjects.UseVisualStyleBackColor = false;
            this.showAllObjects.Click += new System.EventHandler(this.showAllObjects_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.toggleToolStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCount,
            this.toolStripStatusLabelLastAction,
            this.toolStripStatusLabelDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 26);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            this.toolStripStatusLabelCount.Size = new System.Drawing.Size(162, 20);
            this.toolStripStatusLabelCount.Text = "Количество объектов:";
            // 
            // toolStripStatusLabelLastAction
            // 
            this.toolStripStatusLabelLastAction.Name = "toolStripStatusLabelLastAction";
            this.toolStripStatusLabelLastAction.Size = new System.Drawing.Size(155, 20);
            this.toolStripStatusLabelLastAction.Text = "Последнее действие:";
            // 
            // toolStripStatusLabelDateTime
            // 
            this.toolStripStatusLabelDateTime.Name = "toolStripStatusLabelDateTime";
            this.toolStripStatusLabelDateTime.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabelDateTime.Text = "Дата и время:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 577);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.showAllObjects);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.internetBank);
            this.Controls.Add(this.smsNotification);
            this.Controls.Add(this.openingDate);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.radioButtonIrrevocable);
            this.Controls.Add(this.radioButtonRevocable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetBank)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonRevocable;
        private System.Windows.Forms.RadioButton radioButtonIrrevocable;
        private System.Windows.Forms.NumericUpDown Balance;
        private System.Windows.Forms.DateTimePicker openingDate;
        private System.Windows.Forms.ComboBox smsNotification;
        private System.Windows.Forms.TrackBar internetBank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker birthDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passportData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker operationDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label operationType;
        private System.Windows.Forms.Label operationSum;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.ListBox infoBox;
        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton sortToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem accNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton clearToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton forwardToolStripButton;
        private System.Windows.Forms.ToolStripButton backToolStripButton;
        private System.Windows.Forms.Button showAllObjects;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDateTime;
    }
}

