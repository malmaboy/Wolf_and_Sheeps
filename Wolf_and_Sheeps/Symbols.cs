using System;
using System.Linq;

namespace Wolf_and_Sheeps
{
    public class Symbols
    {
        public const char X_symbol = 'X'; // Simbolo do Lobo
        public const char Space = ' ';
        public static char [,] symbols;
		public const char O_symbol = 'O'; // Simbolo da Ovelha

        public int wolf_pos_c;

        public int wolf_pos_l;

        public int sheep_pos_c;

        public int sheep_pos_l;

 
        public Symbols()
        {
            symbols = new char [BOARD.Dimension, BOARD.Dimension];
            InicialWolfs();
            InicialSheeps();
    
        } 

        public void InicialWolfs() // Desenha as peças de acordo com a escolha do jogador
        {
            bool check = false;

            while(check == false)
            {

                do
                {
                    Console.WriteLine("Escolha a posição do Lobo. ");
                    wolf_pos_c = Int32.Parse(Console.ReadLine());


                    switch(wolf_pos_c)
                    {

                        case 1:
                            check = true;
                            Symbols.symbols[0,1] = X_symbol;
                            break;
                        case 3:
                            check = true;
                            Symbols.symbols[0,3] = X_symbol;;
                            break;
                        case 5:
                            check = true;
                            Symbols.symbols[0,5] = X_symbol;;
                            break;
                        case 7:
                            check = true;
                            Symbols.symbols[0,7] = X_symbol;;
                            break;
                        default:
                            Console.WriteLine("Opção Invalida." );
                            break;
                    }
                }while(false);
            }

            
        }

        public void InicialSheeps()
        {
            Symbols.symbols[7,0] = O_symbol;
            Symbols.symbols[7,2] = O_symbol;
            Symbols.symbols[7,4] = O_symbol;
            Symbols.symbols[7,6] = O_symbol;
        }

    }
}