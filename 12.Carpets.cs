﻿using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int lines = int.Parse(input);
            int elementsOnLines = lines;
            int center = elementsOnLines / 2;

            for (int i = 1; i <= lines / 2; i++)
            {
                int elPos = 1;
                while (elPos <= elementsOnLines)
                {
                    if ((elPos <= center - i) || (elPos > center + i))
                    {
                        Console.Write(".");
                        elPos++;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("/");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }

                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("\\");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                            
                        }
                    }
                }
                Console.WriteLine();
            }
            for (int i = lines / 2; i > 0; i--)
            {
                int elPos = 1;
                while (elPos <= elementsOnLines)
                {
                    if ((elPos <= center - i) || (elPos > center + i))
                    {
                        Console.Write(".");
                        elPos++;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("\\");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("/");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }

                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
