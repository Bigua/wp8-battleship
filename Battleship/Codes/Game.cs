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
                boats.Add(new JetSki(10 + i, rnd.Next(1, 3)));
            }
            for (int i = 0; i < 3; i++)
            {
                boats.Add(new SpeedBoat(20 + i, rnd.Next(1, 3)));
            }
            for (int i = 0; i < 2; i++)
            {
                boats.Add(new Frigate(30 + i, rnd.Next(1, 3)));
            }
            for (int i = 0; i < 1; i++)
            {
                boats.Add(new Destroyer(40 + i, rnd.Next(1, 3)));
            }
            boats.Add(new AircraftCarrier(50, rnd.Next(1, 3)));

            board.populate(boats);
        }

        public Boolean Shoot(int x, int y)
        {
            Boolean efective = false;
            int status = board.shoot(x, y);
            Debug.WriteLine(status);
            if (status != 0 && status != 77)
            {
                efective = true;
            }
            return efective;
        }

        public void testEffective()
        {

        }

    }
}
