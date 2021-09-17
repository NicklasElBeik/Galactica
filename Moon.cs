using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }
        public double Distance(Moon moon, Planet planet)
        {
            double distance = Math.Sqrt(Math.Pow((moon.position.PositionX - planet.position.PositionX), 2)
                + Math.Pow((moon.position.PositionY - planet.position.PositionY), 2));
            return distance;
        }
    }
}
