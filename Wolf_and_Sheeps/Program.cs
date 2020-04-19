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
                    Board.MoveSheep();
                }

        }

    }
}
