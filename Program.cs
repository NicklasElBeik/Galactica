using System;

namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceObjects spaceObjects = new SpaceObjects();
            SpaceObjects.Position position = new SpaceObjects.Position();
            { spaceObjects.Name = "Saturn"; spaceObjects.Id = 1; position.PositionX = 1; position.PositionY = 1; }
            Console.WriteLine(position);
            Console.ReadKey();
        }
    }
}
