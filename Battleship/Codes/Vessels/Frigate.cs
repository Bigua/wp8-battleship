using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes.Vessels
{
    class Frigate : Boat
    {
        public Frigate(int id, int orientation)
            : base(Vessel.frigate, id, orientation)
        {

        }
    }
}
