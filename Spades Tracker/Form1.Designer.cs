namespace Spades_Tracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.cboSuit1 = new System.Windows.Forms.ComboBox();
            this.cboCard1 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboCard2 = new System.Windows.Forms.ComboBox();
            this.cboSuit2 = new System.Windows.Forms.ComboBox();
            this.cboCard3 = new System.Windows.Forms.ComboBox();
            this.cboSuit3 = new System.Windows.Forms.ComboBox();
            this.cboCard4 = new System.Windows.Forms.ComboBox();
            this.cboSuit4 = new System.Windows.Forms.ComboBox();
            this.cboCard5 = new System.Windows.Forms.ComboBox();
            this.cboSuit5 = new System.Windows.Forms.ComboBox();
            this.cboCard6 = new System.Windows.Forms.ComboBox();
            this.cboSuit6 = new System.Windows.Forms.ComboBox();
            this.cboCard7 = new System.Windows.Forms.ComboBox();
            this.cboSuit7 = new System.Windows.Forms.ComboBox();
            this.cboCard13 = new System.Windows.Forms.ComboBox();
            this.cboSuit13 = new System.Windows.Forms.ComboBox();
            this.cboCard12 = new System.Windows.Forms.ComboBox();
            this.cboSuit12 = new System.Windows.Forms.ComboBox();
            this.cboCard11 = new System.Windows.Forms.ComboBox();
            this.cboSuit11 = new System.Windows.Forms.ComboBox();
            this.cboCard10 = new System.Windows.Forms.ComboBox();
            this.cboSuit10 = new System.Windows.Forms.ComboBox();
            this.cboCard9 = new System.Windows.Forms.ComboBox();
            this.cboSuit9 = new System.Windows.Forms.ComboBox();
            this.cboCard8 = new System.Windows.Forms.ComboBox();
            this.cboSuit8 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(244, 499);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(121, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load from File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(108, 499);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(121, 23);
            this.btnSaveFile.TabIndex = 1;
            this.btnSaveFile.Text = "Save to File";
            this.btnSaveFile.UseMnemonic = false;
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboSuit1
            // 
            this.cboSuit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit1.FormattingEnabled = true;
            this.cboSuit1.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit1.Location = new System.Drawing.Point(244, 97);
            this.cboSuit1.Name = "cboSuit1";
            this.cboSuit1.Size = new System.Drawing.Size(121, 23);
            this.cboSuit1.TabIndex = 2;
            // 
            // cboCard1
            // 
            this.cboCard1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard1.FormattingEnabled = true;
            this.cboCard1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard1.Location = new System.Drawing.Point(107, 97);
            this.cboCard1.Name = "cboCard1";
            this.cboCard1.Size = new System.Drawing.Size(121, 23);
            this.cboCard1.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Card 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Card 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Card 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Card 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Card 5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Card 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Card 12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Card 11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Card 10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Card 9";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Card 8";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "Card 7";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 463);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Card 13";
            // 
            // cboCard2
            // 
            this.cboCard2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard2.FormattingEnabled = true;
            this.cboCard2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard2.Location = new System.Drawing.Point(107, 128);
            this.cboCard2.Name = "cboCard2";
            this.cboCard2.Size = new System.Drawing.Size(121, 23);
            this.cboCard2.TabIndex = 21;
            // 
            // cboSuit2
            // 
            this.cboSuit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit2.FormattingEnabled = true;
            this.cboSuit2.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit2.Location = new System.Drawing.Point(244, 128);
            this.cboSuit2.Name = "cboSuit2";
            this.cboSuit2.Size = new System.Drawing.Size(121, 23);
            this.cboSuit2.TabIndex = 20;
            // 
            // cboCard3
            // 
            this.cboCard3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard3.FormattingEnabled = true;
            this.cboCard3.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard3.Location = new System.Drawing.Point(107, 158);
            this.cboCard3.Name = "cboCard3";
            this.cboCard3.Size = new System.Drawing.Size(121, 23);
            this.cboCard3.TabIndex = 23;
            // 
            // cboSuit3
            // 
            this.cboSuit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit3.FormattingEnabled = true;
            this.cboSuit3.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit3.Location = new System.Drawing.Point(244, 158);
            this.cboSuit3.Name = "cboSuit3";
            this.cboSuit3.Size = new System.Drawing.Size(121, 23);
            this.cboSuit3.TabIndex = 22;
            // 
            // cboCard4
            // 
            this.cboCard4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard4.FormattingEnabled = true;
            this.cboCard4.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard4.Location = new System.Drawing.Point(107, 189);
            this.cboCard4.Name = "cboCard4";
            this.cboCard4.Size = new System.Drawing.Size(121, 23);
            this.cboCard4.TabIndex = 25;
            // 
            // cboSuit4
            // 
            this.cboSuit4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit4.FormattingEnabled = true;
            this.cboSuit4.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit4.Location = new System.Drawing.Point(244, 189);
            this.cboSuit4.Name = "cboSuit4";
            this.cboSuit4.Size = new System.Drawing.Size(121, 23);
            this.cboSuit4.TabIndex = 24;
            // 
            // cboCard5
            // 
            this.cboCard5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard5.FormattingEnabled = true;
            this.cboCard5.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard5.Location = new System.Drawing.Point(107, 220);
            this.cboCard5.Name = "cboCard5";
            this.cboCard5.Size = new System.Drawing.Size(121, 23);
            this.cboCard5.TabIndex = 27;
            // 
            // cboSuit5
            // 
            this.cboSuit5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit5.FormattingEnabled = true;
            this.cboSuit5.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit5.Location = new System.Drawing.Point(244, 220);
            this.cboSuit5.Name = "cboSuit5";
            this.cboSuit5.Size = new System.Drawing.Size(121, 23);
            this.cboSuit5.TabIndex = 26;
            // 
            // cboCard6
            // 
            this.cboCard6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard6.FormattingEnabled = true;
            this.cboCard6.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard6.Location = new System.Drawing.Point(107, 249);
            this.cboCard6.Name = "cboCard6";
            this.cboCard6.Size = new System.Drawing.Size(121, 23);
            this.cboCard6.TabIndex = 29;
            // 
            // cboSuit6
            // 
            this.cboSuit6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit6.FormattingEnabled = true;
            this.cboSuit6.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit6.Location = new System.Drawing.Point(244, 249);
            this.cboSuit6.Name = "cboSuit6";
            this.cboSuit6.Size = new System.Drawing.Size(121, 23);
            this.cboSuit6.TabIndex = 28;
            // 
            // cboCard7
            // 
            this.cboCard7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard7.FormattingEnabled = true;
            this.cboCard7.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard7.Location = new System.Drawing.Point(108, 278);
            this.cboCard7.Name = "cboCard7";
            this.cboCard7.Size = new System.Drawing.Size(121, 23);
            this.cboCard7.TabIndex = 31;
            // 
            // cboSuit7
            // 
            this.cboSuit7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit7.FormattingEnabled = true;
            this.cboSuit7.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit7.Location = new System.Drawing.Point(244, 278);
            this.cboSuit7.Name = "cboSuit7";
            this.cboSuit7.Size = new System.Drawing.Size(121, 23);
            this.cboSuit7.TabIndex = 30;
            // 
            // cboCard13
            // 
            this.cboCard13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard13.FormattingEnabled = true;
            this.cboCard13.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard13.Location = new System.Drawing.Point(107, 457);
            this.cboCard13.Name = "cboCard13";
            this.cboCard13.Size = new System.Drawing.Size(121, 23);
            this.cboCard13.TabIndex = 43;
            // 
            // cboSuit13
            // 
            this.cboSuit13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit13.FormattingEnabled = true;
            this.cboSuit13.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit13.Location = new System.Drawing.Point(244, 457);
            this.cboSuit13.Name = "cboSuit13";
            this.cboSuit13.Size = new System.Drawing.Size(121, 23);
            this.cboSuit13.TabIndex = 42;
            // 
            // cboCard12
            // 
            this.cboCard12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard12.FormattingEnabled = true;
            this.cboCard12.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard12.Location = new System.Drawing.Point(108, 428);
            this.cboCard12.Name = "cboCard12";
            this.cboCard12.Size = new System.Drawing.Size(121, 23);
            this.cboCard12.TabIndex = 41;
            // 
            // cboSuit12
            // 
            this.cboSuit12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit12.FormattingEnabled = true;
            this.cboSuit12.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit12.Location = new System.Drawing.Point(244, 428);
            this.cboSuit12.Name = "cboSuit12";
            this.cboSuit12.Size = new System.Drawing.Size(121, 23);
            this.cboSuit12.TabIndex = 40;
            // 
            // cboCard11
            // 
            this.cboCard11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard11.FormattingEnabled = true;
            this.cboCard11.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard11.Location = new System.Drawing.Point(107, 399);
            this.cboCard11.Name = "cboCard11";
            this.cboCard11.Size = new System.Drawing.Size(121, 23);
            this.cboCard11.TabIndex = 39;
            // 
            // cboSuit11
            // 
            this.cboSuit11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit11.FormattingEnabled = true;
            this.cboSuit11.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit11.Location = new System.Drawing.Point(244, 399);
            this.cboSuit11.Name = "cboSuit11";
            this.cboSuit11.Size = new System.Drawing.Size(121, 23);
            this.cboSuit11.TabIndex = 38;
            // 
            // cboCard10
            // 
            this.cboCard10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard10.FormattingEnabled = true;
            this.cboCard10.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard10.Location = new System.Drawing.Point(107, 368);
            this.cboCard10.Name = "cboCard10";
            this.cboCard10.Size = new System.Drawing.Size(121, 23);
            this.cboCard10.TabIndex = 37;
            // 
            // cboSuit10
            // 
            this.cboSuit10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit10.FormattingEnabled = true;
            this.cboSuit10.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit10.Location = new System.Drawing.Point(244, 368);
            this.cboSuit10.Name = "cboSuit10";
            this.cboSuit10.Size = new System.Drawing.Size(121, 23);
            this.cboSuit10.TabIndex = 36;
            // 
            // cboCard9
            // 
            this.cboCard9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard9.FormattingEnabled = true;
            this.cboCard9.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard9.Location = new System.Drawing.Point(107, 337);
            this.cboCard9.Name = "cboCard9";
            this.cboCard9.Size = new System.Drawing.Size(121, 23);
            this.cboCard9.TabIndex = 35;
            // 
            // cboSuit9
            // 
            this.cboSuit9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit9.FormattingEnabled = true;
            this.cboSuit9.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit9.Location = new System.Drawing.Point(244, 337);
            this.cboSuit9.Name = "cboSuit9";
            this.cboSuit9.Size = new System.Drawing.Size(121, 23);
            this.cboSuit9.TabIndex = 34;
            // 
            // cboCard8
            // 
            this.cboCard8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCard8.FormattingEnabled = true;
            this.cboCard8.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.cboCard8.Location = new System.Drawing.Point(107, 307);
            this.cboCard8.Name = "cboCard8";
            this.cboCard8.Size = new System.Drawing.Size(121, 23);
            this.cboCard8.TabIndex = 33;
            // 
            // cboSuit8
            // 
            this.cboSuit8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit8.FormattingEnabled = true;
            this.cboSuit8.Items.AddRange(new object[] {
            "Clubs",
            "Hearts",
            "Spades",
            "Diamonds"});
            this.cboSuit8.Location = new System.Drawing.Point(244, 307);
            this.cboSuit8.Name = "cboSuit8";
            this.cboSuit8.Size = new System.Drawing.Size(121, 23);
            this.cboSuit8.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(141, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 15);
            this.label17.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(106, 256);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 15);
            this.label18.TabIndex = 45;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(40, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(359, 41);
            this.label19.TabIndex = 46;
            this.label19.Text = "Insert your deck";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(108, 543);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(186, 21);
            this.label20.TabIndex = 47;
            this.label20.Text = "Your bid could be:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 587);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cboCard13);
            this.Controls.Add(this.cboSuit13);
            this.Controls.Add(this.cboCard12);
            this.Controls.Add(this.cboSuit12);
            this.Controls.Add(this.cboCard11);
            this.Controls.Add(this.cboSuit11);
            this.Controls.Add(this.cboCard10);
            this.Controls.Add(this.cboSuit10);
            this.Controls.Add(this.cboCard9);
            this.Controls.Add(this.cboSuit9);
            this.Controls.Add(this.cboCard8);
            this.Controls.Add(this.cboSuit8);
            this.Controls.Add(this.cboCard7);
            this.Controls.Add(this.cboSuit7);
            this.Controls.Add(this.cboCard6);
            this.Controls.Add(this.cboSuit6);
            this.Controls.Add(this.cboCard5);
            this.Controls.Add(this.cboSuit5);
            this.Controls.Add(this.cboCard4);
            this.Controls.Add(this.cboSuit4);
            this.Controls.Add(this.cboCard3);
            this.Controls.Add(this.cboSuit3);
            this.Controls.Add(this.cboCard2);
            this.Controls.Add(this.cboSuit2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCard1);
            this.Controls.Add(this.cboSuit1);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnLoadFile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bid Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoadFile;
        private Button btnSaveFile;
        private ComboBox cboSuit1;
        private ComboBox cboCard1;
        private ImageList imageList1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private ComboBox cboCard2;
        private ComboBox cboSuit2;
        private ComboBox cboCard3;
        private ComboBox cboSuit3;
        private ComboBox cboCard4;
        private ComboBox cboSuit4;
        private ComboBox cboCard5;
        private ComboBox cboSuit5;
        private ComboBox cboCard6;
        private ComboBox cboSuit6;
        private ComboBox cboCard7;
        private ComboBox cboSuit7;
        private ComboBox cboCard13;
        private ComboBox cboSuit13;
        private ComboBox cboCard12;
        private ComboBox cboSuit12;
        private ComboBox cboCard11;
        private ComboBox cboSuit11;
        private ComboBox cboCard10;
        private ComboBox cboSuit10;
        private ComboBox cboCard9;
        private ComboBox cboSuit9;
        private ComboBox cboCard8;
        private ComboBox cboSuit8;
        private Label label17;
        private Label label18;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label20;
        private Label label19;
    }
}