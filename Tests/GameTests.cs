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


            Assert.AreEqual(1, playerOne.chooseWasCalledTimes());
            Assert.AreEqual(1, playerTwo.chooseWasCalledTimes());

        }

        [TestMethod]
        public void TestPlayersDontChoose_IfGameNotStarted()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();



            game.Game game = new game.Game(playerOne, playerTwo);
            


            Assert.AreEqual(0, playerOne.chooseWasCalledTimes());
            Assert.AreEqual(0, playerTwo.chooseWasCalledTimes());

        }

       

        [DataTestMethod]
        [DataRow(Choice.ROCK, Choice.ROCK,GameResult.TIE,GameResult.TIE)]
        [DataRow(Choice.ROCK, Choice.PAPER, GameResult.LOSE, GameResult.WIN)]
        [DataRow(Choice.PAPER, Choice.ROCK, GameResult.WIN, GameResult.LOSE)]
        [DataRow(Choice.PAPER, Choice.PAPER, GameResult.TIE, GameResult.TIE)]
        [DataRow(Choice.ROCK, Choice.SCISSORS, GameResult.WIN, GameResult.LOSE)]
        [DataRow(Choice.SCISSORS, Choice.ROCK, GameResult.LOSE, GameResult.WIN)]
        [DataRow(Choice.SCISSORS, Choice.PAPER, GameResult.WIN, GameResult.LOSE)]
        [DataRow(Choice.PAPER, Choice.SCISSORS, GameResult.LOSE, GameResult.WIN)]
        [DataRow(Choice.SCISSORS, Choice.SCISSORS, GameResult.TIE, GameResult.TIE)]
        public void GameResultsTest(Choice p1, Choice p2,GameResult result1, GameResult result2)
        {

            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(p1);
            playerTwo.nextChoice(p2);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreEqual(result1, playerOne.getGameResult());
            Assert.AreEqual(result2, playerTwo.getGameResult());
            Assert.AreEqual(1, playerOne.chooseWasCalledTimes());
            Assert.AreEqual(1, playerTwo.chooseWasCalledTimes());

        }

    }
}