using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', i - 1));
                Console.Write('*');
                Console.Write(new string('.', n - i));
                Console.WriteLine();
            }

            for (int i = 2; i <= n; i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write('*');
                Console.Write(new string('.', i - 1));
                Console.WriteLine();
            }

        }
    }

// - 100 points.

//*....
//.*...
//..*..
//...*.
//....*
//...*.
//..*..
//.*...
//*....

