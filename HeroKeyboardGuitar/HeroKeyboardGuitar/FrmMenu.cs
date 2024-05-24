using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeroKeyboardGuitar
{

    public partial class FrmMenu : Form
    {
        public static Dictionary<string, string> settings = new();
        private readonly string SONGS_ROOT_PATH = $"{Application.StartupPath}../../../Songs/";
        private GenreType genre;
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
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WAV files (*.wav)|*.wav";
            openFileDialog.Title = "Select a .wav song file!";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                FrmGenreSelect genreSelect = new();
                genreSelect.ShowDialog();
                if (genreSelect.ShowDialog() == DialogResult.OK)
                {


                    // Make sure chosen file has a .wav extension
                    if (Path.GetExtension(filePath).ToLower() == ".wav")
                    {
                        // Formating song file by adding "_GENRE" to the end of the file name 
                        string songNameWithGenre = Path.GetFileNameWithoutExtension(filePath) +
                                 "_" +
                                 genreSelect.selectedGenre +
                                 Path.GetExtension(filePath);
                        string destinationPath = Path.Combine(SONGS_ROOT_PATH, songNameWithGenre);

                        try
                        {
                            // Move the song file to the "Songs" folder
                            File.Move(filePath, destinationPath);
                            MessageBox.Show("Song added!");
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Error moving file: " + exc.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must select a .wav file.");
                    }
                }
            }
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
}
