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
}
