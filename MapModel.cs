using System;
using System.Drawing;

namespace BattleShip
{
    public class MapModel2

    {
        public static void Main()
        {
            // ------------------- CREATING THE MAPMODEL FOR THE GAME ------------------------

            Console.WriteLine("  - - -     B A T T L E S H I P  M A P    - - -  \n\n");

            for (int i = 0; i < 12; i++)
            {
                Console.Write("{0,4}", Convert.ToChar(i + 65));
            }

            Console.WriteLine();

            for (int i = 0; i < 12; i++)
            {

                Console.Write("{0,-2}", Convert.ToChar(i + 65));


                for (int j = 0; j < 12; j++)
                {
                    if (i == 0 && j == 9) 
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]"); 
                        Console.ResetColor();
                    }
                    else if (i == 0 && j == 10) 
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]"); 
                        Console.ResetColor();
                    }
                    else if (i == 0 && j == 11) 
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();

                    }
                    else if (i == 2 && j == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 3 && j == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 4 && j == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }

                    else if (i == 5 && j == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }

                    else if (i == 5 && j == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 5 && j == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 5 && j == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 5 && j == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 5 && j == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 5 && j == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 6 && j == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();

                    }
                    else if (i == 6 && j == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 6 && j == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 4 && j == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 3 && j == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 6 && j == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 6 && j == 8)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 8 && j == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 7 && j == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 5 && j == 7)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 6 && j == 7)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 6 && j == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 6 && j == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 7 && j == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                 
                    else if (i == 6 && j == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 7 && j == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 8 && j == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else if (i == 9 && j == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,-4}", "[*]");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0,-4}", "[*]"); 
                        Console.ResetColor();
                    }
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }




    }

}
