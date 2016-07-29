namespace _03.PlayerActionValidater.Tests
{
    using Santase.GameLogic.Players;
    using NUnit.Framework;
    using Santase.GameLogic.Cards;
    using Santase.GameLogic.PlayerActionValidate;
    using Santase.GameLogic.RoundStates;
    using System.Collections.Generic;

    [TestFixture]
    public class PlayerActionValidaterTests
    {
        private static PlayerActionValidator validator = new PlayerActionValidator();

        [Test]
        public void IsValid_SholdReturnTrueWhenMoreThanTwoCardsLeftRoundStateIsCalled()
        {
            MoreThanTwoCardsLeftRoundState state = new MoreThanTwoCardsLeftRoundState(new StateManager());

            PlayerAction action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Heart, CardType.King));
            PlayerTurnContext context = new PlayerTurnContext(state, new Card(CardSuit.Spade, CardType.Jack), 6, 50, 60);
            ICollection<Card> cards = new List<Card>()
            {
                new Card(CardSuit.Spade, CardType.Ten),
                new Card(CardSuit.Heart, CardType.King),
                new Card(CardSuit.Spade, CardType.King),
                new Card(CardSuit.Club, CardType.King),
                new Card(CardSuit.Club, CardType.Nine),
                new Card(CardSuit.Diamond, CardType.Nine)
            };
            
            Assert.IsTrue(validator.IsValid(action, context, cards));
        }

        [Test]
        public void IsValid_SholdReturnFalseWhenMoreThanTwoCardsLeftRoundStateIsCalledWithNonExistingCard()
        {
            MoreThanTwoCardsLeftRoundState state = new MoreThanTwoCardsLeftRoundState(new StateManager());

            PlayerAction action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Diamond, CardType.Ace));
            PlayerTurnContext context = new PlayerTurnContext(state, new Card(CardSuit.Spade, CardType.Jack), 6, 50, 60);
            ICollection<Card> cards = new List<Card>()
            {
                new Card(CardSuit.Spade, CardType.Ten),
                new Card(CardSuit.Heart, CardType.King),
                new Card(CardSuit.Spade, CardType.King),
                new Card(CardSuit.Club, CardType.King),
                new Card(CardSuit.Club, CardType.Nine),
                new Card(CardSuit.Diamond, CardType.Nine)
            };
            
            Assert.IsFalse(validator.IsValid(action, context, cards));
        }
        

        [Test]
        public void IsValid_TestValidMoveWithTrumpCard()
        {
            FinalRoundState endRound = new FinalRoundState(new StateManager());

            PlayerTurnContext context = new PlayerTurnContext(endRound, new Card(CardSuit.Spade, CardType.Jack), 6, 20, 20);
            context.FirstPlayedCard = new Card(CardSuit.Club, CardType.Nine);

            PlayerAction action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Spade, CardType.Nine));
            ICollection<Card> cards = new List<Card>()
            {
                new Card(CardSuit.Spade, CardType.Queen),
                new Card(CardSuit.Spade, CardType.King),
                new Card(CardSuit.Heart, CardType.Queen),
                new Card(CardSuit.Diamond, CardType.King),
                new Card(CardSuit.Spade, CardType.Nine),
                new Card(CardSuit.Diamond, CardType.Nine)
            };

            Assert.IsTrue(validator.IsValid(action, context, cards));
        }

        [Test]
        public void IsValid_TestWrongChangeTrumpIfNotYourTurn()
        {
            MoreThanTwoCardsLeftRoundState state = new MoreThanTwoCardsLeftRoundState(new StateManager());
            PlayerTurnContext context = new PlayerTurnContext(state, new Card(CardSuit.Diamond, CardType.Jack), 6, 20, 20);

            context.FirstPlayedCard = new Card(CardSuit.Diamond, CardType.King);

            PlayerAction action = new PlayerAction(PlayerActionType.ChangeTrump, new Card(CardSuit.Spade, CardType.Nine));
           
            IList<Card> cards = new List<Card>()
            {
                new Card(CardSuit.Spade, CardType.Queen),
                new Card(CardSuit.Spade, CardType.King),
                new Card(CardSuit.Heart, CardType.Queen),
                new Card(CardSuit.Club, CardType.Ace),
                new Card(CardSuit.Club, CardType.Nine),
                new Card(CardSuit.Diamond, CardType.Nine)
            };

            Assert.IsFalse(validator.IsValid(action, context, cards));
        }
    }
}
