namespace _03.Santase.GameLogic
{
    public interface IGameRules
    {
        int RoundPointsForGoingOut { get; }

        int HalfRoundPoints { get; }

        int GamePointsNeededForWin { get; }
    }
}
