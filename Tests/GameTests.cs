using game;
using Tests.mocks;

namespace Tests
{
    [TestClass]
    public class GameTests
    {

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
       // [DataRow(Choice.ROCK, Choice.ROCK,PointResult.TIE,PointResult.TIE)]
        [DataRow(Choice.ROCK, Choice.PAPER, PointResult.LOSE, PointResult.WIN)]
        [DataRow(Choice.PAPER, Choice.ROCK, PointResult.WIN, PointResult.LOSE)]
        //[DataRow(Choice.PAPER, Choice.PAPER, PointResult.TIE, PointResult.TIE)]
        [DataRow(Choice.ROCK, Choice.SCISSORS, PointResult.WIN, PointResult.LOSE)]
        [DataRow(Choice.SCISSORS, Choice.ROCK, PointResult.LOSE, PointResult.WIN)]
        [DataRow(Choice.SCISSORS, Choice.PAPER, PointResult.WIN, PointResult.LOSE)]
        [DataRow(Choice.PAPER, Choice.SCISSORS, PointResult.LOSE, PointResult.WIN)]
        //[DataRow(Choice.SCISSORS, Choice.SCISSORS, PointResult.TIE, PointResult.TIE)]
        public void pointResultsTest(Choice p1, Choice p2,PointResult result1, PointResult result2)
        {

            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(p1);
            playerTwo.nextChoice(p2);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            Assert.AreEqual(result1, playerOne.getLastPointResult());
            Assert.AreEqual(result2, playerTwo.getLastPointResult());
            Assert.AreEqual(1, playerOne.chooseWasCalledTimes());
            Assert.AreEqual(1, playerTwo.chooseWasCalledTimes());

        }


        [TestMethod]
        public void TestPlayersChooseAgain_IfTie()
        {
            MockPlayer playerOne = new MockPlayer();
            MockPlayer playerTwo = new MockPlayer();
            playerOne.nextChoice(Choice.PAPER, Choice.PAPER);
            playerTwo.nextChoice(Choice.PAPER, Choice.ROCK);


            game.Game game = new game.Game(playerOne, playerTwo);
            game.start();

            
            Assert.AreEqual(2, playerOne.chooseWasCalledTimes());
            Assert.AreEqual(2, playerTwo.chooseWasCalledTimes());
            Assert.AreEqual(new PointResult[] {PointResult.TIE, PointResult.WIN}, playerOne.getPointResults());
            Assert.AreEqual(new PointResult[] { PointResult.TIE, PointResult.LOSE }, playerTwo.getPointResults());

        }


    }
}