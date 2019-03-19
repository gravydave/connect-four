using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour_V0
{
    class MoveHandler
    {
        private Grid grid;

        //Constructor Uses the Grid to handle moves
        public MoveHandler(Grid grid)
        {
            this.grid = grid;
        }

        /*
         */
        private bool move(int turn)
        {
            int chosenColomn = selectColomn(turn);

            for(int rdx = 0; rdx < grid.getRows(); rdx++)           //placement of 'piece' represented by either a 1 or 2 (symbolic of players id)
            {
                int element = grid.getElementAt(chosenColomn, rdx); //element of the array at chosenColomn, row index

                if(element == 0) //IF the element at grid[chosenColomn, rdx] is empty, check next
                {
                    rdx++;
                }

                if(element != 0 && rdx != 0) //IF the element isnt a 0 AND rdx isnt 0
                {
                    rdx--;
                    grid.setElementAt(chosenColomn, rdx, turn);
                }
            }
        }


        /*
         * METHOD:   selectColomn
         * INPUT:    INT turn
         * RETURN:   INT 
         * ALGORITHM:
         *   choose a colomn between 1 and 7
         *   if colomn selection is outside those bounds
         *      
         */
        private int selectColomn(int turn)
        {
            Console.WriteLine("\nPlayer " + turn + ", which colomn shall you place your coin? (1 - 7 Inclusive) \n");

            int chosenColomn = int.Parse(Console.ReadLine());   //player Selects Colomn Between 1 - 7 Inclusive

            chosenColomn = chosenColomn - 1;                    //turn colomn choice into array format 0 to 6

            while (chosenColomn < 0 || chosenColomn > 6)         //choice validation for colomn selection
            {
                Console.WriteLine("\nInvalid choice Player " + turn +
                    ". Digits between 1 - 7 INCLUSIVE");

                chosenColomn = int.Parse(Console.ReadLine());

                chosenColomn = chosenColomn - 1;
            }

            return chosenColomn = int.Parse(Console.ReadLine()); //RETURN chosenColomn
        }
               
        //win acheived stub
        public bool gameWon() { return false; }

        //gameOver method stub (no more plays to be made)
        public bool gameOver() { return false; }

    }
}
