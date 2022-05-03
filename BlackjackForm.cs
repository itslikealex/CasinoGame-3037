using System.Windows.Forms;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public partial class BlackjackForm : Form
    {
        private Deck DeckBlack = new Deck(6);
        private Hand dealer = new Hand();
        private Hand player = new Hand();
        private int SetPlayerBet = 0;
        private int Winner = 0;
        private const int MinBet = 10;
        private const int MinCardCount = 12;
        private int playerScore = 0;
        private int dealerScore = 0;
        private int DealCount = 2;
        private int DealCountD = 2;
        private int i = 2;
        private int winCount = 0;
        private int totalWinnings = 0;
        public Player User { get; set; }

        public BlackjackForm(Player player)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            User = player;
        }

        private async void btnDeal_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtBxBet.Text, out SetPlayerBet))
            {
                if (SetPlayerBet < MinBet)
                {
                    txtBxBet.Text = "MINIMUM BET $10";
                    txtBxBet.Focus();
                    return;
                }
                else if (User.Cash < SetPlayerBet)
                {
                    txtBxBet.Text = "INSUFFICIENT FUNDS";
                    txtBxBet.Focus();
                    return;
                }
                else
                {
                    tblLytPnlChip.Visible = true;
                    lblChip.Text = SetPlayerBet.ToString();
                    User.BetCash(SetPlayerBet);
                    txtBxBet.Enabled = false;
                }
            }
            else
            {
                txtBxBet.Text = "DIGITS ONLY";
                txtBxBet.Focus();
                return;
            }

            if (DeckBlack.Cards.Count < MinCardCount)
            {
                DeckBlack = new Deck(6);
                await Task.Delay(1000);
                lblWinBanner.Text = "NEW DECK SHUFFLED";
                tblLytPnlWinBanner.Visible = true;
                await Task.Delay(3000);
                tblLytPnlWinBanner.Visible = false;
            }

            lblBank.Text = User.Cash.ToString("C");
            StartGame();
        }

        private async void StartGame()
        {
            DeckBlack.DrawCard(player);
            DeckBlack.DrawCard(dealer);
            DeckBlack.DrawCard(player);
            DeckBlack.DrawCard(dealer);

            lblCurrBet.Visible = false;
            txtBxBet.Visible = false;
            btnDeal.Visible = false;
            btnClrBet.Visible = false;

            await Task.Delay(800);
            player.Cards[0].LoadImage();
            pcBxPlayerCard1.Image = player.Cards[0].GetImage;
            pcBxPlayerCard1.Visible = true;

            await Task.Delay(800);
            dealer.Cards[0].LoadImage();
            pcBxDealerCard1.Image = dealer.Cards[0].GetImage;
            pcBxDealerCard1.Visible = true;

            await Task.Delay(800);
            player.Cards[1].LoadImage();
            pcBxPlayerCard2.Image = player.Cards[1].GetImage;
            pcBxPlayerCard2.BringToFront();
            pcBxPlayerCard2.Visible = true;

            await Task.Delay(800);
            pcBxDealerCard2.Image = Casino.Properties.Resources.card_back1;
            pcBxDealerCard2.BringToFront();
            pcBxDealerCard2.Visible = true;

            DetermineWinner();
        }

        private void btnClrBet_Click(object sender, System.EventArgs e)
        {
            SetPlayerBet = 0;
            txtBxBet.Text = "0";
            txtBxBet.Focus();
            lblChip.Text = " ";
        }

        public async void DetermineWinner()
        {
            playerScore = GetScore(player);
            lblPlayerScore.Visible = true;
            lblPlayerScore.Text = playerScore.ToString();
            dealerScore = GetScore(dealer);

            if (playerScore == 21)
            {
                if (dealerScore == 21)
                {
                    await Task.Delay(1500);
                    tblLytPnlWinBanner.Visible = true;
                    lblWinBanner.Text = "BLACKJACK!";
                    Winner = 0;
                    determinePayout();
                }
                else
                {
                    Winner = 3;
                    determinePayout();
                }
            }
            else
            {
                await Task.Delay(1500);
                btnHit.Visible = true;
                btnStand.Visible = true;
            }
        }

        public int GetScore(Hand scoree)
        {
            int score = 0;
            int aceCount = 0;
            for (int i = 0; i < scoree.Cards.Count; i++)
            {
                if (scoree.Cards[i].CardFace == 0)
                {
                    aceCount++;
                }
                else if (scoree.Cards[i].CardFace < 10)
                {
                    score += scoree.Cards[i].CardFace + 1;
                }
                else
                {
                    score += 10;
                }

            }
            for (int i = 0; i < aceCount; i++)
            {
                if (22 > (score + 11 + (aceCount - 1)))
                {
                    score += 11;
                }
                else
                {
                    score++;
                }
            }
            return score;
        }

        private async void btnHit_Click(object sender, EventArgs e)
        {

            DeckBlack.DrawCard(player);
            switch (i)
            {
                case (2):
                    player.Cards[i].LoadImage();
                    pcBxPlayerCard3.Image = player.Cards[i].GetImage;
                    pcBxPlayerCard3.Visible = true;
                    pcBxPlayerCard3.BringToFront();
                    break;
                case (3):
                    player.Cards[i].LoadImage();
                    pcBxPlayerCard4.Image = player.Cards[i].GetImage;
                    pcBxPlayerCard4.Visible = true;
                    pcBxPlayerCard4.BringToFront();
                    break;
                case (4):
                    player.Cards[i].LoadImage();
                    pcBxPlayerCard5.Image = player.Cards[i].GetImage;
                    pcBxPlayerCard5.Visible = true;
                    pcBxPlayerCard5.BringToFront();
                    break;
                case (5):
                    player.Cards[i].LoadImage();
                    pcBxPlayerCard6.Image = player.Cards[i].GetImage;
                    pcBxPlayerCard6.Visible = true;
                    pcBxPlayerCard6.BringToFront();
                    break;
                case (6):
                    player.Cards[i].LoadImage();
                    pcBxPlayerCard7.Image = player.Cards[i].GetImage;
                    pcBxPlayerCard7.Visible = true;
                    pcBxPlayerCard7.BringToFront();
                    break;
            }
            i++;
            DealCount++;
            playerScore = GetScore(player);

            if (playerScore == 21)
            {
                lblPlayerScore.Text = $"{playerScore}!";
                Winner = 2;
            }
            else if (playerScore > 21)
            {
                lblPlayerScore.Text = $"{playerScore}";
                btnHit.Visible = false;
                btnStand.Visible = false;
                lblWinBanner.Text = "BUST!";
                tblLytPnlWinBanner.Visible = true;
                await Task.Delay(1500);
                dealer.Cards[1].LoadImage();
                pcBxDealerCard2.Image = dealer.Cards[1].GetImage;
                pcBxDealerCard2.Visible = true;
                lblDealerScore.Text = dealerScore.ToString();
                lblDealerScore.Visible = true;
                Winner = 1;
                determinePayout();
            }
            else
            {
                lblPlayerScore.Text = $"{playerScore}";
            }
        }

        private async void btnStand_Click(object sender, EventArgs e)
        {
            btnStand.Visible = false;
            btnHit.Visible = false;
            await Task.Delay(800);
            dealer.Cards[1].LoadImage();
            pcBxDealerCard2.Image = dealer.Cards[1].GetImage;
            lblDealerScore.Text = dealerScore.ToString();
            lblDealerScore.Visible = true;

            if (dealerScore > 16 && playerScore < 22)
            {
                await Task.Delay(800);
                lblWinBanner.Text = "DEALER STANDS";
                tblLytPnlWinBanner.Visible = true;
                //determinePayout();
            }
            else
            {
                i = 2;

                while (dealerScore < 22)
                {
                    DeckBlack.DrawCard(dealer);
                    await Task.Delay(800);
                    dealer.Cards[i].LoadImage();

                    switch (i)
                    {
                        case (2):
                            pcBxDealerCard3.Image = dealer.Cards[i].GetImage;
                            pcBxDealerCard3.Visible = true;
                            pcBxDealerCard3.BringToFront();
                            break;
                        case (3):
                            pcBxDealerCard4.Image = dealer.Cards[i].GetImage;
                            pcBxDealerCard4.Visible = true;
                            pcBxDealerCard4.BringToFront();
                            break;
                        case (4):
                            pcBxDealerCard5.Image = dealer.Cards[i].GetImage;
                            pcBxDealerCard5.Visible = true;
                            pcBxDealerCard5.BringToFront();
                            break;
                        case (5):
                            pcBxDealerCard6.Image = dealer.Cards[i].GetImage;
                            pcBxDealerCard6.Visible = true;
                            pcBxDealerCard6.BringToFront();
                            break;
                        case (6):
                            pcBxDealerCard7.Image = dealer.Cards[i].GetImage;
                            pcBxDealerCard7.Visible = true;
                            pcBxDealerCard7.BringToFront();
                            break;
                    }
                    i++;
                    DealCountD++;
                    dealerScore = GetScore(dealer);
                    lblDealerScore.Visible = true;
                    lblDealerScore.Text = $"{dealerScore}";
                    if (dealerScore > 15)
                    {
                        break;
                    }
                }
            }

            if (dealerScore > 21)
            {
                lblWinBanner.Text = "DEALER BUSTS!";
                tblLytPnlWinBanner.Visible = true;
                Winner = 2;
                determinePayout();
            }
            else if (dealerScore < 22 && playerScore < 22)
            {
                if (dealerScore == playerScore)
                {

                    Winner = 0;
                    determinePayout();
                }
                else if (dealerScore > playerScore)
                {
                    Winner = 1;
                    determinePayout();
                }
                else
                {
                    Winner = 2;
                    determinePayout();
                }
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            i = 2;
            SetPlayerBet = 0;
            dealerScore = 0;
            lblDealerScore.Visible = false;
            playerScore = 0;
            lblPlayerScore.Visible = false;
            player.discardHand();
            dealer.discardHand();
            tblLytPnlChip.Visible = false;
            tblLytPnlChip2.Visible = false;
            btnPlayAgain.Visible = false;
            btnHit.Visible = false;
            btnStand.Visible = false;
            tblLytPnlWinBanner.Visible = false;
            lblCurrBet.Visible = true;
            txtBxBet.Visible = true;
            txtBxBet.Enabled = true;
            btnDeal.Visible = true;
            btnClrBet.Visible = true;
            lblCurrentWin.Text = "Current Winnings: $0.00";
            pcBxDealerCard1.Visible = false;
            pcBxDealerCard2.Visible = false;
            pcBxDealerCard3.Visible = false;
            pcBxDealerCard4.Visible = false;
            pcBxDealerCard5.Visible = false;
            pcBxDealerCard6.Visible = false;
            pcBxDealerCard7.Visible = false;
            pcBxPlayerCard1.Visible = false;
            pcBxPlayerCard2.Visible = false;
            pcBxPlayerCard3.Visible = false;
            pcBxPlayerCard4.Visible = false;
            pcBxPlayerCard5.Visible = false;
            pcBxPlayerCard6.Visible = false;
            pcBxPlayerCard7.Visible = false;
            pcBxDealerCard1.Image.Dispose();
            pcBxDealerCard2.Image.Dispose();
            pcBxPlayerCard1.Image.Dispose();
            pcBxPlayerCard2.Image.Dispose();
            if (pcBxDealerCard3.Image != null)
                pcBxDealerCard3.Image.Dispose();
            if (pcBxDealerCard4.Image != null)
                pcBxDealerCard4.Image.Dispose();
            if (pcBxDealerCard5.Image != null)
                pcBxDealerCard5.Image.Dispose();
            if (pcBxDealerCard6.Image != null)
                pcBxDealerCard6.Image.Dispose();
            if (pcBxDealerCard7.Image != null)
                pcBxDealerCard7.Image.Dispose();
            if (pcBxPlayerCard3.Image != null)
                pcBxPlayerCard3.Image.Dispose();
            if (pcBxPlayerCard4.Image != null)
                pcBxPlayerCard4.Image.Dispose();
            if (pcBxPlayerCard5.Image != null)
                pcBxPlayerCard5.Image.Dispose();
            if (pcBxPlayerCard6.Image != null)
                pcBxPlayerCard6.Image.Dispose();
            if (pcBxPlayerCard7.Image != null)
                pcBxPlayerCard7.Image.Dispose();
        }

        private async void determinePayout()
        {
            if (Winner == 0)
            {
                //Console.WriteLine($"Tie! You won {SetPlayerBet}");
                await Task.Delay(1500);
                lblWinBanner.Text = "TIE GAME!";
                tblLytPnlWinBanner.Visible = true;
                totalWinnings += SetPlayerBet;
                lblTotalWins.Text = $"Total Winnings: ${totalWinnings}.00";
                await Task.Delay(1500);
                lblWinBanner.Text = "PUSH!";
                User.PayoutCash(SetPlayerBet);
                lblCurrentWin.Text = "PUSH";
            }
            else if (Winner == 1)
            {
                tblLytPnlChip.Visible = false;
                //Console.WriteLine($"Dealer won! You lost.");
                await Task.Delay(1500);
                lblWinBanner.Text = "DEALER WINS!";
                tblLytPnlWinBanner.Visible = true;
                await Task.Delay(1500);
                lblWinBanner.Text = "LOSER!";
            }
            else if (Winner == 2)
            {
                //Console.WriteLine($"Player won! You won {SetPlayerBet * 2}");
                await Task.Delay(1500);
                lblWinBanner.Text = "WINNER WINNER!";
                tblLytPnlWinBanner.Visible = true;
                lblCurrentWin.Text = "Current Winnings: " + (SetPlayerBet * 2).ToString("C");
                totalWinnings += SetPlayerBet * 2;
                lblTotalWins.Text = $"Total Winnings: ${totalWinnings}.00";
                winCount++;
                lblWinCount.Text = $"Total Wins: {winCount}";
                await Task.Delay(1500);
                tblLytPnlChip2.Visible = true;
                lblChip2.Text = (SetPlayerBet).ToString();
                lblWinBanner.Text = $"YOU WIN ${SetPlayerBet * 2}!";
                User.PayoutCash(SetPlayerBet * 2);
            }
            else
            {
                await Task.Delay(1500);
                lblWinBanner.Text = "BLACKJACK!";
                tblLytPnlWinBanner.Visible = true;
                lblCurrentWin.Text = "Current Winnings: " + (SetPlayerBet * 3 / 2).ToString("C");
                totalWinnings += SetPlayerBet * 3 / 2;
                lblTotalWins.Text = $"Total Winnings: ${totalWinnings}.00";
                winCount++;
                lblWinCount.Text = $"Total Wins: {winCount}";
                await Task.Delay(1500);
                tblLytPnlChip2.Visible = true;
                lblChip2.Text = (SetPlayerBet / 2).ToString();
                lblWinBanner.Text = $"YOU WIN ${SetPlayerBet * 3 / 2}!";
                User.PayoutCash(SetPlayerBet * 3 / 2);
            }

            btnPlayAgain.Visible = true;
            lblBank.Text = User.Cash.ToString("C");
        }
    }
}
