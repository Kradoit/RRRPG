using RRRPGLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using RRRPG.Properties;
using System.Media;

namespace RRRPG
{
    public partial class multiplayerMenue : Form
    {
        // create object for handeling networking
        private Multiplayer multiplayerControl = new Multiplayer();

        public multiplayerMenue()
        {
            InitializeComponent();
        }


        // function called to host a game
        private void btnPlay_Click(object sender, EventArgs e)
        {
            ResourcesRef.Resources = Resources.ResourceManager;
            Hide();
            CharacterSelect frmMain = new CharacterSelect("test");
            frmMain.ShowDialog();
            FormManager.openForms.Add(frmMain);
        }

        // reload button
        private void button1_Click(object sender, EventArgs e)
        {
            // send a udp ping and wait for responses
            string[] ips = multiplayerControl.scan();

            // list all of the ip address

        }
        private void FrmTitle_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.openForms.Remove(this);
            FormManager.CloseAll();
        }
    }
}
