using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes
{
    class Board
    {
        int[,] grid = { { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                      };
        public Board()
        { 
            this.print();
        }

        public void print()
        {
            for (int i = 0; i < 10; i++)
            {
                string line = "";
                for (int j = 0; j < 10; j++)
                {
                    line = line + Convert.ToString(grid[i, j]);
                }
                Debug.WriteLine(line);
            }

        }
    }
}
