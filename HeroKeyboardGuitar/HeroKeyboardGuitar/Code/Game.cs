using AudioAnalyzing;
using HeroKeyboardGuitar.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace HeroKeyboardGuitar;

/// <summary>
/// 
/// </summary>
public class Game {
    private Dictionary<GenreType, Bitmap> bgMap;

    /// <summary>
    /// 
    /// </summary>
    public Audio CurSong { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public GenreType CurSongGenre { get; private set; }

    private static Game instance = new();

    private Game() {
        bgMap = new() {
            [GenreType.CLASSICAL] = Resources.classical,
            [GenreType.COUNTRY] = Resources.country,
            [GenreType.METAL] = Resources.metal,
            [GenreType.POP] = Resources.pop,
            [GenreType.RNB] = Resources.rnb,
            [GenreType.ROCK] = Resources.rock,
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static Game GetInstance() {
        return instance;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static Dictionary<int, Action> GetRewardMap() {
        //return instance.CurSong.re
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Bitmap GetBg() {
        return bgMap.GetValueOrDefault(CurSongGenre, null);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="genre"></param>
    /// <returns></returns>
    public static Bitmap GetBg(GenreType genre) {
        return instance.bgMap[genre];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="song"></param>
    public static void SetCurSong(Audio song) {
        GetInstance().CurSong = song;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="songFilePath"></param>
    /// <param name="genre"></param>
    public static void SetCurSong(string songFilePath, GenreType genre) {
        instance.CurSong = new(songFilePath);
        instance.CurSongGenre = genre;
    }
}
