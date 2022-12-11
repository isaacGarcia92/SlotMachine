using System;

class Program
{
    static void Main(string[] args)
    {
        // 2D Array
        int[,] slotMachineGrid = new int[3, 3];

        // Introduction text and receiving user input
        Console.WriteLine("Welcome to The Slot Machine");
        Console.WriteLine("Please write what type of lines you want to play");
        Console.WriteLine("Horizontal, Vertical or Diagonal");
        string userOption = Console.ReadLine().ToLower();

        // Checking if user option is invalid
        while(userOption != "horizontal" && userOption != "vertical" && userOption != "diagonal")
        {
            Console.WriteLine("Invalid Option");
            userOption = Console.ReadLine().ToLower();
        }

        // Starting slot machine
        Console.WriteLine("Type spacebar to start the slot machine or Enter to exit");

        while(true)
        {
            ConsoleKey key = Console.ReadKey().Key;
            if(key == ConsoleKey.Spacebar)
            {
                PrintSlotMachine(slotMachineGrid);

                switch(userOption)
                {
                    case "horizontal": CheckHorizontalWin(slotMachineGrid);
                        break;

                    case "vertical": CheckVerticalWin(slotMachineGrid);
                        break;

                    case "diagonal": CheckDiagonalWin(slotMachineGrid);
                        break;
                }
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

    public static void CheckHorizontalWin(int[,] array)
    {
        if ((array[0, 0] == array[0, 1]) && (array[0, 1] == array[0, 2]))
        {
            Console.WriteLine("You won in top horizontal!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        if((array[1, 0] == array[1, 1]) && (array[1, 1] == array[1, 2]))
        {
            Console.WriteLine("You won in middle horizontal!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        if ((array[2, 0] == array[2, 1]) && (array[2, 1] == array[2, 2]))
        {
            Console.WriteLine("You won in bottom horizontal!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Try again with spacebar to keep playing!");
        }
    }

    public static void CheckVerticalWin(int[,] array)
    {
        if ((array[0, 0] == array[1, 0]) && (array[1, 0] == array[2, 0]))
        {
            Console.WriteLine("You won in left vertical!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        if ((array[0, 1] == array[1, 1]) && (array[1, 1] == array[2, 1]))
        {
            Console.WriteLine("You won in middle vertical!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        if ((array[0, 2] == array[1, 2]) && (array[1, 2] == array[2, 2]))
        {
            Console.WriteLine("You won in right vertical!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Try again with spacebar to keep playing!");
        }
    }

    public static void CheckDiagonalWin(int[,] array)
    {
        if ((array[0, 0] == array[1, 1]) && (array[1, 1] == array[2, 2]))
        {
            Console.WriteLine("You won in left diagonal!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        if ((array[0, 2] == array[1, 1]) && (array[1, 1] == array[2, 0]))
        {
            Console.WriteLine("You won in right diagonal!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Try again with spacebar to keep playing!");
        }
    }
}