using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;
        public int winnersNumber;
        
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UI.ContestantFirstName();
            UI.ContestantFirstName();
            contestant.LastName = UI.ContestantLastName();
            UI.ContestantLastName();
            contestant.EmailAddress = UI.ContestantEmail();
            UI.ContestantEmail();
            contestant.RegistrationNumber = UI.ContestantRegistrationNumber();
            UI.ContestantRegistrationNumber();
        }

        public Contestant PickWinner()
        {
            Random random = new Random();
            winnersNumber = random.Next();
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key == winnersNumber)
                {
                    return contestant.Value;
                }
            }
            return null;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName + contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegistrationNumber);
        }
    }
}
