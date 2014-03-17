using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes.Vessels
{
    class AircraftCarrier : Boat
    { 
        public AircraftCarrier(int id, int orientation)
            : base(Vessel.aircraftCarrier, id, orientation)
        {

        }
    }
}
