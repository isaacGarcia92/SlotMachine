using System;

class Program
{
    enum TypeOfLine
    {
        Horizontal = 'h',
        Vertical = 'v',
        Diagonal = 'd',
    }

    static void Main(string[] args)
    {
        // 2D Array
        int[,] slotMachineGrid = new int[3, 3];

        // Introduction text and receiving user input
        Console.WriteLine("Welcome to The Slot Machine");
        Console.WriteLine("Please write the letter of the line type you want to play");
        Console.WriteLine("h - Horizontal");
        Console.WriteLine("v - Vertical");
        Console.WriteLine("d - Diagonal");

        char userOption = Convert.ToChar(Console.ReadLine());
        TypeOfLine castedUserOption = (TypeOfLine)userOption;

        // Checking if user option is invalid
        while(castedUserOption != TypeOfLine.Horizontal && castedUserOption != TypeOfLine.Vertical &&
            castedUserOption != TypeOfLine.Diagonal)
        {
            Console.WriteLine("Invalid Option");
            userOption = Convert.ToChar(Console.ReadLine());
            castedUserOption = (TypeOfLine)userOption;
        }

        // Starting slot machine
        Console.WriteLine("Type spacebar to start the slot machine or Enter to exit");

        while(true)
        {
            ConsoleKey key = Console.ReadKey().Key;
            if(key == ConsoleKey.Spacebar)
            {
                PrintSlotMachine(slotMachineGrid);

                switch(castedUserOption)
                {
                    case TypeOfLine.Horizontal: CheckHorizontalWin(slotMachineGrid);
                        break;

                    case TypeOfLine.Vertical: CheckVerticalWin(slotMachineGrid);
                        break;

                    case TypeOfLine.Diagonal: CheckDiagonalWin(slotMachineGrid);
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

    static Random rand = new Random();

    public static void PrintSlotMachine(int[,] array)
    {
        Console.Clear();
        for(int row = 0; row < 3; row++)
        {
            for(int col = 0; col < 3; col++)
            {
                int randomNumber = rand.Next(0, 3);
                Console.Write($"{array[row, col] = randomNumber} ");
            }
            Console.WriteLine();
        }
    }

    public static void CheckHorizontalWin(int[,] array)
    {
        if((array[0, 0] == array[0, 1]) && (array[0, 1] == array[0, 2]))
        {
            Console.WriteLine("You won in top horizontal!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        else if((array[1, 0] == array[1, 1]) && (array[1, 1] == array[1, 2]))
        {
            Console.WriteLine("You won in middle horizontal!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        else if ((array[2, 0] == array[2, 1]) && (array[2, 1] == array[2, 2]))
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
        if((array[0, 0] == array[1, 0]) && (array[1, 0] == array[2, 0]))
        {
            Console.WriteLine("You won in left vertical!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        else if ((array[0, 1] == array[1, 1]) && (array[1, 1] == array[2, 1]))
        {
            Console.WriteLine("You won in middle vertical!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        else if ((array[0, 2] == array[1, 2]) && (array[1, 2] == array[2, 2]))
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
        if((array[0, 0] == array[1, 1]) && (array[1, 1] == array[2, 2]))
        {
            Console.WriteLine("You won in left diagonal!");
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
        else if ((array[0, 2] == array[1, 1]) && (array[1, 1] == array[2, 0]))
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