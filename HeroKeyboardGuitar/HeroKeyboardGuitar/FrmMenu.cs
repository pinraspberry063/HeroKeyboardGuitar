using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroKeyboardGuitar
{

    public partial class FrmMenu : Form
    {
        public static Dictionary<string, string> settings = new();
        public FrmMenu()
        {
            settings.Clear();
            InitializeComponent();
        }

        public static string getSettings(string key)
        {
            return settings[key];
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            settings["mode"] = ModeDropDown.Text;
            FrmSongSelect frmSongSelect = new();
            frmSongSelect.Show();
        }

        
    }
}
