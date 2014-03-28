
namespace Battleship.Codes
{
    class Boat
    {
        public bool sunken { get; set; }
        public Vessel type { get; set; }
        public int orientation { get; set; }
        public int damage { get; set; }
        public int id { get; set; }

        public Boat(Vessel type, int id, int orientation)
        {
            this.id = id;
            this.type = type;
            this.orientation = orientation;
            this.sunken = false;
            this.damage = 0;
        }

        public bool isSunked()
        {
            bool status = false;
            if (damage >= (int)type)
            {
                status = true;
            }
            return status;
        }
    }
}
