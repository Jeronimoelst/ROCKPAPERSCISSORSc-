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
            Choice p1choice = this.playerOne.choose();
            Choice p2choice = this.playerTwo.choose();

             if (p1choice == p2choice)
            {
                this.playerOne.gameResult(GameResult.TIE);
                this.playerTwo.gameResult(GameResult.TIE);
            }
             else if (p2choice == Choice.SCISSORS && p1choice == Choice.PAPER)
            {
                this.playerOne.gameResult(GameResult.LOSE);
                this.playerTwo.gameResult(GameResult.WIN);

            }


            else if (p1choice == Choice.SCISSORS && p2choice == Choice.PAPER)
            {
                this.playerOne.gameResult(GameResult.WIN);
                this.playerTwo.gameResult(GameResult.LOSE);
            }

            else if(p1choice == Choice.SCISSORS)
            {
                this.playerOne.gameResult(GameResult.LOSE);
                this.playerTwo.gameResult(GameResult.WIN);
            }
           

            else if (p2choice == Choice.PAPER )
            {
                this.playerOne.gameResult(GameResult.LOSE);
                this.playerTwo.gameResult(GameResult.WIN);
            }
        
            else
            {
                this.playerOne.gameResult(GameResult.WIN);
                this.playerTwo.gameResult(GameResult.LOSE);
            }
           
            

        }
    }
}