﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UI
    {
        public static int contestantNumber = n;

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

        public static string CustomerEmail()
        {
            Console.WriteLine("Please enter your e-mail address.");
            return Console.ReadLine();
        }
    }
}
