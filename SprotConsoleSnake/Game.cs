using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SprotConsoleSnake
{
    public partial class Game
    {
        public static GameStatus status;

        public static Thread sleep { get; set; }
        public static int score { get; set; }

        public static void Start()
        {
            
            GameBoard.Board();
            var snake = new Snake(40, 20, 4);
            snake.FoodFactory();
            snake.Print();
            while (status != GameStatus.IsOver)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.SetDirection(key);
                }
                snake.FoodCheck();
                snake.Move(1);
                snake.Print();
                Thread.Sleep(300);
                snake.GameOver();
            }

            Console.ReadLine();


        }


        public static void ToDrawScore()
        {
            Console.SetCursorPosition(85, 0);
            Console.Write("You are lost!");
            Console.SetCursorPosition(85, 1);
            Console.Write($"Score: {score}");
        }
    }
}
