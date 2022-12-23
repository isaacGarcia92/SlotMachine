using System;

class Program
{
    const int INITIAL_CREDITS = 50;
    static Random rand = new Random();

    enum LineOptions
    {
        CenterHorizontal = 1,
        TopAndBottomHorizontal = 2,
        AllThreeHorizontal = 3,
        AllHorizonalAndLeftVertical = 4,
        AllHorizontal_LeftAndMiddleVertical = 5,
        AllHorizontalAndVertical = 6,
        AllHorizontal_VerticalAndLeftDiagonal = 7,
        AllLines = 8,
    }

    static void Main(string[] args)
    {
        // 2D Array
        int[,] slotMachineGrid = new int[3, 3];

        int userOption = 0;

        // Player's initial money
        int playerMoney = INITIAL_CREDITS;

        int betAmount;

        //Console Key variable
        ConsoleKey key;

        int userAnswer;

        while (true)
        {
            // Introduction text and printing initial slot machine
            Console.WriteLine("Welcome to The Slot Machine!");
            Console.WriteLine($"You have {playerMoney} USD credits available");
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

            // Checking if user input is valid
            while (true)
            {
                Console.WriteLine("Please type the number of lines you want to play:");
                if (!int.TryParse(Console.ReadLine(), out userOption) || userOption <= 0 || userOption > 8)
                {
                    Console.WriteLine("Invalid Option!");
                }
                else
                {
                    break;
                }
            }

            //Checking if bet amount is valid
            while (true)
            {
                Console.WriteLine("Enter bet amount:");
                if (!int.TryParse(Console.ReadLine(), out betAmount))
                {
                    Console.WriteLine("Invalid Option!");
                }
                else if (betAmount > playerMoney)
                {
                    Console.WriteLine("Bet is greater than available credits!");
                }
                else
                {
                    break;
                }
            }
            playerMoney -= betAmount;

            // Checking if input for slot machine is valid
            while (true)
            {
                Console.WriteLine("Type spacebar to start the slot machine");
                key = Console.ReadKey().Key;
                if (key != ConsoleKey.Spacebar)
                {
                    Console.WriteLine("Invalid Option!");
                }
                else
                {
                    break;
                }
            }

            if (key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        int randomNumber = rand.Next(0, 3);
                        Console.Write($"{slotMachineGrid[row, col] = randomNumber} ");
                    }
                    Console.WriteLine();
                }

                //Casting user input to enum type
                LineOptions castedUserOption = (LineOptions)userOption;

                switch (castedUserOption)
                {
                    case LineOptions.CenterHorizontal:
                        if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                        {
                            Console.WriteLine("You won in middle horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;

                    case LineOptions.TopAndBottomHorizontal:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[0, 1]) && (slotMachineGrid[0, 1] == slotMachineGrid[0, 2]))
                        {
                            Console.WriteLine("You won in top horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[2, 0] == slotMachineGrid[2, 1]) && (slotMachineGrid[2, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in bottom horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;

                    case LineOptions.AllThreeHorizontal:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[0, 1]) && (slotMachineGrid[0, 1] == slotMachineGrid[0, 2]))
                        {
                            Console.WriteLine("You won in top horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                        {
                            Console.WriteLine("You won in middle horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[2, 0] == slotMachineGrid[2, 1]) && (slotMachineGrid[2, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in bottom horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;

                    case LineOptions.AllHorizonalAndLeftVertical:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[0, 1]) && (slotMachineGrid[0, 1] == slotMachineGrid[0, 2]))
                        {
                            Console.WriteLine("You won in top horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                        {
                            Console.WriteLine("You won in middle horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[2, 0] == slotMachineGrid[2, 1]) && (slotMachineGrid[2, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in bottom horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 0] == slotMachineGrid[1, 0]) && (slotMachineGrid[1, 0] == slotMachineGrid[2, 0]))
                        {
                            Console.WriteLine("You won in left vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;

                    case LineOptions.AllHorizontal_LeftAndMiddleVertical:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[0, 1]) && (slotMachineGrid[0, 1] == slotMachineGrid[0, 2]))
                        {
                            Console.WriteLine("You won in top horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                        {
                            Console.WriteLine("You won in middle horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[2, 0] == slotMachineGrid[2, 1]) && (slotMachineGrid[2, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in bottom horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 0] == slotMachineGrid[1, 0]) && (slotMachineGrid[1, 0] == slotMachineGrid[2, 0]))
                        {
                            Console.WriteLine("You won in left vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 1] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 1]))
                        {
                            Console.WriteLine("You won in middle vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;

                    case LineOptions.AllHorizontalAndVertical:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[0, 1]) && (slotMachineGrid[0, 1] == slotMachineGrid[0, 2]))
                        {
                            Console.WriteLine("You won in top horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                        {
                            Console.WriteLine("You won in middle horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[2, 0] == slotMachineGrid[2, 1]) && (slotMachineGrid[2, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in bottom horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 0] == slotMachineGrid[1, 0]) && (slotMachineGrid[1, 0] == slotMachineGrid[2, 0]))
                        {
                            Console.WriteLine("You won in left vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 1] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 1]))
                        {
                            Console.WriteLine("You won in middle vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 2] == slotMachineGrid[1, 2]) && (slotMachineGrid[1, 2] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in right vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;

                    case LineOptions.AllHorizontal_VerticalAndLeftDiagonal:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[0, 1]) && (slotMachineGrid[0, 1] == slotMachineGrid[0, 2]))
                        {
                            Console.WriteLine("You won in top horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                        {
                            Console.WriteLine("You won in middle horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[2, 0] == slotMachineGrid[2, 1]) && (slotMachineGrid[2, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in bottom horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 0] == slotMachineGrid[1, 0]) && (slotMachineGrid[1, 0] == slotMachineGrid[2, 0]))
                        {
                            Console.WriteLine("You won in left vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 1] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 1]))
                        {
                            Console.WriteLine("You won in middle vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 2] == slotMachineGrid[1, 2]) && (slotMachineGrid[1, 2] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in right vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in left diagonal!");
                            playerMoney += betAmount * userOption;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;

                    case LineOptions.AllLines:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[0, 1]) && (slotMachineGrid[0, 1] == slotMachineGrid[0, 2]))
                        {
                            Console.WriteLine("You won in top horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                        {
                            Console.WriteLine("You won in middle horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[2, 0] == slotMachineGrid[2, 1]) && (slotMachineGrid[2, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in bottom horizontal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 0] == slotMachineGrid[1, 0]) && (slotMachineGrid[1, 0] == slotMachineGrid[2, 0]))
                        {
                            Console.WriteLine("You won in left vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 1] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 1]))
                        {
                            Console.WriteLine("You won in middle vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 2] == slotMachineGrid[1, 2]) && (slotMachineGrid[1, 2] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in right vertical!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in left diagonal!");
                            playerMoney += betAmount * userOption;
                        }
                        else if ((slotMachineGrid[0, 2] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 0]))
                        {
                            Console.WriteLine("You won in right diagonal!");
                            playerMoney += betAmount * userOption;
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;
                }
            }

            if (playerMoney <= 0)
            {
                Console.WriteLine("You do not have more available credits!");
                break;
            }

            Console.WriteLine($"Available credits: {playerMoney} USD");
            Console.WriteLine("Do you want to keep playing?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out userAnswer) || userAnswer <= 0 || userAnswer > 2)
                {
                    Console.WriteLine("Invalid Option!");
                }
                else
                {
                    break;
                }
            }

            if (userAnswer == 2) break;

            Console.Clear();
        }
        Console.WriteLine($"You earned {playerMoney} USD");
        Console.WriteLine("Thanks for playing");
    }
}
