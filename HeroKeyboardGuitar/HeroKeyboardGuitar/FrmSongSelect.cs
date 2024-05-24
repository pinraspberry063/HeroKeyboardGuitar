using HeroKeyboardGuitar.Properties;
using SkiaSharp;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace HeroKeyboardGuitar {
    public partial class FrmSongSelect : Form {
        private readonly string SONGS_ROOT_PATH = $"{Application.StartupPath}../../../Songs/";
        private readonly string HS_ROOT_PATH = $"{Application.StartupPath}../../../HighScores/";

        public FrmSongSelect() {
            InitializeComponent();
        }
        public void FrmSongSelect_Load(object sender, EventArgs e) {
            int top = 50;
            int left = 20;
            const int size = 300;
            const int spacing = 50;
            foreach (var songFilePath in Directory.GetFiles(SONGS_ROOT_PATH)) {
                var song = Path.GetFileNameWithoutExtension(songFilePath);
                var songName = song.Split('_')[0];
                // Check to see if there exists a high score for the song
                var hs_file = HS_ROOT_PATH + songName + ".txt";
                var highscore = "0";
                if (File.Exists(hs_file)) {
                    StreamReader streamReader = File.OpenText(hs_file);
                    highscore = streamReader.ReadLine();
                    streamReader.Close();
                }
                else
                {
                    var high_score_file = File.CreateText(hs_file);
                    
                    high_score_file.Close();
                    StreamWriter sw = new(hs_file);
                    sw.WriteLine(highscore.ToString());
                    sw.Close();

                }
                
                GenreType genre;
                if (!Enum.TryParse(song.Split('_')[1], true, out genre)) {
                    genre = GenreType.COUNTRY;
                }
                Button btnSong = new() {
                    BackgroundImage = Game.GetBg(genre),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Width = size,
                    Height = size,
                    Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(songName.ToLower()),
                    TextAlign = ContentAlignment.BottomCenter,
                    Font = new Font("Arial", 30),
                    ForeColor = Color.Cyan,
                    Top = top,
                    Left = left,
                };
                // Display the High Scores for all the displayed songs
                TextBox High_Score_Viewer = new()
                {
                    Width = size,
                    Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase("High Score: " + highscore),
                    BackColor = Color.Black,
                    Font = new Font("Courier", 20),
                    ForeColor = Color.BlueViolet,
                    BorderStyle = BorderStyle.None,
                    Top = top + size + (spacing / 2),
                    Left = (left - 20) + (spacing / 2),

                };
                left += size + spacing;
                var filePath = songFilePath;
                btnSong.Click += (e, sender) => {
                    Game.SetCurSong(filePath, genre);
                    FrmMain frmMain = new();
                    frmMain.Show();
                };
                Controls.Add(btnSong);
                Controls.Add(High_Score_Viewer);
            }
        }
    }
}
