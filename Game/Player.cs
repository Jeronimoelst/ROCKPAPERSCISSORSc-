using game;

namespace Game
{
    public interface Player
    {
        public Choice choose();

        public void gameResult(GameResult result);
    }
}