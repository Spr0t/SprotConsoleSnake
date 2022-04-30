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
           Game g = new Game();
            GameBoard.Board();
            GameBoard.SnakeHead();
            GameBoard q = new GameBoard();
            q.Move();












            Console.ReadLine();
        }
    }
}
