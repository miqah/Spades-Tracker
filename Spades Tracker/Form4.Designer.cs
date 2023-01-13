namespace Spades_Tracker
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.endScoreLbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nillHandLbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dealsFirstLbl = new System.Windows.Forms.ComboBox();
            this.settingsLbl = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.Button();
            this.confirmSettingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endScoreLbl
            // 
            this.endScoreLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endScoreLbl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.endScoreLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endScoreLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endScoreLbl.Location = new System.Drawing.Point(800, 200);
            this.endScoreLbl.Name = "endScoreLbl";
            this.endScoreLbl.Size = new System.Drawing.Size(69, 39);
            this.endScoreLbl.TabIndex = 0;
            this.endScoreLbl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Points to End the Game (Default 500):\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nillHandLbl
            // 
            this.nillHandLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nillHandLbl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nillHandLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nillHandLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nillHandLbl.Location = new System.Drawing.Point(321, 302);
            this.nillHandLbl.Name = "nillHandLbl";
            this.nillHandLbl.Size = new System.Drawing.Size(69, 39);
            this.nillHandLbl.TabIndex = 2;
            this.nillHandLbl.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(755, 66);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount of Points Awarded For Achieving a Nill Hand\r\n (Default 100):\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dealsFirstLbl
            // 
            this.dealsFirstLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dealsFirstLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dealsFirstLbl.FormattingEnabled = true;
            this.dealsFirstLbl.Items.AddRange(new object[] {
            "Random",
            "Player One",
            "Player Two",
            "Player Three",
            "Player Four"});
            this.dealsFirstLbl.Location = new System.Drawing.Point(249, 366);
            this.dealsFirstLbl.Name = "dealsFirstLbl";
            this.dealsFirstLbl.Size = new System.Drawing.Size(559, 45);
            this.dealsFirstLbl.TabIndex = 6;
            this.dealsFirstLbl.Text = "Who Deals First (Default Random):";
            this.dealsFirstLbl.SelectedIndexChanged += new System.EventHandler(this.dealsFirstLbl_SelectedIndexChanged);
            // 
            // settingsLbl
            // 
            this.settingsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsLbl.Location = new System.Drawing.Point(320, 30);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(414, 102);
            this.settingsLbl.TabIndex = 7;
            this.settingsLbl.Text = "Settings";
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuBtn.AutoSize = true;
            this.menuBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuBtn.Location = new System.Drawing.Point(305, 135);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(203, 38);
            this.menuBtn.TabIndex = 8;
            this.menuBtn.Text = "Return To Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmSettingsBtn
            // 
            this.confirmSettingsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmSettingsBtn.AutoSize = true;
            this.confirmSettingsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmSettingsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmSettingsBtn.Location = new System.Drawing.Point(529, 133);
            this.confirmSettingsBtn.Name = "confirmSettingsBtn";
            this.confirmSettingsBtn.Size = new System.Drawing.Size(216, 38);
            this.confirmSettingsBtn.TabIndex = 9;
            this.confirmSettingsBtn.Text = "Confirm Settings";
            this.confirmSettingsBtn.UseVisualStyleBackColor = true;
            this.confirmSettingsBtn.Click += new System.EventHandler(this.confirmSettingsBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1035, 498);
            this.Controls.Add(this.confirmSettingsBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.nillHandLbl);
            this.Controls.Add(this.endScoreLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.settingsLbl);
            this.Controls.Add(this.dealsFirstLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Resize += new System.EventHandler(this.Settings_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox endScoreLbl;
        private Label label1;
        private TextBox nillHandLbl;
        private Label label2;
        private ComboBox dealsFirstLbl;
        private Label settingsLbl;
        private Button menuBtn;
        private Button confirmSettingsBtn;
    }
}