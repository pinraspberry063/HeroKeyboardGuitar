using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeroKeyboardGuitar
{
    public partial class FrmGenreSelect : Form
    {
        public string selectedGenre;
        public FrmGenreSelect()
        {
            InitializeComponent();
            genreDropdown.Items.AddRange(Enum.GetNames(typeof(GenreType))); // Populate drop down with genres
            
        }
        // Force the user to pick a genre
        private void finishBtn_Click(object sender, EventArgs e)
        {
            if (genreDropdown.SelectedItem != null)
            {
                selectedGenre = genreDropdown.SelectedItem.ToString();
                DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Please select a genre.");
            }
        }

        private void InitializeComponent()
        {
            genreDropdown = new System.Windows.Forms.ComboBox();
            finishBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // genreDropdown
            // 
            genreDropdown.FormattingEnabled = true;
            genreDropdown.Location = new Point(12, 22);
            genreDropdown.Name = "genreDropdown";
            genreDropdown.Size = new Size(268, 28);
            genreDropdown.TabIndex = 0;
            // 
            // finishBtn
            // 
            finishBtn.Location = new Point(186, 71);
            finishBtn.Name = "finishBtn";
            finishBtn.Size = new Size(94, 29);
            finishBtn.TabIndex = 1;
            finishBtn.Text = "Finish";
            finishBtn.TextImageRelation = TextImageRelation.TextAboveImage;
            finishBtn.UseVisualStyleBackColor = true;
            finishBtn.Click += finishBtn_Click;
            // 
            // FrmGenreSelect
            // 
            ClientSize = new Size(292, 112);
            Controls.Add(finishBtn);
            Controls.Add(genreDropdown);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGenreSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "What genre best fits the new song?";
            Load += FrmGenreSelect_Load;
            ResumeLayout(false);
        }

        private void FrmGenreSelect_Load(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.ComboBox genreDropdown;
    }
}
