namespace HeroKeyboardGuitar;

/// <summary>
/// 
/// </summary>
public class Score {
    /// <summary>
    /// 
    /// </summary>
    public int Amount { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public int Streak { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public Score() {
        Amount = 0;
        Streak = 0;
    }

    /// <summary>
    /// 
    /// </summary>
    public void CheckReward() {
        // TODO: possibly make this a dictionary mapping genres to reward maps
        //Game.GetRewardMap()
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    public void Add(int amount) {
        Amount += amount;
        Streak++;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Miss() {
        Streak = 0;
    }
}
