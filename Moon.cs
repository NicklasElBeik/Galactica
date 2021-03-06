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
            double distance = Math.Sqrt(Math.Pow((moon.position.PosX - planet.position.PosX), 2)
                + Math.Pow((moon.position.PosY - planet.position.PosY), 2));
            return distance;
        }
    }
}
