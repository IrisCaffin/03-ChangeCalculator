﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter the cost
            Console.WriteLine("Enter cost: ");
            //Define cost information given
            string cost = Console.ReadLine();
            //Convert submitted cost input into an decimal
            decimal totalCost = decimal.Parse(cost);
           

            //Ask the user to enter the money receivved
            Console.WriteLine("Enter money received from customer: ");
            //Define money received information given
            string money = Console.ReadLine();
            //Convert submited money received input into an integer
            decimal receivedMoney = decimal.Parse(money);
      
            //Figure out the change by subtracting totalCost from givenMoney
            decimal change = receivedMoney - totalCost;

            //Turn change into quarters, dimes, nickels, and pennies
            decimal quartersFractional = change / 0.25m;
            decimal actualQuarters = Math.Floor(quartersFractional);

            decimal dimesFractional = (change % 0.25m) / 0.1m;
            decimal actualDimes = Math.Floor(dimesFractional);

            decimal nickelsFractional = ((change % 0.25m) % 0.1m) / 0.05m;
            decimal actualNickels = Math.Floor(nickelsFractional);

            decimal penniesFractional = (((change % 0.25m) % 0.1m) % 0.05m) / 0.01m;
            decimal actualPennies = Math.Floor(penniesFractional);

            //Give change and quarters, dimes, nickels, and pennies results back to the user
            Console.WriteLine("Quarters: " + actualQuarters);
            Console.WriteLine("Dimes: " + actualDimes);
            Console.WriteLine("Nickels: " + actualNickels);
            Console.WriteLine("Pennies: " + actualPennies);

            Console.ReadLine();
            

        }
    }
}
