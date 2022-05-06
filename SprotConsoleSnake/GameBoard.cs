using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotConsoleSnake
{
     public class GameBoard
    {
        static public void Board()
        {
            int y = 0;

            for (int i = 0; i < 46; i++)
            {
                int x = 0;

                for (int j = 0; j < 80; j++)
                {
                    Console.SetCursorPosition(x, y);
                    if (x == 0 || x == 79 || y == 0 || y == 45)
                    {
                        Console.Write("█");/*▮🞒🞖█■*/
                    }
                    x++;
                }
                y++;
            }
        }

    }
}
