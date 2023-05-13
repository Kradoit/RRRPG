
namespace RRRPG
{
    partial class multiplayerMenue
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
            hostBtn = new Button();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            reload = new Button();
            SuspendLayout();
            // 
            // hostBtn
            // 
            hostBtn.BackColor = Color.Transparent;
            hostBtn.BackgroundImage = Properties.Resources.Img_Title_Play_Button;
            hostBtn.BackgroundImageLayout = ImageLayout.Stretch;
            hostBtn.FlatStyle = FlatStyle.Popup;
            hostBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            hostBtn.ForeColor = Color.Black;
            hostBtn.Location = new Point(884, 575);
            hostBtn.Margin = new Padding(7, 8, 7, 8);
            hostBtn.Name = "hostBtn";
            hostBtn.Size = new Size(571, 208);
            hostBtn.TabIndex = 1;
            hostBtn.Text = "Host";
            hostBtn.UseVisualStyleBackColor = false;
            hostBtn.Click += btnPlay_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(719, 144);
            listView1.Name = "listView1";
            listView1.Size = new Size(302, 242);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // reload
            // 
            reload.BackColor = Color.Transparent;
            reload.BackgroundImage = Properties.Resources.reload;
            reload.BackgroundImageLayout = ImageLayout.Stretch;
            reload.FlatStyle = FlatStyle.Popup;
            reload.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            reload.ForeColor = Color.Black;
            reload.Location = new Point(55, 356);
            reload.Margin = new Padding(7, 8, 7, 8);
            reload.Name = "reload";
            reload.Size = new Size(148, 139);
            reload.TabIndex = 3;
            reload.UseVisualStyleBackColor = false;
            reload.Click += button1_Click;
            // 
            // multiplayerMenue
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1892, 876);
            Controls.Add(reload);
            Controls.Add(listView1);
            Controls.Add(hostBtn);
            Name = "multiplayerMenue";
            Text = "multiplayerMenue";
            ResumeLayout(false);
        }

        #endregion

        private Button hostBtn;
        private ListView listView1;
        private ImageList imageList1;
        private Button reload;
    }
}