using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    class Planet : SpaceObjects
    {
        public double Diameter { get; set; }
        public double RotationPeriod { get; set; }
        public double RevolutionPeriod { get; set; }
        public PlanetType Type { get; set; }

        public List<Moon> moons = new List<Moon>();
        public double Distance(Star star, Planet planet)
        {
            double distance = Math.Sqrt(Math.Pow((star.position.PosX - planet.position.PosX), 2)
                + Math.Pow((star.position.PosY - planet.position.PosY), 2));
            return distance;
        }
    }
}
