using System;
using System.Linq;

namespace Wolf_and_Sheeps
{
    public class Symbols
    {
        public const char X_symbol = 'X';
        public const char Space = ' ';
        public static char [,] symbols;

        public Symbols()
        {
            symbols = new char [BOARD.dimension, BOARD.dimension];
            
        } 


    }
}