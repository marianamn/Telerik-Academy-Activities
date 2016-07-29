namespace _03.Santase.GameLogic.GameMechanics
{
    public interface ISantaseGame
    {
        int FirstPlayerTotalPoints { get; }

        int SecondPlayerTotalPoints { get; }

        int RoundsPlayed { get; }

        PlayerPosition Start(PlayerPosition firstToPlayInFirstRound);
    }
}
