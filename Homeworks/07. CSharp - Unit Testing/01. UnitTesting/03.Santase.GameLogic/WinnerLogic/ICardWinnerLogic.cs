namespace _03.Santase.GameLogic.WinnerLogic
{
    using Cards;
    public interface ICardWinnerLogic
    {
        PlayerPosition Winner(Card firstPlayerCard, Card secondPlayerCard, CardSuit trumpSuit);
    }
}
