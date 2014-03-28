using Battleship.Codes.Vessels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Battleship.Codes
{
    class Game
    {
        public Board board { get; set; }
        public List<Boat> boats { get; set; }

        public Game()
        {
            board = new Board();
            this.makeShips();
        }

        public void makeShips()
        {
            Random rnd = new Random();
            boats = new List<Boat>();

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

        public Boolean[] Shoot(int x, int y)
        {
            Boolean[] efective = { false, false };
            int status = board.shoot(x, y);
            if (status != 0 && status != 77)
            {
                efective[0] = true;
                efective[1] = this.TestSunkBoat(this.registerShoot(status));
            }

            return efective;
        }

        public int registerShoot(int status)
        {
            int index = -1;
            var shootedBoat = from Boat boat in boats
                              where boat.id == status
                              select boat;
            foreach (var item in shootedBoat)
            {
                item.damage += 1;
                index = boats.IndexOf(item);
            }
            return index;
        }

        public Boolean TestSunkBoat(int index)
        {
            Boolean boat = false;
            boat = boats[index].isSunked();
            return boat;
        }
    }
}
