using System;
using System.Drawing;

namespace BattleShip

{
    public class MapModel

    {

        public static void Main()


        {
            //  -------------------   CREATING THE MAPMODEL FOR THE GAME   ------------------------


            Console.WriteLine("  - - - - -    B A T T L E S H I P  M A P !    - - - - - -  \n\n");


            /*  > We start by creating an array in which we put the size of our matrix, being 12x12.
                  The numbers go from 1 to 12 as seen in the foor loop.                          */


            int[,] mapmodel = new int[12, 12];

            for (int i = 1; i < 12; i++)

            {
                for (int j = 1; j < 12; j++)

                {
                    mapmodel[i, j] = i * j;
                }

            }



            /*  > We use a bidimentional array in order to define two variables. In this case, we 
                  have the "i" and the "j" that will store the vakues of the rows and columns of
                  the matrix.                                                                  */



            for (int i = 1; i < 12; i++)

            {

                Console.WriteLine("___\n");  // > Making spaces between each column.

                for (int j = 1; j < 12; j++)

                {

                    if (i == 1 || j == 1)    /* > Creating a condition so that on only the first column
                                                  an the firt row are visible in the map. So, if i and j 
                                                  are equal to 1, the first row and column will show up. */

                    {

                        Console.Write("" + mapmodel[i, j] + " |  ");  // printing the first column and row. 

                    }

                    else    /* > Now, the rest of the numbers in the matrix wont be visible. They'll be 
                                 substitued with the color blue to simulate the water.               */


                    {

                        Console.Write("   . "); // Mirarlo luego. 


                    }

                }

                Console.WriteLine();

            }

            Console.ReadLine();

        }

    }

}

