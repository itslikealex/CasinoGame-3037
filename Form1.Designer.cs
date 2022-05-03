
namespace Casino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.tblLytPnlHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblCasino = new System.Windows.Forms.Label();
            this.tblLytPnlInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addMoney = new System.Windows.Forms.Button();
            this.addPlayer = new System.Windows.Forms.Button();
            this.playerSelect = new System.Windows.Forms.ComboBox();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.pnlEnterInfo = new System.Windows.Forms.Panel();
            this.btnLetsPlay = new System.Windows.Forms.Button();
            this.lblDepositError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.tblLytPnlDeposit = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtBxDeposit = new System.Windows.Forms.TextBox();
            this.tblLytPnlEnterName = new System.Windows.Forms.TableLayoutPanel();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.tblLytPnlSelectGame = new System.Windows.Forms.TableLayoutPanel();
            this.btnVideoPoker = new System.Windows.Forms.Button();
            this.btnBacarrat = new System.Windows.Forms.Button();
            this.btnBlackjack = new System.Windows.Forms.Button();
            this.btnSlots = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainMenu.SuspendLayout();
            this.tblLytPnlHeader.SuspendLayout();
            this.tblLytPnlInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlStart.SuspendLayout();
            this.pnlEnterInfo.SuspendLayout();
            this.tblLytPnlDeposit.SuspendLayout();
            this.tblLytPnlEnterName.SuspendLayout();
            this.tblLytPnlSelectGame.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainMenu.Controls.Add(this.tblLytPnlHeader);
            this.pnlMainMenu.Controls.Add(this.pnlStart);
            this.pnlMainMenu.Location = new System.Drawing.Point(12, 31);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(884, 558);
            this.pnlMainMenu.TabIndex = 1;
            // 
            // tblLytPnlHeader
            // 
            this.tblLytPnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLytPnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLytPnlHeader.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLytPnlHeader.ColumnCount = 3;
            this.tblLytPnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytPnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLytPnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytPnlHeader.Controls.Add(this.lblCasino, 1, 0);
            this.tblLytPnlHeader.Controls.Add(this.tblLytPnlInfo, 0, 0);
            this.tblLytPnlHeader.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tblLytPnlHeader.Location = new System.Drawing.Point(0, 0);
            this.tblLytPnlHeader.Name = "tblLytPnlHeader";
            this.tblLytPnlHeader.RowCount = 1;
            this.tblLytPnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tblLytPnlHeader.Size = new System.Drawing.Size(883, 134);
            this.tblLytPnlHeader.TabIndex = 1;
            // 
            // lblCasino
            // 
            this.lblCasino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCasino.AutoSize = true;
            this.lblCasino.Font = new System.Drawing.Font("Segoe UI", 68.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCasino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCasino.Location = new System.Drawing.Point(180, 1);
            this.lblCasino.Name = "lblCasino";
            this.lblCasino.Size = new System.Drawing.Size(521, 132);
            this.lblCasino.TabIndex = 0;
            this.lblCasino.Text = "CASINO";
            this.lblCasino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblLytPnlInfo
            // 
            this.tblLytPnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLytPnlInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblLytPnlInfo.ColumnCount = 1;
            this.tblLytPnlInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPnlInfo.Controls.Add(this.lblBank, 0, 1);
            this.tblLytPnlInfo.Controls.Add(this.lblName, 0, 0);
            this.tblLytPnlInfo.Location = new System.Drawing.Point(4, 4);
            this.tblLytPnlInfo.Name = "tblLytPnlInfo";
            this.tblLytPnlInfo.RowCount = 2;
            this.tblLytPnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnlInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnlInfo.Size = new System.Drawing.Size(169, 126);
            this.tblLytPnlInfo.TabIndex = 1;
            // 
            // lblBank
            // 
            this.lblBank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBank.Location = new System.Drawing.Point(5, 64);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(159, 60);
            this.lblBank.TabIndex = 1;
            this.lblBank.Text = "Bank";
            this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBank.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(5, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(159, 60);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.addMoney, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addPlayer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerSelect, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(708, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(171, 126);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // addMoney
            // 
            this.addMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMoney.Location = new System.Drawing.Point(3, 3);
            this.addMoney.Name = "addMoney";
            this.addMoney.Size = new System.Drawing.Size(165, 36);
            this.addMoney.TabIndex = 0;
            this.addMoney.Text = "Add Funds";
            this.addMoney.UseVisualStyleBackColor = true;
            this.addMoney.Click += new System.EventHandler(this.addMoney_Click);
            // 
            // addPlayer
            // 
            this.addPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayer.Location = new System.Drawing.Point(3, 45);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(165, 36);
            this.addPlayer.TabIndex = 1;
            this.addPlayer.Text = "Add Player";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // playerSelect
            // 
            this.playerSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerSelect.FormattingEnabled = true;
            this.playerSelect.Location = new System.Drawing.Point(3, 87);
            this.playerSelect.Name = "playerSelect";
            this.playerSelect.Size = new System.Drawing.Size(165, 23);
            this.playerSelect.TabIndex = 2;
            this.playerSelect.SelectedIndexChanged += new System.EventHandler(this.playerSelect_SelectedIndexChanged);
            // 
            // pnlStart
            // 
            this.pnlStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStart.Controls.Add(this.pnlEnterInfo);
            this.pnlStart.Controls.Add(this.btnStartGame);
            this.pnlStart.Controls.Add(this.tblLytPnlSelectGame);
            this.pnlStart.Location = new System.Drawing.Point(9, 140);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(870, 420);
            this.pnlStart.TabIndex = 3;
            // 
            // pnlEnterInfo
            // 
            this.pnlEnterInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEnterInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlEnterInfo.Controls.Add(this.btnLetsPlay);
            this.pnlEnterInfo.Controls.Add(this.lblDepositError);
            this.pnlEnterInfo.Controls.Add(this.lblNameError);
            this.pnlEnterInfo.Controls.Add(this.tblLytPnlDeposit);
            this.pnlEnterInfo.Controls.Add(this.tblLytPnlEnterName);
            this.pnlEnterInfo.Location = new System.Drawing.Point(277, 86);
            this.pnlEnterInfo.Name = "pnlEnterInfo";
            this.pnlEnterInfo.Size = new System.Drawing.Size(317, 207);
            this.pnlEnterInfo.TabIndex = 2;
            this.pnlEnterInfo.Visible = false;
            // 
            // btnLetsPlay
            // 
            this.btnLetsPlay.Location = new System.Drawing.Point(5, 162);
            this.btnLetsPlay.Name = "btnLetsPlay";
            this.btnLetsPlay.Size = new System.Drawing.Size(310, 42);
            this.btnLetsPlay.TabIndex = 4;
            this.btnLetsPlay.Text = "LET\'S PLAY!";
            this.btnLetsPlay.UseVisualStyleBackColor = true;
            this.btnLetsPlay.Visible = false;
            this.btnLetsPlay.Click += new System.EventHandler(this.btnLetsPlay_Click);
            // 
            // lblDepositError
            // 
            this.lblDepositError.AutoSize = true;
            this.lblDepositError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDepositError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepositError.Location = new System.Drawing.Point(86, 137);
            this.lblDepositError.Name = "lblDepositError";
            this.lblDepositError.Size = new System.Drawing.Size(184, 15);
            this.lblDepositError.TabIndex = 3;
            this.lblDepositError.Text = "DEPOSIT BETWEEN 5 AND 10000";
            this.lblDepositError.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNameError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameError.Location = new System.Drawing.Point(86, 61);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(158, 15);
            this.lblNameError.TabIndex = 2;
            this.lblNameError.Text = "INPUT NAME TO CONTINUE";
            this.lblNameError.Visible = false;
            // 
            // tblLytPnlDeposit
            // 
            this.tblLytPnlDeposit.ColumnCount = 2;
            this.tblLytPnlDeposit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytPnlDeposit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblLytPnlDeposit.Controls.Add(this.lblDeposit, 0, 0);
            this.tblLytPnlDeposit.Controls.Add(this.txtBxDeposit, 1, 0);
            this.tblLytPnlDeposit.Location = new System.Drawing.Point(3, 87);
            this.tblLytPnlDeposit.Name = "tblLytPnlDeposit";
            this.tblLytPnlDeposit.RowCount = 1;
            this.tblLytPnlDeposit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPnlDeposit.Size = new System.Drawing.Size(313, 39);
            this.tblLytPnlDeposit.TabIndex = 1;
            // 
            // lblDeposit
            // 
            this.lblDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeposit.Location = new System.Drawing.Point(3, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(72, 39);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Deposit:";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBxDeposit
            // 
            this.txtBxDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxDeposit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxDeposit.Location = new System.Drawing.Point(81, 3);
            this.txtBxDeposit.Name = "txtBxDeposit";
            this.txtBxDeposit.Size = new System.Drawing.Size(229, 33);
            this.txtBxDeposit.TabIndex = 1;
            // 
            // tblLytPnlEnterName
            // 
            this.tblLytPnlEnterName.ColumnCount = 2;
            this.tblLytPnlEnterName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytPnlEnterName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblLytPnlEnterName.Controls.Add(this.lblEnterName, 0, 0);
            this.tblLytPnlEnterName.Controls.Add(this.txtBxName, 1, 0);
            this.tblLytPnlEnterName.Location = new System.Drawing.Point(3, 12);
            this.tblLytPnlEnterName.Name = "tblLytPnlEnterName";
            this.tblLytPnlEnterName.RowCount = 1;
            this.tblLytPnlEnterName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPnlEnterName.Size = new System.Drawing.Size(313, 39);
            this.tblLytPnlEnterName.TabIndex = 0;
            // 
            // lblEnterName
            // 
            this.lblEnterName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnterName.Location = new System.Drawing.Point(3, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(72, 39);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Enter Name:";
            this.lblEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBxName
            // 
            this.txtBxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxName.Location = new System.Drawing.Point(81, 3);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(229, 33);
            this.txtBxName.TabIndex = 1;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartGame.Location = new System.Drawing.Point(189, 3);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(491, 66);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // tblLytPnlSelectGame
            // 
            this.tblLytPnlSelectGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLytPnlSelectGame.ColumnCount = 2;
            this.tblLytPnlSelectGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnlSelectGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnlSelectGame.Controls.Add(this.btnVideoPoker, 1, 1);
            this.tblLytPnlSelectGame.Controls.Add(this.btnBacarrat, 0, 1);
            this.tblLytPnlSelectGame.Controls.Add(this.btnBlackjack, 1, 0);
            this.tblLytPnlSelectGame.Controls.Add(this.btnSlots, 0, 0);
            this.tblLytPnlSelectGame.Location = new System.Drawing.Point(0, 69);
            this.tblLytPnlSelectGame.Name = "tblLytPnlSelectGame";
            this.tblLytPnlSelectGame.RowCount = 2;
            this.tblLytPnlSelectGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnlSelectGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnlSelectGame.Size = new System.Drawing.Size(870, 301);
            this.tblLytPnlSelectGame.TabIndex = 3;
            this.tblLytPnlSelectGame.Visible = false;
            // 
            // btnVideoPoker
            // 
            this.btnVideoPoker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoPoker.BackgroundImage = global::Casino.Properties.Resources.videopoker_menu;
            this.btnVideoPoker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVideoPoker.Location = new System.Drawing.Point(438, 153);
            this.btnVideoPoker.Name = "btnVideoPoker";
            this.btnVideoPoker.Size = new System.Drawing.Size(429, 145);
            this.btnVideoPoker.TabIndex = 3;
            this.btnVideoPoker.UseVisualStyleBackColor = true;
            this.btnVideoPoker.Click += new System.EventHandler(this.btnVideoPoker_Click);
            // 
            // btnBacarrat
            // 
            this.btnBacarrat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBacarrat.BackgroundImage = global::Casino.Properties.Resources.bacarrat_menu;
            this.btnBacarrat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBacarrat.Location = new System.Drawing.Point(3, 153);
            this.btnBacarrat.Name = "btnBacarrat";
            this.btnBacarrat.Size = new System.Drawing.Size(429, 145);
            this.btnBacarrat.TabIndex = 2;
            this.btnBacarrat.UseVisualStyleBackColor = true;
            this.btnBacarrat.Click += new System.EventHandler(this.btnBacarrat_Click);
            // 
            // btnBlackjack
            // 
            this.btnBlackjack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlackjack.BackgroundImage = global::Casino.Properties.Resources.blackjack_menu;
            this.btnBlackjack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlackjack.Location = new System.Drawing.Point(438, 3);
            this.btnBlackjack.Name = "btnBlackjack";
            this.btnBlackjack.Size = new System.Drawing.Size(429, 144);
            this.btnBlackjack.TabIndex = 1;
            this.btnBlackjack.UseVisualStyleBackColor = true;
            this.btnBlackjack.Click += new System.EventHandler(this.btnBlackjack_Click);
            // 
            // btnSlots
            // 
            this.btnSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlots.BackgroundImage = global::Casino.Properties.Resources.slot_menu;
            this.btnSlots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlots.Location = new System.Drawing.Point(3, 3);
            this.btnSlots.Name = "btnSlots";
            this.btnSlots.Size = new System.Drawing.Size(429, 144);
            this.btnSlots.TabIndex = 0;
            this.btnSlots.UseVisualStyleBackColor = true;
            this.btnSlots.Click += new System.EventHandler(this.btnSlots_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(909, 591);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Casino";
            this.pnlMainMenu.ResumeLayout(false);
            this.tblLytPnlHeader.ResumeLayout(false);
            this.tblLytPnlHeader.PerformLayout();
            this.tblLytPnlInfo.ResumeLayout(false);
            this.tblLytPnlInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlStart.ResumeLayout(false);
            this.pnlEnterInfo.ResumeLayout(false);
            this.pnlEnterInfo.PerformLayout();
            this.tblLytPnlDeposit.ResumeLayout(false);
            this.tblLytPnlDeposit.PerformLayout();
            this.tblLytPnlEnterName.ResumeLayout(false);
            this.tblLytPnlEnterName.PerformLayout();
            this.tblLytPnlSelectGame.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TableLayoutPanel tblLytPnlSelectGame;
        private System.Windows.Forms.Button btnVideoPoker;
        private System.Windows.Forms.Button btnBacarrat;
        private System.Windows.Forms.Button btnBlackjack;
        private System.Windows.Forms.Button btnSlots;
        private System.Windows.Forms.Panel pnlEnterInfo;
        private System.Windows.Forms.TableLayoutPanel tblLytPnlDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtBxDeposit;
        private System.Windows.Forms.TableLayoutPanel tblLytPnlEnterName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Button btnLetsPlay;
        private System.Windows.Forms.Label lblDepositError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.TableLayoutPanel tblLytPnlHeader;
        private System.Windows.Forms.Label lblCasino;
        private System.Windows.Forms.TableLayoutPanel tblLytPnlInfo;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addMoney;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.ComboBox playerSelect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

