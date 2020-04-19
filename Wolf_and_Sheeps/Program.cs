using System;

namespace Wolf_and_Sheeps
{
    class Program
    {
        static void Main(string[] args)
        {
                BOARD Board = new BOARD();
                Board.InitialPos();
                Board.DisplayBoard();
                while(true)
                {
                    Board.MoveWolf();
                    if (Board.WolfWin() == true)
                    {
                        Console.WriteLine("O Lobo ganha!");
                        break;
                    }
                    Board.MoveSheep();
                }

        }

    }
}
