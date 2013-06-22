using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int asteriks = 2 * i - 1;
                int dots = n - i - 1;
                Console.Write(new string('.', dots));
                Console.Write(new string('*', asteriks));
                Console.Write(new string('.', dots));
                Console.WriteLine();
            }
            {
                int asteriks = 1;
                int dots = n - 1;
                Console.Write(new string('.', n - 2));
                Console.Write(new string('*', asteriks));
                Console.Write(new string('.', n - 2));
                Console.WriteLine();
            }
        }
    }

