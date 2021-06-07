using System;

namespace CodeAcademy___Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
//TASK1 - SINGLE IF STATEMENT
            int socks = 3;
            if (socks <= 3)
            {
// If socks is equal to or greater than 3, the code block will execute.
                Console.WriteLine("Time to do laundry!");
//TASK2 - IF/ELSE
// Set the safe limit of people that can be in SaladMart at any one time,
// based on Social Distancing Rules.
                int SaladMartLimit = 10;
// Ask the user to confirm how many people are queueing for SaladMart
                Console.WriteLine("Have a look, how many people are currently in Saladmart?");
                string people = Console.ReadLine();
// Attempt conversion from string input to integer
                if (Int32.TryParse(people, out int SaladMartNum))
                {
                    Console.WriteLine($"Ok, so there are " + SaladMartNum +
                            " people at SaladMart already. Hmmm...");
                }
                else
                {
                    Console.WriteLine($"'{people}' is not a number?! Try again.");
                }
// Apply the conditional 
                if (SaladMartNum <= SaladMartLimit)
{
// this code block will execute only if the amount of people at SaladMart is less than
// or equal to the limit set in SaladMartLimit.

                 Console.WriteLine($"I have made the decision for you. Because there" +
                 $" are {SaladMartNum} people currently in SaladMart, this is equal to or less" +
                 $" than the limit of people that can be in the restaurant, which is currently" +
                 $" {SaladMartLimit}. It is safe to attend within Covid19 Social Distancing" +
                 $" Rules. Go and eat there.");
                 }
                 else
                 {
// this code block will execute if the amount of people in SaladMart exceeds the limit set
// in SaladMartLimit.
                 Console.WriteLine($"Because there are {SaladMartNum} people already in " +
                     $"SaladMart, this exceeds the limit of {SaladMartLimit}, which is " +
                     $"the limit under current Covid19 Social Distancing Rules." +
                     $" Could you go to Rita's Jazz Cafe for your lunch instead?");
                  }
              
            }
        }
    }
}
