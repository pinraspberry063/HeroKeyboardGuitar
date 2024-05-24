
using NAudio.Wave;
using System;
using System.Windows.Forms;
namespace HeroKeyboardGuitar;

/// <summary>
/// Holds the current score and streak of the player
/// </summary>
public class Score {
    private static string SOUND_ROOT_PATH = $"{Application.StartupPath}../../../Sounds/sound25/";
    AudioFileReader sound25 = new AudioFileReader("C: \Users\keith\source\repos\HeroKeyboardGuitar\HeroKeyboardGuitar\HeroKeyboardGuitar\Sounds\sound25");
    //AudioFileReader sound50 = new AudioFileReader(SOUND_ROOT_PATH + "sound50/");
    //AudioFileReader sound100 = new AudioFileReader(SOUND_ROOT_PATH + "sound100/");
    WaveOutEvent outputDevice25 = new WaveOutEvent();
    //WaveOutEvent outputDevice50 = new WaveOutEvent();
    //WaveOutEvent outputDevice100 = new WaveOutEvent();

    /// <summary>
    /// Amount of notes successfully hit
    /// </summary>
    public int Amount { get; private set; }

    /// <summary>
    /// Current streak, i.e. consecutive hit notes without a miss
    /// </summary>
    public int Streak { get; private set; }

    /// <summary>
    /// initializes amount, streak, and sounds
    /// </summary>
    public Score() {
        Amount = 0;
        Streak = 0;
        Console.WriteLine(SOUND_ROOT_PATH);
        outputDevice25.Init(sound25);
        //outputDevice50.Init(sound50);
        //outputDevice100.Init(sound100);
    }


    /// <summary>
    /// Add to the current score
    /// </summary>
    /// <param name="amount">Amount to add</param>
    public void Add(int amount) {
        if (Streak >= 5)
        {
            Amount += amount * 2;
            Streak++;
        }
        else if (Streak >= 10)
        {
            Amount += amount * 3;
            Streak++;
        }
        else if (Streak >= 20)
        {
            Amount += amount * 4;
            Streak++;
        }
        else
        {
            Amount += amount;
            Streak++;
        }

        switch (Streak)
        {
            case 3:
                outputDevice25.Play();
                break;
            case 50:
                //outputDevice50.Play();
                break;
            case 100:
                //outputDevice100.Play();
                break;
            default:
                break;
        }
    }


    /// <summary>
    /// Resets streak back to 0
    /// </summary>
    public void Miss() {
        Streak = 0;
    }
}
