namespace _03.Santase.GameLogic.PlayerActionValidate
{
    using Cards;
    using RoundStates;
    using System.Collections.Generic;

    internal static class ChangeTrumpActionValidator
    {
        public static bool CanChangeTrump(bool isThePlayerFirst, BaseRoundState state, Card trumpCard, ICollection<Card> playerCards)
        {
            if (!isThePlayerFirst)
            {
                return false;
            }

            if (!state.CanChangeTrump)
            {
                return false;
            }

            return playerCards.Contains(new Card(trumpCard.Suit, CardType.Nine));
        }
    }
}
