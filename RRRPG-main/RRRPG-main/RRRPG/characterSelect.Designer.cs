using RRRPG.Properties;

namespace RRRPG
{
    partial class CharacterSelect
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
            components = new System.ComponentModel.Container();
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            player1 = new Label();
            btnStart = new Button();
            hostStateMachine = new System.Windows.Forms.Timer(components);
            userStateMachine = new System.Windows.Forms.Timer(components);
            lblWeaponSelectBow = new Label();
            picWeaponSelectBow = new PictureBox();
            lblWeaponSelectNerfRev = new Label();
            picWeaponSelectMagicWand = new PictureBox();
            lblWeaponSelectMagicWand = new Label();
            lblOpponent = new Label();
            picWeaponSelectNerfRev = new PictureBox();
            label3 = new Label();
            lblWeaponSelectWaterGun = new Label();
            lblWeaponSelectCorkGun = new Label();
            picWeaponSelectWaterGun = new PictureBox();
            picWeaponSelectCorkGun = new PictureBox();
            panWeaponSelect = new Panel();
            lblPlayer = new Label();
            picOpponent = new PictureBox();
            picOpponent2 = new PictureBox();
            picPlayer = new PictureBox();
            lblOpponentSpeak = new Label();
            text3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).BeginInit();
            panWeaponSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            SuspendLayout();
            // 
            // tmrPlayMusicAfterGameOver
            // 
            tmrPlayMusicAfterGameOver.Interval = 2000;
            // 
            // player1
            // 
            player1.AutoSize = true;
            player1.BackColor = Color.White;
            player1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            player1.Location = new Point(299, 166);
            player1.Margin = new Padding(4, 0, 4, 0);
            player1.Name = "player1";
            player1.Size = new Size(221, 48);
            player1.TabIndex = 19;
            player1.Text = "Opponent 1";
            player1.Click += lblPlayerSpeak_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(136, 957);
            btnStart.Margin = new Padding(4, 5, 4, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(321, 117);
            btnStart.TabIndex = 17;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // hostStateMachine
            // 
            hostStateMachine.Interval = 2;
            hostStateMachine.Tick += host;
            // 
            // userStateMachine
            // 
            userStateMachine.Interval = 2;
            userStateMachine.Tick += checkForData;
            // 
            // lblWeaponSelectBow
            // 
            lblWeaponSelectBow.AutoSize = true;
            lblWeaponSelectBow.BackColor = Color.Black;
            lblWeaponSelectBow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectBow.ForeColor = Color.White;
            lblWeaponSelectBow.Location = new Point(714, 277);
            lblWeaponSelectBow.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectBow.Name = "lblWeaponSelectBow";
            lblWeaponSelectBow.Size = new Size(63, 32);
            lblWeaponSelectBow.TabIndex = 15;
            lblWeaponSelectBow.Text = "Bow";
            // 
            // picWeaponSelectBow
            // 
            picWeaponSelectBow.BackColor = Color.Black;
            picWeaponSelectBow.BackgroundImage = Resources.Img_Bow;
            picWeaponSelectBow.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectBow.Location = new Point(666, 18);
            picWeaponSelectBow.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectBow.Name = "picWeaponSelectBow";
            picWeaponSelectBow.Size = new Size(143, 253);
            picWeaponSelectBow.TabIndex = 14;
            picWeaponSelectBow.TabStop = false;
            picWeaponSelectBow.Click += picWeaponSelectBow_Click;
            // 
            // lblWeaponSelectNerfRev
            // 
            lblWeaponSelectNerfRev.AutoSize = true;
            lblWeaponSelectNerfRev.BackColor = Color.Black;
            lblWeaponSelectNerfRev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectNerfRev.ForeColor = Color.White;
            lblWeaponSelectNerfRev.Location = new Point(501, 277);
            lblWeaponSelectNerfRev.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
            lblWeaponSelectNerfRev.Size = new Size(172, 32);
            lblWeaponSelectNerfRev.TabIndex = 13;
            lblWeaponSelectNerfRev.Text = "Nerf Revolver";
            // 
            // picWeaponSelectMagicWand
            // 
            picWeaponSelectMagicWand.BackColor = Color.Black;
            picWeaponSelectMagicWand.BackgroundImage = Resources.Img_Magic_Wand;
            picWeaponSelectMagicWand.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectMagicWand.Location = new Point(18, 15);
            picWeaponSelectMagicWand.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
            picWeaponSelectMagicWand.Size = new Size(183, 255);
            picWeaponSelectMagicWand.TabIndex = 5;
            picWeaponSelectMagicWand.TabStop = false;
            picWeaponSelectMagicWand.Click += picWeaponSelectMagicWand_Click;
            // 
            // lblWeaponSelectMagicWand
            // 
            lblWeaponSelectMagicWand.AutoSize = true;
            lblWeaponSelectMagicWand.BackColor = Color.Black;
            lblWeaponSelectMagicWand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectMagicWand.ForeColor = Color.White;
            lblWeaponSelectMagicWand.Location = new Point(66, 277);
            lblWeaponSelectMagicWand.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
            lblWeaponSelectMagicWand.Size = new Size(84, 32);
            lblWeaponSelectMagicWand.TabIndex = 6;
            lblWeaponSelectMagicWand.Text = "Magic";
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.ForeColor = Color.White;
            lblOpponent.Location = new Point(1149, -127);
            lblOpponent.Margin = new Padding(4, 0, 4, 0);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(190, 48);
            lblOpponent.TabIndex = 15;
            lblOpponent.Text = "Opponent";
            // 
            // picWeaponSelectNerfRev
            // 
            picWeaponSelectNerfRev.BackColor = Color.Black;
            picWeaponSelectNerfRev.BackgroundImage = Resources.Img_Nerf_Revolver;
            picWeaponSelectNerfRev.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectNerfRev.Location = new Point(511, 18);
            picWeaponSelectNerfRev.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
            picWeaponSelectNerfRev.Size = new Size(143, 253);
            picWeaponSelectNerfRev.TabIndex = 12;
            picWeaponSelectNerfRev.TabStop = false;
            picWeaponSelectNerfRev.Click += picWeaponSelectNerfRev_Click;
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
            // lblWeaponSelectWaterGun
            // 
            lblWeaponSelectWaterGun.AutoSize = true;
            lblWeaponSelectWaterGun.BackColor = Color.Black;
            lblWeaponSelectWaterGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectWaterGun.ForeColor = Color.White;
            lblWeaponSelectWaterGun.Location = new Point(369, 275);
            lblWeaponSelectWaterGun.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
            lblWeaponSelectWaterGun.Size = new Size(136, 32);
            lblWeaponSelectWaterGun.TabIndex = 10;
            lblWeaponSelectWaterGun.Text = "Water Gun";
            // 
            // lblWeaponSelectCorkGun
            // 
            lblWeaponSelectCorkGun.AutoSize = true;
            lblWeaponSelectCorkGun.BackColor = Color.Black;
            lblWeaponSelectCorkGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectCorkGun.ForeColor = Color.White;
            lblWeaponSelectCorkGun.Location = new Point(223, 275);
            lblWeaponSelectCorkGun.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectCorkGun.Name = "lblWeaponSelectCorkGun";
            lblWeaponSelectCorkGun.Size = new Size(121, 32);
            lblWeaponSelectCorkGun.TabIndex = 9;
            lblWeaponSelectCorkGun.Text = "Cork Gun";
            // 
            // picWeaponSelectWaterGun
            // 
            picWeaponSelectWaterGun.BackColor = Color.Black;
            picWeaponSelectWaterGun.BackgroundImage = Resources.Img_Water_Gun;
            picWeaponSelectWaterGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectWaterGun.Location = new Point(360, 17);
            picWeaponSelectWaterGun.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
            picWeaponSelectWaterGun.Size = new Size(143, 253);
            picWeaponSelectWaterGun.TabIndex = 8;
            picWeaponSelectWaterGun.TabStop = false;
            picWeaponSelectWaterGun.Click += picWeaponSelectWaterGun_Click;
            // 
            // picWeaponSelectCorkGun
            // 
            picWeaponSelectCorkGun.BackColor = Color.Black;
            picWeaponSelectCorkGun.BackgroundImage = Resources.Img_Cork_Gun;
            picWeaponSelectCorkGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectCorkGun.Location = new Point(209, 17);
            picWeaponSelectCorkGun.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectCorkGun.Name = "picWeaponSelectCorkGun";
            picWeaponSelectCorkGun.Size = new Size(143, 253);
            picWeaponSelectCorkGun.TabIndex = 7;
            picWeaponSelectCorkGun.TabStop = false;
            picWeaponSelectCorkGun.Click += picWeaponSelectCorkGun_Click;
            // 
            // panWeaponSelect
            // 
            panWeaponSelect.BackColor = Color.Black;
            panWeaponSelect.Controls.Add(lblWeaponSelectBow);
            panWeaponSelect.Controls.Add(picWeaponSelectBow);
            panWeaponSelect.Controls.Add(lblWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(picWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(label3);
            panWeaponSelect.Controls.Add(lblWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(lblWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(picWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectMagicWand);
            panWeaponSelect.Controls.Add(lblWeaponSelectMagicWand);
            panWeaponSelect.Location = new Point(530, 882);
            panWeaponSelect.Margin = new Padding(4, 5, 4, 5);
            panWeaponSelect.Name = "panWeaponSelect";
            panWeaponSelect.Size = new Size(809, 382);
            panWeaponSelect.TabIndex = 16;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(365, -130);
            lblPlayer.Margin = new Padding(4, 0, 4, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(123, 48);
            lblPlayer.TabIndex = 14;
            lblPlayer.Text = "Player";
            // 
            // picOpponent
            // 
            picOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent.Location = new Point(217, 268);
            picOpponent.Margin = new Padding(4, 5, 4, 5);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(382, 486);
            picOpponent.TabIndex = 12;
            picOpponent.TabStop = false;
            // 
            // picOpponent2
            // 
            picOpponent2.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent2.Location = new Point(1437, 268);
            picOpponent2.Margin = new Padding(4, 5, 4, 5);
            picOpponent2.Name = "picOpponent2";
            picOpponent2.Size = new Size(410, 518);
            picOpponent2.TabIndex = 20;
            picOpponent2.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Location = new Point(834, 191);
            picPlayer.Margin = new Padding(4, 5, 4, 5);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(376, 491);
            picPlayer.TabIndex = 11;
            picPlayer.TabStop = false;
            // 
            // lblOpponentSpeak
            // 
            lblOpponentSpeak.AutoSize = true;
            lblOpponentSpeak.BackColor = Color.White;
            lblOpponentSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponentSpeak.Location = new Point(971, 85);
            lblOpponentSpeak.Name = "lblOpponentSpeak";
            lblOpponentSpeak.Size = new Size(83, 48);
            lblOpponentSpeak.TabIndex = 18;
            lblOpponentSpeak.Text = "You";
            // 
            // text3
            // 
            text3.AutoSize = true;
            text3.BackColor = Color.White;
            text3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            text3.Location = new Point(1571, 166);
            text3.Name = "text3";
            text3.Size = new Size(216, 48);
            text3.TabIndex = 21;
            text3.Text = "opponent 2";
            // 
            // CharacterSelect
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1715, 1346);
            Controls.Add(text3);
            Controls.Add(picOpponent2);
            Controls.Add(player1);
            Controls.Add(lblOpponentSpeak);
            Controls.Add(btnStart);
            Controls.Add(lblOpponent);
            Controls.Add(panWeaponSelect);
            Controls.Add(lblPlayer);
            Controls.Add(picOpponent);
            Controls.Add(picPlayer);
            Name = "CharacterSelect";
            Text = "Form1";
            FormClosed += FrmMain2_FormClosed;
            Load += FrmMain2_Load;
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).EndInit();
            panWeaponSelect.ResumeLayout(false);
            panWeaponSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private Label player1;
        private Button btnStart;
        private System.Windows.Forms.Timer hostStateMachine;
        private System.Windows.Forms.Timer userStateMachine;
        private Label lblWeaponSelectBow;
        private PictureBox picWeaponSelectBow;
        private Label lblWeaponSelectNerfRev;
        private PictureBox picWeaponSelectMagicWand;
        private Label lblWeaponSelectMagicWand;
        private Label lblOpponent;
        private PictureBox picWeaponSelectNerfRev;
        private Label label3;
        private Label lblWeaponSelectWaterGun;
        private Label lblWeaponSelectCorkGun;
        private PictureBox picWeaponSelectWaterGun;
        private PictureBox picWeaponSelectCorkGun;
        private Panel panWeaponSelect;
        private Label lblPlayer;
        private PictureBox picOpponent;
        private PictureBox picPlayer;
        private PictureBox picOpponent2;
        private Label lblOpponentSpeak;
        private Label text3;
    }
}