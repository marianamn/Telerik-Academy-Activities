namespace _02.Deck.Tests
{
    using System;
    using NUnit.Framework;
    using _03.Santase.GameLogic.Cards;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void Deck_ShouldContainsTwentyFourCards()
        {
            Deck deck = new Deck();

            var expectetCount = 24;

            Assert.AreEqual(expectetCount, deck.CardsLeft);
        }

        [Test]
        public void TrumpCard_ShouldBeAValidOne()
        {
            Deck deck = new Deck();

            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), deck.TrumpCard.Suit));
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), deck.TrumpCard.Type));
        }

        [Test]
        public void GetNextCard_ShouldReturnAValidCard()
        {
            Deck deck = new Deck();

            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), deck.GetNextCard().Suit));
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), deck.GetNextCard().Type));
        }

        [Test]
        public void GetNextCard_ShouldRemoveTheCardFromDeck()
        {
            Deck deck = new Deck();
            var initialNumberOfCards = deck.CardsLeft;

            var expectedNumberOfCardsAfterGetNextCard = initialNumberOfCards - 1;
            deck.GetNextCard();

            Assert.AreEqual(expectedNumberOfCardsAfterGetNextCard, deck.CardsLeft);
        }

        [TestCase(24)]
        public void GetNextCard_ShouldThrowAnInternalGameExceptionWhenThereAreNoCardsLeftInTheDeck(int cardsToBeDrawn)
        {
            Deck deck = new Deck();

            // take 24 cards from deck - result: no cards left
            for (int i = 0; i < cardsToBeDrawn; i++)
            {
                deck.GetNextCard();
            }

            // take nextCard from empty deck should throw an exception
            Assert.Throws<_03.Santase.GameLogic.InternalGameException>(() => deck.GetNextCard());
        }

        [Test]
        public void ChangeTrumpCard_ShouldChangeTheTrumpCardIfThereAreCardsLeftInTheDeck()
        {
            Deck deck = new Deck();
            var initialTrumpedCard = deck.TrumpCard;

            var newCard = deck.GetNextCard();
            deck.ChangeTrumpCard(newCard);

            Assert.AreNotSame(initialTrumpedCard, deck.TrumpCard);
        }

        [TestCase(24)]
        public void ChangeTrumpCard_ShouldNotChangeTheTrumpCardIfThereAreNoCardsLeftInTheDeck(int cardsToBeDrawn)
        {
            Deck deck = new Deck();
            var initialTrumpedCard = deck.TrumpCard;

            var newCard = new Card(CardSuit.Spade, CardType.Ace);

            for (int i = 0; i < cardsToBeDrawn; i++)
            {
                if (i == cardsToBeDrawn - 1)
                {
                    newCard = deck.GetNextCard();
                }
                else
                {
                    deck.GetNextCard();
                }
            }

            deck.ChangeTrumpCard(newCard);

            Assert.AreEqual(0, deck.CardsLeft, "There should be no cards left in the deck after drawing 24 cards");
            Assert.AreSame(initialTrumpedCard, deck.TrumpCard, "ChangeTrumpCard should not change the trump card when there are no cards left in the deck");
        }
    }
}
