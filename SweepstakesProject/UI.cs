using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UI
    {
        public static int contestantNumber = 0;

        public static string ContestantFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            return Console.ReadLine();
        }

        public static string ContestantLastName()
        {
            Console.WriteLine("Please enter your last name.");
            return Console.ReadLine();
        }

        public static string ContestantEmail()
        {
            Console.WriteLine("Please enter your e-mail address.");
            return Console.ReadLine();
        }

        public static int ContestantRegistrationNumber()
        {
            contestantNumber = +1;
            Console.WriteLine("Yor registration number is " + contestantNumber);
            return contestantNumber;
        }

        public static string ManagerType()
        {
            bool type = false;
            while (!type)
            {
                Console.WriteLine("Would you like to manage the Sweepstakes in a stack or queue?");
                string choice = Console.ReadLine();

                if (choice == "stack" || choice == "queue")
                {
                    type = true;
                    return choice;
                }
                else
                {
                    Console.WriteLine("Please try again. Type {0}stack{0} or {0}queue{0}.", Convert.ToChar(34));
                    type = false;
                }
            }
            return null;
        }
    }
}
