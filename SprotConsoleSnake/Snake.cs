using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SprotConsoleSnake
{
    public partial class Snake
    {
        public List<Segment> Segments { get; set; }
        public int size => Segments.Count;
        
        ConsoleKeyInfo Key { get; set; }

        public Direction direction { get; set; }

        public Segment this[int index]
        {
            get { return Segments[index]; }
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int FoodX { get; set; }
        public int FoodY { get; set; } 

        public Snake(int X, int Y, int size)
        {

            Segments = new List<Segment>();
            for (var i = 0; i < size; i++)
            {
                Segments.Add(new Segment(X, Y + i));
            }
            direction = Direction.Up;
            Print();
            Game.status = Game.GameStatus.InProgress;
        }

        public void Move(int speed)
        {
            int x = 0, y = 0;

            Key = Console.ReadKey(true);

            if (Key.Key == ConsoleKey.A)
            {
                direction = Direction.Left;
            }
            if (Key.Key == ConsoleKey.D)
            {
                direction = Direction.Right;
            }
            if (Key.Key == ConsoleKey.W)
            {
                direction = Direction.Up;
            }
            if (Key.Key == ConsoleKey.S)
            {
                direction = Direction.Down;
            }

            switch (direction)
            {
                case Direction.Up:
                    y = -speed;
                    break;
                case Direction.Down:
                    y = speed;
                    break;
                case Direction.Left:
                    x = -(speed+1);
                    break;
                case Direction.Right:
                    x = (speed+1);
                    break;
            }
            for (var i = size - 1; i >= 1; i--)
            {
                Segments[i].X = Segments[i - 1].X;
                Segments[i].Y = Segments[i - 1].Y;
            }
            Segments[0].X += x;
            Segments[0].Y += y;


        }

        public void FoodCheck()
        {
            if (Segments[0].X == FoodX && Segments[0].Y == FoodY || Segments[0].X == FoodX - 1 && Segments[0].Y == FoodY || Segments[0].X == FoodX + 1 && Segments[0].Y == FoodY)
            {
                
                if (Segments[0].X == FoodX - 1 && Segments[0].Y == FoodY || Segments[0].X == FoodX + 1 && Segments[0].Y == FoodY)
                {
                    Console.SetCursorPosition(FoodX, FoodY);
                    Console.Write(" ");
                }
                FoodFactory();
                Segments.Add(new Segment(X, Y));
                Game.score++;

            }
        }

        public void FoodFactory()
        {
            var rnd = new Random();

            FoodX = rnd.Next(3, 77);
            FoodY = rnd.Next(3, 43);

            Console.SetCursorPosition(FoodX, FoodY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("О");
            Console.ResetColor();

        }

        public void Print()
        {
            for (var i = 0; i < Segments.Count; i++)
            {
                if (i == Segments.Count - 1)
                {
                    Console.SetCursorPosition(Segments[i].X, Segments[i].Y);
                    Console.Write(" ");
                }
                else
                {
                    Console.SetCursorPosition(Segments[i].X, Segments[i].Y);
                    Console.Write('*');
                }
            }
        }

        
        

        public void GameOver()
        {
            for (var i = 1; i < Segments.Count; i++)
            {
                if (Segments[0].X == Segments[i].X && Segments[0].Y == Segments[i].Y || Segments[0].X == 80 || Segments[0].X == 79 || Segments[0].X == 0 || Segments[0].Y == 45 || Segments[0].Y == 0)
                {
                    Game.status = Game.GameStatus.IsOver;
                    Game.ToDrawScore();
                }
            }
        }

    }
}
