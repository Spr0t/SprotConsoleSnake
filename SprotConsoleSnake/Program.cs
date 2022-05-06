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
            Console.WriteLine("Welcome to snake game =)\nTo start - press 'Enter' ");
            Console.ReadLine();
            Console.Clear();
            Game.Start();

        }
    }
}
