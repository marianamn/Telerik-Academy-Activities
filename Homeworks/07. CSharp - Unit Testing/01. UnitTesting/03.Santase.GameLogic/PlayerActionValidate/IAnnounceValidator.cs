namespace _03.Santase.GameLogic.PlayerActionValidate
{
    using Cards;
    using System.Collections.Generic;

    public interface IAnnounceValidator
    {
        Announce GetPossibleAnnounce(
            ICollection<Card> playerCards,
            Card cardToBePlayed,
            Card trumpCard,
            bool amITheFirstPlayer = true);
    }
}
