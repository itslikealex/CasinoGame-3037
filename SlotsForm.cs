using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Casino
{
    public partial class SlotsForm : Form
    {
        private Player User;
        private int totalWon = 0;
        private int lastWin = 0;
        private int ReelCount1;
        private int ReelCount2;
        private int ReelCount3;
        private int PlayerBet = 0;
        private int TimeBetween = 5;
        private int MinBet = 1;
        private Reels slotsReels = new Reels(0);
        bool spinning = true;
        public SlotsForm(Player player)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            User = player;
            Random r = new Random();
            ReelCount1 = r.Next(0, 21);
            ReelCount2 = r.Next(0, 21);
            ReelCount3 = r.Next(0, 21);
            //display.Text = "The Game is functional here?";
            pictureBox1_2.Image = slotsReels.Reel1[ReelCount1].DisplayImage();
            pictureBox2_2.Image = slotsReels.Reel2[ReelCount2].DisplayImage();
            pictureBox3_2.Image = slotsReels.Reel3[ReelCount3].DisplayImage();
            winningLabel.Text = $"Games since last win: {lastWin}";
            wonMoney.Text = $"Total Won: {totalWon}";
        }
        private async void StartGame()
        {
            int i = 0;
            display.Text = "Pull the lever to stop the slots";
            while (i<500)
            {
                await Task.Delay(200);
                if (!spinning)
                {
                    break;
                }
                //display.Text = "we are spinning";
                ReelCount1 = ((ReelCount1 + 3) % 22);
                ReelCount2 = ((ReelCount2 + 3) % 22);
                ReelCount3 = ((ReelCount3 + 3) % 22);
                pictureBox1_2.Image = slotsReels.Reel1[ReelCount1].DisplayImage();
                pictureBox2_2.Image = slotsReels.Reel2[ReelCount2].DisplayImage();
                pictureBox3_2.Image = slotsReels.Reel3[ReelCount3].DisplayImage();
                i++;
            }
            if (slotsReels.GetValues(ReelCount1, ReelCount2, ReelCount3))
            {
                int PayOut = slotsReels.PayOut;
                User.PayoutCash(PayOut * PlayerBet);
                totalWon+=(PayOut * PlayerBet);
                display.Text = ($"You Won!! {PayOut * PlayerBet}");
                lastWin = 0;
            }
            else
            {
                lastWin++;
                display.Text = ("You Lost");
            }
            pictureBox1_2.Image = slotsReels.Reel1[ReelCount1].DisplayImage();
            pictureBox2_2.Image = slotsReels.Reel2[ReelCount2].DisplayImage();
            pictureBox3_2.Image = slotsReels.Reel3[ReelCount3].DisplayImage();
            lblBank.Text = User.Cash.ToString("C");
            winningLabel.Text = $"Games since last win: {lastWin}";
            wonMoney.Text = $"Total Won: {totalWon}";

        }
        private bool GetBet()
        {
            if (int.TryParse(BetAmount.Text, out PlayerBet))
            {
                if (PlayerBet < MinBet)
                {
                    display.Text = ("You did not bet the minimum amount. Please rebet.");
                    PlayerBet = 0;
                    return false;
                }
                else if (PlayerBet > User.Cash)
                {
                    //display.Text=("You do not have enough cash");
                    PlayerBet = 0;
                    return false;
                }
                else
                {
                    display.Text = ("Bet Successful");
                    User.BetCash(PlayerBet);
                    return true;
                }
            }
            else
            {
                BetAmount.Text = "DIGITS ONLY";
                return false;
            }            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            spinning = true;
            //button1.Image = Casino.Properties.Resources.handle1;
            //display.Text = "The code works on click";
            if (GetBet())
            {
                display.Text = "Game has Started";
                StartGame();
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            spinning = false;
            for(int i = 0; i < 4; i++)
            {
                await Task.Delay(40);
                changeButtonPic(i);
            }
            await Task.Delay(140);
            button1.Image = Casino.Properties.Resources.handle1;
        }
        private void changeButtonPic(int handleImage)
        {
            switch (handleImage)
            {
                case 0:
                    button1.Image = Casino.Properties.Resources.handle2;
                    break;
                case 1:
                    button1.Image = Casino.Properties.Resources.handle3;
                    break;
                case 2:
                    button1.Image = Casino.Properties.Resources.handle4;
                    break;
                case 3:
                    button1.Image = Casino.Properties.Resources.handle5;
                    break;
            }
        }

        private void display_Click(object sender, EventArgs e)
        {

        }
    }
}