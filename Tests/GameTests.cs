using game;
using Tests.mocks;

namespace Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void TestPlayersChoose_WhenGameStarts()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();



            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();


            Assert.IsTrue(playerOne.chooseWasCalled());
            Assert.IsTrue(playerTwo.chooseWasCalled());

        }

        [TestMethod]
        public void TestPlayersDontChoose_IfGameNotStarted()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();



            game.Game game = new game.Game(playerOne, playerTwo);
            


            Assert.IsFalse(playerOne.chooseWasCalled());
            Assert.IsFalse(playerTwo.chooseWasCalled());

        }

        [TestMethod]
        public void TestGameTie_IfBothChooseRock()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.ROCK);
            playerTwo.nextChoice(Choice.ROCK);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreEqual(playerOne.getGameResult(), GameResult.TIE);
            Assert.AreEqual(playerTwo.getGameResult(), GameResult.TIE);

        }

    }
}