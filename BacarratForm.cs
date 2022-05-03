using System;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace Casino
{
    public partial class BacarratForm : Form
    {
        private int SetDealerBet = 0;
        private int SetPlayerBet = 0;
        private int SetTieBet = 0;
        private int currBet = 0;
        public string playerCard1;
        public string playerCard2;
        public string playerCard3;
        public string dealerCard1;
        public string dealerCard2;
        public string dealerCard3;
        private int winCount = 0;
        private int drWins = 0;
        private int prWins = 0;
        private int tWins = 0;
        private int totalWinnings = 0;
        private int playerTotal = 0;
        private int dealerTotal = 0;

        private Deck DeckBac = new Deck(6);
        private Hand dealer = new Hand();
        private Hand player = new Hand();
        private int Winner = 0;
        private int cashToAdd { get; set; }
        private int MinCardCount = 6;

        public Player User { get; set; }

        public BacarratForm(Player player)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            User = player;
        }

        private void btnPlayerWinsMinus_Click(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
            {
                if (User.Cash > 0 && SetPlayerBet > 0)
                {
                    SetPlayerBet -= 1;
                    currBet -= 1;
                }
            }
            else if (rdBtn5.Checked)
            {
                if (User.Cash > 0 && SetPlayerBet > 0)
                {
                    SetPlayerBet -= 5;
                    currBet -= 5;
                }
            }
            else if (rdBtn20.Checked)
            {
                if (User.Cash > 0 && SetPlayerBet > 0)
                {
                    SetPlayerBet -= 20;
                    currBet -= 20;
                }
            }
            if (currBet < 0)
                currBet = 0;
            lblCurrBet.Text = "Current Bet: " + currBet.ToString("C");
        }

        private void btnPlayerWinsPlus_Click(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
            {
                if (User.Cash > 0 && User.Cash > currBet)
                {
                    SetPlayerBet += 1;
                    currBet += 1;
                }
            }
            else if (rdBtn5.Checked)
            {
                if (User.Cash > 0 && User.Cash > currBet)
                {
                    SetPlayerBet += 5;
                    currBet += 5;
                }
            }
            else if (rdBtn20.Checked)
            {
                if (User.Cash > 0 && User.Cash > currBet)
                {
                    SetPlayerBet += 20;
                    currBet += 20;
                }
            }
            if (currBet < 0)
                currBet = 0;
            lblCurrBet.Text = "Current Bet: " + currBet.ToString("C");
        }

        private void btnDealerWinsMinus_Click(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
            {
                if (User.Cash > 0 && SetDealerBet > 0)
                {
                    SetDealerBet -= 1;
                    currBet -= 1;
                }
            }
            else if (rdBtn5.Checked)
            {
                if (User.Cash > 0 && SetDealerBet > 0)
                {
                    SetDealerBet -= 5;
                    currBet -= 5;
                }
            }
            else if (rdBtn20.Checked)
            {
                if (User.Cash > 0 && SetDealerBet > 0)
                {
                    SetDealerBet -= 20;
                    currBet -= 20;
                }
            }
            if (currBet < 0)
                currBet = 0;
            lblCurrBet.Text = "Current Bet: " + currBet.ToString("C");
        }

        private void btnDealerWinsPlus_Click(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
            {
                if (User.Cash > 0 && User.Cash > currBet)
                {
                    SetDealerBet += 1;
                    currBet += 1;
                }
            }
            else if (rdBtn5.Checked)
            {
                if (User.Cash > 0 && User.Cash > currBet)
                {
                    SetDealerBet += 5;
                    currBet += 5;
                }
            }
            else if (rdBtn20.Checked)
            {
                if (User.Cash > 0 && User.Cash > currBet)
                {
                    SetDealerBet += 20;
                    currBet += 20;
                }
            }
            if (currBet < 0)
                currBet = 0;
            lblCurrBet.Text = "Current Bet: " + currBet.ToString("C");
        }

        private void btnTieGameMinus_Click(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
            {
                if (User.Cash > 0 && SetTieBet > 0)
                {
                    SetTieBet -= 1;
                    currBet -= 1;
                }
            }
            else if (rdBtn5.Checked)
            {
                if (User.Cash > 0 && SetTieBet > 0)
                {
                    SetTieBet -= 5;
                    currBet -= 5;
                }
            }
            else if (rdBtn20.Checked)
            {
                if (User.Cash > 0 && SetTieBet > 0)
                {
                    SetTieBet -= 20;
                    currBet -= 20;
                }
            }
            if (currBet < 0)
                currBet = 0;
            lblCurrBet.Text = "Current Bet: " + currBet.ToString("C");
        }

        private void btnTieGamePlus_Click(object sender, EventArgs e)
        {
            if (rdBtn1.Checked)
            {
                if (User.Cash > 0 && User.Cash > currBet)
                {
                    SetTieBet += 1;
                    currBet += 1;
                }
            }
            else if (rdBtn5.Checked)
            {
                if (User.Cash > 0 && User.Cash > currBet)
                {
                    SetTieBet += 5;
                    currBet += 5;
                }
            }
            else if (rdBtn20.Checked)
            {
                if (User.Cash > 0 && User.Cash > currBet)
                {
                    SetTieBet += 20;
                    currBet += 20;
                }
            }
            if (currBet < 0)
                currBet = 0;
            lblCurrBet.Text = "Current Bet: " + currBet.ToString("C");
        }

        private void btnDealBacarrat_Click(object sender, EventArgs e)
        {
            if (currBet == 0 || currBet > User.Cash)
                return;
            User.BetCash(currBet);
            lblBank.Text = User.Cash.ToString("C");

            if (DeckBac.Cards.Count < MinCardCount)
            {
                DeckBac = new Deck(6);
            }

            DeckBac.DrawCard(player);
            DeckBac.DrawCard(dealer);
            DeckBac.DrawCard(player);
            DeckBac.DrawCard(dealer);

            DetermineWinner();
            Payout(Winner);
            lblBank.Text = User.Cash.ToString("C");

            player.discardHand();
            dealer.discardHand();

            pnlBets.Visible = false;
            btnPlayAgain.Visible = true;
            //lblPayout.Visible = true;
            //lblPayout2.Visible = true;
        }

        private void btnClrBets_Click(object sender, EventArgs e)
        {
            User.Cash += currBet;
            SetPlayerBet = 0;
            SetDealerBet = 0;
            SetTieBet = 0;
            currBet = 0;
            lblCurrBet.Text = "Current Bet: " + currBet.ToString("C");
        }

        public async void GetScore(Hand scoree, int num)
        {
            int score = 0;
            for (int i = 0; i < scoree.Cards.Count; i++)
            {
                if (num == 0)
                {
                    if (i == 0)
                    {
                        pcBx3rdPlayerCard.Visible = false;
                        scoree.Cards[i].LoadImage();
                        pcBx1stPlayerCard.Image = scoree.Cards[i].GetImage;
                    }
                    else if (i == 1)
                    {
                        scoree.Cards[i].LoadImage();
                        pcBx2ndPlayerCard.Image = scoree.Cards[i].GetImage;
                    }
                    else if (i == 2)
                    {
                        scoree.Cards[i].LoadImage();
                        pcBx3rdPlayerCard.Visible = true;
                        pcBx3rdPlayerCard.Image = scoree.Cards[i].GetImage;
                    }
                }
                else if (num == 1)
                {
                    if (i == 0)
                    {
                        pcBx3rdDealerCard.Visible = false;
                        scoree.Cards[i].LoadImage();
                        pcBx1stDealerCard.Image = scoree.Cards[i].GetImage;
                    }
                    else if (i == 1)
                    {
                        scoree.Cards[i].LoadImage();
                        pcBx2ndDealerCard.Image = scoree.Cards[i].GetImage;
                    }
                    else if (i == 2)
                    {
                        scoree.Cards[i].LoadImage();
                        pcBx3rdDealerCard.Visible = true;
                        pcBx3rdDealerCard.Image = scoree.Cards[i].GetImage;
                    }
                }

                if (scoree.Cards[i].CardFace < 9)
                {
                    score += scoree.Cards[i].CardFace + 1;
                }
            }

            score = score % 10;
            if (num == 0)
            {
                playerTotal = score;
                lblPlayerScore.Text = score.ToString();
                lblPlayerScore.Visible = true;
            }
            else if (num == 1)
            {
                dealerTotal = score;
                lblDealerScore.Text = score.ToString();
                lblDealerScore.Visible = true;
            }
        }
        private void DetermineWinner()
        {
            bool tieGame = false;
            bool playerWin = false;
            bool dealerWin = false;
            GetScore(player, 0);
            GetScore(dealer, 1);

            // no more cards drawn if player or dealer have 8 or 9 points
            if (playerTotal == 8 || playerTotal == 9 || dealerTotal == 8 || dealerTotal == 9)
            {
                // tie hand dealt
                if (playerTotal == dealerTotal)
                    tieGame = true;
                // player has 9 and dealer has 8 - player wins
                else if (playerTotal > dealerTotal)
                    playerWin = true;
                // player has 8 and dealer has 9 - dealer wins
                else
                    dealerWin = true;


            }
            // any other outcome than the player/dealer having natural 8 or 9
            else
            {
                // player is dealt a total 0 - 5
                if (playerTotal < 6)
                {
                    DeckBac.DrawCard(player);  // player is dealt a third card
                    int thirdCard = player.Cards[2].CardFace;

                    // dealer is dealt a third card based on the player's third card 
                    //If the banker total is 2 or less, then the banker draws a card, regardless of what the player's third card is
                    if (dealerTotal <= 2)
                    {
                        DeckBac.DrawCard(dealer);
                    }
                    //If the banker total is 3, then the banker draws a third card unless the player's third card was an 8.
                    else if (dealerTotal == 3 && thirdCard != 7)
                    {
                        DeckBac.DrawCard(dealer);
                    }
                    //If the banker total is 4, then the banker draws a third card if the player's third card was 2, 3, 4, 5, 6, 7.
                    else if (dealerTotal == 4 && thirdCard > 0 && thirdCard < 7)
                    {
                        DeckBac.DrawCard(dealer);
                    }
                    //If the banker total is 5, then the banker draws a third card if the player's third card was 4, 5, 6, or 7.
                    else if (dealerTotal == 5 && thirdCard > 2 && thirdCard < 7)
                    {
                        DeckBac.DrawCard(dealer);
                    }
                    //If the banker total is 6, then the banker draws a third card if the player's third card was a 6 or 7.
                    else if (dealerTotal == 6 && (thirdCard == 5 || thirdCard == 6))
                    {
                        DeckBac.DrawCard(dealer);
                    }

                    //If the banker total is 7, then the banker stands
                    //If the banker total is one of the above and the player's third card does not meet the criteria for dealer to draw another card

                    // show new totals
                    GetScore(player, 0);
                    GetScore(dealer, 1);

                    // tie hand dealt
                    if (playerTotal == dealerTotal)
                        tieGame = true;
                    // player has a better hand - player wins
                    else if (playerTotal > dealerTotal)
                        playerWin = true;
                    // dealer has a better hand - dealer wins
                    else
                        dealerWin = true;
                }
                // player is dealt a total of 6 or 7 and dealer has a total of 0-5
                else if (dealerTotal < 6)
                {
                    // dealer gets another card
                    DeckBac.DrawCard(dealer);

                    // show new totals
                    GetScore(player, 0);
                    GetScore(dealer, 1);

                    // tie hand dealt
                    if (playerTotal == dealerTotal)
                        tieGame = true;
                    // player has a better hand - player wins
                    else if (playerTotal > dealerTotal)
                        playerWin = true;
                    // dealer has a better hand - dealer wins
                    else
                        dealerWin = true;
                }
                // dealer and player both have a total of 6 or 7
                else
                {
                    GetScore(player, 0);
                    GetScore(dealer, 1);
                    // tie hand dealt
                    if (playerTotal == dealerTotal)
                        tieGame = true;
                    // player has 7 and dealer has 6 - player wins
                    else if (playerTotal > dealerTotal)
                        playerWin = true;
                    // player has 6 and dealer has 7 - dealer wins
                    else
                        dealerWin = true;
                }
            }
            if (tieGame)
            {
                Winner = 0;
            }
            else if (dealerWin)
            {
                Winner = 1;
            }
            else if (playerWin)
            {
                Winner = 2;
            }
        }

        private void Payout(int w)
        {
            if (w == 0)
            {
                tWins++;
                lblTWinCount.Text = $"{tWins}";
                User.PayoutCash(8 * SetTieBet);
                if (SetTieBet > 0)
                {
                    lblPayout.Visible = true;
                    lblPayout2.Visible = true;
                    winCount++;
                    lblWinCount.Text = $"Wins: {winCount}";
                    totalWinnings += (SetTieBet * 8);
                    lblPayout.Text = (SetTieBet * 8).ToString("C");
                    lblPayout2.Text = (SetTieBet * 8).ToString("C");
                    lblCurrentWin.Text = "Current Winnings: " + (SetTieBet * 8).ToString("C");
                    lblTotalWins.Text = "Total Winnings: " + totalWinnings.ToString("C");
                }
                else
                {
                    lblCurrentWin.Text = "Current Winnings: $0.00";
                    lblTotalWins.Text = "Total Winnings: " + totalWinnings.ToString("C");
                }
            }
            else if (w == 1)
            {
                drWins++;
                lblDrWinCount.Text = $"{drWins}";
                User.PayoutCash(2 * SetDealerBet);
                if (SetDealerBet > 0)
                {
                    lblPayout.Visible = true;
                    lblPayout2.Visible = true;
                    winCount++;
                    lblWinCount.Text = $"Wins: {winCount}";
                    totalWinnings += (SetDealerBet * 2);
                    lblPayout.Text = (SetDealerBet * 2).ToString("C");
                    lblPayout2.Text = (SetDealerBet * 2).ToString("C");
                    lblCurrentWin.Text = "Current Winnings: " + (SetDealerBet * 2).ToString("C");
                    lblTotalWins.Text = "Total Winnings: " + totalWinnings.ToString("C");
                }
                else
                {
                    lblCurrentWin.Text = "Current Winnings: $0.00";
                    lblTotalWins.Text = "Total Winnings: " + totalWinnings.ToString("C");
                }
            }
            else if (w == 2)
            {
                prWins++;
                lblPrWinCount.Text = $"{prWins}";
                User.PayoutCash(2 * SetPlayerBet);
                if (SetPlayerBet > 0)
                {
                    lblPayout.Visible = true;
                    lblPayout2.Visible = true;
                    winCount++;
                    lblWinCount.Text = $"Wins: {winCount}";
                    totalWinnings += (SetPlayerBet * 2);
                    lblPayout.Text = (SetPlayerBet * 2).ToString("C");
                    lblPayout2.Text = (SetPlayerBet * 2).ToString("C");
                    lblCurrentWin.Text = "Current Winnings: " + (SetPlayerBet * 2).ToString("C");
                    lblTotalWins.Text = "Total Winnings: " + totalWinnings.ToString("C");
                }
                else
                {
                    lblCurrentWin.Text = "Current Winnings: $0.00";
                    lblTotalWins.Text = "Total Winnings: " + totalWinnings.ToString("C");
                }
            }
        }

        private void QuitGame()
        {
            this.Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            pnlBets.Visible = true;
            btnPlayAgain.Visible = false;
            lblPayout.Visible = false;
            lblPayout2.Visible = false;
            SetPlayerBet = 0;
            SetDealerBet = 0;
            SetTieBet = 0;
            currBet = 0;
            lblCurrBet.Text = "Current Bet: " + currBet.ToString("C");
            pcBx1stDealerCard.Image = Casino.Properties.Resources.card_back1;
            pcBx1stPlayerCard.Image = Casino.Properties.Resources.card_back1;
            pcBx2ndDealerCard.Image = Casino.Properties.Resources.card_back1;
            pcBx2ndPlayerCard.Image = Casino.Properties.Resources.card_back1;
            pcBx3rdDealerCard.Visible = false;
            pcBx3rdPlayerCard.Visible = false;
        }

        //private void BacarratForm_Load(object sender, EventArgs e)
        //{
        //
        //}
        private async void waitTime(int x)
        {
            await Task.Delay(x);
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
