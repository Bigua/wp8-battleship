using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes
{
    enum Types { jetSky, speedboat, frigate, destroyer, aircraftCarrier }
    class Boat
    {
        public bool sunken { get; set; }
        public int type { get; set; }
        public string orientation { get; set; }
        public int damage { get; set; }

        public Boat(int type, string orientation)
        {
            this.type = type;
            this.orientation = orientation;
            this.sunken = false;
            this.damage = 0;
        }
    }
}
