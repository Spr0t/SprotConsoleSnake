using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotConsoleSnake
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameBoard.Board();
            GameBoard g = new GameBoard();
            g.SnakeMove();
            g.GenerateFood();
            while (true)
            {
                g.Move();
                g.Clear();

            }
            



            Console.ReadLine();
        }
    }
}
