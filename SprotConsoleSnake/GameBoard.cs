using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotConsoleSnake
{
     public class GameBoard
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ConsoleKeyInfo Key { get; set; }

        static public void Board()
        {
            int y = 0;

            for (int i = 0; i < 46; i++)
            {
                int x = 0;

                for (int j = 0; j < 80; j++)
                {
                    Console.SetCursorPosition(x, y);
                    if (x == 0 || x == 79)
                        Console.Write("██");/*▮■*/

                    else if (y == 0 || y == 45)
                        Console.Write("█");
                    x++;
                }
                y++;
            }
        }

        static public void SnakeHead(int y = 40,int x = 23)
        {

            Console.SetCursorPosition(y, x);
            Console.Write("██");

        }

        public void Move() 
        {

            Key = Console.ReadKey();
           
            if(Key.Key == ConsoleKey.W)
           {
                SnakeHead(39, 23);
           }
            

        }

    }
}
