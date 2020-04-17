using System;
using System.Linq;




namespace Wolf_and_Sheeps
{
    public class BOARD
    {
		private string[,] BOARD;
		public const int Dimension = 8;

		private Move move;

		public BOARD()
		{
			move = new Move();
			BOARD = new string [Dimension,Dimension];
			HorizontalSymbol = "+---";
			VerticalSymbol = "| ";

		}

		public string HorizontalSymbol{get; set;}
		public string VerticalSymbol{get; set;}


		public void DisplayBoard()
		{
			while(!move.Exit)
			{
				Console.WriteLine("    0   1   2   3   4   5   6   7");
				
				for(int l = 0;l < Dimension;l++)
				{
					ConsoleWrite("  ");
					for(int c = 0;c < Dimension; c++)
					{
						Console.WriteLine(HorizontalSymbol);
					}

					Console.Write("+\n");

					for(int c = 0;c < Dimension;c++);
					{
						if (c == 0)
							Console.Write(l + " ");

						Console.WriteLine(VerticalSymbol + Symbols.symbols[l,c] + " ");
					}
					
					ConsoleWrite("|\n");
				}

			Console.Write("  ");
			for(int c = 0;c < Dimension; c++);
			{
				Console.WriteLine(HorizontalSymbol);
			}
				Console.Write("+\n\n");
			}
		}

		
    }
}