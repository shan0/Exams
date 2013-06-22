using System;

class SandGlass
{
    static void Main()
    {
        int sandGlassHeight = int.Parse(Console.ReadLine());
        int sandGlassWidth = (sandGlassHeight + 1) / 2;
        string startAndEnd;
        string middle;
        string top;

        if (sandGlassHeight % 2 == 0)
        {
            Console.WriteLine("This number is not odd!");
        }
        else
        {
            top = new string('*', sandGlassHeight);
            Console.WriteLine(top);
            for (int j = sandGlassHeight - 2, i = 0; j >= 3; i++, j -= 2)
            {
                startAndEnd = new string('.', i + 1);
                middle = new string('*', j);

                Console.WriteLine(startAndEnd + middle + startAndEnd);
            }
            for (int i = sandGlassWidth, j = 1; i > 0; i--, j += 2)
            {
                startAndEnd = new string('.', i - 1);
                middle = new string('*', j);

                Console.WriteLine(startAndEnd + middle + startAndEnd);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}



//*****
//.***.
//..*..
//.***.
//*****

//*******
//.*****.
//..***..
//...*...
//..***..
//.*****.
//*******



