using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Casino
{
    public partial class vPoker : Form
    {
        
        public Player User { get; set; }
        public vPoker(Player player)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.User = player;
            this.groupBox2.Text = player.PlayerName;
        }
        
        // Game variables
        int previousCard = 51;
        int[] PlayerCards = new int[5];
        int[] DealerCards = new int[5];
        double num_pWins;
        double num_pLosses;
        double pCredit = 50;
        double num_dWins;
        double num_dLosses;
        double pW_LRatio = 0;
        double dW_LRatio = 0;
        double dCredit = 50;
        double movJackpot = 1000;
        int randDeal;

        // Creates the GUI objects and other componenets that
        // are part of the interface
        private void vPoker_Load(object sender, EventArgs e)
        {
            replaceButton.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gameMessages.Text = "Press 'Deal'";
            gameInfo.Text = "0  - High Card   1  - One Pair       2  - Two Pair           3  - Three of A Kind        4  - Straight     \n\n5  - Flush           6  - Full House           7  - Four of A Kind         8  - Straight Flush";

            btnOne.Enabled = false;
            btnFive.Enabled = false;
            btnTen.Enabled = false;
            btnTwentyFive.Enabled = false;
            btnFifty.Enabled = false;
            btnOneHundred.Enabled = false;
            btnFiveHundred.Enabled = false;

            Jackpot.Text = movJackpot.ToString("C2");
            pWins.Text = (num_pWins.ToString() + "/10");
            pWallet.Text = pCredit.ToString("C2");
            dWallet.Text = dCredit.ToString("C2");
        }

        // Create Rand object - used to simulate picking random
        // cards from the deck
        private readonly Random r = new Random();

        // Deck of cards as an array of integers which represents the value of the card,
        // it is also used as the index to keep track of the cards dealt. The images, have 
        // the same name i.e. 21.png is the 2-of-clubs and 144.png is ace-of-spades
        readonly int[] t_Deck = new int[52] {21, 22, 23, 24, 31, 32, 33, 34, 41, 42, 43, 44, 51, 52, 53, 54, 61, 62, 63, 64, 71, 72, 73, 74,
        81, 82, 83, 84, 91, 92, 93, 94, 101, 102, 103, 104, 111, 112, 113, 114, 121, 122, 123,124, 131, 132, 133, 134, 141, 142, 143, 144};

        // The deal button. It deals random cards, updates variables,
        // and then changes the picture boxes to show cards dealt,
        private void dealButton_Click(object sender, EventArgs e)
        {
            int i;
            this. Dealer('s');

            for (i = 0; (i <= 4); i++)
            {
                PlayerCards[i] = this. Dealer('n');
                DealerCards[i] = this. Dealer('n');
            }

            gameMessages.Text = "Press \'Replace Cards\' to play your hand...";
            this.sort(ref PlayerCards);
            this.sort(ref DealerCards);
            string im1 = "c" + PlayerCards[0].ToString();
            string im2 = "c" + PlayerCards[1].ToString();
            string im3 = "c" + PlayerCards[2].ToString();
            string im4 = "c" + PlayerCards[3].ToString();
            string im5 = "c" + PlayerCards[4].ToString();
            player_cpic_slot5.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im1);
            player_cpic_slot4.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im2);
            player_cpic_slot3.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im3);
            player_cpic_slot2.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im4);
            player_cpic_slot1.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im5);
            dealer_cpic_slot5.Image = Casino.Properties.Resources.Back;
            dealer_cpic_slot4.Image = Casino.Properties.Resources.Back;
            dealer_cpic_slot3.Image = Casino.Properties.Resources.Back;
            dealer_cpic_slot2.Image = Casino.Properties.Resources.Back;
            dealer_cpic_slot1.Image = Casino.Properties.Resources.Back;



            checkBox1.Show();
            checkBox2.Show();
            checkBox3.Show();
            checkBox4.Show();
            checkBox5.Show();
            replaceButton.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;


            btnOne.Enabled = true;
            btnFive.Enabled = true;
            btnTen.Enabled = true;
            btnTwentyFive.Enabled = true;
            btnFifty.Enabled = true;
            btnOneHundred.Enabled = true;
            btnFiveHundred.Enabled = true;
            try
            {
                pW_LRatio = (num_pWins / num_pLosses);
                dW_LRatio = (num_dWins / num_dLosses);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide By Zero Exception");
            }
            pWins.Text = (num_pWins.ToString() + "/10");
            pWallet.Text = pCredit.ToString("C2");
            dWallet.Text = dCredit.ToString("C2");
        }

        // The replace button. It swaps any cards that were checked, calls 
        // evalHand(), and then shows info about the round and updates 
        // other variables used by the game to keep score
        private void replaceButton_Click(object sender, EventArgs e)
        {

            double pHandValue = 0;
            double dHandValue = 0;
            int intBoxTotal = 0;
            if ((checkBox1.Checked == true))
            {
                intBoxTotal = 1;
            }

            if ((checkBox2.Checked == true))
            {
                intBoxTotal++;
            }

            if ((checkBox3.Checked == true))
            {
                intBoxTotal++;
            }

            if ((checkBox4.Checked == true))
            {
                intBoxTotal++;
            }

            if ((checkBox5.Checked == true))
            {
                intBoxTotal++;
            }

            if ((intBoxTotal > 3))
            {
                MessageBox.Show("You\'re only able to replace up to 3 cards", "Replace Cards", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((checkBox1.Checked == true))
                {
                    PlayerCards[0] = this. Dealer('n');
                }

                if ((checkBox2.Checked == true))
                {
                    PlayerCards[1] = this. Dealer('n');
                }

                if ((checkBox3.Checked == true))
                {
                    PlayerCards[2] = this. Dealer('n');
                }

                if ((checkBox4.Checked == true))
                {
                    PlayerCards[3] = this. Dealer('n');
                }
                if ((checkBox5.Checked == true))
                {
                    PlayerCards[4] = this. Dealer('n');
                }

                replaceButton.Enabled = false;
                btnOne.Enabled = false;
                btnFive.Enabled = false;
                btnTen.Enabled = false;
                btnTwentyFive.Enabled = false;
                btnFifty.Enabled = false;
                btnOneHundred.Enabled = false;
                btnFiveHundred.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;

                this.sort(ref PlayerCards);
                string im1 = "c" + PlayerCards[0].ToString();
                string im2 = "c" + PlayerCards[1].ToString();
                string im3 = "c" + PlayerCards[2].ToString();
                string im4 = "c" + PlayerCards[3].ToString();
                string im5 = "c" + PlayerCards[4].ToString();
                player_cpic_slot5.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im1);
                player_cpic_slot4.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im2);
                player_cpic_slot3.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im3);
                player_cpic_slot2.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im4);
                player_cpic_slot1.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(im5);


                pHandValue = this.evalHand(ref PlayerCards);

                this.dealerAI(ref DealerCards, dHandValue);
                for (int i = 0; (i <= 4); i++)
                {
                    if ((DealerCards[i] == 0))
                    {
                        DealerCards[i] = this. Dealer('n');
                    }

                }

                this.sort(ref DealerCards);

                dHandValue = this.evalHand(ref DealerCards);

                string d_im1 = "c" + DealerCards[0].ToString();
                string d_im2 = "c" + DealerCards[1].ToString();
                string d_im3 = "c" + DealerCards[2].ToString();
                string d_im4 = "c" + DealerCards[3].ToString();
                string d_im5 = "c" + DealerCards[4].ToString();
                dealer_cpic_slot5.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(d_im1);
                dealer_cpic_slot4.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(d_im2);
                dealer_cpic_slot3.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(d_im3);
                dealer_cpic_slot2.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(d_im4);
                dealer_cpic_slot1.Image = (Image)Casino.Properties.Resources.ResourceManager.GetObject(d_im5);
            }

            this.dealerBets();
      
            if ((pHandValue > dHandValue))
            {
                gameMessages.Text = ("Congrats Player!" + "\n" + "You\'ve won!" + "\n" + "Dealer: " + dHandValue.ToString() + "\n" + "Player: " + pHandValue.ToString());
                num_pWins++;
                num_dLosses++;
                pCredit+=movJackpot;
                movJackpot = 350;
                Jackpot.Text = movJackpot.ToString("C2");

                try
                {
                    pW_LRatio = (num_pWins / num_pLosses);
                    dW_LRatio = (num_dWins / num_dLosses);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Divide By Zero Exception");
                }
                pWins.Text = (num_pWins.ToString() + "/10");
                pWallet.Text = pCredit.ToString("C2");
                dWallet.Text = dCredit.ToString("C2");

                if ((num_pWins == 10))
                {
                    DialogResult result = MessageBox.Show("Game over, you win!\nWould you like to play again?", "End", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else if ((pHandValue == dHandValue))
            {
                gameMessages.Text = ("It\'s a Tie!!!" + "\n" + "Dealer: " + dHandValue.ToString() + "\n" + "Player: " + pHandValue.ToString() + "\n");
            }
            else
            {
                gameMessages.Text = ("Sorry Player\n" + "You\'ve lost." + "\n" + "Play Again!" + "\n" + "Dealer: " + dHandValue.ToString() + "\n" + "Player: " + pHandValue.ToString() + "\n");
                num_dWins++;
                num_pLosses++;
                dCredit+=movJackpot;
                movJackpot = 350;
                Jackpot.Text = movJackpot.ToString("C2");
                try
                {
                    pW_LRatio = (num_pWins / num_pLosses);
                    dW_LRatio = (num_dWins / num_dLosses);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Divide By Zero Exception");
                }
                pWins.Text = (num_pWins.ToString() + "/10");
                pWallet.Text = pCredit.ToString("C2");
                dWallet.Text = dCredit.ToString("C2");
                if ((num_dWins == 10))
                {
                    DialogResult result = MessageBox.Show("Game over, you lose!\nWould you like to play again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            try
            {
                pW_LRatio = (num_pWins / num_pLosses);
                dW_LRatio = (num_dWins / num_dLosses);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide By Zero Exception");
            }
            pWins.Text = (num_pWins.ToString() + "/10");
            pWallet.Text = pCredit.ToString("C2");
            dWallet.Text = dCredit.ToString("C2");
        }

        // Get the value of the hand, starting from highest possible
        public double evalHand(ref int[] hand)

        {
            double handValue;
            handValue = this.straightFlush(ref hand);
            if ((handValue == 0))
            {
                handValue = this.fourOfKind(ref hand);
                if ((handValue == 0))
                {
                    handValue = this.fullHouse(ref hand);
                    if ((handValue == 0))
                    {
                        handValue = this.flush(ref hand);
                        if ((handValue == 0))
                        {
                            handValue = this.straight(ref hand);
                            if ((handValue == 0))
                            {
                                handValue = this.threeOfKind(ref hand);
                                if ((handValue == 0))
                                {
                                    handValue = this.twoPair(ref hand);
                                    if ((handValue == 0))
                                    {
                                        handValue = this.onePair(ref hand);
                                        if ((handValue == 0))
                                        {
                                            handValue = this.highCard(ref hand);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return handValue;
        }

        // Functions that evaluate the and and determine how many points
        // the hand is worth
        private double highCard(ref int[] Hand)
        {
            int C1;
            int C2;
            int C3;
            int C4;
            int C5;
            C1 = Hand[0];
            C2 = Hand[1];
            C3 = Hand[2];
            C4 = Hand[3];
            C5 = Hand[4];
            C1 = C1 / 10;
            C2 = C2 / 10;
            C3 = C3 / 10;
            C4 = C4 / 10;
            C5 = C5 / 10;
            double Value = ((C1 * 0.01) + ((C2 * 0.0001) + ((C3 * 1E-06) + ((C4 * 1E-08) + (C5 * 1E-10)))));
            return Value;
        }
        private double onePair(ref int[] hands)
        {
            double Value;
            int[] hand = new int[5];
            for (int i = 0; (i <= 4); i++)
            {
                hand[i] = (hands[i] / 10);
            }
            if ((hand[0] == hand[1]))
            {
                Value = (1 + ((hand[0] * 0.01) + ((hand[2] * 0.0001) + ((hand[3] * 1E-06) + (hand[4] * 1E-08)))));
                return Value;
            }
            else if ((hand[1] == hand[2]))
            {
                Value = (1 + ((hand[1] * 0.01) + ((hand[0] * 0.0001) + ((hand[3] * 1E-06) + (hand[4] * 1E-08)))));
                return Value;
            }
            else if ((hand[2] == hand[3]))
            {
                Value = (1 + ((hand[2] * 0.01) + ((hand[0] * 0.0001) + ((hand[1] * 1E-06) + (hand[4] * 1E-08)))));
                return Value;
            }
            else if ((hand[3] == hand[4]))
            {
                Value = (1 + ((hand[3] * 0.01) + ((hand[0] * 0.0001) + ((hand[1] * 1E-06) + (hand[2] * 1E-08)))));
                return Value;
            }
            else
            {
                Value = 0;
                return Value;
            }

        }
        private double twoPair(ref int[] Cards)
        {
            double Value = 0;
            if (Cards[0] / 10 == Cards[1] / 10 & Cards[2] / 10 == Cards[3] / 10)
            {
                Value = 2 + (Cards[0] / 10) * 0.01 + (Cards[2] / 10) * 0.0001 + (Cards[4] / 10) * 1E-06;
                return Value;
            }
            else if (Cards[0] / 10 == Cards[1] / 10 & Cards[3] / 10 == Cards[4] / 10)
            {
                Value = 2 + (Cards[1] / 10) * 0.01 + (Cards[3] / 10) * 0.0001 + (Cards[3] / 10) * 1E-06;
                return Value;
            }
            else if (Cards[1] / 10 == Cards[2] / 10 & Cards[3] / 10 == Cards[4] / 10)
            {
                Value = 2 + (Cards[2] / 10) * 0.01 + (Cards[3] / 10) * 0.0001 + (Cards[0] / 10) * 1E-06;
                return Value;
            }
            else
            {
                return Value;
            }
        }
        private double threeOfKind(ref int[] Cards)
        {
            double Value;
            Value = 0;
            if (Cards[0] / 10 == Cards[2] / 10)
            {
                Value = 3 + (Cards[0] / 10) * 0.01;
                return Value;
            }
            else if (Cards[1] / 10 == Cards[3] / 10)
            {
                Value = 3 + (Cards[1] / 10) * 0.01;
                return Value;
            }
            else if (Cards[2] / 10 == Cards[4] / 10)
            {
                Value = 3 + (Cards[2] / 10) * 0.01;
                return Value;
            }
            else
            {
                return Value;

            }

        }
        private double straight(ref int[] Cards)
        {
            
            double Value = 0;
            if (((Cards[0] / 10) - (Cards[1] / 10) == 1) && ((Cards[1] / 10) - (Cards[2] / 10) == 1) && ((Cards[2] / 10) - (Cards[3] / 10) == 1) && ((Cards[3] / 10) - (Cards[4] / 10) == 1))
            {
                Value = 4.0 + (Cards[0] / 10) * 0.01;
            }

            return Value;
        }
        private double flush(ref int[] Cards)
        {
            double Value = 0;

            if ((Cards[0] % 10 == Cards[1] % 10) && (Cards[1] % 10 == Cards[2] % 10) && (Cards[2] % 10 == Cards[3] % 10) && (Cards[3] % 10 == Cards[4] % 10))
            {
                Value = 5.0 + ((Cards[0] / 10) * 0.01) + ((Cards[1] / 10) * 0.0001) + ((Cards[2] / 10) * 1E-06) + ((Cards[3] / 10) * 1E-08) + ((Cards[4] / 10) * 1E-10);
            }

            return Value;
        }
        private double fullHouse(ref int[] Cards)
        {
            double Value;
            Value = 0;

            if (Cards[0] / 10 == Cards[2] / 10 & Cards[3] / 10 == Cards[4] / 10)
            {
                Value = 6 + (Cards[0] / 10) * 0.01 + (Cards[3] / 10) * 0.0001;
                return Value;
            }
            else if (Cards[0] / 10 == Cards[1] / 10 & Cards[2] / 10 == Cards[4] / 10)
            {
                Value = 6 + (Cards[0] / 10) * 0.01 + (Cards[2] / 10) * 0.0001;
                return Value;
            }
            else
            {
                return Value;
            }
        }
        private double fourOfKind(ref int[] Cards)
        {
            double Value;
            Value = 0;

            if (Cards[0] / 10 == Cards[3] / 10)
            {
                Value = 7 + (Cards[0] / 10) * 0.01;
                return Value;
            }
            else if (Cards[1] / 10 == Cards[4] / 10)
            {
                Value = 7 + (Cards[1] / 10) * 0.01;
                return Value;
            }
            else
            {
                return Value;
            }
        }
        private double straightFlush(ref int[] Cards)
        {
            double Value = 0;
            int Count = 0;

            if (((Cards[0] / 10) - (Cards[1] / 10) == 1) && ((Cards[1] / 10) - (Cards[2] / 10) == 1) && ((Cards[2] / 10) - (Cards[3] / 10) == 1) && ((Cards[3] / 10) - (Cards[4] / 10) == 1))
            {
                Count = 1;
            }
            if ((Cards[0] % 10 == Cards[1] % 10) && (Cards[1] % 10 == Cards[2] % 10) && (Cards[2] % 10 == Cards[3] % 10) && (Cards[3] % 10 == Cards[4] % 10))
            {
                Count += 1;
            }

            if ((Count == 2))
            {
                Value = 8.0 + (Cards[0] / 10) * 0.01;
            }
            return Value;
        }

        // put the card in order (insertion sort)
        private void sort(ref int[] hand)
        {
            int i;
            int j;
            int intTemp;
            for (i = 0; (i <= 3); i++)
            {
                for (j = (i + 1); (j <= 4); j++)
                {
                    if ((hand[j] > hand[i]))
                    {
                        intTemp = hand[i];
                        hand[i] = hand[j];
                        hand[j] = intTemp;
                    }
                }
            }
        }

        // Deal cards rand is used to get cards from the array
        private int Dealer(char dor)
        {
            if ((dor == 's'))
            {
                previousCard = 51;
                return 0;
            }
            else
            {
                int x;
                int sswap;
                randDeal = r.Next();
                if ((previousCard == 0))
                {
                    return 0;
                }

                x = r.Next(0, previousCard);
                sswap = t_Deck[x];
                t_Deck[x] = t_Deck[previousCard];
                t_Deck[previousCard] = sswap;
                previousCard--;
                return t_Deck[previousCard + 1];
            }

        }

        // The logic behind the dealer
        public void dealerAI(ref int[] DealerCards, double dHandTotal)
        {
            int[] b = new int[4];
            if (true)
            {
                if (dHandTotal < 1)
                {
                    b[((DealerCards[0] % 10) - 1)] = b[((DealerCards[0] % 10) - 1)] + 1;
                    b[((DealerCards[1] % 10) - 1)] = b[((DealerCards[1] % 10) - 1)] + 1;
                    b[((DealerCards[2] % 10) - 1)] = b[((DealerCards[2] % 10) - 1)] + 1;
                    b[((DealerCards[3] % 10) - 1)] = b[((DealerCards[3] % 10) - 1)] + 1;
                    b[((DealerCards[4] % 10) - 1)] = b[((DealerCards[4] % 10) - 1)] + 1;

                    for (int i = 0; i <= 3; i++)
                    {
                        if ((b[i] >= 3))
                        {
                            for (int j = 0; j <= 4; j++)
                            {
                                if (((PlayerCards[j] % 10) != 1))
                                {
                                    PlayerCards[j] = 0;
                                }
                            }
                        }
                    }

                    if (DealerCards[0] / 10 == ((DealerCards[3] / 10) + 4))
                    {
                        DealerCards[4] = 0;
                    }
                    if (DealerCards[1] / 10 == ((DealerCards[4] / 10) + 4))
                    {
                        DealerCards[4] = 0;
                    }

                    if (DealerCards[2] == 51 | DealerCards[2] == 52 | DealerCards[2] == 53 | DealerCards[2] == 54)
                    {
                        if (DealerCards[0] == 141 | DealerCards[0] == 142 | DealerCards[0] == 143 | DealerCards[0] == 144)
                        {
                            DealerCards[1] = 0;
                        }
                    }

                    if ((DealerCards[0] != 0 & DealerCards[1] != 0 & DealerCards[2] != 0 & DealerCards[3] != 0 & DealerCards[4] != 0))
                    {
                        DealerCards[2] = 0;
                        DealerCards[3] = 0;
                        DealerCards[4] = 0;
                    }
                }

                if (dHandTotal < 2 & dHandTotal > 1)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        if (DealerCards[1] / 10 != Math.Truncate((dHandTotal * 100) - 100))
                        {
                            DealerCards[i] = 0;
                        }
                    }

                } 

                if (dHandTotal < 3 & dHandTotal > 2)
                    for (int i = 0; i <= 4; i++)
                    {
                        if (DealerCards[i] / 1 == ((dHandTotal * 1000000) - (Math.Truncate((dHandTotal * 10000)) * 100)))
                        {
                            DealerCards[i] = 0;
                        }
                    } 

            }
            if (dHandTotal < 4 & dHandTotal > 3)
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (DealerCards[1] / 10 != Math.Truncate((dHandTotal * 100) - 300))
                    {
                        DealerCards[i] = 0;
                    }
                }
            }
        }

        // Functions to modify the value in the dealers Bank
        public void dealerBets()
        {
            if ((dCredit > 1500))
            {
                dCredit -= 650;
                movJackpot += 650;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if ((dCredit > 1200))
            {
                dCredit -= 700;
                movJackpot += 650;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if ((dCredit > 1000))
            {
                dCredit -= 500;
                movJackpot += 500;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if (((dCredit > 1000)
                        && (dW_LRatio > 0.5)))
            {
                dCredit -= 400;
                movJackpot += 400;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if ((dCredit > 750))
            {
                dCredit -= 550;
                movJackpot += 550;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if (((dCredit > 650)
                        && (dW_LRatio > 0.75)))
            {
                dCredit -= 400;
                movJackpot += 400;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if ((dCredit > 650))
            {
                dCredit -= 150;
                movJackpot += 150;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if (((num_dWins > num_pWins)
                        && ((dCredit > 500)
                        && (dW_LRatio > 0.5))))
            {
                dCredit -= 500;
                movJackpot += 500;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if ((dCredit > 450))
            {
                dCredit -= 300;
                movJackpot += 300;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if (((dCredit > 450)
                        && (dW_LRatio > 1)))
            {
                dCredit -= 375;
                movJackpot += 375;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if ((dCredit > 300))
            {
                dCredit -= 150;
                movJackpot += 150;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if ((dCredit > 200))
            {
                dCredit -= 50;
                movJackpot += 50;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if ((dCredit > 100))
            {
                dCredit -= 75;
                movJackpot += 75;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }
            else if ((dCredit > 75))
            {
                dCredit -= 15;
                movJackpot += 15;
                dWallet.Text = dCredit.ToString("C2");
                Jackpot.Text = movJackpot.ToString("C2");
            }

        }

        // Functions to place bets using the 'Bets' buttons
        private void btnOne_Click_1(object sender, EventArgs e)
        {
            if ((pCredit >= 1))
            {
                pCredit--;
                movJackpot++;
                Jackpot.Text = ("$" + movJackpot.ToString("N2"));
                pWallet.Text = pCredit.ToString("C2");
            }
            else
            {
                MessageBox.Show("Not enough money!", "Empty Wallet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnFive_Click_1(object sender, EventArgs e)
        {
            if ((pCredit >= 5))
            {
                pCredit -= 5;
                movJackpot += 5;
                Jackpot.Text = ("$" + movJackpot.ToString("N2"));
                pWallet.Text = pCredit.ToString("C2");
            }
            else
            {
                MessageBox.Show("Not enough money!", "Empty Wallet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnTen_Click_1(object sender, EventArgs e)
        {
            if ((pCredit >= 10))
            {
                pCredit -= 10;
                movJackpot += 10;
                Jackpot.Text = ("$" + movJackpot.ToString("N2"));
                pWallet.Text = pCredit.ToString("C2");
            }
            else
            {
                MessageBox.Show("Not enough money!", "Empty Wallet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnTwentyFive_Click_1(object sender, EventArgs e)
        {
            if ((pCredit >= 25))
            {
                pCredit -= 25;
                movJackpot += 25;
                Jackpot.Text = ("$" + movJackpot.ToString("N2"));
                pWallet.Text = pCredit.ToString("C2");
            }
            else
            {
                MessageBox.Show("Not enough money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnFifty_Click_1(object sender, EventArgs e)
        {
            if ((pCredit >= 50))
            {
                pCredit -= 50;
                movJackpot += 50;
                Jackpot.Text = ("$" + movJackpot.ToString("N2"));
                pWallet.Text = pCredit.ToString("C2");
            }
            else
            {
                MessageBox.Show("Not enough money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnOneHundred_Click_1(object sender, EventArgs e)
        {
            if ((pCredit >= 100))
            {
                pCredit -= 100;
                movJackpot += 100;
                Jackpot.Text = ("$" + movJackpot.ToString("N2"));
                pWallet.Text = pCredit.ToString("C2");
            }
            else
            {
                MessageBox.Show("Not enough money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnFiveHundred_Click_1(object sender, EventArgs e)
        {
            if ((pCredit >= 500))
            {
                pCredit -= 500;
                movJackpot += 500;
                Jackpot.Text = ("$" + movJackpot.ToString("N2"));
                pWallet.Text = pCredit.ToString("C2");
            }
            else
            {
                MessageBox.Show("Not enough money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Controls and function calls for menu bar options
        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameMessages_Click(object sender, EventArgs e)
        {

        }
    }
}
