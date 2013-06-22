using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 0; i++)
            {
                Console.Write(new string('.', n));
                Console.Write(new string('*', n));
                Console.WriteLine();
            }
            for (int i = 0; i <= n - 2; i++)
            {
                Console.Write(new string('.', n - i - 1));
                Console.Write('*');
                Console.Write(new string('.', n + i - 1));
                Console.Write('*');
                Console.WriteLine();
            }
            for (int i = 0; i <= 0; i++)
            {
                Console.Write(new string('*', 2 * n));
                Console.WriteLine();
            }
        }
    }



//.....*****
//....*....*
//...*.....*
//..*......*
//.*.......*
//**********

//100- points.


