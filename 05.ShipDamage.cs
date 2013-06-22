using System;

    class Program
    {
        static void Main()
        {
            int sx1 = int.Parse(Console.ReadLine());
            int sy1 = int.Parse(Console.ReadLine());
            int sx2 = int.Parse(Console.ReadLine());
            int sy2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cx1 = int.Parse(Console.ReadLine());
            int cy1 = int.Parse(Console.ReadLine());
            int cx2 = int.Parse(Console.ReadLine());
            int cy2 = int.Parse(Console.ReadLine());
            int cx3 = int.Parse(Console.ReadLine());
            int cy3 = int.Parse(Console.ReadLine());
            cy1 = 2 * h - cy1;
            cy2 = 2 * h - cy2;
            cy3 = 2 * h - cy3;

            int minX = Math.Min(sx1, sx2);
            int maxX = Math.Max(sx1, sx2);
            int minY = Math.Min(sy1, sy2);
            int maxY = Math.Max(sy1, sy2);

            int damage = 0;
            if (((cx1 == minX) || (cx1 == maxX)) &&
                ((cy1 == minY) || (cy1 == maxY)))
            {
                //Corner
                damage += 25;
            }
            if (((cx1 > minX) && (cx1 < maxX)) &&
                ((cy1 == minY) || (cy1 == maxY)))
            {
                //Line Y
                damage += 50;
            }
            if (((cy1 > minY) && (cy1 < maxY)) &&
                 ((cx1 == minX) || (cx1 == maxX)))
            {
                //Line X
                damage += 50;
            }
            if (((cx1 > minX) && (cx1 < maxX)) &&
                 ((cy1 > minY) && (cy1 < maxY)))
            {
                //Inside
                damage += 100;
            }
            Console.WriteLine(damage + "%");

        }
    }

