using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes.Vessels
{
    class Destroyer : Boat
    {
        public Destroyer(int id, int orientation)
            : base(Vessel.destroyer, id, orientation)
        {

        }
    }
}
