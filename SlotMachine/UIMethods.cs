using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public static class UIMethods
    {

        public static void DisplayIntroductionText(ref int money)
        {
            Console.WriteLine("Welcome to The Slot Machine!");
            Console.WriteLine($"You have {money} USD credits available");
            Console.WriteLine();
            Console.WriteLine("Here are the options:");
            Console.WriteLine("1 - Center Horizontal");
            Console.WriteLine("2 - Top and Bottom Horizontal");
            Console.WriteLine("3 - All Three Horizontal");
            Console.WriteLine("4 - All Horizontal and Left Vertical");
            Console.WriteLine("5 - All Horizontal, Left and Middle Vertical");
            Console.WriteLine("6 - All Horizontal and Vertical");
            Console.WriteLine("7 - All Horizontal, Vertical and Left Diagonal");
            Console.WriteLine("8 - All Lines");
            Console.WriteLine();
        }

        public static void ChooseNumberOfLines(int option)
        {
            while (true)
            {
                Console.WriteLine("Please type the number of lines you want to play:");
                if (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option > 8)
                {
                    Console.WriteLine("Invalid Option!");
                }
                else
                {
                    break;
                }
            }
        }

        public static void EnterBetAmount(int bet, ref int money)
        {
            while (true)
            {
                Console.WriteLine("Enter bet amount:");
                if (!int.TryParse(Console.ReadLine(), out bet) || bet <= 0)
                {
                    Console.WriteLine("Invalid Option!");
                }
                else if (bet > money)
                {
                    Console.WriteLine("Bet is greater than available credits!");
                }
                else
                {
                    money -= bet;
                    break;
                }
            }
        }

        public static void StartSlotMachine()
        {
            Console.WriteLine("Type spacebar to start the slot machine");
        }

        public static void InvalidSlotMachineOption()
        {
            Console.WriteLine("Invalid Option!");
        }

        public static void NoMoreCredits()
        {
            Console.WriteLine("You do not have more available credits!");
        }

        public static void AvailableCredits(ref int money)
        {
            Console.WriteLine($"Available credits: {money} USD");
        }

        public static void ContinueGame(int answer)
        {
            Console.WriteLine("Do you want to keep playing?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out answer) || answer <= 0 || answer > 2)
                {
                    Console.WriteLine("Invalid Option!");
                }
                else
                {
                    break;
                }
            }
        }

        public static void MoneyEarned(ref int money)
        {
            Console.Clear();
            Console.WriteLine($"You earned {money} USD");
            Console.WriteLine("Thanks for playing");
        }
    }
}
