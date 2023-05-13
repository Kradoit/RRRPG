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

namespace RRRPG
{
    public partial class CharacterSelect : Form
    {
        public CharacterSelect(string mpo)
        {
            Console.WriteLine("---------------------------");
            if (mpo.Equals(mpo))
            {
                FormManager.openForms.Remove(this);
                FormManager.CloseAll();
            }
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton"))
            {
                System.Environment.Exit(0);
            }
        }
        private void FrmTitle_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.openForms.Remove(this);
            FormManager.CloseAll();
        }
    }
}
