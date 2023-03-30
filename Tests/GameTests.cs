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
        public void TestGamePlayerOneWin_IfP1ChooseRock()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.ROCK);
            playerTwo.nextChoice(Choice.SCISSORS);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreNotEqual(playerOne.getGameResult(), GameResult.WIN);
            Assert.AreNotEqual(playerTwo.getGameResult(), GameResult.LOSE);

        }

        [TestMethod]
        public void TestGamePlayerTwoWin_IfP2ChooseRock()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.SCISSORS);
            playerTwo.nextChoice(Choice.ROCK);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreNotEqual(playerOne.getGameResult(), GameResult.LOSE);
            Assert.AreNotEqual(playerTwo.getGameResult(), GameResult.WIN);

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

        [TestMethod]
        public void TestGamePlayerOneWin_IfP1ChoosePaper()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.PAPER);
            playerTwo.nextChoice(Choice.ROCK);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreNotEqual(playerOne.getGameResult(), GameResult.WIN);
            Assert.AreNotEqual(playerTwo.getGameResult(), GameResult.LOSE);

        }


        [TestMethod]
        public void TestGamePlayerTwoWin_IfP2ChoosePaper()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.ROCK);
            playerTwo.nextChoice(Choice.PAPER);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreNotEqual(playerOne.getGameResult(), GameResult.LOSE);
            Assert.AreNotEqual(playerTwo.getGameResult(), GameResult.WIN);

        }

        [TestMethod]
        public void TestGameTie_IfBothChoosePaper()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.PAPER);
            playerTwo.nextChoice(Choice.PAPER);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreEqual(playerOne.getGameResult(), GameResult.TIE);
            Assert.AreEqual(playerTwo.getGameResult(), GameResult.TIE);

        }


        [TestMethod]
        public void TestGamePlayerOneWin_IfP1ChooseScissors()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.SCISSORS);
            playerTwo.nextChoice(Choice.PAPER);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreNotEqual(playerOne.getGameResult(), GameResult.WIN);
            Assert.AreNotEqual(playerTwo.getGameResult(), GameResult.LOSE);

        }

        [TestMethod]
        public void TestGamePlayerTwoWin_IfP2ChooseScissors()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.PAPER);
            playerTwo.nextChoice(Choice.SCISSORS);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreNotEqual(playerOne.getGameResult(), GameResult.LOSE);
            Assert.AreNotEqual(playerTwo.getGameResult(), GameResult.WIN);

        }


        [TestMethod]
        public void TestGameTie_IfBothChooseScissors()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.SCISSORS);
            playerTwo.nextChoice(Choice.SCISSORS);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreEqual(playerOne.getGameResult(), GameResult.TIE);
            Assert.AreEqual(playerTwo.getGameResult(), GameResult.TIE);

        }

    }
}