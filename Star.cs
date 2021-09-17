using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    class Star : SpaceObjects
    {
        public StarType Type { get; set; }
        public int Temperature { get; set; }

        public List<Planet> planets = new List<Planet>();
        public Position Coord { get; }
        public Star()
        {
            this.position = new Position();
        }
    }
        public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
}
