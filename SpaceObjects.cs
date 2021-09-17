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
            public int PosX { get; set; }
            public int PosY { get; set; }
            public override string ToString()
            {
                return $"({PosX},{PosY})";
            }
        }
        public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }
    }
}
