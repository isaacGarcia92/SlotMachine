using System;

class Program
{
    static void Main(string[] args)
    {
        // 2D Array
        int[,] slotMachineGrid = new int[3, 3];

        // Random variable
        Random rand = new Random();

        // Filling array with random number
        for(int row=0; row<3; row++)
        {
            for (int col=0; col<3; col++)
            {
                int randomNumber = rand.Next(0, 3);
                Console.Write($"{slotMachineGrid[row, col] = randomNumber} ");
            }
            Console.WriteLine();
        }

        // Check if middle row is all the same
        if ((slotMachineGrid[1, 0] == slotMachineGrid[1, 1]) && (slotMachineGrid[1, 1] == slotMachineGrid[1, 2]))
        {
            Console.WriteLine("You won!");
        }
        else
        {
            Console.WriteLine("You lost!");
        }
    }
}