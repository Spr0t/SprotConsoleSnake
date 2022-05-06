using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotConsoleSnake
{
   public class Game
   {

        public static void Start()
        {
            GameBoard.Board();
            var snake = new Snake(40, 20, 4);
            snake.FoodFactory();
            snake.Print();
            while (true)
            {
                snake.FoodCheck();
                snake.Move(1);
                snake.Print();
                
            }

        }



    }
}
