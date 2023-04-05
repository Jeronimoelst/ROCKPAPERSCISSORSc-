using Game;
using System;
using System.Collections.Generic;

namespace game
{
    public enum Choice
    {
        ROCK = 1,
        PAPER = 2,
        SCISSORS = 3,
    }

    public enum PointResult
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
           

            Dictionary<Choice, Choice> defeats = new Dictionary<Choice, Choice>();
            defeats.Add(Choice.ROCK, Choice.SCISSORS);
            defeats.Add(Choice.PAPER, Choice.ROCK);
            defeats.Add(Choice.SCISSORS, Choice.PAPER);

            Choice p1defeats = defeats [p1choice];
           

            if (p1choice == p2choice)
            {
                
                this.playerOne.pointResult(PointResult.TIE);
                this.playerTwo.pointResult(PointResult.TIE);
                this.playerOne.choose();
                this.playerTwo.choose();
            }

            else if (p1defeats == p2choice)
            {
                this.playerOne.pointResult(PointResult.WIN);
                this.playerTwo.pointResult(PointResult.LOSE);
            }
            else
            {
                this.playerOne.pointResult(PointResult.LOSE);
                this.playerTwo.pointResult(PointResult.WIN);
            }
            
        }
    }
}