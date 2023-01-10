using System;
using SlotMachine;

class Program
{
    const int INITIAL_CREDITS = 50;

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

        int betAmount = 0;

        //Console Key variable
        ConsoleKey key;

        int userAnswer;

        while (true)
        {
            UIMethods.DisplayIntroductionText(ref playerMoney);
            UIMethods.ChooseNumberOfLines(userOption);
            UIMethods.EnterBetAmount(betAmount, ref playerMoney);

            while (true)
            {
                UIMethods.StartSlotMachine();
                key = Console.ReadKey().Key;
                if (key != ConsoleKey.Spacebar)
                {
                    UIMethods.InvalidSlotMachineOption();
                }

                else
                {
                    break;
                }
            }

            if (key == ConsoleKey.Spacebar)
            {
                GameLogic.PrintSlotMachine(slotMachineGrid);
            }
        }
    }
}
