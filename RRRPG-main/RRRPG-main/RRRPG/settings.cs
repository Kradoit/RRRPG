using RRRPG.Properties;
using RRRPGLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RRRPG
{
    public partial class settings : Form
    {

        private SoundPlayer soundPlayer;

        public settings()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ResourcesRef.Resources = Resources.ResourceManager;
            Hide();
            FrmTitle frmTitle = new FrmTitle();
            frmTitle.ShowDialog();
            FormManager.openForms.Add(frmTitle);
        }

        private void buttonTrack1_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music_3);
            SoundManager.currTrack = 1;
            soundPlayer.PlayLooping();

        }

        private void buttonTrack2_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resources.BabyShark);
            SoundManager.currTrack = 2;
            soundPlayer.PlayLooping();
        }

        private void buttonTrack3_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resources.ComfortablyNumb);
            SoundManager.currTrack = 3;
            soundPlayer.PlayLooping();
        }
    }
}
