using System;

class Program
{
    enum TypeOfLine
    {
        Horizontal = 'h',
        Vertical = 'v',
        Diagonal = 'd',
    }

    static Random rand = new Random();

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

        string userOption = Console.ReadLine();
        char firstCharacter = userOption[0];
        TypeOfLine castedUserOption = (TypeOfLine)firstCharacter;

        // Checking if user option is invalid
        while(castedUserOption != TypeOfLine.Horizontal && castedUserOption != TypeOfLine.Vertical &&
            castedUserOption != TypeOfLine.Diagonal)
        {
            Console.WriteLine("Invalid Option");
            userOption = Console.ReadLine();
            firstCharacter = userOption[0];
            castedUserOption = (TypeOfLine)firstCharacter;
        }

        // Starting slot machine
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

                switch (castedUserOption)
                {
                    case TypeOfLine.Horizontal:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[0, 1]) && (slotMachineGrid[0, 1] == slotMachineGrid[0, 2]))
                        {
                            Console.WriteLine("You won in top horizontal!");
                            Console.WriteLine("Thanks for playing!");
                            return;
                        }
                        else if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
                        {
                            Console.WriteLine("You won in middle horizontal!");
                            Console.WriteLine("Thanks for playing!");
                            return;
                        }
                        else if ((slotMachineGrid[2, 0] == slotMachineGrid[2, 1]) && (slotMachineGrid[2, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in bottom horizontal!");
                            Console.WriteLine("Thanks for playing!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Try again with spacebar to keep playing!");
                        }
                        break;

                    case TypeOfLine.Vertical:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[1, 0]) && (slotMachineGrid[1, 0] == slotMachineGrid[2, 0]))
                        {
                            Console.WriteLine("You won in left vertical!");
                            Console.WriteLine("Thanks for playing!");
                            return;
                        }
                        else if ((slotMachineGrid[0, 1] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 1]))
                        {
                            Console.WriteLine("You won in middle vertical!");
                            Console.WriteLine("Thanks for playing!");
                            return;
                        }
                        else if ((slotMachineGrid[0, 2] == slotMachineGrid[1, 2]) && (slotMachineGrid[1, 2] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in right vertical!");
                            Console.WriteLine("Thanks for playing!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Try again with spacebar to keep playing!");
                        }
                        break;

                    case TypeOfLine.Diagonal:
                        if ((slotMachineGrid[0, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 2]))
                        {
                            Console.WriteLine("You won in left diagonal!");
                            Console.WriteLine("Thanks for playing!");
                            return;
                        }
                        else if ((slotMachineGrid[0, 2] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[2, 0]))
                        {
                            Console.WriteLine("You won in right diagonal!");
                            Console.WriteLine("Thanks for playing!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Try again with spacebar to keep playing!");
                        }
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
}