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
        public int PreX { get; set; }
        public int PreY { get; set; }
        public int FoodX { get; set; }
        public int FoodY { get; set; }
        public ConsoleKeyInfo Key { get; set; }

        public int XW { get; set; }
        public int YW { get; set; }
        public int XA { get; set; }
        public int YA { get; set; }
        public int XS { get; set; }
        public int YS { get; set; }
        public int XD { get; set; }
        public int YD { get; set; }



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

        public void SnakeMove(int x = 40,int y = 23)
        {
            X = x;
            Y = y;
            Console.SetCursorPosition(X, Y);
            Console.Write("*");
           
        }

        public void Previous()
        {
            PreX = X;
            PreY = Y;
        }

        public void Move() 
        {
            Key = Console.ReadKey(true);
           
            if(Key.Key == ConsoleKey.W)
            {
                Previous();
                Y--;
                
                SnakeMove(X, Y);

            }
            if (Key.Key == ConsoleKey.S)
            {
                Previous();
                Y++;
                
                SnakeMove(X, Y);

            }
                
            if (Key.Key == ConsoleKey.A)
            {
                Previous();
                X--;
                
                SnakeMove(X, Y);

            }
                
            if (Key.Key == ConsoleKey.D)
            {
                Previous();
                X++;
                
                SnakeMove(X, Y);
            }
                
                     
        }

        public void Clear()
        {
            Console.SetCursorPosition(PreX, PreY);
            Console.Write(" ");
            if (X == FoodX && Y == FoodY)
            {
                GenerateFood();
            }



        }





        public void GenerateFood()
        {
            var rnd = new Random();

            FoodX = rnd.Next(3,77);
            FoodY = rnd.Next(3,43);

            Console.SetCursorPosition(FoodX, FoodY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("О");
            Console.ResetColor(); 

        }



    }
}
