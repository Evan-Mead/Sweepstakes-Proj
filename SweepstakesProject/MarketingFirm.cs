using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class MarketingFirm
    {
        private ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void SelectManager()
        {
            string managerSelection = UI.ManagerType();

            if (managerSelection == "stack")
            {
                manager = new SweepstakesStackManager();
            }
            else if (managerSelection == "queue")
            {
                manager = new SweepstakesQueueManager();
            }
            else
            {
                return;
            }
        }

        public void CreateSweepstake()
        {

            Sweepstakes newSweepstakes = new Sweepstakes();
            manager.InsertSweepstakes(newSweepstakes);

        }
    }
}