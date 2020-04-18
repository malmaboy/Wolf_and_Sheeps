using System;
using System.Linq;




namespace Wolf_and_Sheeps
{
    public class BOARD : Symbols
    {
		private string[,] Board;
		public const int Dimension = 8;

		

		public BOARD()
		{
			
			Board = new string [Dimension, Dimension];
			HorizontalSymbol = "+---";
			VerticalSymbol = "| ";

		}

		public string HorizontalSymbol{get; set;}
		public string VerticalSymbol{get; set;}


    public void DisplayBoard()
    {
        Console.WriteLine("    0   1   2   3   4   5   6   7"); 

        for(int l = 0; l < Dimension; l++)
        {
          Console.Write("  ");
          for (int c = 0; c < Dimension; c++)
          {
            Console.Write(HorizontalSymbol); 
          }

          Console.Write("+\n");

          for (int c = 0; c < Dimension; c++)
          {
            if (c == 0)
              Console.Write(l + " "); 

            Console.Write(VerticalSymbol + Symbols.symbols[l, c] + " "); 
          }

            Console.Write("|\n");
        }

      
      Console.Write("  "); 
      for (int c = 0; c < Dimension; c++)
      {
        Console.Write(HorizontalSymbol);
      }

      Console.Write("+\n\n");
        
      
    }

    public void MoveWolf()
    {
      
    } 

    public void MoveSheep() 
    {

    }
    
  }
}