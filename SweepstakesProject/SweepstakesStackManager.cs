using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        private Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

        public void InsertSweeptakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            UI.ContestantRegistrationNumber();
            return stack.Pop();
        }
    }
}
