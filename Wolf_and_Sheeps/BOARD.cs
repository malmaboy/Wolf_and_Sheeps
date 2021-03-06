using System;
using System.Linq;

namespace Wolf_and_Sheeps
{
    public class BOARD : Symbols
    {
        private string[,] Board;
        public const int Dimension = 8;

        public int mov_vertical;

        public int mov_horizontal;

        public bool win;

        public BOARD()
        {
            // Variaveis
            Board = new string[Dimension, Dimension];
            HorizontalSymbol = "+---";
            VerticalSymbol = "| ";

        }

        public string HorizontalSymbol { get; set; }
        public string VerticalSymbol { get; set; }


        public void DisplayBoard()  // Imprime o tabuleiro 8x8
        {
            Console.WriteLine("    0   1   2   3   4   5   6   7");

            for (int l = 0; l < Dimension; l++)
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

        public void InitialPos() // Imprime as posições iniciais das ovelhas e do lobo
        {
          // Posições das ovelhas
            sheep1_pos_l = 7;
            sheep2_pos_l = 7;
            sheep3_pos_l = 7;
            sheep4_pos_l = 7;
            sheep1_pos_c = 0;
            sheep2_pos_c = 2;
            sheep3_pos_c = 4;
            sheep4_pos_c = 6;

            Symbols.symbols[sheep1_pos_l, sheep1_pos_c] = O_symbol1;
            Symbols.symbols[sheep2_pos_l, sheep2_pos_c] = O_symbol2;
            Symbols.symbols[sheep3_pos_l, sheep3_pos_c] = O_symbol3;
            Symbols.symbols[sheep4_pos_l, sheep4_pos_c] = O_symbol4;

            bool check = false;
            // Posição do lobo e as escolha da posição do lobo
            while (check == false)
            {
                wolf_pos_l = 0;

                do
                {
                    Console.WriteLine("Escolha a posição do Lobo. ");
                    wolf_pos_c = Int32.Parse(Console.ReadLine());


                    switch (wolf_pos_c)
                    {

                        case 1:
                            check = true;
                            Symbols.symbols[0, 1] = X_symbol;
                            break;
                        case 3:
                            check = true;
                            Symbols.symbols[0, 3] = X_symbol; ;
                            break;
                        case 5:
                            check = true;
                            Symbols.symbols[0, 5] = X_symbol; ;
                            break;
                        case 7:
                            check = true;
                            Symbols.symbols[0, 7] = X_symbol; ;
                            break;
                        default:
                            Console.WriteLine("Opção Invalida.");
                            break;
                    }
                } while (false);
            }

        }

            public void MoveWolf() // Movimentação do lobo
            {

              Symbols.symbols[wolf_pos_l, wolf_pos_c] = Space;

              bool check = false;
              int l_check = wolf_pos_l;
              int c_check = wolf_pos_c;

              while(check == false)
              {
                Console.WriteLine("Linha do Lobo");
                wolf_pos_l = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Coluna do lobo");
                wolf_pos_c = Int32.Parse(Console.ReadLine());

                if (wolf_pos_c + 1 == c_check | wolf_pos_c - 1 == c_check)
                {
                  if (wolf_pos_l + 1 == l_check | wolf_pos_l - 1 == l_check)
                  {
                    check = true;
                  }

                  else
                  {
                    Console.WriteLine("Movimento Inválido");
                  }
                }

                else
                {
                  Console.WriteLine("Movimento Inválido");
                }

                if (PiecePositionWolf() == false & check == true)
                {
                  Symbols.symbols[wolf_pos_l, wolf_pos_c] = X_symbol;
                }

                else
                {
                  if (check == true)
                  {
                    Console.WriteLine("Movimento inválido");
                    check = false;
                  }
                }
              }

              DisplayBoard();

            }

            public void MoveSheep() // Movimentação da ovelha
            {
              int sheep_move = 0;

              bool check = false;


              Console.WriteLine("Escolha uma ovelha");

              while(check == false)
              {
                sheep_move = Int32.Parse(Console.ReadLine());

                if (1 <= sheep_move & sheep_move <= 4)
                {
                  check = true;
                }
              }

              if (sheep_move == 1)
              {
                Symbols.symbols[sheep1_pos_l, sheep1_pos_c] = Space;

                int c_check = sheep1_pos_c;

                if (sheep1_pos_l >= 1)
                {
                  sheep1_pos_l-=1;
                }

                check = false;

                while(check == false)
                {

                  Console.WriteLine("Coluna da Ovelha");
                  sheep1_pos_c = Int32.Parse(Console.ReadLine());

                  if (sheep1_pos_c + 1 == c_check | sheep1_pos_c - 1 == c_check)
                  {
                    check = true;
                  }

                  else
                  {
                    Console.WriteLine("Movimento Inválido");
                  }

                  if (PiecePositionSheep1() == false & check == true)
                  {
                    Symbols.symbols[sheep1_pos_l, sheep1_pos_c] = O_symbol1;
                  }

                  else
                  {
                    if (check == true)
                    {
                      Console.WriteLine("Movimento Inválido");
                      check = false;
                    }
                  }


                }

                DisplayBoard();
              }

              if (sheep_move == 2)
              {
                Symbols.symbols[sheep2_pos_l, sheep2_pos_c] = Space;

                int c_check = sheep2_pos_c;

                if (sheep2_pos_l >= 1)
                {
                  sheep2_pos_l-=1;
                }

                check = false;

                while(check == false)
                {

                  Console.WriteLine("Coluna da Ovelha");
                  sheep2_pos_c = Int32.Parse(Console.ReadLine());

                  if (sheep2_pos_c + 1 == c_check | sheep2_pos_c - 1 == c_check)
                  {
                    check = true;
                  }

                  else
                  {
                    Console.WriteLine("Movimento Inválido");
                  }
                }

                if (PiecePositionSheep2() == false & check == true)
                  {
                    Symbols.symbols[sheep2_pos_l, sheep2_pos_c] = O_symbol2;
                  }

                  else
                  {
                    if (check == true)
                    {
                      Console.WriteLine("Movimento Inválido");
                      check = false;
                    }
                  }

                DisplayBoard();
              }

              if (sheep_move == 3)
              {
                Symbols.symbols[sheep3_pos_l, sheep3_pos_c] = Space;

                int c_check = sheep3_pos_c;

                if (sheep3_pos_l >= 1)
                {
                  sheep3_pos_l-=1;
                }

                check = false;

                while(check == false)
                {

                  Console.WriteLine("Coluna da Ovelha");
                  sheep3_pos_c = Int32.Parse(Console.ReadLine());

                  if (sheep3_pos_c + 1 == c_check | sheep3_pos_c - 1 == c_check)
                  {
                    check = true;
                  }

                  else
                  {
                    Console.WriteLine("Movimento Inválido");
                  }
                }

                if (PiecePositionSheep3() == false & check == true)
                  {
                    Symbols.symbols[sheep3_pos_l, sheep3_pos_c] = O_symbol3;
                  }

                  else
                  {
                    if (check == true)
                    {
                      Console.WriteLine("Movimento Inválido");
                      check = false;
                    }
                  }

                DisplayBoard();
              }

              if (sheep_move == 4)
              {
                Symbols.symbols[sheep4_pos_l, sheep4_pos_c] = Space;

                int c_check = sheep4_pos_c;

                check = false;

                if (sheep3_pos_l >= 1)
                {
                  sheep3_pos_l-=1;
                }

                while(check == false)
                {

                  Console.WriteLine("Coluna da Ovelha");
                  sheep4_pos_c = Int32.Parse(Console.ReadLine());

                  if (sheep4_pos_c + 1 == c_check | sheep4_pos_c - 1 == c_check)
                  {
                    check = true;
                  }

                  else
                  {
                    Console.WriteLine("Movimento Inválido");
                  }
                }

                if (PiecePositionSheep4() == false & check == true)
                  {
                    Symbols.symbols[sheep4_pos_l, sheep4_pos_c] = O_symbol4;
                  }

                  else
                  {
                    if (check == true)
                    {
                      Console.WriteLine("Movimento Inválido");
                      check = false;
                    }
                  }

                DisplayBoard();

              } 
      
            }

            public bool PiecePositionWolf()
            {
              
              if (wolf_pos_l == sheep1_pos_l & wolf_pos_c == sheep1_pos_c)
              {
                return true;
              }
                
              if (wolf_pos_l == sheep2_pos_l & wolf_pos_c == sheep2_pos_c)
              {
                return true;
              }
                
              if (wolf_pos_l == sheep3_pos_l & wolf_pos_c == sheep3_pos_c)
              {
                return true;
              }
                
              if (wolf_pos_l == sheep4_pos_l & wolf_pos_c == sheep4_pos_c)
              {
                return true;
              }
                
              return false;
              
            }

            public bool PiecePositionSheep1()
            {
              if (wolf_pos_l == sheep1_pos_l & wolf_pos_c == sheep1_pos_c)
              {
                return true;
              }
                
              if (sheep1_pos_l == sheep2_pos_l & sheep1_pos_c == sheep2_pos_c)
              {
                return true;
              }
                
              if (sheep1_pos_l == sheep3_pos_l & sheep1_pos_c == sheep3_pos_c)
              {
                return true;
              }
                
              if (sheep1_pos_l == sheep4_pos_l & sheep1_pos_c == sheep4_pos_c)
              {
                return true;
              }
                
              return false;
            }

            public bool PiecePositionSheep2()
            {
              if (wolf_pos_l == sheep2_pos_l & wolf_pos_c == sheep2_pos_c)
              {
                return true;
              }
                
              if (sheep1_pos_l == sheep2_pos_l & sheep1_pos_c == sheep2_pos_c)
              {
                return true;
              }
                
              if (sheep2_pos_l == sheep3_pos_l & sheep2_pos_c == sheep3_pos_c)
              {
                return true;
              }
                
              if (sheep2_pos_l == sheep4_pos_l & sheep2_pos_c == sheep4_pos_c)
              {
                return true;
              }
                
              return false;
            }

            public bool PiecePositionSheep3()
            {
              if (wolf_pos_l == sheep3_pos_l & wolf_pos_c == sheep3_pos_c)
              {
                return true;
              }
                
              if (sheep1_pos_l == sheep3_pos_l & sheep1_pos_c == sheep3_pos_c)
              {
                return true;
              }
                
              if (sheep2_pos_l == sheep3_pos_l & sheep2_pos_c == sheep3_pos_c)
              {
                return true;
              }
                
              if (sheep3_pos_l == sheep4_pos_l & sheep3_pos_c == sheep4_pos_c)
              {
                return true;
              }
                
              return false;
            }

            public bool PiecePositionSheep4()
            {
              if (wolf_pos_l == sheep4_pos_l & wolf_pos_c == sheep4_pos_c)
              {
                return true;
              }
                
              if (sheep1_pos_l == sheep4_pos_l & sheep1_pos_c == sheep4_pos_c)
              {
                return true;
              }
                
              if (sheep4_pos_l == sheep3_pos_l & sheep4_pos_c == sheep3_pos_c)
              {
                return true;
              }
                
              if (sheep2_pos_l == sheep4_pos_l & sheep2_pos_c == sheep4_pos_c)
              {
                return true;
              }
                
              return false;
            }

            public bool WolfWin()
            {
              if (wolf_pos_l == 7)
              {
                return true;
              }

              return false;
            }

     

        }
    }
