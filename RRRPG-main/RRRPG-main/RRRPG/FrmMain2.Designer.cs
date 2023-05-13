using RRRPG.Properties;

namespace RRRPG
{
    partial class FrmMain2
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
            this.components = new System.ComponentModel.Container();
            this.tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerSpeak = new Label();
            this.btnStart = new Button();
            this.tmrStateMachine = new System.Windows.Forms.Timer(this.components);
            this.lblWeaponSelectBow = new Label();
            this.picWeaponSelectBow = new PictureBox();
            this.lblWeaponSelectNerfRev = new Label();
            this.picWeaponSelectMagicWand = new PictureBox();
            this.lblWeaponSelectMagicWand = new Label();
            this.lblOpponent = new Label();
            this.picWeaponSelectNerfRev = new PictureBox();
            this.label3 = new Label();
            this.lblWeaponSelectWaterGun = new Label();
            this.lblWeaponSelectCorkGun = new Label();
            this.picWeaponSelectWaterGun = new PictureBox();
            this.picWeaponSelectCorkGun = new PictureBox();
            this.panWeaponSelect = new Panel();
            this.lblPlayer = new Label();
            this.btnDoIt = new Button();
            this.picOpponent = new PictureBox();
            this.picOpponent2 = new PictureBox();
            this.lblOpponentSpeak = new Label();
            this.lblOpponentSpeak2 = new Label();
            this.picPlayer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectMagicWand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectNerfRev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectWaterGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectCorkGun).BeginInit();
            this.panWeaponSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.picOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picOpponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picPlayer).BeginInit();
            SuspendLayout();
            // 
            // tmrPlayMusicAfterGameOver
            // 
            this.tmrPlayMusicAfterGameOver.Interval = 2000;
            // 
            // lblPlayerSpeak
            // 
            this.lblPlayerSpeak.AutoSize = true;
            this.lblPlayerSpeak.BackColor = Color.White;
            this.lblPlayerSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblPlayerSpeak.Location = new Point(152, 99);
            this.lblPlayerSpeak.Margin = new Padding(7, 0, 7, 0);
            this.lblPlayerSpeak.Name = "lblPlayerSpeak";
            this.lblPlayerSpeak.Size = new Size(710, 81);
            this.lblPlayerSpeak.TabIndex = 19;
            this.lblPlayerSpeak.Text = "Bite my shiny metal ass!";
            // 
            // btnStart
            // 
            this.btnStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnStart.Location = new Point(231, 1569);
            this.btnStart.Margin = new Padding(7, 8, 7, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new Size(546, 192);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += this.btnStart_Click;
            // 
            // tmrStateMachine
            // 
            this.tmrStateMachine.Interval = 40;
            this.tmrStateMachine.Tick += this.tmrDialog_Tick;
            // 
            // lblWeaponSelectBow
            // 
            this.lblWeaponSelectBow.AutoSize = true;
            this.lblWeaponSelectBow.BackColor = Color.Black;
            this.lblWeaponSelectBow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblWeaponSelectBow.ForeColor = Color.White;
            this.lblWeaponSelectBow.Location = new Point(1214, 454);
            this.lblWeaponSelectBow.Margin = new Padding(7, 0, 7, 0);
            this.lblWeaponSelectBow.Name = "lblWeaponSelectBow";
            this.lblWeaponSelectBow.Size = new Size(105, 54);
            this.lblWeaponSelectBow.TabIndex = 15;
            this.lblWeaponSelectBow.Text = "Bow";
            // 
            // picWeaponSelectBow
            // 
            this.picWeaponSelectBow.BackColor = Color.Black;
            this.picWeaponSelectBow.BackgroundImage = Resources.Img_Bow;
            this.picWeaponSelectBow.BackgroundImageLayout = ImageLayout.Zoom;
            this.picWeaponSelectBow.Location = new Point(1132, 30);
            this.picWeaponSelectBow.Margin = new Padding(7, 8, 7, 8);
            this.picWeaponSelectBow.Name = "picWeaponSelectBow";
            this.picWeaponSelectBow.Size = new Size(243, 415);
            this.picWeaponSelectBow.TabIndex = 14;
            this.picWeaponSelectBow.TabStop = false;
            this.picWeaponSelectBow.Click += this.picWeaponSelectBow_Click;
            // 
            // lblWeaponSelectNerfRev
            // 
            this.lblWeaponSelectNerfRev.AutoSize = true;
            this.lblWeaponSelectNerfRev.BackColor = Color.Black;
            this.lblWeaponSelectNerfRev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblWeaponSelectNerfRev.ForeColor = Color.White;
            this.lblWeaponSelectNerfRev.Location = new Point(852, 454);
            this.lblWeaponSelectNerfRev.Margin = new Padding(7, 0, 7, 0);
            this.lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
            this.lblWeaponSelectNerfRev.Size = new Size(284, 54);
            this.lblWeaponSelectNerfRev.TabIndex = 13;
            this.lblWeaponSelectNerfRev.Text = "Nerf Revolver";
            // 
            // picWeaponSelectMagicWand
            // 
            this.picWeaponSelectMagicWand.BackColor = Color.Black;
            this.picWeaponSelectMagicWand.BackgroundImage = Resources.Img_Magic_Wand;
            this.picWeaponSelectMagicWand.BackgroundImageLayout = ImageLayout.Zoom;
            this.picWeaponSelectMagicWand.Location = new Point(31, 25);
            this.picWeaponSelectMagicWand.Margin = new Padding(7, 8, 7, 8);
            this.picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
            this.picWeaponSelectMagicWand.Size = new Size(311, 418);
            this.picWeaponSelectMagicWand.TabIndex = 5;
            this.picWeaponSelectMagicWand.TabStop = false;
            this.picWeaponSelectMagicWand.Click += this.picWeaponSelectMagicWand_Click;
            // 
            // lblWeaponSelectMagicWand
            // 
            this.lblWeaponSelectMagicWand.AutoSize = true;
            this.lblWeaponSelectMagicWand.BackColor = Color.Black;
            this.lblWeaponSelectMagicWand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblWeaponSelectMagicWand.ForeColor = Color.White;
            this.lblWeaponSelectMagicWand.Location = new Point(112, 454);
            this.lblWeaponSelectMagicWand.Margin = new Padding(7, 0, 7, 0);
            this.lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
            this.lblWeaponSelectMagicWand.Size = new Size(138, 54);
            this.lblWeaponSelectMagicWand.TabIndex = 6;
            this.lblWeaponSelectMagicWand.Text = "Magic";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblOpponent.ForeColor = Color.White;
            this.lblOpponent.Location = new Point(1953, -208);
            this.lblOpponent.Margin = new Padding(7, 0, 7, 0);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new Size(318, 81);
            this.lblOpponent.TabIndex = 15;
            this.lblOpponent.Text = "Opponent";
            // 
            // picWeaponSelectNerfRev
            // 
            this.picWeaponSelectNerfRev.BackColor = Color.Black;
            this.picWeaponSelectNerfRev.BackgroundImage = Resources.Img_Nerf_Revolver;
            this.picWeaponSelectNerfRev.BackgroundImageLayout = ImageLayout.Zoom;
            this.picWeaponSelectNerfRev.Location = new Point(869, 30);
            this.picWeaponSelectNerfRev.Margin = new Padding(7, 8, 7, 8);
            this.picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
            this.picWeaponSelectNerfRev.Size = new Size(243, 415);
            this.picWeaponSelectNerfRev.TabIndex = 12;
            this.picWeaponSelectNerfRev.TabStop = false;
            this.picWeaponSelectNerfRev.Click += this.picWeaponSelectNerfRev_Click;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            this.label3.ForeColor = Color.Silver;
            this.label3.Location = new Point(500, 533);
            this.label3.Margin = new Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(401, 71);
            this.label3.TabIndex = 11;
            this.label3.Text = "Weapon Select";
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeaponSelectWaterGun
            // 
            this.lblWeaponSelectWaterGun.AutoSize = true;
            this.lblWeaponSelectWaterGun.BackColor = Color.Black;
            this.lblWeaponSelectWaterGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblWeaponSelectWaterGun.ForeColor = Color.White;
            this.lblWeaponSelectWaterGun.Location = new Point(627, 451);
            this.lblWeaponSelectWaterGun.Margin = new Padding(7, 0, 7, 0);
            this.lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
            this.lblWeaponSelectWaterGun.Size = new Size(224, 54);
            this.lblWeaponSelectWaterGun.TabIndex = 10;
            this.lblWeaponSelectWaterGun.Text = "Water Gun";
            // 
            // lblWeaponSelectCorkGun
            // 
            this.lblWeaponSelectCorkGun.AutoSize = true;
            this.lblWeaponSelectCorkGun.BackColor = Color.Black;
            this.lblWeaponSelectCorkGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblWeaponSelectCorkGun.ForeColor = Color.White;
            this.lblWeaponSelectCorkGun.Location = new Point(379, 451);
            this.lblWeaponSelectCorkGun.Margin = new Padding(7, 0, 7, 0);
            this.lblWeaponSelectCorkGun.Name = "lblWeaponSelectCorkGun";
            this.lblWeaponSelectCorkGun.Size = new Size(197, 54);
            this.lblWeaponSelectCorkGun.TabIndex = 9;
            this.lblWeaponSelectCorkGun.Text = "Cork Gun";
            // 
            // picWeaponSelectWaterGun
            // 
            this.picWeaponSelectWaterGun.BackColor = Color.Black;
            this.picWeaponSelectWaterGun.BackgroundImage = Resources.Img_Water_Gun;
            this.picWeaponSelectWaterGun.BackgroundImageLayout = ImageLayout.Zoom;
            this.picWeaponSelectWaterGun.Location = new Point(612, 28);
            this.picWeaponSelectWaterGun.Margin = new Padding(7, 8, 7, 8);
            this.picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
            this.picWeaponSelectWaterGun.Size = new Size(243, 415);
            this.picWeaponSelectWaterGun.TabIndex = 8;
            this.picWeaponSelectWaterGun.TabStop = false;
            this.picWeaponSelectWaterGun.Click += this.picWeaponSelectWaterGun_Click;
            // 
            // picWeaponSelectCorkGun
            // 
            this.picWeaponSelectCorkGun.BackColor = Color.Black;
            this.picWeaponSelectCorkGun.BackgroundImage = Resources.Img_Cork_Gun;
            this.picWeaponSelectCorkGun.BackgroundImageLayout = ImageLayout.Zoom;
            this.picWeaponSelectCorkGun.Location = new Point(355, 28);
            this.picWeaponSelectCorkGun.Margin = new Padding(7, 8, 7, 8);
            this.picWeaponSelectCorkGun.Name = "picWeaponSelectCorkGun";
            this.picWeaponSelectCorkGun.Size = new Size(243, 415);
            this.picWeaponSelectCorkGun.TabIndex = 7;
            this.picWeaponSelectCorkGun.TabStop = false;
            this.picWeaponSelectCorkGun.Click += this.picWeaponSelectCorkGun_Click;
            // 
            // panWeaponSelect
            // 
            this.panWeaponSelect.BackColor = Color.Black;
            this.panWeaponSelect.Controls.Add(this.lblWeaponSelectBow);
            this.panWeaponSelect.Controls.Add(this.picWeaponSelectBow);
            this.panWeaponSelect.Controls.Add(this.lblWeaponSelectNerfRev);
            this.panWeaponSelect.Controls.Add(this.picWeaponSelectNerfRev);
            this.panWeaponSelect.Controls.Add(this.label3);
            this.panWeaponSelect.Controls.Add(this.lblWeaponSelectWaterGun);
            this.panWeaponSelect.Controls.Add(this.lblWeaponSelectCorkGun);
            this.panWeaponSelect.Controls.Add(this.picWeaponSelectWaterGun);
            this.panWeaponSelect.Controls.Add(this.picWeaponSelectCorkGun);
            this.panWeaponSelect.Controls.Add(this.picWeaponSelectMagicWand);
            this.panWeaponSelect.Controls.Add(this.lblWeaponSelectMagicWand);
            this.panWeaponSelect.Location = new Point(901, 1446);
            this.panWeaponSelect.Margin = new Padding(7, 8, 7, 8);
            this.panWeaponSelect.Name = "panWeaponSelect";
            this.panWeaponSelect.Size = new Size(1375, 626);
            this.panWeaponSelect.TabIndex = 16;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblPlayer.ForeColor = Color.White;
            this.lblPlayer.Location = new Point(620, -213);
            this.lblPlayer.Margin = new Padding(7, 0, 7, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new Size(208, 81);
            this.lblPlayer.TabIndex = 14;
            this.lblPlayer.Text = "Player";
            // 
            // btnDoIt
            // 
            this.btnDoIt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnDoIt.Location = new Point(134, 1358);
            this.btnDoIt.Margin = new Padding(7, 8, 7, 8);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new Size(546, 192);
            this.btnDoIt.TabIndex = 13;
            this.btnDoIt.Text = "Try Your Luck!";
            this.btnDoIt.UseVisualStyleBackColor = true;
            this.btnDoIt.Click += this.btnDoIt_Click;
            // 
            // picOpponent
            // 
            this.picOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            this.picOpponent.Location = new Point(1394, 241);
            this.picOpponent.Margin = new Padding(7, 8, 7, 8);
            this.picOpponent.Name = "picOpponent";
            this.picOpponent.Size = new Size(1071, 1156);
            this.picOpponent.TabIndex = 11;
            this.picOpponent.TabStop = false;
            // 
            // picOpponent2
            // 
            this.picOpponent2.BackgroundImageLayout = ImageLayout.Stretch;
            this.picOpponent2.Location = new Point(2613, 305);
            this.picOpponent2.Margin = new Padding(7, 8, 7, 8);
            this.picOpponent2.Name = "picOpponent2";
            this.picOpponent2.Size = new Size(993, 1058);
            this.picOpponent2.TabIndex = 20;
            this.picOpponent2.TabStop = false;
            // 
            // lblOpponentSpeak
            // 
            this.lblOpponentSpeak.AutoSize = true;
            this.lblOpponentSpeak.BackColor = Color.White;
            this.lblOpponentSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblOpponentSpeak.Location = new Point(1682, 108);
            this.lblOpponentSpeak.Margin = new Padding(5, 0, 5, 0);
            this.lblOpponentSpeak.Name = "lblOpponentSpeak";
            this.lblOpponentSpeak.Size = new Size(522, 81);
            this.lblOpponentSpeak.TabIndex = 18;
            this.lblOpponentSpeak.Text = "I will outlast you!";
            // 
            // lblOpponentSpeak2
            // 
            this.lblOpponentSpeak2.AutoSize = true;
            this.lblOpponentSpeak2.BackColor = Color.White;
            this.lblOpponentSpeak2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblOpponentSpeak2.Location = new Point(2927, 157);
            this.lblOpponentSpeak2.Margin = new Padding(5, 0, 5, 0);
            this.lblOpponentSpeak2.Name = "lblOpponentSpeak2";
            this.lblOpponentSpeak2.Size = new Size(270, 81);
            this.lblOpponentSpeak2.TabIndex = 21;
            this.lblOpponentSpeak2.Text = "so will I!";
            // 
            // picPlayer
            // 
            this.picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            this.picPlayer.Image = Resources.Img_Bender_Idle;
            this.picPlayer.Location = new Point(44, 241);
            this.picPlayer.Margin = new Padding(7, 8, 7, 8);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new Size(1122, 936);
            this.picPlayer.TabIndex = 12;
            this.picPlayer.TabStop = false;
            // 
            // FrmMain2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(3244, 2108);
            Controls.Add(this.lblOpponentSpeak2);
            Controls.Add(this.picOpponent2);
            Controls.Add(this.lblPlayerSpeak);
            Controls.Add(this.lblOpponentSpeak);
            Controls.Add(this.btnStart);
            Controls.Add(this.lblOpponent);
            Controls.Add(this.panWeaponSelect);
            Controls.Add(this.lblPlayer);
            Controls.Add(this.btnDoIt);
            Controls.Add(this.picPlayer);
            Controls.Add(this.picOpponent);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmMain2";
            Text = "Form1";
            FormClosed += FrmMain2_FormClosed;
            Load += FrmMain2_Load;
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectMagicWand).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectNerfRev).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectWaterGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picWeaponSelectCorkGun).EndInit();
            this.panWeaponSelect.ResumeLayout(false);
            this.panWeaponSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.picOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picOpponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private Label lblPlayerSpeak;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrStateMachine;
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
        private Button btnDoIt;
        private PictureBox picOpponent;
        private PictureBox picOpponent2;
        private Label lblOpponentSpeak;
        private Label lblOpponentSpeak2;
        private PictureBox picPlayer;
    }
}