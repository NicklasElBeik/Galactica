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
        public DateTime RotationPeriod { get; set; }
        public DateTime RevolutionPeriod { get; set; }
        public List <Moon> MoonList { get; set; }
        public double Distance(Star star, Planet planet)
        {
            double distance = Math.Sqrt(Math.Pow((star.position.PositionX - planet.position.PositionX), 2)
                + Math.Pow((star.position.PositionY - planet.position.PositionY), 2));
            return distance;
        }
    }
}
