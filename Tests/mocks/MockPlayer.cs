using game;
using Game;

namespace Tests.mocks
{
    internal class MockPlayer : Player
    {
        private int chooseCalled;
        private PointResult[] results = new PointResult[] {};
        private Choice[] choicesToReturn = new Choice[] { Choice.ROCK };

        public MockPlayer()
        {
            this.chooseCalled = 0;
            
        }

        public Choice choose()
        {
            int index = this.chooseCalled;
            this.chooseCalled++;
            return this.choicesToReturn[index];
        }

        public void pointResult(PointResult result)
        {
            this.results = this.results.Append(result).ToArray();
        }

        internal int chooseWasCalledTimes()
        {
            return this.chooseCalled;
        }

        internal PointResult getLastPointResult()
        {
           return this.results.Last();
        }

        internal PointResult[] getPointResults()
        {
            return this.results;
        }

        internal void nextChoice(params Choice[] choices)
        {
            this.choicesToReturn = choices;
        }
    }
}