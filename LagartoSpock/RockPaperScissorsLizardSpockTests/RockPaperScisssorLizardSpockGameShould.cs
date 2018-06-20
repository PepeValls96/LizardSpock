namespace RockPaperScissorsTests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RockPaperScissorsLizardSpockGame;
    using RockPaperScissorsLizardSpockGame.Classes;
    using RockPaperScissorsLizardSpockGame.PlayGame;

    // TODO: Add or remove any namespace here

    [TestClass]
	public class RockPaperScisssorLizardSpockGameShould : RockPaperScissorsGameShould
	{
		internal override IRockPaperScissorsGame CreateGame()
		{
            return new WithLizardSpockGame();
        }

		[TestMethod]
		public void ReturnScissors_When_PassScissorsAndLizardAsParameters()
		{
			IRockPaperScissorsGame game = CreateGame();

			HandType expectedWinnerHand = HandType.Scissors;
			var winnerHand = game.Play(HandType.Scissors, ExtendedHandType.Lizard);

			Assert.AreEqual(expectedWinnerHand, winnerHand);
		}

		[TestMethod]
		public void ReturnLizard_When_PassSpockAndLizardAsParameters()
		{
			IRockPaperScissorsGame game = CreateGame();

			HandType expectedWinnerHand = ExtendedHandType.Lizard;
			var winnerHand = game.Play(ExtendedHandType.Spock, ExtendedHandType.Lizard);

			Assert.AreEqual(expectedWinnerHand, winnerHand);
		}
	}
}