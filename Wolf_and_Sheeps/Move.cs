using System;
using System.Linq;

namespace Wolf_and_Sheeps
{
    /// <summary>
    /// Faz o movimento das peças
    /// </summary>
    public class move : Symbols // Importa a classe "Symbols"
    {
        // Variaveis 
        private int moveX;
        private int moveY;
        private int X;
        private int Y;

        public move()
        {
            moveX = 0;
            moveY = 0;
            X = 0;
            Y = 0;
            Exit = false;
        }

        public bool Exit {get; set; } 
    }
}