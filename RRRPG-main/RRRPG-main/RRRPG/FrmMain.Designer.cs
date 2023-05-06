namespace RRRPG {
  partial class FrmMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.picOpponent = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      this.btnDoIt = new System.Windows.Forms.Button();
      this.lblPlayer = new System.Windows.Forms.Label();
      this.lblOpponent = new System.Windows.Forms.Label();
      this.picWeaponSelectMagicWand = new System.Windows.Forms.PictureBox();
      this.lblWeaponSelectMagicWand = new System.Windows.Forms.Label();
      this.panWeaponSelect = new System.Windows.Forms.Panel();
      this.lblWeaponSelectBow = new System.Windows.Forms.Label();
      this.picWeaponSelectBow = new System.Windows.Forms.PictureBox();
      this.lblWeaponSelectNerfRev = new System.Windows.Forms.Label();
      this.picWeaponSelectNerfRev = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lblWeaponSelectWaterGun = new System.Windows.Forms.Label();
      this.lblWeaponSelectCorkGun = new System.Windows.Forms.Label();
      this.picWeaponSelectWaterGun = new System.Windows.Forms.PictureBox();
      this.picWeaponSelectCorkGun = new System.Windows.Forms.PictureBox();
      this.btnStart = new System.Windows.Forms.Button();
      this.lblOpponentSpeak = new System.Windows.Forms.Label();
      this.lblPlayerSpeak = new System.Windows.Forms.Label();
      this.tmrStateMachine = new System.Windows.Forms.Timer(this.components);
      this.tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectMagicWand)).BeginInit();
      this.panWeaponSelect.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectBow)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectNerfRev)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectWaterGun)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectCorkGun)).BeginInit();
      this.SuspendLayout();
      // 
      // picOpponent
      // 
      this.picOpponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picOpponent.Location = new System.Drawing.Point(525, 120);
      this.picOpponent.Name = "picOpponent";
      this.picOpponent.Size = new System.Drawing.Size(526, 501);
      this.picOpponent.TabIndex = 0;
      this.picOpponent.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.Image = global::RRRPG.Properties.Resources.Img_Bender_Idle;
      this.picPlayer.Location = new System.Drawing.Point(12, 86);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(489, 597);
      this.picPlayer.TabIndex = 1;
      this.picPlayer.TabStop = false;
      // 
      // btnDoIt
      // 
      this.btnDoIt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnDoIt.Location = new System.Drawing.Point(160, 695);
      this.btnDoIt.Name = "btnDoIt";
      this.btnDoIt.Size = new System.Drawing.Size(225, 70);
      this.btnDoIt.TabIndex = 2;
      this.btnDoIt.Text = "Try Your Luck!";
      this.btnDoIt.UseVisualStyleBackColor = true;
      this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
      // 
      // lblPlayer
      // 
      this.lblPlayer.AutoSize = true;
      this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblPlayer.ForeColor = System.Drawing.Color.White;
      this.lblPlayer.Location = new System.Drawing.Point(212, 48);
      this.lblPlayer.Name = "lblPlayer";
      this.lblPlayer.Size = new System.Drawing.Size(85, 32);
      this.lblPlayer.TabIndex = 3;
      this.lblPlayer.Text = "Player";
      // 
      // lblOpponent
      // 
      this.lblOpponent.AutoSize = true;
      this.lblOpponent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblOpponent.ForeColor = System.Drawing.Color.White;
      this.lblOpponent.Location = new System.Drawing.Point(761, 50);
      this.lblOpponent.Name = "lblOpponent";
      this.lblOpponent.Size = new System.Drawing.Size(129, 32);
      this.lblOpponent.TabIndex = 4;
      this.lblOpponent.Text = "Opponent";
      // 
      // picWeaponSelectMagicWand
      // 
      this.picWeaponSelectMagicWand.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectMagicWand.BackgroundImage = global::RRRPG.Properties.Resources.Img_Magic_Wand;
      this.picWeaponSelectMagicWand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectMagicWand.Location = new System.Drawing.Point(12, 10);
      this.picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
      this.picWeaponSelectMagicWand.Size = new System.Drawing.Size(128, 153);
      this.picWeaponSelectMagicWand.TabIndex = 5;
      this.picWeaponSelectMagicWand.TabStop = false;
      this.picWeaponSelectMagicWand.Click += new System.EventHandler(this.picWeaponSelectMagicWand_Click);
      // 
      // lblWeaponSelectMagicWand
      // 
      this.lblWeaponSelectMagicWand.AutoSize = true;
      this.lblWeaponSelectMagicWand.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectMagicWand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectMagicWand.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectMagicWand.Location = new System.Drawing.Point(46, 166);
      this.lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
      this.lblWeaponSelectMagicWand.Size = new System.Drawing.Size(57, 21);
      this.lblWeaponSelectMagicWand.TabIndex = 6;
      this.lblWeaponSelectMagicWand.Text = "Magic";
      // 
      // panWeaponSelect
      // 
      this.panWeaponSelect.BackColor = System.Drawing.Color.Black;
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
      this.panWeaponSelect.Location = new System.Drawing.Point(507, 636);
      this.panWeaponSelect.Name = "panWeaponSelect";
      this.panWeaponSelect.Size = new System.Drawing.Size(566, 229);
      this.panWeaponSelect.TabIndex = 7;
      // 
      // lblWeaponSelectBow
      // 
      this.lblWeaponSelectBow.AutoSize = true;
      this.lblWeaponSelectBow.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectBow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectBow.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectBow.Location = new System.Drawing.Point(500, 166);
      this.lblWeaponSelectBow.Name = "lblWeaponSelectBow";
      this.lblWeaponSelectBow.Size = new System.Drawing.Size(43, 21);
      this.lblWeaponSelectBow.TabIndex = 15;
      this.lblWeaponSelectBow.Text = "Bow";
      // 
      // picWeaponSelectBow
      // 
      this.picWeaponSelectBow.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectBow.BackgroundImage = global::RRRPG.Properties.Resources.Img_Bow;
      this.picWeaponSelectBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectBow.Location = new System.Drawing.Point(466, 11);
      this.picWeaponSelectBow.Name = "picWeaponSelectBow";
      this.picWeaponSelectBow.Size = new System.Drawing.Size(100, 152);
      this.picWeaponSelectBow.TabIndex = 14;
      this.picWeaponSelectBow.TabStop = false;
      this.picWeaponSelectBow.Click += new System.EventHandler(this.picWeaponSelectBow_Click);
      // 
      // lblWeaponSelectNerfRev
      // 
      this.lblWeaponSelectNerfRev.AutoSize = true;
      this.lblWeaponSelectNerfRev.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectNerfRev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectNerfRev.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectNerfRev.Location = new System.Drawing.Point(351, 166);
      this.lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
      this.lblWeaponSelectNerfRev.Size = new System.Drawing.Size(115, 21);
      this.lblWeaponSelectNerfRev.TabIndex = 13;
      this.lblWeaponSelectNerfRev.Text = "Nerf Revolver";
      // 
      // picWeaponSelectNerfRev
      // 
      this.picWeaponSelectNerfRev.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectNerfRev.BackgroundImage = global::RRRPG.Properties.Resources.Img_Nerf_Revolver;
      this.picWeaponSelectNerfRev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectNerfRev.Location = new System.Drawing.Point(358, 11);
      this.picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
      this.picWeaponSelectNerfRev.Size = new System.Drawing.Size(100, 152);
      this.picWeaponSelectNerfRev.TabIndex = 12;
      this.picWeaponSelectNerfRev.TabStop = false;
      this.picWeaponSelectNerfRev.Click += new System.EventHandler(this.picWeaponSelectNerfRev_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.Silver;
      this.label3.Location = new System.Drawing.Point(206, 195);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(158, 30);
      this.label3.TabIndex = 11;
      this.label3.Text = "Weapon Select";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblWeaponSelectWaterGun
      // 
      this.lblWeaponSelectWaterGun.AutoSize = true;
      this.lblWeaponSelectWaterGun.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectWaterGun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectWaterGun.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectWaterGun.Location = new System.Drawing.Point(258, 165);
      this.lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
      this.lblWeaponSelectWaterGun.Size = new System.Drawing.Size(90, 21);
      this.lblWeaponSelectWaterGun.TabIndex = 10;
      this.lblWeaponSelectWaterGun.Text = "Water Gun";
      // 
      // lblWeaponSelectCorkGun
      // 
      this.lblWeaponSelectCorkGun.AutoSize = true;
      this.lblWeaponSelectCorkGun.BackColor = System.Drawing.Color.Black;
      this.lblWeaponSelectCorkGun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblWeaponSelectCorkGun.ForeColor = System.Drawing.Color.White;
      this.lblWeaponSelectCorkGun.Location = new System.Drawing.Point(156, 165);
      this.lblWeaponSelectCorkGun.Name = "lblWeaponSelectCorkGun";
      this.lblWeaponSelectCorkGun.Size = new System.Drawing.Size(80, 21);
      this.lblWeaponSelectCorkGun.TabIndex = 9;
      this.lblWeaponSelectCorkGun.Text = "Cork Gun";
      // 
      // picWeaponSelectWaterGun
      // 
      this.picWeaponSelectWaterGun.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectWaterGun.BackgroundImage = global::RRRPG.Properties.Resources.Img_Water_Gun;
      this.picWeaponSelectWaterGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectWaterGun.Location = new System.Drawing.Point(252, 10);
      this.picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
      this.picWeaponSelectWaterGun.Size = new System.Drawing.Size(100, 152);
      this.picWeaponSelectWaterGun.TabIndex = 8;
      this.picWeaponSelectWaterGun.TabStop = false;
      this.picWeaponSelectWaterGun.Click += new System.EventHandler(this.picWeaponSelectWaterGun_Click);
      // 
      // picWeaponSelectCorkGun
      // 
      this.picWeaponSelectCorkGun.BackColor = System.Drawing.Color.Black;
      this.picWeaponSelectCorkGun.BackgroundImage = global::RRRPG.Properties.Resources.Img_Cork_Gun;
      this.picWeaponSelectCorkGun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.picWeaponSelectCorkGun.Location = new System.Drawing.Point(146, 10);
      this.picWeaponSelectCorkGun.Name = "picWeaponSelectCorkGun";
      this.picWeaponSelectCorkGun.Size = new System.Drawing.Size(100, 152);
      this.picWeaponSelectCorkGun.TabIndex = 7;
      this.picWeaponSelectCorkGun.TabStop = false;
      this.picWeaponSelectCorkGun.Click += new System.EventHandler(this.picWeaponSelectCorkGun_Click);
      // 
      // btnStart
      // 
      this.btnStart.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnStart.Location = new System.Drawing.Point(212, 768);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(225, 70);
      this.btnStart.TabIndex = 8;
      this.btnStart.Text = "START";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lblOpponentSpeak
      // 
      this.lblOpponentSpeak.AutoSize = true;
      this.lblOpponentSpeak.BackColor = System.Drawing.Color.White;
      this.lblOpponentSpeak.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblOpponentSpeak.Location = new System.Drawing.Point(583, 100);
      this.lblOpponentSpeak.Name = "lblOpponentSpeak";
      this.lblOpponentSpeak.Size = new System.Drawing.Size(213, 32);
      this.lblOpponentSpeak.TabIndex = 9;
      this.lblOpponentSpeak.Text = "I will outlast you!";
      // 
      // lblPlayerSpeak
      // 
      this.lblPlayerSpeak.AutoSize = true;
      this.lblPlayerSpeak.BackColor = System.Drawing.Color.White;
      this.lblPlayerSpeak.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblPlayerSpeak.Location = new System.Drawing.Point(330, 158);
      this.lblPlayerSpeak.Name = "lblPlayerSpeak";
      this.lblPlayerSpeak.Size = new System.Drawing.Size(288, 32);
      this.lblPlayerSpeak.TabIndex = 10;
      this.lblPlayerSpeak.Text = "Bite my shiny metal ass!";
      // 
      // tmrStateMachine
      // 
      this.tmrStateMachine.Interval = 40;
      this.tmrStateMachine.Tick += new System.EventHandler(this.tmrDialog_Tick);
      // 
      // tmrPlayMusicAfterGameOver
      // 
      this.tmrPlayMusicAfterGameOver.Interval = 2000;
      this.tmrPlayMusicAfterGameOver.Tick += new System.EventHandler(this.tmrPlayMusicAfterGameOver_Tick);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(1085, 887);
      this.Controls.Add(this.lblPlayerSpeak);
      this.Controls.Add(this.lblOpponentSpeak);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.panWeaponSelect);
      this.Controls.Add(this.lblOpponent);
      this.Controls.Add(this.lblPlayer);
      this.Controls.Add(this.btnDoIt);
      this.Controls.Add(this.picPlayer);
      this.Controls.Add(this.picOpponent);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmMain";
      this.Text = "Russian Roulette RPG";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectMagicWand)).EndInit();
      this.panWeaponSelect.ResumeLayout(false);
      this.panWeaponSelect.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectBow)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectNerfRev)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectWaterGun)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWeaponSelectCorkGun)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

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