namespace Poker.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class PokerHandsCheckerTests
    {
        private PokerHandsChecker handsChecker = new PokerHandsChecker();

        // IsValidHand() tests
        [Test]
        public void PokerHandsChecker_IsValidHand_ShouldReturnTrueIfTheHandIsConsistsOfExactlyFiveDifferentCards()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Ace, CardSuit.Clubs),
                                   new Card(CardFace.Ten, CardSuit.Spades),
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Eight, CardSuit.Clubs),
                                   new Card(CardFace.Eight, CardSuit.Diamonds)
                                });

            Assert.IsTrue(this.handsChecker.IsValidHand(hand));
        }

        [Test]
        public void PokerHandsChecker_IsValidHand_ShouldReturnFalseIfTheHandDoesNotConsistsOfFiveDifferentCards()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Ace, CardSuit.Clubs),
                                   new Card(CardFace.Ace, CardSuit.Clubs),
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Eight, CardSuit.Clubs),
                                   new Card(CardFace.Eight, CardSuit.Diamonds)
                                });

            Assert.IsFalse(this.handsChecker.IsValidHand(hand));
        }

        [Test]
        public void PokerHandsChecker_IsValidHand_ShouldReturnFalseIfTheHandDoesNotConsistsOfFiveCards()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Ace, CardSuit.Clubs),
                                   new Card(CardFace.Ace, CardSuit.Clubs),
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Eight, CardSuit.Clubs)
                                });

            Assert.IsFalse(this.handsChecker.IsValidHand(hand));
        }

        // IsStraightFlush() tests
        [Test]
        public void PokerHandsChecker_IsStraightFlush_ShouldReturnTrueIfTheHandConsistOfFiveConsecutiveCardsFromTheSameSuit()
        {
            // Q♥ J♥ 10♥ 9♥ 8♥
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Queen, CardSuit.Hearts),
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Ten, CardSuit.Hearts),
                                   new Card(CardFace.Nine, CardSuit.Hearts),
                                   new Card(CardFace.Eight, CardSuit.Hearts)
                                });

            Assert.IsTrue(this.handsChecker.IsStraightFlush(hand));
        }

        [Test]
        public void PokerHandsChecker_IsStraightFlush_ShouldReturnFalseIfTheHandDoesNotConsistsOfFiveCards()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Ace, CardSuit.Hearts),
                                   new Card(CardFace.Ace, CardSuit.Hearts),
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Eight, CardSuit.Hearts)
                                });

            Assert.IsFalse(this.handsChecker.IsValidHand(hand));
        }

        [Test]
        public void PokerHandsChecker_IsStraightFlush_ShouldReturnFalseIfTheHandConsistOfFiveConsecutiveCardsFromDifferentSuit()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Queen, CardSuit.Hearts),
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Ten, CardSuit.Hearts),
                                   new Card(CardFace.Nine, CardSuit.Hearts),
                                   new Card(CardFace.Eight, CardSuit.Diamonds)
                                });

            Assert.IsFalse(this.handsChecker.IsStraightFlush(hand));
        }

        [Test]
        public void PokerHandsChecker_IsStraightFlush_ShouldReturnFalseIfTheHandConsistOfFiveNoneConsecutiveCardsFromTheSameSuit()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Queen, CardSuit.Hearts),
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Ten, CardSuit.Hearts),
                                   new Card(CardFace.Nine, CardSuit.Hearts),
                                   new Card(CardFace.Five, CardSuit.Hearts)
                                });

            Assert.IsFalse(this.handsChecker.IsStraightFlush(hand));
        }

        // IsFlush() tests
        [Test]
        public void PokerHandsChecker_IsFlush_ShouldReturnTrueIfTheHandConsistsOfFiveNoneConsecutiveCardsWithTheSameSuit()
        {
            // K♣ 10♣ 7♣ 6♣ 4♣
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.King, CardSuit.Clubs),
                                   new Card(CardFace.Ten, CardSuit.Clubs),
                                   new Card(CardFace.Seven, CardSuit.Clubs),
                                   new Card(CardFace.Six, CardSuit.Clubs),
                                   new Card(CardFace.Four, CardSuit.Clubs)
                                });

            Assert.IsTrue(this.handsChecker.IsFlush(hand));
        }
        
        [Test]
        public void PokerHandsChecker_IsFlush_ShouldReturnFalseIfTheHandConsistsOfFiveNoneConsecutiveCardsWithDifferentSuit()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.King, CardSuit.Diamonds),
                                   new Card(CardFace.Ten, CardSuit.Clubs),
                                   new Card(CardFace.Seven, CardSuit.Clubs),
                                   new Card(CardFace.Six, CardSuit.Clubs),
                                   new Card(CardFace.Four, CardSuit.Clubs)
                                });

            Assert.IsFalse(this.handsChecker.IsFlush(hand));
        }

        [Test]
        public void PokerHandsChecker_IsFlush_ShouldReturnFalseIfTheHandConsistsOfFiveConsecutiveCardsWithTheSameSuit()
        {
            Hand hand = new Hand(
                             new List<ICard>
                                 {
                                   new Card(CardFace.Queen, CardSuit.Hearts),
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Ten, CardSuit.Hearts),
                                   new Card(CardFace.Nine, CardSuit.Hearts),
                                   new Card(CardFace.Eight, CardSuit.Hearts)
                                 });

            Assert.IsFalse(this.handsChecker.IsFlush(hand));
        }

        // IsFourOfAKind() tests
        [Test]
        public void PokerHandsChecker_IsFourOfAKind_ShouldReturnTrueIfTheHandConsistsOfFourCardsFromDifferentSuitsAndTheSameFaceAndOneDifferentCard()
        {
            // 9♣ 9♠ 9♦ 9♥ J♥
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Nine, CardSuit.Clubs),
                                   new Card(CardFace.Nine, CardSuit.Spades),
                                   new Card(CardFace.Nine, CardSuit.Diamonds),
                                   new Card(CardFace.Nine, CardSuit.Hearts),
                                   new Card(CardFace.Jack, CardSuit.Hearts)
                                });

            Assert.IsTrue(this.handsChecker.IsFourOfAKind(hand));
        }

        public void PokerHandsChecker_IsFourOfAKind_ShouldReturnFalseIfTheHandConsistsOfFourCards()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Nine, CardSuit.Clubs),
                                   new Card(CardFace.Nine, CardSuit.Spades),
                                   new Card(CardFace.Nine, CardSuit.Diamonds),
                                   new Card(CardFace.Nine, CardSuit.Hearts)
                                });

            Assert.IsFalse(this.handsChecker.IsFourOfAKind(hand));
        }

        [Test]
        public void PokerHandsChecker_IsFourOfAKind_ShouldReturnFalseIfTheHandConsistsOfFourCardsFromDifferentSuitsButDifferendFace()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Nine, CardSuit.Clubs),
                                   new Card(CardFace.Nine, CardSuit.Spades),
                                   new Card(CardFace.Nine, CardSuit.Diamonds),
                                   new Card(CardFace.Nine, CardSuit.Clubs),
                                   new Card(CardFace.Jack, CardSuit.Hearts)
                                });

            Assert.IsFalse(this.handsChecker.IsFourOfAKind(hand));
        }
        
        [Test]
        public void PokerHandsChecker_IsFourOfAKind_ShouldReturnFalseIfTFourOfTheCardsDoesNOtHaveTheSameFace()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Nine, CardSuit.Clubs),
                                   new Card(CardFace.Nine, CardSuit.Spades),
                                   new Card(CardFace.Nine, CardSuit.Diamonds),
                                   new Card(CardFace.Eight, CardSuit.Hearts),
                                   new Card(CardFace.Jack, CardSuit.Hearts)
                                });

            Assert.IsFalse(this.handsChecker.IsFourOfAKind(hand));
        }

        // IsHighCard() tests
        [Test]
        public void PokerHandsChecker_IsHighCard_ShouldReturnTrueIfThereIsHighCardInHand()
        {
            //K♥ J♥ 8♣ 7♦ 4♠
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.King, CardSuit.Hearts),
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Eight, CardSuit.Clubs),
                                   new Card(CardFace.Seven, CardSuit.Diamonds),
                                   new Card(CardFace.Four, CardSuit.Spades)
                                });

            Assert.IsTrue(this.handsChecker.IsHighCard(hand));
        }

        // IsOnePair() tests
        [Test]
        public void PokerHandsChecker_IsOnePair_ShouldReturnTrueIfThereAreOnePairOfTwoEqualCard()
        {
            //4♥ 4♠ K♠ 10♦ 5♠
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Four, CardSuit.Hearts),
                                   new Card(CardFace.Four, CardSuit.Spades),
                                   new Card(CardFace.King, CardSuit.Spades),
                                   new Card(CardFace.Ten, CardSuit.Diamonds),
                                   new Card(CardFace.Five, CardSuit.Spades)
                                });

            Assert.IsTrue(this.handsChecker.IsOnePair(hand));
        }
        
        [Test]
        public void PokerHandsChecker_IsOnePair_ShouldReturnFalseIfThereAreNoPairOfTwoEqualCard()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Four, CardSuit.Hearts),
                                   new Card(CardFace.Five, CardSuit.Spades),
                                   new Card(CardFace.King, CardSuit.Spades),
                                   new Card(CardFace.Ten, CardSuit.Diamonds),
                                   new Card(CardFace.Five, CardSuit.Spades)
                                });

            Assert.IsFalse(this.handsChecker.IsOnePair(hand));
        }

        // IsTwoPair() tests
        [Test]
        public void PokerHandsChecker_IsTwoPair_ShouldReturnTrueIfThereAreTwoPairOfTwoEqualCard()
        {
            // J♥ J♣ 4♣ 4♠ 9♥
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.Jack, CardSuit.Clubs),
                                   new Card(CardFace.Four, CardSuit.Clubs),
                                   new Card(CardFace.Four, CardSuit.Spades),
                                   new Card(CardFace.Nine, CardSuit.Hearts)
                                });

            Assert.IsTrue(this.handsChecker.IsTwoPair(hand));
        }

        [Test]
        public void PokerHandsChecker_IsTwoPair_ShouldReturnFalseIfThereAreNotTwoPairOfTwoEqualCard()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Jack, CardSuit.Hearts),
                                   new Card(CardFace.King, CardSuit.Clubs),
                                   new Card(CardFace.Four, CardSuit.Clubs),
                                   new Card(CardFace.Four, CardSuit.Spades),
                                   new Card(CardFace.Nine, CardSuit.Hearts)
                                });

            Assert.IsFalse(this.handsChecker.IsTwoPair(hand));
        }


        // IsStraight() tests
        [Test]
        public void PokerHandsChecker_IsStraight_ShouldReturnTrueIfHandConsistsOfFiveConsequativeCardsFromDifferentSuit()
        {
            // 7♣ 6♠ 5♠ 4♥ 3♥
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Seven, CardSuit.Clubs),
                                   new Card(CardFace.Six, CardSuit.Spades),
                                   new Card(CardFace.Five, CardSuit.Spades),
                                   new Card(CardFace.Four, CardSuit.Hearts),
                                   new Card(CardFace.Three, CardSuit.Hearts)
                                });

            Assert.IsTrue(this.handsChecker.IsStraight(hand));
        }
        
        [Test]
        public void PokerHandsChecker_IsStraight_ShouldReturnFalseIfHandConsistsOfFiveConsequativeCardsFromTheSameSuit()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Seven, CardSuit.Clubs),
                                   new Card(CardFace.Six, CardSuit.Clubs),
                                   new Card(CardFace.Five, CardSuit.Clubs),
                                   new Card(CardFace.Four, CardSuit.Clubs),
                                   new Card(CardFace.Three, CardSuit.Clubs)
                                });

            Assert.IsFalse(this.handsChecker.IsStraight(hand));
        }

        // IsThreeOfAKind() tests
        [Test]
        public void PokerHandsChecker_IsThreeOfAKind_ShouldReturnTrueIfHandConsistsOfThreeEqualCardsAndTwoDifferent()
        {
            // 2♦ 2♠ 2♣ K♠ 6♥
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Two, CardSuit.Diamonds),
                                   new Card(CardFace.Two, CardSuit.Spades),
                                   new Card(CardFace.Two, CardSuit.Clubs),
                                   new Card(CardFace.King, CardSuit.Spades),
                                   new Card(CardFace.Six, CardSuit.Hearts)
                                });

            Assert.IsTrue(this.handsChecker.IsThreeOfAKind(hand));
        }

        [Test]
        public void PokerHandsChecker_IsThreeOfAKind_ShouldReturnFalseIfHandConsistsOfThreeEqualCardsAndTwoOtherEqualCards()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Two, CardSuit.Diamonds),
                                   new Card(CardFace.Two, CardSuit.Spades),
                                   new Card(CardFace.Two, CardSuit.Clubs),
                                   new Card(CardFace.King, CardSuit.Spades),
                                   new Card(CardFace.King, CardSuit.Hearts)
                                });

            Assert.IsFalse(this.handsChecker.IsThreeOfAKind(hand));
        }

        [Test]
        public void PokerHandsChecker_IsThreeOfAKind_ShouldReturnFalseIfHandConsistsOfFiveEqualCards()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Two, CardSuit.Diamonds),
                                   new Card(CardFace.Two, CardSuit.Spades),
                                   new Card(CardFace.Two, CardSuit.Clubs),
                                   new Card(CardFace.Two, CardSuit.Spades),
                                   new Card(CardFace.Two, CardSuit.Hearts)
                                });

            Assert.IsFalse(this.handsChecker.IsThreeOfAKind(hand));
        }

        // IsFullHouse() tests
        [Test]
        public void PokerHandsChecker_IsFullHouse_ShouldReturnTrueIfHandConsistsOfThreeEqualCardsAndanotherTwoEquals()
        {
            // 3♣ 3♠ 3♦ 6♣ 6♥
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Three, CardSuit.Clubs),
                                   new Card(CardFace.Three, CardSuit.Spades),
                                   new Card(CardFace.Three, CardSuit.Diamonds),
                                   new Card(CardFace.Six, CardSuit.Clubs),
                                   new Card(CardFace.Six, CardSuit.Hearts)
                                });

            Assert.IsTrue(this.handsChecker.IsFullHouse(hand));
        }

        [Test]
        public void PokerHandsChecker_IsFullHouse_ShouldReturnFalseIfHandConsistsOfThreeEqualCardsAndanotherTwoDifferent()
        {
            Hand hand = new Hand(
                            new List<ICard>
                                {
                                   new Card(CardFace.Three, CardSuit.Clubs),
                                   new Card(CardFace.Three, CardSuit.Spades),
                                   new Card(CardFace.Three, CardSuit.Diamonds),
                                   new Card(CardFace.Six, CardSuit.Clubs),
                                   new Card(CardFace.Five, CardSuit.Hearts)
                                });

            Assert.IsFalse(this.handsChecker.IsFullHouse(hand));
        }
    }
}
