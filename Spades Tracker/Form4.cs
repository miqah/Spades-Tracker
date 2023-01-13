using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Spades_Tracker
{
    public partial class Settings : Form
    {
        private Rectangle settingsLblOriginalRect;
        private Rectangle menuBtnOriginalRect;
        private Rectangle confirmSettingsBtnOriginalRect;
        private Rectangle label1OriginalRect;
        private Rectangle label2OriginalRect;
        private Rectangle endScoreLblOriginalRect;
        private Rectangle nillHandLblOriginalRect;
        private Rectangle dealsFirstLblOriginalRect;

        private Size formOriginalSize;
        
        public static int EndingScore = 500;
        public static int NillScore = 100;

        public static Boolean RandomStart = true;
        public static Boolean PlayerOneStart = false;
        public static Boolean PlayerTwoStart = false;
        public static Boolean PlayerThreeStart = false;
        public static Boolean PlayerFourStart = false;

        public Settings()
        {
            InitializeComponent();

            
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;

            settingsLblOriginalRect = new Rectangle(settingsLbl.Location.X, settingsLbl.Location.Y, settingsLbl.Width, settingsLbl.Height);
            menuBtnOriginalRect = new Rectangle(menuBtn.Location.X, menuBtn.Location.Y, settingsLbl.Width, settingsLbl.Height);
            confirmSettingsBtnOriginalRect = new Rectangle(confirmSettingsBtn.Location.X, confirmSettingsBtn.Location.Y, confirmSettingsBtn.Width, confirmSettingsBtn.Height);
            label1OriginalRect = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            label2OriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            endScoreLblOriginalRect = new Rectangle(endScoreLbl.Location.X, endScoreLbl.Location.Y, endScoreLbl.Width, endScoreLbl.Height);
            nillHandLblOriginalRect = new Rectangle(nillHandLbl.Location.X, nillHandLbl.Location.Y, nillHandLbl.Width, nillHandLbl.Height);
            dealsFirstLblOriginalRect = new Rectangle(dealsFirstLbl.Location.X, dealsFirstLbl.Location.Y, dealsFirstLbl.Width, dealsFirstLbl.Height);
            
        }

        private void resizeChildrenControls()
        {
            resizeControl(settingsLblOriginalRect, settingsLbl);
            resizeControl(menuBtnOriginalRect, menuBtn);
            resizeControl(confirmSettingsBtnOriginalRect, confirmSettingsBtn);
            resizeControl(label1OriginalRect, label1);
            resizeControl(label2OriginalRect, label2);
            resizeControl(endScoreLblOriginalRect, endScoreLbl);
            resizeControl(nillHandLblOriginalRect, nillHandLbl);
            resizeControl(dealsFirstLblOriginalRect, dealsFirstLbl);
        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);


            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dealsFirstLbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartForm home = new StartForm();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void confirmSettingsBtn_Click(object sender, EventArgs e)
        {
            if (dealsFirstLbl.Text == "Random")
            {
                RandomStart = true;
                PlayerOneStart = false;
                PlayerTwoStart = false;
                PlayerThreeStart = false;
                PlayerFourStart = false;
            }

            else if (dealsFirstLbl.Text == "Player One")
            {
                RandomStart = false;
                PlayerOneStart = true;
                PlayerTwoStart = false;
                PlayerThreeStart = false;
                PlayerFourStart = false;

            }

            else if (dealsFirstLbl.Text == "Player Two")
            {
                RandomStart = false;
                PlayerOneStart = false;
                PlayerTwoStart = true;
                PlayerThreeStart = false;
                PlayerFourStart = false;

            }

            else if (dealsFirstLbl.Text == "Player Three")
            {
                RandomStart = false;
                PlayerOneStart = false;
                PlayerTwoStart = false;
                PlayerThreeStart = true;
                PlayerFourStart = false;

            }

            else if (dealsFirstLbl.Text == "Player Four")
            {
                RandomStart = false;
                PlayerOneStart = false;
                PlayerTwoStart = false;
                PlayerThreeStart = false;
                PlayerFourStart = true;

            }

            else
            {
                RandomStart = true;
                PlayerOneStart = false;
                PlayerTwoStart = false;
                PlayerThreeStart = false;
                PlayerFourStart = false;
            }

            int tempIntOne;

            int.TryParse(nillHandLbl.Text, out tempIntOne);

            NillScore = tempIntOne;

            if (NillScore == 0)
            {
                NillScore = 100;
            }


            int tempIntTwo;

            int.TryParse(endScoreLbl.Text, out tempIntTwo);

            EndingScore = tempIntTwo;

            if (EndingScore == 0)
            {
                EndingScore = 500;
            }

        }
    }
}
