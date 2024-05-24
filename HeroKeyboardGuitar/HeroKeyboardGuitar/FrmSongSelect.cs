using HeroKeyboardGuitar.Properties;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace HeroKeyboardGuitar {
    internal partial class FrmSongSelect : Form {
        private readonly string SONGS_ROOT_PATH = $"{Application.StartupPath}../../../Songs/";

        public FrmSongSelect() {
            InitializeComponent();
        }

        private void FrmSongSelect_Load(object sender, EventArgs e) {
            int top = 50;
            int left = 20;
            const int size = 300;
            const int spacing = 50;
            int songBtnCounter = 0;
            foreach (var songFilePath in Directory.GetFiles(SONGS_ROOT_PATH))
            {
                if (songBtnCounter < 15) // Prevent user from having more than 15 songs
                {
                    var song = Path.GetFileNameWithoutExtension(songFilePath);
                    var songName = song.Split('_')[0];
                    GenreType genre;
                    if (!Enum.TryParse(song.Split('_')[1], true, out genre))
                    {
                        genre = GenreType.COUNTRY;
                    }
                    Button btnSong = new()
                    {
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
                    songBtnCounter++;
                    // Start a new row of songs after every 5 songs
                    if (songBtnCounter % 5 == 0)
                    {
                        top += size + spacing;
                        left = 20;
                    }
                    else
                    {
                        left += size + spacing;
                    }
                    var filePath = songFilePath;
                    btnSong.Click += (e, sender) =>
                    {
                        Game.SetCurSong(filePath, genre);
                        FrmMain frmMain = new();
                        frmMain.Show();
                    };
                    Controls.Add(btnSong);
                }
                else
                {
                    MessageBox.Show("You've reached the max amount of songs. Go to the songs folder under the game's folder and delete some songs.");
                }
            }
            }
        }
    }

