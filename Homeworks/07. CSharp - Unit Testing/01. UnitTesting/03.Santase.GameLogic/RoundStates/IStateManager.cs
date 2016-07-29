namespace _03.Santase.GameLogic.RoundStates
{
    public interface IStateManager
    {
        BaseRoundState State { get; }

        void SetState(BaseRoundState newState);
    }
}
