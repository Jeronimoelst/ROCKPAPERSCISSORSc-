using game;
using Game;

namespace Tests.mocks
{
    internal class MockPlayer : Player
    {
        private int chooseCalled;
        private GameResult result;
        private Choice nextChoiceToReturn;

        public MockPlayer()
        {
            this.chooseCalled = 0;
            
        }

        public Choice choose()
        {
            this.chooseCalled++;
            return this.nextChoiceToReturn;
        }

        public void gameResult(GameResult result)
        {
            this.result = result;
        }

        internal Boolean chooseWasCalled()
        {
            return this.chooseCalled > 0;
        }
        internal int chooseWasCalledTimes()
        {
            return this.chooseCalled;
        }

        internal GameResult getGameResult()
        {
           return this.result;
        }

        internal void nextChoice(Choice option)
        {
            this.nextChoiceToReturn = option;
        }
    }
}