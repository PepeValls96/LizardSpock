namespace RockPaperScissorsTests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RockPaperScissorsLizardSpockGame;
    using RockPaperScissorsLizardSpockGame.Classes;
    using RockPaperScissorsLizardSpockGame.Interfaces;
    using RockPaperScissorsLizardSpockGame.PlayGame;

    // TODO: Add or remove any namespace here

    [TestClass]
	public class RockPaperScissorsGameShould
	{
        internal virtual IRockPaperScissorsGame CreateGame()
        {
            return new RockPaperScissorsGame();
        }

        [TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ThrowArgumentOutOfRangeException_When_AnyArgumentIsNone()
		{
			IRockPaperScissorsGame game = CreateGame();
			game.Play(HandType.None, HandType.Paper);

			Assert.Fail();
		}

		[TestMethod]
		public void ReturnScissors_When_PassScissorsAndPaperAsParameters()
		{
			IRockPaperScissorsGame game = CreateGame();

			HandType expectedWinnerHand = HandType.Scissors;
			var winnerHand = game.Play(HandType.Scissors, HandType.Paper);

			Assert.AreEqual(expectedWinnerHand, winnerHand);
		}

		[TestMethod]
		public void ReturnScissors_When_PassPaperAndScissorsAsParameters()
		{
			IRockPaperScissorsGame game = CreateGame();

			var expectedWinnerHand = HandType.Scissors;
			HandType winnerHand = game.Play(HandType.Scissors, HandType.Paper);

			Assert.AreEqual(expectedWinnerHand, winnerHand);
		}

		[TestMethod]
		public void ReturnPaper_When_PassStoneAndPaperAsParameters()
		{
			IRockPaperScissorsGame game = CreateGame();

			var expectedWinnerHand = HandType.Paper;
			HandType winnerHand = game.Play(HandType.Stone, HandType.Paper);

			Assert.AreEqual(expectedWinnerHand, winnerHand);
		}

		[TestMethod]
		public void ReturnStone_When_PassStoneAndScissorsAsParameters()
		{
			IRockPaperScissorsGame game = CreateGame();

			var expectedWinnerHand = HandType.Stone;
			HandType winnerHand = game.Play(HandType.Stone, HandType.Scissors);

			Assert.AreEqual(expectedWinnerHand, winnerHand);
		}
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_When_BothArgumentAreNone()
        {
            IRockPaperScissorsGame game = CreateGame();
            game.Play(HandType.None, HandType.None);

            Assert.Fail();
        }
        [TestMethod]
        public void ThrowArgumentOutOfRangeException_When_BothArgumentAreEquals()
        {
            IRockPaperScissorsGame game = CreateGame();
            HandType winnerHand = game.Play(HandType.Stone, HandType.Stone);

            Assert.AreEqual(HandType.None, winnerHand); ;
        }
    }
}