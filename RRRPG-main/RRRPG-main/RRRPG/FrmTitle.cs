using RRRPG.Properties;
using RRRPGLib;
using System.Media;

namespace RRRPG;

public partial class FrmTitle : Form
{
    private SoundPlayer soundPlayer;
    public FrmTitle()
    {
        InitializeComponent();
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        ResourcesRef.Resources = Resources.ResourceManager;
        Hide();
        soundPlayer.Stop();
        characterSelect CharacterSelect = new characterSelect();
        CharacterSelect.ShowDialog();
        FormManager.openForms.Add(CharacterSelect);
    }
    private void button1_Click(object sender, EventArgs e)
    {
        ResourcesRef.Resources = Resources.ResourceManager;
        Hide();
        soundPlayer.Stop();
        FrmMain2 frmMain2 = new FrmMain2();
        frmMain2.ShowDialog();
        FormManager.openForms.Add(frmMain2);
    }

    private void FrmTitle_Load(object sender, EventArgs e)
    {
        soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music_3);
        soundPlayer.PlayLooping();
        FormManager.openForms.Add(this);
    }

    private void FrmTitle_FormClosed(object sender, FormClosedEventArgs e)
    {
        FormManager.openForms.Remove(this);
        FormManager.CloseAll();
    }
    /// multiplayer button
    private void button2_Click(object sender, EventArgs e)
    {
        ResourcesRef.Resources = Resources.ResourceManager;
        Hide();
        soundPlayer.Stop();
        multiplayerMenue multiplayerMenue = new multiplayerMenue();
        multiplayerMenue.ShowDialog();
        FormManager.openForms.Add(multiplayerMenue);

    }
}
