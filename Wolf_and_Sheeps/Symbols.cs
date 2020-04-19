using System;
using System.Linq;

namespace Wolf_and_Sheeps
{
    public class Symbols
    {
        public const char X_symbol = 'X'; // Simbolo do Lobo
        public const char Space = ' ';
        public static char [,] symbols;
		public const char O_symbol1 = '1'; // Simbolos das Ovelhas

        public const char O_symbol2 = '2';

        public const char O_symbol3 = '3';

        public const char O_symbol4 = '4';

        public int wolf_pos_c;

        public int wolf_pos_l;

        public int sheep1_pos_c;

        public int sheep1_pos_l;

        public int sheep2_pos_c;

        public int sheep2_pos_l;

        public int sheep3_pos_c;

        public int sheep3_pos_l;

        public int sheep4_pos_c;

        public int sheep4_pos_l;

 
        public Symbols()
        {
            symbols = new char [BOARD.Dimension, BOARD.Dimension];

        } 


    }
}