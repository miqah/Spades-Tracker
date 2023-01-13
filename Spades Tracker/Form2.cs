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
    public partial class Form2 : Form
    {
        public static string playerOneName;
        public static string playerTwoName;
        public static string playerThreeName;
        public static string playerFourName;
        public Form2()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartForm home = new StartForm();
            home.Show();
            this.Hide();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            playerOneName = playerOneBtn.Text;
            playerOneNameLbl.Text = playerOneName;

            if (string.IsNullOrWhiteSpace(playerOneBtn.Text))
            {
                playerOneName = "Player 1";
                
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void playerTwoBtn_TextChanged(object sender, EventArgs e)
        {
            playerTwoName = playerTwoBtn.Text;
            playerTwoNameLbl.Text = playerTwoName;

            if (string.IsNullOrWhiteSpace(playerTwoName))
            {
                playerTwoName = "Player 2";
                
            }
        }

        private void playerThreeBtn_TextChanged(object sender, EventArgs e)
        {
            playerThreeName = playerThreeBtn.Text;
            playerThreeNameLbl.Text = playerThreeName;

            if (string.IsNullOrWhiteSpace(playerThreeName))
            {
                playerThreeName = "Player 3";
                
            }
        }

        private void playerFourBtn_TextChanged(object sender, EventArgs e)
        {
            playerFourName = playerFourBtn.Text;
            playerFourNameLbl.Text = playerFourName;

            if (string.IsNullOrWhiteSpace(playerFourName))
            {
                playerFourName = "Player 4";
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            spadesWdw gameMenu = new spadesWdw();
            gameMenu.Show();
            this.Hide();
        }


        private void playerOneNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
