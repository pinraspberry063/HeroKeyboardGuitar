using AudioAnalyzing;
using HeroKeyboardGuitar.Properties;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

internal partial class FrmMain : Form
{
    private List<Note> notes;
    public float noteSpeed;
    private Audio curSong;
    private Score score;
    private Timer time;
    private int xPos;
    public PictureBox currTarget { get; private set; }
    private Random random;

   

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

    public PictureBox GetCurrentTarget()
    {
        return this.currTarget;
    }
    
    public void FrmMain_Load(object sender, EventArgs e) {
        noteSpeed = FrmMenu.NoteSpeed;
        score = new();
          
        lblScore.Text = score.Amount.ToString();
        panBg.BackgroundImage = Game.GetInstance().GetBg();
        panBg.Height = (int)(Height * 0.8);
        curSong = Game.GetInstance().CurSong;
        currTarget = pictargets["default"];
        notes = new();
        xPos = currTarget.Left + currTarget.Width / 2;
        if (Game.GetInstance().mode == "Color Blind Mode")
        {
            currTarget.BackgroundImage = Properties.Resources.defaultcb;
        }
        foreach (var actionTime in curSong.ActionTimes)
        {
            double yPos = actionTime * noteSpeed - panBg.Height*40;
            const int noteSize = 50;
            if (notes.Any(note => (yPos - note.Pic.Top) < noteSize / 2))
            {
                continue;
            }
            PictureBox picNote = new()
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Width = noteSize,
                Height = noteSize,
                Top = (int)yPos,
                Left = xPos - noteSize / 2,
                BackgroundImage = Resources.marker,
                BackgroundImageLayout = ImageLayout.Stretch,
                //Anchor = AnchorStyles.Bottom,
                
            };
            random = new();
            
            var rnd = random.Next(0, 3);
           
            switch(rnd)
            {
                
                // green
                case 0:
                    currTarget = new();
                    currTarget = pictargets["green"];
                    xPos = currTarget.Left + currTarget.Width / 2 - noteSize / 2;

                    picNote.BackgroundImage = Resources.marker;
                    break;
                // Red
                case 1:
                    currTarget = new();
                    currTarget = pictargets["red"];
                    xPos = currTarget.Left + currTarget.Width / 2 - noteSize / 2;

                    picNote.BackgroundImage = Resources.marker_red;
                    break;
                // Blue
                case 2:
                    currTarget = new();
                    currTarget = pictargets["blue"];
                    xPos = currTarget.Left + currTarget.Width / 2 - noteSize / 2;
                    
                    picNote.BackgroundImage = Resources.marker_blue;
                    break;
                default:
                    currTarget = new();
                    currTarget = pictargets["default"];
                    xPos = currTarget.Left + currTarget.Width / 2 - noteSize / 2;
                    picNote.BackgroundImage = Resources.marker;
                    break;
                

            }
            picNote.Left = xPos;
            Controls.Add(picNote);
            picNote.BringToFront();
            notes.Add(new(picNote, xPos - noteSize / 2, yPos ));
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
            if (note.CheckMiss(currTarget))
            {
                score.Miss();
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
        
        switch(e.KeyCode)
        {
            case Keys.NumPad5:
                currTarget = pictargets["red"];
                currTarget.BackgroundImage = Resources.pressed_red;
                break;
            case Keys.NumPad4:
                currTarget = pictargets["green"];
                currTarget.BackgroundImage = Resources.pressed;
                break;
            case Keys.NumPad6:
                currTarget = pictargets["blue"];
                currTarget.BackgroundImage = Resources.pressed_blue;
                break;
            default:
                break;


        }
        if (Game.GetInstance().mode == "Color Blind Mode")
        {
            currTarget.BackgroundImage = Resources.pressedcb;
        }
        //else { currTarget.BackgroundImage = Resources.pressed; }
        
        
         

    }

    private void FrmMain_KeyUp(object sender, KeyEventArgs e)
    {
        
        if (Game.GetInstance().mode == "Color Blind Mode")
        {
            currTarget.BackgroundImage = Resources.defaultcb;
        }
        else { currTarget.BackgroundImage = Resources._default; }

        // Checks to see of the key is being held down or if it is actually being clicked
        
        switch (e.KeyCode)
        {
            case Keys.NumPad5:
                currTarget = pictargets["red"];
                currTarget.BackgroundImage = Resources.default_red;
                break;
            case Keys.NumPad4:
                currTarget = pictargets["green"];
                currTarget.BackgroundImage = Resources._default;
                break;
            case Keys.NumPad6:
                currTarget = pictargets["blue"];
                currTarget.BackgroundImage = Resources.default_blue;
                break;
            default:
                break;
        }
        if (time.Interval < 1000)
        {
            foreach (var note in notes)
            {
                if (note.CheckHit(currTarget))
                {
                    score.Add(1);
                    lblScore.Text = score.Amount.ToString();
                    lblScore.Font = new("Arial", 42);

                    break;

                }
            }
        }

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
