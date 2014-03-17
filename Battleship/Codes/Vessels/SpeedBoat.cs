using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes.Vessels
{
    class SpeedBoat : Boat
    {
        public SpeedBoat(int id, int orientation)
            : base(Vessel.speedboat, id, orientation)
        {

        }
    }
}
