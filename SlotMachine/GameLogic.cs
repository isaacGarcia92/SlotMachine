using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SlotMachine
{
    public static class GameLogic
    {
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

        public static void PrintSlotMachine(int[,] gameBoard)
        {
            Console.Clear();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    int randomNumber = rand.Next(0, 3);
                    Console.Write($"{gameBoard[row, col] = randomNumber} ");
                }
                Console.WriteLine();
            }
        }

        public static void CheckSlotWin(int option, Enum castedOption, int[,] gameBoard, int money, int bet)
        {
            
            switch (castedOption)
            {
                case LineOptions.CenterHorizontal:
                    if ((gameBoard[1, 0] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[1, 2]))
                    {
                        Console.WriteLine("You won in middle horizontal!");
                        money += bet * option;
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                    break;

                case LineOptions.TopAndBottomHorizontal:
                    if ((gameBoard[0, 0] == gameBoard[0, 1]) && (gameBoard[0, 1] == gameBoard[0, 2]))
                    {
                        Console.WriteLine("You won in top horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[2, 0] == gameBoard[2, 1]) && (gameBoard[2, 1] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in bottom horizontal!");
                        money += bet * option;
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                    break;

                case LineOptions.AllThreeHorizontal:
                    if ((gameBoard[0, 0] == gameBoard[0, 1]) && (gameBoard[0, 1] == gameBoard[0, 2]))
                    {
                        Console.WriteLine("You won in top horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[1, 0] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[1, 2]))
                    {
                        Console.WriteLine("You won in middle horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[2, 0] == gameBoard[2, 1]) && (gameBoard[2, 1] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in bottom horizontal!");
                        money += bet * option;
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                    break;

                case LineOptions.AllHorizonalAndLeftVertical:
                    if ((gameBoard[0, 0] == gameBoard[0, 1]) && (gameBoard[0, 1] == gameBoard[0, 2]))
                    {
                        Console.WriteLine("You won in top horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[1, 0] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[1, 2]))
                    {
                        Console.WriteLine("You won in middle horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[2, 0] == gameBoard[2, 1]) && (gameBoard[2, 1] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in bottom horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 0] == gameBoard[1, 0]) && (gameBoard[1, 0] == gameBoard[2, 0]))
                    {
                        Console.WriteLine("You won in left vertical!");
                        money += bet * option;
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                    break;

                case LineOptions.AllHorizontal_LeftAndMiddleVertical:
                    if ((gameBoard[0, 0] == gameBoard[0, 1]) && (gameBoard[0, 1] == gameBoard[0, 2]))
                    {
                        Console.WriteLine("You won in top horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[1, 0] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[1, 2]))
                    {
                        Console.WriteLine("You won in middle horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[2, 0] == gameBoard[2, 1]) && (gameBoard[2, 1] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in bottom horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 0] == gameBoard[1, 0]) && (gameBoard[1, 0] == gameBoard[2, 0]))
                    {
                        Console.WriteLine("You won in left vertical!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 1] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[2, 1]))
                    {
                        Console.WriteLine("You won in middle vertical!");
                        money += bet * option;
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                    break;

                case LineOptions.AllHorizontalAndVertical:
                    if ((gameBoard[0, 0] == gameBoard[0, 1]) && (gameBoard[0, 1] == gameBoard[0, 2]))
                    {
                        Console.WriteLine("You won in top horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[1, 0] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[1, 2]))
                    {
                        Console.WriteLine("You won in middle horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[2, 0] == gameBoard[2, 1]) && (gameBoard[2, 1] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in bottom horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 0] == gameBoard[1, 0]) && (gameBoard[1, 0] == gameBoard[2, 0]))
                    {
                        Console.WriteLine("You won in left vertical!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 1] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[2, 1]))
                    {
                        Console.WriteLine("You won in middle vertical!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 2] == gameBoard[1, 2]) && (gameBoard[1, 2] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in right vertical!");
                        money += bet * option;
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                    break;

                case LineOptions.AllHorizontal_VerticalAndLeftDiagonal:
                    if ((gameBoard[0, 0] == gameBoard[0, 1]) && (gameBoard[0, 1] == gameBoard[0, 2]))
                    {
                        Console.WriteLine("You won in top horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[1, 0] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[1, 2]))
                    {
                        Console.WriteLine("You won in middle horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[2, 0] == gameBoard[2, 1]) && (gameBoard[2, 1] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in bottom horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 0] == gameBoard[1, 0]) && (gameBoard[1, 0] == gameBoard[2, 0]))
                    {
                        Console.WriteLine("You won in left vertical!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 1] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[2, 1]))
                    {
                        Console.WriteLine("You won in middle vertical!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 2] == gameBoard[1, 2]) && (gameBoard[1, 2] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in right vertical!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 0] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in left diagonal!");
                        money += bet * option;
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                    break;

                case LineOptions.AllLines:
                    if ((gameBoard[0, 0] == gameBoard[0, 1]) && (gameBoard[0, 1] == gameBoard[0, 2]))
                    {
                        Console.WriteLine("You won in top horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[1, 0] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[1, 2]))
                    {
                        Console.WriteLine("You won in middle horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[2, 0] == gameBoard[2, 1]) && (gameBoard[2, 1] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in bottom horizontal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 0] == gameBoard[1, 0]) && (gameBoard[1, 0] == gameBoard[2, 0]))
                    {
                        Console.WriteLine("You won in left vertical!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 1] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[2, 1]))
                    {
                        Console.WriteLine("You won in middle vertical!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 2] == gameBoard[1, 2]) && (gameBoard[1, 2] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in right vertical!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 0] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[2, 2]))
                    {
                        Console.WriteLine("You won in left diagonal!");
                        money += bet * option;
                    }
                    else if ((gameBoard[0, 2] == gameBoard[1, 1]) && (gameBoard[1, 1] == gameBoard[2, 0]))
                    {
                        Console.WriteLine("You won in right diagonal!");
                        money += bet * option;
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                    break;
            }
        }
    }
}
