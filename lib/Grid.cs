using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour_V0
{
    public class Grid
    {
        //GLOBAL FIELDS
        private static readonly int colomns = 7;
        private static readonly int rows = 6;
        private int[,] grid = new int[colomns, rows];
        
        public Grid() => generateGrid();
        //Colomns
        /*   *   *   *   *   *   *   * 
         *   *   *   *   *   *   *   * 
         *   *   *   *   *   *   *   * 
         *   *   *   *   *   *   *   * 
         *   *   *   *   *   *   *   * 
         *   *   *   *   *   *   *   * 
         *   *   *   *   *   *   *   */ //6 Rows

        //ACCESS MODIFIERS
        public int getColomns() { return colomns; }                         //GET colomn access modifier
        public int getRows()    { return rows; }                            //GET row access modifier
        public int getElementAt(int cdx, int rdx) { return grid[cdx, rdx]; }//GET element access modifier
        public void setElementAt(int cdx, int rdx, int turn)                //SET element(colomn, row, turn) player1 = 1    player2 = 2
        {
            if (turn == 1)
            {
                grid[cdx, rdx] = 1;
            }
            else if(turn == 2)
            {
                grid[cdx, rdx] = 2;
            }
        }

        /*
         * METHOD: generateGrid
         * INPUT:  int colomns, int rows
         * RETURN: null
         * ALGORITHM:
         *   Nested FOR loops create 7 integer arrays of size 6 and populate with 0
         */
        private void generateGrid()
        {
            for (int cdx = 0; cdx < colomns; cdx++)//cdx = colomn index
            {
                for (int rdx = 0; rdx < rows; rdx++)//rdx = row index
                {
                    grid[cdx, rdx] = 0;
                }
            }
        }



        /*
        * METHOD: displayGrid
        * INPUT:  null
        * RETURN: null
        * ALGORITHM:
        *   Nested for loops that cycle through the rows of grid[,], 
        *   string formatting to display to console
        */
        public void displayGrid()
        {
            for (int rdx = 0; rdx < rows; rdx++)
            {
                for (int cdx = 0; cdx < colomns; cdx++)
                {
                    Console.Write(string.Format("{0} ", grid[cdx, rdx]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
