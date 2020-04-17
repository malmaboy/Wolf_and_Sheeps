using System;

namespace Wolf_and_Sheeps
{
    class Program
    {
        static void Main(string[] args)
        {
            Board();
        }

/*        static void Board() // Desenha o tabuleiro
        {
            string horizontalbar = "----------------";
            string verticalbar = "| ";
            string  Numbers = ("1 2 3 4 5 6 7 8");
            string letters = ("A B C D E F G H");
            int lins = 8, cols = 8, i, j;
            int[,] m = {  {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8}, };
            
          Console.WriteLine(Numbers);
            for (i = 0; i < lins; i++)
            {
                Console.WriteLine(horizontalbar);
                for (j = 0; j < cols; j++)
                    Console.Write("{0} ", m[i, j]);
                    Console.WriteLine(verticalbar);
                    
            }
        }

    }
}
