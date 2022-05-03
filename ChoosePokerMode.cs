using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 

namespace Casino
{
    public partial class ChoosePokerMode : Form
    {
        public Player User;
        public ChoosePokerMode(Player player)
        {
            InitializeComponent();
            User = player;
        }
        public ChoosePokerMode()
        {
            InitializeComponent();
        }

        private void ChoosePokerMode_Load(object sender, EventArgs e)
        {

        }

        private void single_Click(object sender, EventArgs e)
        {
            this.Close();
            VideoPokerForm form = new VideoPokerForm(User);
            form.ShowDialog();
        }

        private void dealer_Click(object sender, EventArgs e)
        {
            this.Close();
            vPoker form = new vPoker(User);
            form.ShowDialog();
        }
    }
}
