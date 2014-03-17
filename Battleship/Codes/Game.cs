using Battleship.Codes.Vessels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes
{
    class Game
    {
        Board board;
        public Game()
        {
            board = new Board();
            this.makeShips();

        }

        public void makeShips()
        {
            Random rnd = new Random();

            List<Boat> boats = new List<Boat>();

            for (int i = 0; i < 4; i++)
            {
                boats.Add(new SpeedBoat(10 + i, rnd.Next(1, 3)));
            }
            board.populate(boats);
        }

    }
}
