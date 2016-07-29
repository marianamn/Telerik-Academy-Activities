namespace _03.Santase.GameLogic.Cards
{
    public interface IDeck
    {
        Card TrumpCard { get; }

        int CardsLeft { get; }

        Card GetNextCard();

        void ChangeTrumpCard(Card newCard);
    }
}
