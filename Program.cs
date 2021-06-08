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
                    $" Rules. Go and eat there. \n");
                }
                else
                {
// this code block will execute if the amount of people in SaladMart exceeds the limit set
// in SaladMartLimit.
                    Console.WriteLine($"Because there are {SaladMartNum} people already in " +
                        $"SaladMart, this exceeds the limit of {SaladMartLimit}, which is " +
                        $"the limit under current Covid19 Social Distancing Rules." +
                        $" Could you go to Rita's Jazz Cafe for your lunch instead? \n");
                }

//TASK3 - ELSE/IF
// Ask the user to confirm how many guests are coming for Games Night 2021
                Console.WriteLine("How many people are attending the games night " +
                    "you are hosting tonight?");
                string gamers = Console.ReadLine();
// Attempt conversion from string input to integer
                if (Int32.TryParse(gamers, out int guests))
                {
                Console.WriteLine($"So you have {guests} coming tonight.");
                }
                else
                {
                Console.WriteLine($"'{gamers}' is not a number?! Try again.");
               }
//Decide on the game to be played, which will depend on how many people turn up
                if (guests > 4)
                {
                    Console.WriteLine($"As you live in a tiny bedsit, {guests} " +
                        "people is too many people to fit in. I think it should be " +
                        "about 4 or less. Maybe tell a few of them you hate them, " +
                        "to get the numbers down? Come back here when the numbers " +
                        "are lower.");
                }
                else if (guests >= 4)
                {
                    Console.WriteLine($"As the number of guests is {guests} " +
                        "we will play Monopoly and hate each other within " +
                        "30 minutes.");
                }
                else if (guests >= 3)
                {
                    Console.WriteLine($"As the number of guests is {guests} " +
                        "we will play Uno, which quite frankly, is fun for all the " +
                        "family.");
                }
                else if (guests >= 2)
                {
                    Console.WriteLine($"As the number of guests is {guests} " +
                        "we will play King in the Corner.");
                }
                else if (guests == 1)
                {
                    Console.WriteLine($"As you only have {guests} person coming tonight, " +
                        "We are going to play Strip Poker. Close the blinds now.");
                }
                else if (guests == 0)
                {
                    Console.WriteLine($"No one is turning up? You're better than these " +
                        $"people, find some new friends that respect your time and social " +
                        $"efforts. Spend the evening on the PS4 or perhaps start that box " +
                        $"set of Judge John Deed you've been meaning to watch.");
                }
                /*          Commenting this out for now, as else is present in the exception
                *          handling, and this gets written out when an exception is found on 
                *          user's input (not int). 
                *               else
                                {
                                  Console.WriteLine($"You're on your own today, so play the " +
                                        $"lonely man's game; Solitaire.");
                                }
                */
            }
        }
    }
}
