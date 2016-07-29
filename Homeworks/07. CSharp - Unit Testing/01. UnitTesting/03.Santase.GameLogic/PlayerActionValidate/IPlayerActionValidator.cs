namespace _03.Santase.GameLogic.PlayerActionValidate
{
    using Cards;
    using Players;
    using System.Collections.Generic;


    public interface IPlayerActionValidator
    {
        bool IsValid(PlayerAction action, PlayerTurnContext context, ICollection<Card> playerCards);

        ICollection<Card> GetPossibleCardsToPlay(PlayerTurnContext context, ICollection<Card> playerCards);
    }
}
