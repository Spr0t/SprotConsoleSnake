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
            Console.SetWindowSize(110, 48);
            Console.SetBufferSize(110, 48);
            Console.CursorVisible = false;

            Console.WriteLine("Welcome to snake game =)\nTo start - press 'Enter' ");
            Console.ReadLine();
            Console.Clear();
            Game.Start();

        }
    }
}
