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

        // Introduction text and printing initial slot machine
        Console.WriteLine("Welcome to The Slot Machine!");
        Console.WriteLine($"You have {INITIAL_CREDITS} USD credits available");
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

        // Choosing lines to play
        Console.WriteLine("Please type the number of lines you want to play:");

        // Checking if user input is valid
        int userOption = 0;
        bool inputIsANumber = false;

        while (!inputIsANumber)
        {
            if (!int.TryParse(Console.ReadLine(), out userOption) || userOption <= 0 || userOption > 8)
            {
                Console.WriteLine("Invalid Option!");
                Console.WriteLine("Please type the number of lines you want to play:");
            }
            else
            {
                inputIsANumber = true;
            }
        }

        // Player's initial money
        int playerMoney = INITIAL_CREDITS;

        // Enter user's bet amount
        Console.WriteLine("Enter bet amount:");

        //Checking if bet amount is valid
        int betAmount = 0;
        bool betAmountIsANumber = false;

        while (!betAmountIsANumber)
        {
            if (!int.TryParse(Console.ReadLine(), out betAmount))
            {
                Console.WriteLine("Invalid Option!");
                Console.WriteLine("Enter bet amount:");
            }
            else if (betAmount > playerMoney)
            {
                Console.WriteLine("Bet is greater than available credits!");
                Console.WriteLine("Enter bet amount:");
            }
            else
            {
                betAmountIsANumber = true;
                playerMoney -= betAmount;
            }
        }

        //Casting user input to enum type
        LineOptions castedUserOption = (LineOptions)userOption;

        // Starting slot machine
        Console.WriteLine("Type spacebar to start the slot machine");

        while (true)
        {
            ConsoleKey key = Console.ReadKey().Key;
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

                switch (castedUserOption)
                {
                    case LineOptions.CenterHorizontal:
                        if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                        {
                            Console.WriteLine("You won in middle horizontal!");
                            playerMoney += betAmount * userOption;
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
                        break;
                }
            }
            if (playerMoney == 0)
            {
                Console.WriteLine("You do not have more available credits!");
                break;
            }

            Console.WriteLine($"Available credits: {playerMoney} USD");
            Console.WriteLine("Do you want to keep playing?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");
            int userAnswer = 0;
            bool isAnswerAChar = false;

            while(!isAnswerAChar)
            {
                if (!int.TryParse(Console.ReadLine(), out userAnswer) || userAnswer <= 0 || userAnswer > 2)
                {
                    Console.WriteLine("Invalid Option!");
                    Console.WriteLine("Do you want to keep playing? y/n");
                }
                else
                {
                    isAnswerAChar = true;
                }
            }
            
            if(userAnswer == 1)
            {
                Console.Clear();
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
                Console.WriteLine($"Available credits: {playerMoney} USD");
                Console.WriteLine("Please type the number of lines you want to play:");
                userOption = 0;
                inputIsANumber = false;
                while (!inputIsANumber)
                {
                    if (!int.TryParse(Console.ReadLine(), out userOption) || userOption <= 0 || userOption > 8)
                    {
                        Console.WriteLine("Invalid Option!");
                        Console.WriteLine("Please type the number of lines you want to play:");
                    }
                    else
                    {
                        inputIsANumber = true;
                    }
                }
                Console.WriteLine("Enter bet amount:");
                betAmount = 0;
                betAmountIsANumber = false;
                while (!betAmountIsANumber)
                {
                    if (!int.TryParse(Console.ReadLine(), out betAmount))
                    {
                        Console.WriteLine("Invalid Option!");
                        Console.WriteLine("Enter bet amount:");
                    }
                    else if (betAmount > playerMoney)
                    {
                        Console.WriteLine("Bet is greater than available credits!");
                        Console.WriteLine("Enter bet amount:");
                    }
                    else
                    {
                        betAmountIsANumber = true;
                        playerMoney -= betAmount;
                    }
                }
            }
            if(userAnswer == 2) break;

            Console.WriteLine("Type spacebar to start the slot machine");
        }

        Console.WriteLine($"You earned {playerMoney} USD");
        Console.WriteLine("Thanks for playing");
    }
}
