using System;
using System.Collections.Generic;

namespace rockPaperScissors
{
    public class Logic
    {
        // public Options(string choice, bool winner);
        // public bool Winner { get; private set; }
        // public string choice { get; private set; }
        // string str = Rock();

        static void Main(string[] args)
        {
            Console.WriteLine("Choose Rock, Paper or Scissors:");
            string playerChoice = Console.ReadLine();
            if (playerChoice == "rock")
            {
                System.Console.WriteLine($"You chose {playerChoice}");
            }
            else if (playerChoice == "scissors")
            {
                System.Console.WriteLine($"Because you chose { playerChoice } you lost");
            }
            else if (playerChoice == "paper")
            {
                System.Console.WriteLine($"You may have won with {playerChoice}");
            }
            else if (playerChoice == "")
            {
                System.Console.WriteLine("I didn't here you");
            }
            else
            {
                System.Console.WriteLine("You can't cheat!");
            }

        }
    }
}

// public string gameLogic()
// {
//     if (playerChoise = getComputerChoice())
//     {
//         Console.WriteLine("You tied!");
//         return "You tied";
//     }
//     else if (playerChoice = 'rock' && getComputerChoice = 'scissors')
//     {
//         Console.WriteLine("You")
//     }
// }