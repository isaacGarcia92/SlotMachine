using System;

class Program
{
    static void Main(string[] args)
    {
        // 2D Array
        int[,] slotMachineGrid = new int[3, 3];

        // Random variable
        Random rand = new Random();

        Console.WriteLine("Type spacebar to start the slot machine or Enter to exit");

        while(true)
        {
            ConsoleKey key = Console.ReadKey().Key;
            if(key == ConsoleKey.Spacebar)
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
            }

            if(key == ConsoleKey.Enter)
            {
                Console.WriteLine("Thanks for playing!");
                return;
            }

            if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
            {
                Console.WriteLine("You won!");
                Console.WriteLine("Thanks for playing!");
                return;
            }

            else
            {
                Console.WriteLine("You lost!");
                Console.WriteLine("Try again with spacebar to keep playing!");
            }
        }
    }
}