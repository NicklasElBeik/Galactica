using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    class SpaceObjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position position { get; set; }
        public class Position
        {
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public override string ToString()
            {
                return "(" + PositionX + "," + PositionY + ")";
            }
        }
        public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }
    }
}
