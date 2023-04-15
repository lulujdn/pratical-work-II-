using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip

{
    public class Program

    {
      
        public static void Menu()

        {
            int option;
        
            while(true)


            {

              // ---------------------------------- C R E A T I N G  T H E  M E N U -------------------------------
   
                Console.WriteLine("    ___| |_____________________________________________________| |___      ");
                Console.WriteLine("  ( ___   _____________________________________________________   ___ )    ");
                Console.WriteLine("       | |                                                     | |         ");
                Console.WriteLine("       | |                                                     | |         "); 
                Console.WriteLine("       | |               WELCOME TO BATTLESHIP!                | |         ");
                Console.WriteLine("       | |                                                     | |         ");
                Console.WriteLine("       | |    Please choose an option down below:              | |         ");
                Console.WriteLine("       | |                                                     | |         ");
                Console.WriteLine("       | |    1. Load a previous game.                         | |         ");
                Console.WriteLine("       | |                                                     | |         ");
                Console.WriteLine("       | |    2. Two-Player game.                              | |         ");
                Console.WriteLine("       | |                                                     | |         ");
                Console.WriteLine("       | |    3. One-Player game.                              | |         ");
                Console.WriteLine("       | |                                                     | |         ");
                Console.WriteLine("       | |    4. Ranking.                                      | |         ");
                Console.WriteLine("       | |                                                     | |         ");
                Console.WriteLine("       | |    5. Exit game.                                    | |         ");
                Console.WriteLine("       | |                                                     | |         ");
                Console.WriteLine("    ___| |_____________________________________________________| |___      ");
                Console.WriteLine("  ( ___   _____________________________________________________   ___ )    ");
                Console.WriteLine("       | |                                                     | |         ");


                option = Int32.Parse(Console.ReadLine());


                switch (option)

                {
                    case 1:
                        {
                            Console.WriteLine("Which game would you like to load?");

                            switch(option)

                            {
                                case 1:
                                    break;
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine(" You've chosen two players.");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine(" You've chosen one player. ");
                            break;
                        }

                    case 4:
                        {
                            Console.Write("Here's the current ranking. ");
                            break;
                        }

                    case 5:
                        {
                            break;
                        }


                }


            }
           

        }


    }


}