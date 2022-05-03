using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Casino
{
    public partial class aboutDialog : Form
    {
        public aboutDialog()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void aboutDialog_Load(object sender, EventArgs e)
        {
            aboutText.Text = "By: Alex Bellina, Matt Fadler, Yasaman Nasiri, William Welch, Briice\n\nDr. Rafet-Al Tobasei \\ CSCI-3070\n\nMiddle Tennessee State University - Spring 2022";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
