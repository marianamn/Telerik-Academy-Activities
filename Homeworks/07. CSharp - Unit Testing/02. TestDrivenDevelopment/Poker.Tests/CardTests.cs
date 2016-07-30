namespace Poker.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CardTests
    {
        [Test]
        public void Card_ToString_ShouldReturnTheCardFaceAndTheCardSuitWhenTheCardIsAnAce()
        {
            Card testCard = new Card(CardFace.Ace, CardSuit.Spades);

            string expectedResult = "A♠";

            Assert.AreEqual(expectedResult, testCard.ToString());
        }

        [Test]
        public void Card_ToString_ShouldReturnTheCardFaceAndTheCardSuitWhenTheCardIsAKing()
        {
            Card testCard = new Card(CardFace.King, CardSuit.Spades);

            string expectedResult = "K♠";

            Assert.AreEqual(expectedResult, testCard.ToString());
        }

        [Test]
        public void Card_ToString_ShouldReturnTheCardFaceAndTheCardSuitWhenTheCardIsAJack()
        {
            Card testCard = new Card(CardFace.Jack, CardSuit.Hearts);

            string expectedResult = "J♥";

            Assert.AreEqual(expectedResult, testCard.ToString());
        }

        [Test]
        public void Card_ToString_ShouldReturnTheCardFaceAndTheCardSuitWhenTheCardIsAQueen()
        {
            Card testCard = new Card(CardFace.Queen, CardSuit.Hearts);

            string expectedResult = "Q♥";

            Assert.AreEqual(expectedResult, testCard.ToString());
        }

        [Test]
        public void Card_ToString_ShouldReturnTheCardFaceAndTheCardSuitWhenTheCardIsANumberCard()
        {
            Card testCard = new Card(CardFace.Five, CardSuit.Diamonds);

            string expectedResult = "5♦";

            Assert.AreEqual(expectedResult, testCard.ToString());
        }
    }
}
