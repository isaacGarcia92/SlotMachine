using System;

class Program
{
    static void Main(string[] args)
    {
        // 2D Array
        int[,] slotMachineGrid = new int[3, 3];

        Console.WriteLine("Type spacebar to start the slot machine or Enter to exit");

        while(true)
        {
            ConsoleKey key = Console.ReadKey().Key;
            if(key == ConsoleKey.Spacebar)
            {
                PrintSlotMachine(slotMachineGrid);
                IsMiddleRowTheSame(slotMachineGrid);
            }

            if(key == ConsoleKey.Enter)
            {
                Console.WriteLine("Thanks for playing!");
                return;
            }
        }
    }

    public static void PrintSlotMachine(int[,] array)
    {
        Random rand = new Random();
        Console.Clear();
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                int randomNumber = rand.Next(0, 3);
                Console.Write($"{array[row, col] = randomNumber} ");
            }
            Console.WriteLine();
        }
    }

    public static void IsMiddleRowTheSame(int[,] array)
    {
        if ((array[1, 0] == array[1, 1]) && (array[1, 1] == array[1, 2]))
        {
            Console.WriteLine("You won!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }

        else
        {
            Console.WriteLine("You lost!");
            Console.WriteLine("Try again with spacebar to keep playing!");
        }
    }
}