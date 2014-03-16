using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes.Vessels
{
    class AircraftCarrier : Boat
    { 
        public AircraftCarrier(string orientation)
            : base(Vessel.aircraftCarrier, orientation)
        {

        }
    }
}
