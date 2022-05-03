namespace Casino
{
    partial class ChoosePokerMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.single = new System.Windows.Forms.Button();
            this.dealer = new System.Windows.Forms.Button();
            this.btnVideoPoker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // single
            // 
            this.single.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.single.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.single.Location = new System.Drawing.Point(239, 265);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(162, 100);
            this.single.TabIndex = 0;
            this.single.Text = "Single Player";
            this.single.UseVisualStyleBackColor = false;
            this.single.Click += new System.EventHandler(this.single_Click);
            // 
            // dealer
            // 
            this.dealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dealer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dealer.Location = new System.Drawing.Point(451, 265);
            this.dealer.Name = "dealer";
            this.dealer.Size = new System.Drawing.Size(162, 100);
            this.dealer.TabIndex = 1;
            this.dealer.Text = "Play Dealer";
            this.dealer.UseVisualStyleBackColor = false;
            this.dealer.Click += new System.EventHandler(this.dealer_Click);
            // 
            // btnVideoPoker
            // 
            this.btnVideoPoker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoPoker.BackgroundImage = global::Casino.Properties.Resources.videopoker_menu;
            this.btnVideoPoker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVideoPoker.Location = new System.Drawing.Point(129, 49);
            this.btnVideoPoker.Name = "btnVideoPoker";
            this.btnVideoPoker.Size = new System.Drawing.Size(573, 210);
            this.btnVideoPoker.TabIndex = 4;
            this.btnVideoPoker.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(263, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Game Mode";
            // 
            // ChoosePokerMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(911, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVideoPoker);
            this.Controls.Add(this.dealer);
            this.Controls.Add(this.single);
            this.Name = "ChoosePokerMode";
            this.Text = "Poker";
            this.Load += new System.EventHandler(this.ChoosePokerMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button single;
        private System.Windows.Forms.Button dealer;
        private System.Windows.Forms.Button btnVideoPoker;
        private System.Windows.Forms.Label label1;
    }
}