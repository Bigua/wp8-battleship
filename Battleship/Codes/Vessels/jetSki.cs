﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes.Vessels
{
    class JetSki : Boat
    {
        public JetSki(int id, int orientation)
            : base(Vessel.jetSki, id, orientation)
        {
        }
    }
}
