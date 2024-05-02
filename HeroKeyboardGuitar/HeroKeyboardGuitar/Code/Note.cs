using HeroKeyboardGuitar.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

/// <summary>
/// 
/// </summary>
public enum NoteState {
    /// <summary>
    /// 
    /// </summary>
    TRAVELING,

    /// <summary>
    /// 
    /// </summary>
    HIT,

    /// <summary>
    /// 
    /// </summary>
    MISS,
}

/// <summary>
/// 
/// </summary>
public class Note {
    /// <summary>
    /// 
    /// </summary>
    public NoteState State { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public PictureBox Pic { get; private set; }

    private double xPos;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pic"></param>
    /// <param name="xPos"></param>
    public Note(PictureBox pic, double xPos) {
        Pic = pic;
        State = NoteState.TRAVELING;
        this.xPos = xPos;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Dispose() {
        Pic.Dispose();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    public void Move(double amount) {
        xPos -= amount;
        Pic.Left = (int)xPos;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="picTarget"></param>
    /// <returns></returns>
    public bool CheckHit(PictureBox picTarget) {
        if (Pic.Left < picTarget.Left + picTarget.Width && Pic.Left + Pic.Width > picTarget.Left && State == NoteState.TRAVELING) {
            Pic.BackgroundImage = Resources.marker_hit;
            State = NoteState.HIT;
            return true;
        }
        else {
            return false;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="picTarget"></param>
    /// <returns></returns>
    public bool CheckMiss(PictureBox picTarget) {
        if (Pic.Left < picTarget.Left && State == NoteState.TRAVELING) {
            Pic.BackgroundImage = Resources.marker_miss;
            State = NoteState.MISS;
            return true;
        }
        else {
            return false;
        }
    }
}
