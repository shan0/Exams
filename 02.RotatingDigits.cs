using System;

    class RotatingDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                int lastNumber = number % 10;
                number /= 10;

                string result = lastNumber.ToString() + number.ToString();
                number = int.Parse(result);
            }
            Console.WriteLine(number);
        }
    }

