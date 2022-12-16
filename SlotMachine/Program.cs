using System;

class Program
{
    const int ONE_DOLLAR = 1;
    static Random rand = new Random();

    enum LineOptions
    {
        CenterHorizontal = 1,
        TopAndBottomHorizontal = 2,
        AllThreeHorizontal = 3,
        AllHorizonalAndLeftVertical = 4,
        AllHorizontalAndMiddleVertical = 5,
        AllHorizontalAndVertical = 6,
        AllHorizontal_VerticalAndLeftDiagonal = 7,
        AllLines = 8,
    }

    static void Main(string[] args)
    {
        // 2D Array
        int[,] slotMachineGrid = new int[3, 3];

        // Introduction text and printing initial slot machine
        Console.WriteLine("Welcome to The Slot Machine");

        for(int row = 0; row < 3; row++)
        {
            for(int col = 0; col < 3; col++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }

        // Starting slot machine
        Console.WriteLine("Type spacebar to start the slot machine");
        Console.WriteLine($"Try to hit center horizontal and vertical and also diagonal to win {ONE_DOLLAR} USD per line");

        // Player's money
        int playerMoney = 0;

        while(true)
        {
            ConsoleKey key = Console.ReadKey().Key;
            if(key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                for(int row = 0; row < 3; row++)
                {
                    for(int col = 0; col < 3; col++)
                    {
                        int randomNumber = rand.Next(0, 3);
                        Console.Write($"{slotMachineGrid[row, col] = randomNumber} ");
                    }
                    Console.WriteLine();
                }

                if((slotMachineGrid[0, 0] == slotMachineGrid[0, 1]) && (slotMachineGrid[0, 1] == slotMachineGrid[0, 2]))
                {
                    Console.WriteLine("You won in top horizontal!");
                }
                else if((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                {
                    Console.WriteLine("You won in middle horizontal!");
                    playerMoney++;
                }
                else if((slotMachineGrid[2, 0] == slotMachineGrid[2, 1]) && (slotMachineGrid[2, 1] == slotMachineGrid[2, 2]))
                {
                    Console.WriteLine("You won in bottom horizontal!");
                }
                else if((slotMachineGrid[0, 0] == slotMachineGrid[1, 0]) && (slotMachineGrid[1, 0] == slotMachineGrid[2, 0]))
                {
                    Console.WriteLine("You won in left vertical!");
                }
                else if((slotMachineGrid[0, 1] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 1]))
                {
                    Console.WriteLine("You won in middle vertical!");
                    playerMoney++;
                }
                else if((slotMachineGrid[0, 2] == slotMachineGrid[1, 2]) && (slotMachineGrid[1, 2] == slotMachineGrid[2, 2]))
                {
                    Console.WriteLine("You won in right vertical!");
                }
                else if((slotMachineGrid[0, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 2]))
                {
                    Console.WriteLine("You won in left diagonal!");
                    playerMoney++;
                }
                else if((slotMachineGrid[0, 2] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 0]))
                {
                    Console.WriteLine("You won in right diagonal!");
                    playerMoney++;
                }
                else
                {
                    Console.WriteLine("Try again with spacebar to keep playing!");
                }
                Console.WriteLine("If you want to exit the game, type Enter and collect your earnings");
            }
            if(key == ConsoleKey.Enter) break;
        }
        Console.WriteLine($"You earned {playerMoney} USD");
        Console.WriteLine("Thanks for playing");
    }
}
