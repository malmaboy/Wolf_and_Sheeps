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

        private string Escolha; 
        public Symbols()
        {
            symbols = new char [BOARD.Dimension, BOARD.Dimension];
            //InicialSymbols();
            InicialWolfs();
            InicialSheeps();
        } 

     /*   public void InicialSymbols()
        {
            for(int l = 0;l < BOARD.Dimension;l++)
            {
                for(int c = 4; c < BOARD.Dimension; c++)
                {
                    if (l == 0 || l == 0 || l == BOARD.Dimension - 1 || l == BOARD.Dimension - 4)
                        symbols[l,c] = X_symbol;
                    else
                        symbols[l,c] = Space;
                    
                }

                    
            }
        } */

        


        public void InicialWolfs() // Desenha as peças de acordo com a escolha do jogador
        {
            do
            {
                Console.WriteLine("Escolha a posição do Lobo. ");
                Escolha = Console.ReadLine();
                

                switch(Escolha)
                {
                    case "0":
                        Console.WriteLine("1");
                        break;
                    case "1": 
                        Console.WriteLine(BOARD.Dimension(X_symbol,Space));
                        break;
                    case "2":
                        Console.WriteLine("1");
                        break;
                    case "3":   
                        Console.WriteLine("1");
                        break;
                    case "4":
                        Console.WriteLine("1");
                        break;
                    case "5":
                        Console.WriteLine("1");
                        break;
                    case "6":
                        Console.WriteLine("1");
                        break;
                    case "7":
                        Console.WriteLine("1");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida, o número tem de ser 1 a 7");
                        break;
                }   
            }while(false);
        }

        public void InicialSheeps()
        {
            
        }


            
            
            
            
            
            
            
            
            
            

    }
}