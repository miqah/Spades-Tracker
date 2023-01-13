using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Spades_Tracker
{ 
    public partial class spadesWdw : Form
    {
        Boolean PlayerOneStarting = false;
        Boolean PlayerTwoStarting = false;
        Boolean PlayerThreeStarting = false;
        Boolean PlayerFourStarting = false;

        Boolean GameOver = false;
        Boolean NewRound = false;

        public int BagAmount = 10;

        int TeamOneBagCount = 0;
        int TeamTwoBagCount = 0;

        int round = 1;
        int count = 0;
        int result;

        int FirstPlayerBid = 0;
        int SecondPlayerBid = 0;
        int ThirdPlayerBid = 0;
        int FourthPlayerBid = 0;

        int FirstFinalBid;
        int SecondFinalBid;
        int ThirdFinalBid;
        int FourthFinalBid;

        int TeamOneBid = 0;
        int TeamTwoBid = 0;

        int TeamOneFinalBid = 0;
        int TeamTwoFinalBid = 0;

        int TeamOneScore;
        int TeamTwoScore;


        public spadesWdw()
        {
            InitializeComponent();

        }
        public void whosFirst(int first)
        {
            if (result == 1)
            {

                firstBidLbl.Text = Form2.playerOneName + " bids first";

                PlayerOneStarting = true;
                scoreBox1.Visible = true;
                
                Dealer.Text = Form2.playerOneName;

            }

            else if (result == 2)
            {

                firstBidLbl.Text = Form2.playerTwoName + " bids first";
                PlayerTwoStarting = true;
                scoreBox2.Visible = true;

                Dealer.Text = Form2.playerTwoName;
            }

            else if (result == 3)
            {
                firstBidLbl.Text = Form2.playerThreeName + " bids first";
                PlayerThreeStarting = true;
                scoreBox3.Visible = true;

                Dealer.Text = Form2.playerThreeName;
            }

            else
            {
                firstBidLbl.Text = Form2.playerFourName + " bids first";
                PlayerFourStarting = true;
                scoreBox4.Visible = true;

                Dealer.Text = Form2.playerFourName;
            }


        }
        public void endRound(int n)
        {
            if (n == 9)
            {   
                if (GameOver == false)
                {
                    confirmBidBtn.Text = "End Round";
                    firstBidLbl.Text = "The Round is Over!";

                    NewRound = true;

                    finalBid1.Visible = false;
                    finalBid2.Visible = false;
                    finalBid3.Visible = false;
                    finalBid4.Visible = false;
                }

                else if (GameOver == true)
                {
                    firstBidLbl.Text = "The Game is Over!";
                    confirmBidBtn.Text = "Restart Game";
                }
                

            }
        }
        public Boolean BagOut(int bag)
        {
            Boolean baggedOut = false;

            if (bag >= BagAmount)
            {
                MessageBox.Show("your team has bagged out so you will lose " + Settings.EndingScore);
                baggedOut = true;
            }

            return baggedOut;

        }
        public void FinalPerson(int n)
        {
            if (n >= 4 && n < 9)
            {
                scoreBox1.Visible = false;
                scoreBox2.Visible = false;
                scoreBox3.Visible = false;
                scoreBox4.Visible = false;

                if (PlayerOneStarting == true)
                {
                    if (FirstFinalBid < 0 || FirstFinalBid > 13)
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }

                    else
                    {
                        if (count == 4)
                        {
                            currBidLbl1.Text = scoreBox1.Text;
                            currBidLbl1.Visible = true;
                        }

                        else
                        {
                            currBidLbl1.Text = finalBid1.Text;
                        }

                        finalBid1.Visible = false;
                        finalBid3.Visible = true;
                        firstBidLbl.Text = "How many hands did " + Form2.playerThreeName + " win ?";
                        PlayerThreeStarting = true;
                        PlayerOneStarting = false;
                        ++count;
                    }

                }

                else if (PlayerTwoStarting == true)
                {
                    if (SecondFinalBid < 0 || SecondFinalBid > 13)
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }

                    else
                    {
                        if (count == 4)
                        {
                            currBidLbl2.Text = scoreBox2.Text;
                            currBidLbl2.Visible = true;
                        }

                        else
                        {
                            currBidLbl2.Text = finalBid2.Text;
                        }

                        finalBid2.Visible = false;
                        finalBid4.Visible = true;
                        firstBidLbl.Text = "How many hands did " + Form2.playerFourName + " win ? ";
                        PlayerFourStarting = true;
                        PlayerTwoStarting = false;
                        ++count;
                    }

                }

                else if (PlayerThreeStarting == true)
                {
                    if (ThirdFinalBid < 0 || ThirdFinalBid > 13)
                    {
                        MessageBox.Show(ThirdPlayerBid.ToString());
                    }

                    else
                    {

                        if (count == 4)
                        {
                            currBidLbl3.Text = scoreBox3.Text;
                            currBidLbl3.Visible = true;
                        }

                        else
                        {
                            currBidLbl3.Text = finalBid3.Text;
                        }

                        finalBid3.Visible = false;
                        finalBid2.Visible = true;
                        firstBidLbl.Text = "How many hands did " + Form2.playerTwoName + " win ? ";
                        PlayerTwoStarting = true;
                        PlayerThreeStarting = false;
                        ++count;
                    }
                }

                else if (PlayerFourStarting == true)
                {
                    if (FourthFinalBid < 0 || FourthFinalBid > 13)
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }

                    else
                    {
                        if (count == 4)
                        {
                            currBidLbl4.Text = scoreBox4.Text;
                            currBidLbl4.Visible = true;
                        }

                        else
                        {
                            currBidLbl4.Text = finalBid4.Text;
                        }

                        finalBid4.Visible = false;
                        finalBid1.Visible = true;
                        firstBidLbl.Text = "How many hands did " + Form2.playerOneName + " win ? ";
                        PlayerOneStarting = true;
                        PlayerFourStarting = false;
                        ++count;

                    }
                }
            
                if (count >= 9)
                {
                    TeamOneFinalBid = FirstFinalBid + SecondFinalBid;
                    TeamTwoFinalBid = ThirdFinalBid + FourthFinalBid;

                    TeamOneBid = FirstPlayerBid + SecondPlayerBid;
                    TeamTwoBid = ThirdPlayerBid + FourthPlayerBid;
                    
                    // team one nill counter
                    if (FirstPlayerBid == 0 && FirstFinalBid == 0)
                    {
                        TeamOneScore += Settings.EndingScore;
                        score1Lbl.Text = TeamOneScore.ToString();
                    }

                    else if (FirstPlayerBid == 0 && FirstFinalBid >= 1)
                    {
                        TeamOneScore -= Settings.EndingScore;
                        score1Lbl.Text = TeamOneScore.ToString();
                    }

                    if (SecondPlayerBid == 0 && SecondFinalBid == 0)
                    {
                        TeamOneScore += Settings.EndingScore;
                        score1Lbl.Text = TeamOneScore.ToString();
                    }

                    else if (SecondPlayerBid == 0 && SecondFinalBid >= 1)
                    {
                        TeamOneScore -= Settings.EndingScore;
                        score1Lbl.Text = TeamOneScore.ToString();
                    }

                    // team two nill counter

                    if (ThirdPlayerBid == 0 && ThirdFinalBid == 0)
                    {
                        TeamTwoScore += Settings.EndingScore;
                        score2Lbl.Text = TeamTwoScore.ToString();
                    }

                    else if (ThirdPlayerBid == 0 && ThirdFinalBid >= 1)
                    {
                        TeamTwoScore -= Settings.EndingScore;
                        score2Lbl.Text = TeamTwoScore.ToString();
                    }

                    if (FourthPlayerBid == 0 && FourthFinalBid == 0)
                    {
                        TeamTwoScore += Settings.EndingScore;
                        score2Lbl.Text = TeamTwoScore.ToString();
                    }

                    else if (FourthPlayerBid == 0 && FourthFinalBid >= 1)
                    {
                        TeamTwoScore -= Settings.EndingScore;
                        score2Lbl.Text = TeamTwoScore.ToString();
                    }

                    // counts bags and score for team one
                   
                    if (TeamOneFinalBid > TeamOneBid)
                    {

                        Boolean teamOneBagOut = false;
                        
                        TeamOneBagCount += TeamOneFinalBid - TeamOneBid;

                        TeamOneScore += (TeamOneBid * 10) + (TeamOneFinalBid - TeamOneBid);
                        
                        teamOneBagOut = BagOut(TeamOneBagCount);

                        if (teamOneBagOut == true)
                        {
                            
                            TeamOneBagCount = TeamOneBagCount - BagAmount;
                            TeamOneScore -= Settings.EndingScore;
                            bag1Lbl.Text = TeamOneBagCount.ToString();
                        }

                        else if (teamOneBagOut == false)
                        {
                            bag1Lbl.Text = TeamOneBagCount.ToString();
                        }

                        score1Lbl.Text = TeamOneScore.ToString();
                    }

                    else if (TeamOneFinalBid == TeamOneBid)
                    {
                        TeamOneScore += TeamOneFinalBid * 10;

                        score1Lbl.Text = TeamOneScore.ToString();
                    }

                    else if (TeamOneFinalBid < TeamOneBid)
                    {
                        TeamOneScore -= TeamOneBid * 10;

                        score1Lbl.Text = TeamOneScore.ToString();

                    }

                    if (TeamTwoFinalBid > TeamTwoBid)
                    {
                        Boolean teamTwoBagOut = false;
                        TeamTwoBagCount += TeamTwoFinalBid - TeamTwoBid;
                        
                        TeamTwoScore += (TeamTwoBid * 10) + (TeamTwoFinalBid - TeamTwoBid);

                        teamTwoBagOut = BagOut(TeamTwoBagCount);

                        if (teamTwoBagOut == true)
                        {
                            
                            TeamTwoBagCount = TeamTwoBagCount - BagAmount;
                            TeamTwoScore -= Settings.EndingScore;
                            bag2Lbl.Text = TeamTwoBagCount.ToString();
                        }

                        else if (teamTwoBagOut == false)
                        {
                            bag2Lbl.Text = TeamTwoBagCount.ToString();
                        }

                        score2Lbl.Text = TeamTwoScore.ToString();
                    }

                    else if (TeamTwoFinalBid == TeamTwoBid)
                    {
                        TeamTwoScore += TeamTwoFinalBid * 10;

                        score2Lbl.Text = TeamTwoScore.ToString();
                    }

                    else if (TeamTwoFinalBid < TeamTwoBid)
                    {
                        TeamTwoScore -= TeamTwoBid * 10;

                        score2Lbl.Text = TeamTwoScore.ToString();

                    }

                    if (TeamOneScore >= Settings.NillScore && TeamTwoScore < Settings.NillScore)
                    {
                        MessageBox.Show("Team Two Wins!");
                        GameOver = true;
                    }

                    else if (TeamTwoScore >= Settings.NillScore && TeamOneScore < Settings.NillScore)
                    {
                        MessageBox.Show("Team Two Wins!");
                        GameOver = true;
                    }

                    else if (TeamOneScore >= Settings.NillScore && TeamTwoScore >= Settings.NillScore)
                    {
                        if (TeamOneScore == TeamTwoScore)
                        {
                            MessageBox.Show("It is a draw!");
                            GameOver = true;
                        }

                        else if (TeamOneScore > TeamTwoScore)
                        {
                            MessageBox.Show("Team One Wins!");
                            GameOver = true;
                        }

                        else
                        {
                            MessageBox.Show("Team Two Wins!");
                            GameOver = true;
                        }
                    }

                    endRound(count);
                }

                else if (count > 9)
                {
                    endRound(count);
                }
            }

            }
            private void roundLbl_Load(object sender, EventArgs e)
        {
            roundLabel.Text = "ROUND " + round;

            bag1Lbl.Text = "0";
            bag2Lbl.Text = "0";
            score1Lbl.Text = "0";
            score2Lbl.Text = "0";
            
            playerOneNameLbl.Text = Form2.playerOneName;
            playerTwoNameLbl.Text = Form2.playerTwoName;
            playerThreeNameLbl.Text = Form2.playerThreeName;
            playerFourNameLbl.Text = Form2.playerFourName;

            currBidLbl1.Visible = false;
            currBidLbl2.Visible = false;
            currBidLbl3.Visible = false;
            currBidLbl4.Visible = false;

            playerOneLbl.Text = Form2.playerOneName;
            playerTwoLbl.Text = Form2.playerTwoName;
            playerThreeLbl.Text = Form2.playerThreeName;
            playerFourLbl.Text = Form2.playerFourName;

            if (string.IsNullOrWhiteSpace(Form2.playerOneName))
            {
                playerOneLbl.Text = "Player 1";
                playerOneNameLbl.Text = "Player 1";
                Form2.playerOneName = "Player 1";

            }

            if (string.IsNullOrWhiteSpace(Form2.playerTwoName))
            {
                playerTwoLbl.Text = "Player 2";
                playerTwoNameLbl.Text = "Player 2";
                Form2.playerTwoName = "Player 2";
            }

            if (string.IsNullOrWhiteSpace(Form2.playerThreeName))
            {
                playerThreeLbl.Text = "Player 3";
                playerThreeNameLbl.Text = "Player 3";
                Form2.playerThreeName = "Player 3";
            }

            if (string.IsNullOrWhiteSpace(Form2.playerFourName))
            {
                playerFourLbl.Text = "Player 4";
                playerFourNameLbl.Text = "Player 4";
                Form2.playerFourName = "Player 4";
            }

            if (Settings.RandomStart == true)
            {
                Random randomBtn = new Random();
                int tempValue = randomBtn.Next(1, 5);
                result = tempValue;
            }
            
            else if (Settings.PlayerOneStart == true)
            {
                result = 1;
            }

            else if (Settings.PlayerTwoStart == true)
            {
                result = 2;
            }

            else if (Settings.PlayerThreeStart == true)
            {
                result = 3;
            }
            else if (Settings.PlayerFourStart == true)
            {
                result = 4;
            }
            whosFirst(result);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (count >= 1 && count < 5)
            {

                if (PlayerOneStarting == true)
                {
                    if (FirstPlayerBid >= 0 || FirstPlayerBid <= 13)
                    {
                        MessageBox.Show(count.ToString());

                        currBidLbl1.Text = scoreBox1.Text;
                        currBidLbl1.Visible = true;

                        scoreBox1.Visible = false;
                        scoreBox4.Visible = true;
                        firstBidLbl.Text = Form2.playerFourName + " is next to bid";
                        PlayerFourStarting = true;
                        PlayerOneStarting = false;
                         --count;

                    }

                    else
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }
                }

                else if (PlayerTwoStarting == true)
                {
                    if (SecondPlayerBid < 0 || SecondPlayerBid > 13)
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }

                    else
                    {
                        MessageBox.Show(count.ToString());
                        currBidLbl2.Text = scoreBox2.Text;
                        currBidLbl2.Visible = true;

                        scoreBox2.Visible = false;
                        scoreBox3.Visible = true;
                        firstBidLbl.Text = Form2.playerThreeName + " is next to bid";
                        PlayerThreeStarting = true;
                        PlayerTwoStarting = false;
                        --count;

                    }

                }

                else if (PlayerThreeStarting == true)
                {
                    if (ThirdPlayerBid < 0 || ThirdPlayerBid > 13)
                    {
                        MessageBox.Show(ThirdPlayerBid.ToString());
                    }

                    else
                    {
                        MessageBox.Show(count.ToString());
                        currBidLbl3.Text = scoreBox3.Text;
                        currBidLbl3.Visible = true;

                        scoreBox3.Visible = false;
                        scoreBox1.Visible = true;
                        firstBidLbl.Text = Form2.playerOneName + " is next to bid";
                        PlayerOneStarting = true;
                        PlayerThreeStarting = false;
                        --count;

                    }

                }

                else if (PlayerFourStarting == true)
                {
                    if (FourthPlayerBid < 0 || FourthPlayerBid > 13)
                    {
                        MessageBox.Show("insert a number 0 through 13");
                    }

                    else
                    {
                        MessageBox.Show(count.ToString());
                        currBidLbl4.Text = scoreBox4.Text;
                        currBidLbl4.Visible = true;

                        scoreBox4.Visible = false;
                        scoreBox2.Visible = true;
                        firstBidLbl.Text = Form2.playerTwoName + " is next to bid";
                        PlayerTwoStarting = true;
                        PlayerFourStarting = false;
                        --count;

                    }

                }
            }

            else if ((count >= 5 && count <= 9))
            {
                if (PlayerOneStarting == true)
                {
                    if (FirstFinalBid < 0 || FirstFinalBid > 13)
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }

                    else
                    {
                        if (count == 5)
                        {
                            finalBid1.Visible = false;

                            MessageBox.Show(count.ToString());

                            scoreBox1.Visible = false;
                            scoreBox4.Visible = true;
                            firstBidLbl.Text = Form2.playerFourName + " is next to bid";
                            PlayerFourStarting = true;
                            PlayerOneStarting = false;
                            count = 3;

                            

                        }

                        else
                        {    
                            finalBid1.Visible = false;
                            finalBid4.Visible = true;
                            firstBidLbl.Text = "How many hands did " + Form2.playerFourName + " win ?";
                            PlayerFourStarting = true;
                            PlayerOneStarting = false;
                            --count;
                        }
                    }

                }

                else if (PlayerTwoStarting == true)
                {
                    if (SecondFinalBid < 0 || SecondFinalBid > 13)
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }

                    else
                    {
                        if (count == 5)
                        {

                            finalBid2.Visible = false;

                            scoreBox2.Visible = false;
                            scoreBox3.Visible = true;
                            firstBidLbl.Text = Form2.playerThreeName + " is next to bid";
                            PlayerThreeStarting = true;
                            PlayerTwoStarting = false;
                            count = 3;

                        }

                        else
                        {   
                            finalBid2.Visible = false;
                            finalBid3.Visible = true;
                            firstBidLbl.Text = "How many hands did " + Form2.playerThreeName + " win ? ";
                            PlayerThreeStarting = true;
                            PlayerTwoStarting = false;
                            --count;
                        }
                    }
                  
                }

                else if (PlayerThreeStarting == true)
                {
                    if (ThirdFinalBid < 0 || ThirdFinalBid > 13)
                    {
                        MessageBox.Show("Invalid Bid. Insert a number from 0 to 13");
                    }

                    else
                    {

                        if (count == 5)
                        {
                            MessageBox.Show(count.ToString());

                            finalBid3.Visible = false;

                            scoreBox3.Visible = false;
                            scoreBox1.Visible = true;
                            firstBidLbl.Text = Form2.playerOneName + " is next to bid";
                            PlayerOneStarting = true;
                            PlayerThreeStarting = false;
                            count = 3;
                            
                            

                        }

                        else
                        {
                            finalBid3.Visible = false;
                            finalBid1.Visible = true;
                            firstBidLbl.Text = "How many hands did " + Form2.playerOneName + " win ? ";
                            PlayerOneStarting = true;
                            PlayerThreeStarting = false;
                            --count;
                        }

                    }

                }

                else if (PlayerFourStarting == true)
                {
                    if (FourthFinalBid < 0 || FourthFinalBid > 13)
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }

                    else
                    {
                        if (count == 5)
                        {
                            finalBid4.Visible = false;

                            scoreBox4.Visible = false;
                            scoreBox2.Visible = true;
                            firstBidLbl.Text = Form2.playerTwoName + " is next to bid";
                            PlayerTwoStarting = true;
                            PlayerFourStarting = false;
                            count = 3;
                        }

                        else
                        {
                            finalBid4.Visible = false;
                            finalBid2.Visible = true;
                            firstBidLbl.Text = "How many hands did " + Form2.playerTwoName + " win ? ";
                            PlayerTwoStarting = true;
                            PlayerFourStarting = false;
                            --count;
                        }

                    }
                }

            }

            if (NewRound == true)
            {
                NewRound = false;
                GameOver = false;
                confirmBidBtn.Text = "Confirm Bid";

                if (PlayerOneStarting == true)
                {
                    finalBid1.Visible = false;
                    finalBid4.Visible = true;
                    firstBidLbl.Text = "How many hands did " + Form2.playerFourName + " win ?";
                    PlayerFourStarting = true;
                    PlayerOneStarting = false;
                    --count;

                }

                else if (PlayerTwoStarting == true)
                {
                    finalBid2.Visible = false;
                    finalBid3.Visible = true;
                    firstBidLbl.Text = "How many hands did " + Form2.playerThreeName + " win ? ";
                    PlayerThreeStarting = true;
                    PlayerTwoStarting = false;
                    --count;
                }

                else if (PlayerThreeStarting == true)
                {
                    finalBid3.Visible = false;
                    finalBid1.Visible = true;
                    firstBidLbl.Text = "How many hands did " + Form2.playerOneName + " win ? ";
                    PlayerOneStarting = true;
                    PlayerThreeStarting = false;
                    --count;
                }

                else if (PlayerFourStarting == true)
                {
                    finalBid4.Visible = false;
                    finalBid2.Visible = true;
                    firstBidLbl.Text = "How many hands did " + Form2.playerTwoName + " win ? ";
                    PlayerTwoStarting = true;
                    PlayerFourStarting = false;
                    --count;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (GameOver == true)
            {
                spadesWdw restart = new spadesWdw();
                restart.Show();
                this.Hide();
                count = 0;
            }
            
            if (NewRound == true)
            {
                confirmBidBtn.Text = "Confirm Bid";

                PlayerOneStarting = false;
                PlayerTwoStarting = false;
                PlayerThreeStarting = false;
                PlayerFourStarting = false;

                ++round;
                roundLabel.Text = "ROUND " + round;

                if (result == 1)
                {
                    result = 3;
                }

                else if (result == 2)
                {
                    result = 4;
                }

                else if (result == 3)
                {
                    result = 2;
                }

                else if (result == 4)
                {
                    result = 1;
                }

                whosFirst(result);
                count = 0;
                NewRound = false;
            }
            
            else if (count < 4 && count >= 0)
            {
                if (PlayerOneStarting == true)
                {
                    if (FirstPlayerBid >= 0 && FirstPlayerBid <= 13)
                    {

                        currBidLbl1.Text = scoreBox1.Text;
                        currBidLbl1.Visible = true;

                        scoreBox1.Visible = false;
                        scoreBox3.Visible = true;
                        firstBidLbl.Text = Form2.playerThreeName + " is next to bid";
                        PlayerThreeStarting = true;
                        PlayerOneStarting = false;
                        ++count;
                        

                        if (count == 4)
                        {
                            PlayerOneStarting = true;
                            PlayerThreeStarting = false;
                            FinalPerson(count);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }
                }

                else if (PlayerTwoStarting == true)
                {
                    if (SecondPlayerBid < 0 || SecondPlayerBid > 13)
                    {
                        MessageBox.Show("Invalid bid. Insert a number from 0 to 13");
                    }

                    else
                    {
                        currBidLbl2.Text = scoreBox2.Text;
                        currBidLbl2.Visible = true;

                        scoreBox2.Visible = false;
                        scoreBox4.Visible = true;
                        firstBidLbl.Text = Form2.playerFourName + " is next to bid";
                        PlayerFourStarting = true;
                        PlayerTwoStarting = false;
                        ++count;

                        if (count == 4)
                        {
                            PlayerTwoStarting = true;
                            PlayerFourStarting = false;
                            FinalPerson(count);
                        }
                    }

                }

                else if (PlayerThreeStarting == true)
                {
                    if (ThirdPlayerBid < 0 || ThirdPlayerBid > 13)
                    {
                        MessageBox.Show("Test 2");
                    }

                    else
                    {
                        currBidLbl3.Text = scoreBox3.Text;
                        currBidLbl3.Visible = true;

                        scoreBox3.Visible = false;
                        scoreBox2.Visible = true;
                        firstBidLbl.Text = Form2.playerTwoName + " is next to bid";
                        PlayerTwoStarting = true;
                        PlayerThreeStarting = false;
                        ++count;

                        if (count == 4)
                        {
                            PlayerThreeStarting = true;
                            PlayerTwoStarting = false;
                            FinalPerson(count);
                        }
                    }

                }

                else if (PlayerFourStarting == true)
                {
                    if (FourthPlayerBid < 0 || FourthPlayerBid > 13)
                    {
                        MessageBox.Show("test");
                    }

                    else
                    {
                        currBidLbl4.Text = scoreBox4.Text;
                        currBidLbl4.Visible = true;

                        scoreBox4.Visible = false;
                        scoreBox1.Visible = true;
                        firstBidLbl.Text = Form2.playerOneName + " is next to bid";
                        PlayerOneStarting = true;
                        PlayerFourStarting = false;
                        
                       
                        ++count;

                        if (count == 4)
                        {
                            PlayerOneStarting = false;
                            PlayerFourStarting = true;
                            FinalPerson(count);
                        }
                        
                    }

                }
                
            }
           
            else if (count >= 4)
            {
                FinalPerson(count);
            }
           
 
        }

        // first player's first bid
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int tempInt;

            int.TryParse(scoreBox1.Text, out tempInt);

            FirstPlayerBid = tempInt;
        }

        // second player's first bid
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int tempInt;

            int.TryParse(scoreBox2.Text, out tempInt);
                
            SecondPlayerBid = tempInt;
        }

        
        // fourth player's first bid
        private void scoreBox4_TextChanged(object sender, EventArgs e)
        {
            int tempInt;

            int.TryParse(scoreBox4.Text, out tempInt);

            FourthPlayerBid = tempInt;

        }

        // third player's first bid
        private void scoreBox3_TextChanged(object sender, EventArgs e)
        {
            int tempInt;

            int.TryParse(scoreBox3.Text, out tempInt);

            ThirdPlayerBid = tempInt;
        }

        // exit button
        private void menuBtn_Click(object sender, EventArgs e)
        {
            StartForm home = new StartForm();
            home.Show();
            this.Hide();
            count = 0;

        }

        // text boxes that keep track of the final bids
     

        private void finalBid4_TextChanged(object sender, EventArgs e)
        {
             int tempInt;

             int.TryParse(finalBid4.Text, out tempInt);

             FourthFinalBid = tempInt;
            
        }

        private void finalBid2_TextChanged(object sender, EventArgs e)
        {
            int tempInt;

            int.TryParse(finalBid2.Text, out tempInt);

            SecondFinalBid = tempInt;
        }

        private void finalBid3_TextChanged(object sender, EventArgs e)
        {
            int tempInt;

            int.TryParse(finalBid3.Text, out tempInt);

            ThirdFinalBid = tempInt;
        }

        private void finalBid1_TextChanged(object sender, EventArgs e)
        {
            int tempInt;

            int.TryParse(finalBid1.Text, out tempInt);

            FirstFinalBid = tempInt;
        }

        private void currBidLbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
