using Game;

namespace game
{
    public enum Choice
    {
        ROCK = 1,
        PAPER = 2,
        SCISSORS = 3,
    }

    public enum GameResult
    {
        TIE = 1,
        LOSE = 2,
        WIN = 3,
    }
    public class Game
    {
        private readonly Player playerOne;
        private readonly Player playerTwo;

        public Game(Player playerOne, Player playerTwo)
        {
           
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
           
        }

        public void start()
        {
            this.playerOne.choose();
            this.playerTwo.choose();
            this.playerOne.gameResult(GameResult.TIE);
            this.playerTwo.gameResult(GameResult.TIE);



        }
    }
}