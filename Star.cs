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
        public List <Planet> PlanetList { get; set; }
        public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
    }
}
