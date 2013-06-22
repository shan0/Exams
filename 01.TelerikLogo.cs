using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TelerikLogo
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int point1 = (N + 1) / 2;
        int point2 = point1;
        int point3 = 3 * N - 2 - point1 + 1;
        int point4 = point3;


        for (int i = 0; i < (N + 1) / 2; i++)
        {

            for (int j = 0; j < 3 * N - 2; j++)
            {
                if (j + 1 == point1 || j + 1 == point2 || j + 1 == point3 || j + 1 == point4)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }

            }
            Console.WriteLine();
            point1--;
            point2++;
            point3--;
            point4++;
        }
        for (int i = 0; i < (N - 1) / 2 + N - 1; i++)
        {

            for (int j = 0; j < 3 * N - 2; j++)
            {
                if (j + 1 == point2 || j + 1 == point3)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }

            }
            Console.WriteLine();

            point2++;
            point3--;

        }
        point2--;
        point3++;
        point2--;
        point3++;
        for (int i = 0; i < (N - 1); i++)
        {

            for (int j = 0; j < 3 * N - 2; j++)
            {
                if (j + 1 == point2 || j + 1 == point3)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }

            }
            Console.WriteLine();
            point2--;
            point3++;
        }

    }
}
