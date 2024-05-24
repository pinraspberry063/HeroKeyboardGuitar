using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;
internal partial class FrmTitle : Form
{
    public FrmTitle()
    {
        InitializeComponent();
    }

    private void btnStart_Click(object sender, EventArgs e) {
        
        FrmMenu frmMenu = new FrmMenu();
        frmMenu.Show();
    }

    private void FrmTitle_Load(object sender, EventArgs e)
    {
        btnStart.Left = Width / 2 - btnStart.Width / 2;
        btnStart.Top = (int)(Height * 0.65);
    }

    private void changeDifficulty(object sender, EventArgs e)
    {
        if (DifficultyBox.SelectedItem == null)
        {
            NoteSpeed = 0.5f;
        }
        else if (DifficultyBox.SelectedItem.ToString() == "Easy")
        {
            NoteSpeed = 0.25f;
        }
        else if (DifficultyBox.SelectedItem.ToString() == "Medium")
        {
            NoteSpeed = 0.5f;
        }
        else if (DifficultyBox.SelectedItem.ToString() == "Hard")
        {
            NoteSpeed = 0.75f;
        }

    }
    public static float NoteSpeed = 0.5f;
}
