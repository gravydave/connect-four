using System;

namespace ConnectFour_V0
{
    class ConnectFour
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid();
            grid.displayGrid();
            MoveHandler mvh = new MoveHandler(grid);
        }
    }
}
