using game;
using Game;

namespace Tests.mocks
{
    internal class MockPlayer : Player
    {
        private bool chooseCalled;
        private GameResult result;
        private Choice nextChoiceToReturn;

        public MockPlayer()
        {
            this.chooseCalled = false;
            
        }

        public Choice choose()
        {
            this.chooseCalled = true;
            return this.nextChoiceToReturn;
        }

        public void gameResult(GameResult result)
        {
            this.result = result;
        }

        internal Boolean chooseWasCalled()
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