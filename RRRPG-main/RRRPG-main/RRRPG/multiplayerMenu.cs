using RRRPG.Properties;
using RRRPGLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace RRRPG
{
    public partial class multiplayerMenu : Form
    {
        private SoundPlayer soundPlayer;
        private MultiPlayer Network;

        // function to character select
        private void characterSelect()
        {
            ResourcesRef.Resources = Resources.ResourceManager;
            Hide();
            CharacterSelect characterSelect = new CharacterSelect(Network);
            soundPlayer.Stop();
            characterSelect.ShowDialog();
            FormManager.openForms.Add(characterSelect);
        }

        // base init without mutiplayer
        public multiplayerMenu()
        {
            InitializeComponent();
            FormManager.openForms.Add(this);

            // make the network object
            Network = new MultiPlayer();
        }
        private void FrmMain2_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music);
            soundPlayer.PlayLooping();
        }

        private void FrmMain2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.openForms.Remove(this);
            FormManager.CloseAll();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            // if youre not the host then tell the host youre joining
            if(!Network.isHost)
            {
                // check if they have selected an item
                if (serverList.SelectedItem!=null)
                {
                    Network.join(serverList.GetItemText(serverList.SelectedItem));
                }
            }
            // save the name
            Network.name = nameBox.Text;
            // move to next form
            characterSelect();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reload(object sender, EventArgs e)
        {
            // scan for servers
            var ips = Network.scan();

            // remove all of the current servers
            serverList.Items.Clear();

            // loop through and add the ips to the list
            foreach (string ip in ips) {
                serverList.Items.Add(ip);
            }
        }
        // function to host the game
        private void hostGame(object sender, EventArgs e)
        {
            // set the text of the hostname
            if (nameBox.Text != "")
                Network.name = nameBox.Text;

            // set the network to host
            Network.hostGame();

            // open the chracter select page with networking
            characterSelect();
        }
    }

}
