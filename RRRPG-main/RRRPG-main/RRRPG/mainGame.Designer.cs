namespace RRRPG
{
    partial class mainGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            picOpponent = new PictureBox();
            picPlayer = new PictureBox();
            btnDoIt = new Button();
            lblPlayer = new Label();
            lblOpponent = new Label();
            label3 = new Label();
            btnStart = new Button();
            lblOpponentSpeak = new Label();
            lblPlayerSpeak = new Label();
            tmrStateMachine = new System.Windows.Forms.Timer(components);
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            //((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            //((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).BeginInit();
            //panWeaponSelect.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).BeginInit();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).BeginInit();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).BeginInit();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).BeginInit();
            SuspendLayout();
            // 
            // picOpponent
            // 
            picOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent.Location = new Point(750, 200);
            picOpponent.Margin = new Padding(4, 5, 4, 5);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(751, 835);
            picOpponent.TabIndex = 0;
            picOpponent.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Image = Properties.Resources.Img_Bender_Idle;
            picPlayer.Location = new Point(17, 143);
            picPlayer.Margin = new Padding(4, 5, 4, 5);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(699, 995);
            picPlayer.TabIndex = 1;
            picPlayer.TabStop = false;
            // 
            // btnDoIt
            // 
            btnDoIt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoIt.Location = new Point(229, 1158);
            btnDoIt.Margin = new Padding(4, 5, 4, 5);
            btnDoIt.Name = "btnDoIt";
            btnDoIt.Size = new Size(321, 117);
            btnDoIt.TabIndex = 2;
            btnDoIt.Text = "Try Your Luck!";
            btnDoIt.UseVisualStyleBackColor = true;
            btnDoIt.Click += btnDoIt_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(303, 80);
            lblPlayer.Margin = new Padding(4, 0, 4, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(123, 48);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Player";
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.ForeColor = Color.White;
            lblOpponent.Location = new Point(1087, 83);
            lblOpponent.Margin = new Padding(4, 0, 4, 0);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(190, 48);
            lblOpponent.TabIndex = 4;
            lblOpponent.Text = "Opponent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(294, 325);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(241, 45);
            label3.TabIndex = 11;
            label3.Text = "Weapon Select";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOpponentSpeak
            // 
            lblOpponentSpeak.AutoSize = true;
            lblOpponentSpeak.BackColor = Color.White;
            lblOpponentSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponentSpeak.Location = new Point(833, 167);
            lblOpponentSpeak.Margin = new Padding(4, 0, 4, 0);
            lblOpponentSpeak.Name = "lblOpponentSpeak";
            lblOpponentSpeak.Size = new Size(312, 48);
            lblOpponentSpeak.TabIndex = 9;
            lblOpponentSpeak.Text = "I will outlast you!";
            // 
            // lblPlayerSpeak
            // 
            lblPlayerSpeak.AutoSize = true;
            lblPlayerSpeak.BackColor = Color.White;
            lblPlayerSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerSpeak.Location = new Point(471, 263);
            lblPlayerSpeak.Margin = new Padding(4, 0, 4, 0);
            lblPlayerSpeak.Name = "lblPlayerSpeak";
            lblPlayerSpeak.Size = new Size(425, 48);
            lblPlayerSpeak.TabIndex = 10;
            lblPlayerSpeak.Text = "Bite my shiny metal ass!";
            // 
            // tmrStateMachine
            // 
            tmrStateMachine.Interval = 40;
            tmrStateMachine.Tick += tmrDialog_Tick;
            // 
            // tmrPlayMusicAfterGameOver
            // 
            tmrPlayMusicAfterGameOver.Interval = 2000;
            tmrPlayMusicAfterGameOver.Tick += tmrPlayMusicAfterGameOver_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1550, 1474);
            Controls.Add(lblPlayerSpeak);
            Controls.Add(lblOpponentSpeak);
            Controls.Add(btnStart);
            Controls.Add(panWeaponSelect);
            Controls.Add(lblOpponent);
            Controls.Add(lblPlayer);
            Controls.Add(btnDoIt);
            Controls.Add(picPlayer);
            Controls.Add(picOpponent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMain";
            Text = "Russian Roulette RPG";
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            //((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            //((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).EndInit();
            //panWeaponSelect.ResumeLayout(false);
            //panWeaponSelect.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).EndInit();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).EndInit();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).EndInit();
            //((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picOpponent;
        private PictureBox picPlayer;
        private Button btnDoIt;
        private Label lblPlayer;
        private Label lblOpponent;
        private PictureBox picWeaponSelectMagicWand;
        private Label lblWeaponSelectMagicWand;
        private Panel panWeaponSelect;
        private Button btnStart;
        private Label lblOpponentSpeak;
        private Label lblPlayerSpeak;
        private System.Windows.Forms.Timer tmrStateMachine;
        private PictureBox picWeaponSelectCorkGun;
        private Label lblWeaponSelectWaterGun;
        private Label lblWeaponSelectCorkGun;
        private PictureBox picWeaponSelectWaterGun;
        private Label label3;
        private Label lblWeaponSelectBow;
        private PictureBox picWeaponSelectBow;
        private Label lblWeaponSelectNerfRev;
        private PictureBox picWeaponSelectNerfRev;
        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
    }
}