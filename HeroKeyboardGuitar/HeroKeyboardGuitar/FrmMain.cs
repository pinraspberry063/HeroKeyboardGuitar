using AudioAnalyzing;
using HeroKeyboardGuitar.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

internal partial class FrmMain : Form
{
    private List<Note> notes;
    public float noteSpeed;
    private Audio curSong;
    private Score score;
    private Timer time;


    // for double buffering
    protected override CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
            return cp;
        }
    }

    public FrmMain()
    {
        InitializeComponent();
    }

    public void FrmMain_Load(object sender, EventArgs e)
    {
   // public void FrmMain_Load(object sender, EventArgs e) {
        noteSpeed = FrmMenu.NoteSpeed;
        score = new();
        lblScore.Text = score.Amount.ToString();
        lblStreak.Text = "COMBO: " + score.Streak.ToString();
        panBg.BackgroundImage = Game.GetInstance().GetBg();
        panBg.Height = (int)(Height * 0.8);
        curSong = Game.GetInstance().CurSong;
        notes = new();
        if (Game.GetInstance().mode == "Color Blind Mode")
        {
            picTarget.BackgroundImage = Properties.Resources.defaultcb;
        }
        foreach (var actionTime in curSong.ActionTimes)
        {
            double x = actionTime * noteSpeed + picTarget.Left + picTarget.Width;
            const int noteSize = 50;
            if (notes.Any(note => (x - note.Pic.Left) < noteSize / 2))
            {
                continue;
            }
            PictureBox picNote = new()
            {
                BackColor = Color.Black,
                ForeColor = Color.Black,
                Width = noteSize,
                Height = noteSize,
                Top = picTarget.Top + picTarget.Height / 2 - noteSize / 2,
                Left = (int)x,
                BackgroundImage = Resources.marker,
                BackgroundImageLayout = ImageLayout.Stretch,
                Anchor = AnchorStyles.Bottom,
            };
            Controls.Add(picNote);
            notes.Add(new(picNote, x));
            if(Game.GetInstance().mode == "Color Blind Mode")
            {
                picNote.BackgroundImage = Resources.markercb;
            }     
        }
        Timer tmrWaitThenPlay = new()
        {
            Interval = 1000,
            Enabled = true,
        };
        components.Add(tmrWaitThenPlay);
        tmrWaitThenPlay.Tick += (e, sender) =>
        {
            Game.GetInstance().CurSong.Play();
            tmrWaitThenPlay.Enabled = false;
            tmrPlay.Enabled = true;
        };
    }

    private void tmrPlay_Tick(object sender, EventArgs e)
    {
        int index = curSong.GetPosition();
        foreach (var note in notes)
        {
            note.Move(tmrPlay.Interval * (noteSpeed * 1.3));
            if (note.CheckMiss(picTarget))
            {
                score.Miss();
                streakBar.Value = 0;
                lblStreak.Font = new("Arial", 10);
                lblStreak.Text = "COMBO: " + score.Streak.ToString();
            }
        }
        if (index >= curSong.GetNumberOfSamples() - 1)
        {
            tmrPlay.Enabled = false;
            foreach (var note in notes)
            {
                Controls.Remove(note.Pic);
                note.Dispose();
            }
        }
    }

  

  

    private void FrmMain_KeyDown(object sender, KeyEventArgs e)
    {
        // used to determine if key is being held down
        time = new()
        {
            Interval = 10,
            Enabled = true,
        };
        time.Start();
        
        if (Game.GetInstance().mode == "Color Blind Mode")
        {
            picTarget.BackgroundImage = Resources.pressedcb;
        }
        else { picTarget.BackgroundImage = Resources.pressed; }
        
        
         

    }

    private void FrmMain_KeyUp(object sender, KeyEventArgs e)
    {
        
        if (Game.GetInstance().mode == "Color Blind Mode")
        {
            picTarget.BackgroundImage = Resources.defaultcb;
        }
        else { picTarget.BackgroundImage = Resources._default; }

    private void FrmMain_KeyPress(object sender, KeyPressEventArgs e) {
        foreach (var note in notes) {
            if (note.CheckHit(picTarget)) {
                score.Add(1);
                    streakBar.PerformStep();
                    // Increase streak font size with each hit
                    if (lblStreak.Font.Size < 60)
                    {
                        lblStreak.Font = new("Arial", lblStreak.Font.Size + 2);
                    }
                    lblStreak.Text = "COMBO: " + score.Streak.ToString();
                    lblScore.Text = score.Amount.ToString();
                lblScore.Font = new("Arial", 42);
                break;
            }
        }
    }

    private void FrmMain_KeyDown(object sender, KeyEventArgs e) {
        picTarget.BackgroundImage = Resources.pressed;
    }

    private void FrmMain_KeyUp(object sender, KeyEventArgs e) {
        picTarget.BackgroundImage = Resources._default;
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        Game.GetInstance().CurSong.Stop();
        var HighScore_File = $"{Application.StartupPath}../../../HighScores/" + Game.GetInstance().CurSongName + ".txt";
        StreamReader sr = new StreamReader(HighScore_File);
        var curr_hs =Int32.Parse(sr.ReadLine());
        sr.Close();
        if (curr_hs < Int32.Parse(lblScore.Text))
        {
            StreamWriter sw = new StreamWriter(HighScore_File, false);
            sw.Write(lblScore.Text.ToString());
            sw.Close();
        }
        // Reload the SongSelect Menu upon finishing a song
        FrmMenu.SongMenu.Close();
        FrmMenu.SongMenu = new FrmSongSelect();
        FrmMenu.SongMenu.Show();
    }

    private void tmrScoreShrink_Tick(object sender, EventArgs e)
    {
        if (lblScore.Font.Size > 20)
        {
            lblScore.Font = new("Arial", lblScore.Font.Size - 1);
        }
    }

    
}
