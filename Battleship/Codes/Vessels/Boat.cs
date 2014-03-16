using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes
{
    class Boat
    {
        public bool sunken { get; set; }
        public Vessel type { get; set; }
        public string orientation { get; set; }
        public int damage { get; set; }

        public Boat(Vessel type, string orientation)
        {
            this.type = type;
            this.orientation = orientation;
            this.sunken = false;
            this.damage = 0;
        }
    }
}
