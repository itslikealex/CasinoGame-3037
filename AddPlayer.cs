using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Casino
{
    public partial class AddPlayerForm : Form
    {
        public int setCash;
        public string setName;
        public AddPlayerForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        private void enterPlayer_Click(object sender, EventArgs e)
        {
            Form1.modifyNew = false;
            if (nameTextBox.Text != "")
            {
                if (int.TryParse(moneyTextBox.Text, out setCash))
                {
                    Form1.setNewCash = setCash;
                    Form1.modifyNew= true;
                    Form1.setNewName = nameTextBox.Text;
                    AddPlayerForm.ActiveForm.Close();
                }
                else
                {
                    errorMessage.Text = "DIGITS ONLY";
                }
            }
            else
            {
                errorMessage.Text = "PLEASE ENTER NAME";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1.modifyNew = false;
            AddPlayerForm.ActiveForm.Close();
        }
    }
}
