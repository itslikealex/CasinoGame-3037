using System;
using System.Windows.Forms;

namespace Casino
{
    public partial class Form1 : Form
    {
        
        public int BankDeposit;
        Player playerUno;
        Player playerOne;
        Player playerTwo;
        Player playerThree;
        Player playerFour;
        Player playerFive;
        Player playerSix;
        Player playerSeven;
        Player playerEight;
        Player playerNine;
        public static bool modifyNew = false;
        public static int setNewCash;
        public static string setNewName;
        private int playerCount=0;

        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            addMoney.Visible = false;
            addPlayer.Visible = false;
            playerSelect.Visible = false;

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            pnlEnterInfo.Visible = true;
            btnStartGame.Visible = false;
            btnLetsPlay.Visible = true;

        }

        private void btnLetsPlay_Click(object sender, EventArgs e)
        {

            // Validate that a name is inputted
            if (String.IsNullOrWhiteSpace(txtBxName.Text))
            {
                lblNameError.Visible = true;
                return;
            }
            else
            {
                lblNameError.Visible = false;
            }

            if (String.IsNullOrWhiteSpace(txtBxDeposit.Text))
            {
                lblDepositError.Visible = true;
                return;
            }
            else
            {
                lblDepositError.Visible = false;
            }

            // Validate only numbers are inputted by user and parse number
            if (!int.TryParse(txtBxDeposit.Text, out BankDeposit))
            {
                lblDepositError.Visible = true;
                return;
            }
            //BankDeposit = Math.Round(BankDeposit, 2);

            if (BankDeposit < 5 || BankDeposit > 10000)
            {
                lblDepositError.Visible = true;
                return;
            }
            playerOne = new Player(txtBxName.Text.Trim(), BankDeposit);
            playerUno = playerOne;
            playerSelect.Text = playerOne.PlayerName;
            playerSelect.Items.Insert(0, playerOne.PlayerName);
            // set lblName text to inputted name
            lblName.Text = playerUno.PlayerName;
            lblName.Visible = true;
            // set deposit amount in lblBank and format to currency
            lblBank.Text = playerUno.Cash.ToString("C");
            lblBank.Visible = true;
            addMoney.Visible = true;
            addPlayer.Visible = true;
            playerSelect.Visible = true;
            // set pnlEnterInfo to not visible
            pnlEnterInfo.Visible = false;
            // set pnlSelectGame to visible
            tblLytPnlSelectGame.Visible = true;
        }

        private void btnSlots_Click(object sender, EventArgs e)
        {
            SlotsForm slotsForm = new SlotsForm(playerUno);
            slotsForm.lblName.Text = playerUno.PlayerName;
            slotsForm.lblBank.Text = playerUno.Cash.ToString("C");
            slotsForm.ShowDialog();
            lblBank.Text = playerUno.Cash.ToString("C");

        }

        private void btnBlackjack_Click(object sender, EventArgs e)
        {
            BlackjackForm blackjackForm = new BlackjackForm(playerUno);
            blackjackForm.lblName.Text = playerUno.PlayerName;
            blackjackForm.lblBank.Text = playerUno.Cash.ToString("C");
            blackjackForm.ShowDialog();
            lblBank.Text = playerUno.Cash.ToString("C");

        }

        private void btnBacarrat_Click(object sender, EventArgs e)
        {
            BacarratForm bacarratForm = new BacarratForm(playerUno);
            bacarratForm.lblName.Text = playerUno.PlayerName;
            bacarratForm.lblBank.Text = playerUno.Cash.ToString("C");
            bacarratForm.ShowDialog();
            lblBank.Text = playerUno.Cash.ToString("C");

        }

        private void btnVideoPoker_Click(object sender, EventArgs e)
        {
           ChoosePokerMode choice = new ChoosePokerMode(playerUno);
           choice.Show();

        }

        private void addMoney_Click(object sender, EventArgs e)
        {
            AddMoneyForm addMoneyForm = new AddMoneyForm(playerUno);
            addMoneyForm.lblName.Text = playerUno.PlayerName;
            addMoneyForm.ShowDialog();
            lblBank.Text =playerUno.Cash.ToString("C");

        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.ShowDialog();
            if (modifyNew) {
                playerCount++;
                switch (playerCount)
                {
                    case 1:
                        playerTwo = new Player(setNewName, setNewCash);
                        playerSelect.Items.Insert(1, playerTwo.PlayerName);
                        break;
                    case 2:
                        playerThree = new Player(setNewName, setNewCash);
                        playerSelect.Items.Insert(2, playerThree.PlayerName);
                        break;
                    case 3:
                        playerFour = new Player(setNewName, setNewCash);
                        playerSelect.Items.Insert(3, playerFour.PlayerName);
                        break;
                    case 4:
                        playerFive = new Player(setNewName, setNewCash);
                        playerSelect.Items.Insert(4, playerFive.PlayerName);
                        break;
                    case 5:
                        playerSix = new Player(setNewName, setNewCash);
                        playerSelect.Items.Insert(5, playerSix.PlayerName);
                        break;
                    case 6:
                        playerSeven = new Player(setNewName, setNewCash);
                        playerSelect.Items.Insert(6, playerSeven.PlayerName);
                        break;
                    case 7:
                        playerEight = new Player(setNewName, setNewCash);
                        playerSelect.Items.Insert(7, playerEight.PlayerName);
                        break;
                    case 8:
                        playerNine = new Player(setNewName, setNewCash);
                        playerSelect.Items.Insert(8, playerNine.PlayerName);
                        break;
                    default:
                        addPlayer.Visible=false;
                        break;
                }
            }
        }

        private void playerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int playerSelectNumber = playerSelect.SelectedIndex;
            switch (playerSelectNumber){
                case 0:
                    playerUno = playerOne;
                    lblBank.Text = playerUno.Cash.ToString("C");
                    lblName.Text = playerUno.PlayerName;
                    break;
                case 1:
                    playerUno = playerTwo;
                    lblBank.Text = playerUno.Cash.ToString("C");
                    lblName.Text = playerUno.PlayerName;
                    break;
                case 2:
                    playerUno = playerThree;
                    lblBank.Text = playerUno.Cash.ToString("C");
                    lblName.Text = playerUno.PlayerName;
                    break;
                case 3:
                    playerUno = playerFour;
                    lblBank.Text = playerUno.Cash.ToString("C");
                    lblName.Text = playerUno.PlayerName;
                    break;
                case 4:
                    playerUno = playerFive;
                    lblBank.Text = playerUno.Cash.ToString("C");
                    lblName.Text = playerUno.PlayerName;
                    break;
                case 5:
                    playerUno = playerSix;
                    lblBank.Text = playerUno.Cash.ToString("C");
                    lblName.Text = playerUno.PlayerName;
                    break;
                case 6:
                    playerUno = playerSeven;
                    lblBank.Text = playerUno.Cash.ToString("C");
                    lblName.Text = playerUno.PlayerName;
                    break;
                case 7:
                    playerUno = playerEight;
                    lblBank.Text = playerUno.Cash.ToString("C");
                    lblName.Text = playerUno.PlayerName;
                    break;
                case 8:
                    playerUno = playerNine;
                    lblBank.Text = playerUno.Cash.ToString("C");
                    lblName.Text = playerUno.PlayerName;
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (aboutDialog dialog = new aboutDialog())
            { dialog.ShowDialog(); }
        }

        

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
