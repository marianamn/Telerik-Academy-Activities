using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null || hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < 5; i++)
            {
                if (hand.ToString().IndexOf(hand.Cards[i].ToString()) != hand.ToString().LastIndexOf(hand.Cards[i].ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            // A straight flush is a poker hand containing five cards of sequential rank, all of the same suit, 
            // such as Q♥ J♥ 10♥ 9♥ 8♥
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (this.MaxNumberOfSameCards(hand) != 1)
            {
                return false;
            }

            CardSuit firstCardSuit = hand.Cards[0].Suit;

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != firstCardSuit)
                {
                    return false;
                }
            }

            var cards = hand.Cards
                            .OrderBy(x => (int)x.Face)
                            .ToList();

            for (int i = 1; i < cards.Count; i++)
            {
                if ((int)cards[i].Face != (int)cards[i - 1].Face + 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            // Four of a kind, also known as quads, is a poker hand containing four cards of the same rank 
            // and one card of another rank (the kicker) such as 9♣ 9♠ 9♦ 9♥ J♥

            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (this.MaxNumberOfSameCards(hand) == 4)
            {
                return true;
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            // High card, also known as no pair or simply nothing, is a poker hand containing five cards not all of sequential
            // rank or of the same suit and none of which are of the same rank, such as K♥ J♥ 8♣ 7♦ 4♠
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (this.IsFlush(hand)  || this.IsStraightFlush(hand) || this.IsStraight(hand))
            {
                return false;
            }
            

            if (this.MaxNumberOfSameCards(hand) == 1)
            {
                return true;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            // A full house, also known as a full boat, is a poker hand containing three cards of one rank 
            // and two cards of another rank, such as 3♣ 3♠ 3♦ 6♣ 6♥ 
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (this.MaxNumberOfSameCards(hand) != 3)
            {
                return false;
            }

            return this.DeterminePairTwoPairOrFullHouseIfPairInTheHand(hand) == "full house";
        }

        public bool IsFlush(IHand hand)
        {
            // A flush is a poker hand containing five cards all of the same suit, 
            // not all of sequential rank, such as K♣ 10♣ 7♣ 6♣ 4♣
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            CardSuit firstCardSuit = hand.Cards[0].Suit;

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != firstCardSuit)
                {
                    return false;
                }
            }

            if (this.IsStraightFlush(hand))
            {
                return false;
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            // A straight is a poker hand containing five cards of sequential rank, not all of the same suit, 
            // such as 7♣ 6♠ 5♠ 4♥ 3♥
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (this.MaxNumberOfSameCards(hand) != 1)
            {
                return false;
            }

            if (this.IsFlush(hand) || this.IsStraightFlush(hand))
            {
                return false;
            }

            var cards = hand.Cards.OrderBy(x => (int)x.Face).ToList();
            
            for (int i = 1; i < cards.Count; i++)
            {
                if ((int)cards[i].Face != (int)cards[i - 1].Face + 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            // Three of a kind, also known as trips or a set, is a poker hand containing three cards of the same rank
            // and two cards of two other ranks (the kickers), such as 2♦ 2♠ 2♣ K♠ 6♥
            if (this.MaxNumberOfSameCards(hand) != 3)
            {
                return false;
            }

            List<ICard> remainingCards = new List<ICard>();

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                ICard currentCard = hand.Cards[i];
                int numberOfSameCards = hand.Cards.Where(x => x.Face == currentCard.Face).Count();

                if (numberOfSameCards == 3)
                {
                    remainingCards = hand.Cards.Where(x => x.Face != currentCard.Face).ToList();
                    break;
                }
            }

            return remainingCards[0].Face != remainingCards[1].Face;
        }

        public bool IsTwoPair(IHand hand)
        {
            // Two pair is a poker hand containing two cards of the same rank, two cards of another rank and 
            // one card of a third rank (the kicker), such as J♥ J♣ 4♣ 4♠ 9♥
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (this.MaxNumberOfSameCards(hand) != 2)
            {
                return false;
            }

            return this.DeterminePairTwoPairOrFullHouseIfPairInTheHand(hand) == "two pair";
        }

        public bool IsOnePair(IHand hand)
        {
            // One pair, or simply a pair, is a poker hand containing two cards of the same rank 
            // and three cards of three other ranks (the kickers), such as 4♥ 4♠ K♠ 10♦ 5♠
            if (!this.IsValidHand(hand) || this.IsTwoPair(hand))
            {
                return false;
            }

            if (this.MaxNumberOfSameCards(hand) != 2)
            {
                return false;
            }

            return this.DeterminePairTwoPairOrFullHouseIfPairInTheHand(hand) == "pair";
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            if (!this.IsValidHand(firstHand) || !this.IsValidHand(secondHand))
            {
                throw new InvalidOperationException("Some of hands are invalid!");
            }

            // Straight flush
            if (this.IsStraightFlush(firstHand) || this.IsStraightFlush(secondHand))
            {
                return ComparingHandsMethods.CompareTwoStraightFlushHands(firstHand, secondHand);
            }

            // FOur of a kind
            if (this.IsFourOfAKind(firstHand) || this.IsFourOfAKind(secondHand))
            {
                return ComparingHandsMethods.CompareTwoFourOfAKindHands(firstHand, secondHand);
            }

            // Full house
            if (this.IsFullHouse(firstHand) || this.IsFullHouse(secondHand))
            {
                return ComparingHandsMethods.CompareTwoFullHouseHands(firstHand, secondHand);
            }

            // Flush
            if (this.IsFlush(firstHand) || this.IsFlush(secondHand))
            {
                return ComparingHandsMethods.CompareTwoFlushHands(firstHand, secondHand);
            }

            // Straight
            if (this.IsStraight(firstHand) || this.IsStraight(secondHand))
            {
                return ComparingHandsMethods.CompareTwoStraightHands(firstHand, secondHand);
            }

            throw new NotImplementedException("High card is at last");
        }

        // additional methods for avoiding code duplication
        private int MaxNumberOfSameCards(IHand hand)
        {
            int result = 1;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                ICard typeOfCardToCheck = hand.Cards[i];
                int numberOfSuchCardsInTheHand = hand.Cards.Where(x => x.Face == typeOfCardToCheck.Face).Count();

                if (numberOfSuchCardsInTheHand > result)
                {
                    result = numberOfSuchCardsInTheHand;
                }
            }

            return result;
        }

        private string DeterminePairTwoPairOrFullHouseIfPairInTheHand(IHand hand)
        {
            List<ICard> theOtherCards = new List<ICard>();

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                ICard typeOfCardToCheck = hand.Cards[i];
                int numberOfSuchCardsInTheHand = hand.Cards.Where(x => x.Face == typeOfCardToCheck.Face).Count();
                if (numberOfSuchCardsInTheHand == 2)
                {
                    theOtherCards = hand.Cards.Where(x => x.Face != typeOfCardToCheck.Face).ToList();
                    break;
                }
            }

            int maxNumberOfSameCards = 1;

            for (int i = 0; i < theOtherCards.Count; i++)
            {
                ICard typeOfCardToCheck = theOtherCards[i];
                int numberOfSuchCardsInTheOtherCards = theOtherCards.Where(x => x.Face == typeOfCardToCheck.Face).Count();

                if (numberOfSuchCardsInTheOtherCards > maxNumberOfSameCards)
                {
                    maxNumberOfSameCards = numberOfSuchCardsInTheOtherCards;
                }
            }

            return maxNumberOfSameCards == 1 ? "pair" : maxNumberOfSameCards == 2 ? "two pair" : "full house";
        }
    }
}
