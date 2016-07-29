namespace _03.Santase.GameLogic.PlayerActionValidate
{
    using RoundStates;

    internal static class CloseGameActionValidator
    {
        public static bool CanCloseGame(bool isThePlayerFirst, BaseRoundState state)
        {
            return isThePlayerFirst && state.CanClose;
        }
    }
}
