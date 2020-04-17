using System;
using System.Linq;

namespace Wolf_and_Sheeps
{
    public class Symbols
    {
        public const char X_symbol = 'X'; // Wolf Symbol
        public const char Space = ' ';
        public static char [,] symbols;
		public const char O_symbol = 'O'; // Sheep symbol

        public Symbols()
        {
            symbols = new char [BOARD.dimension, BOARD.dimension];
            
        } 


    }
}