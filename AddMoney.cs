using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Casino
{
    public partial class AddMoneyForm : Form
    {
        Player User;
        public AddMoneyForm(Player player)
        {
            User = player;
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            int addAmountCash;
            if (int.TryParse(AddMoneyBox.Text, out addAmountCash))
            {
                User.PayoutCash(addAmountCash);
                lblBank.Text = User.Cash.ToString("C");
            }
            else
            {
                AddMoneyBox.Text = "Digits Only";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            AddMoneyForm.ActiveForm.Close();
        }
    }
}
