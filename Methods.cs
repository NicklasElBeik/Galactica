using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    class Methods
    {
        public void AddView()
        {
            Star Sun = new Star();
            {
                Sun.Id = 1;
                Sun.Name = "Sun";
                Sun.Temperature = 5778000;
                Sun.Type = SpaceObjects.StarType.YellowDwarf;
            }
            Planet Mercury = new Planet();
            {
                Mercury.Id = 1;
                Mercury.Name = "Mercury";
                Mercury.position = (new SpaceObjects.Position() { PosX = 10, PosY = 10 });
                Mercury.Diameter = 10000;
                Mercury.RotationPeriod = 100;
                Mercury.RevolutionPeriod = 10;
                Mercury.Type = PlanetType.Terrestial;
            }
            Planet Venus = new Planet();
            {
                Venus.Id = 2;
                Venus.Name = "Venus";
                Venus.position = (new SpaceObjects.Position() { PosX = 20, PosY = 20 });
                Venus.Diameter = 20000;
                Venus.RotationPeriod = 200;
                Venus.RevolutionPeriod = 20;
                Venus.Type = PlanetType.Terrestial;
            }
            Planet Earth = new Planet();
            {
                Earth.Id = 3;
                Earth.Name = "Earth";
                Earth.position = (new SpaceObjects.Position() { PosX = 30, PosY = 30 });
                Earth.Diameter = 30000;
                Earth.RotationPeriod = 300;
                Earth.RevolutionPeriod = 30;
                Earth.Type = PlanetType.Terrestial;
            }
            Planet Mars  = new Planet();
            {
                Mars.Id = 4;
                Mars.Name = "Mars";
                Mars.position = (new SpaceObjects.Position() { PosX = 40, PosY = 40 });
                Mars.Diameter = 40000;
                Mars.RotationPeriod = 400;
                Mars.RevolutionPeriod = 40;
                Mars.Type = PlanetType.Terrestial;
            }
            Planet Jupiter = new Planet();
            {
                Jupiter.Id = 5;
                Jupiter.Name = "Jupiter";
                Jupiter.position = (new SpaceObjects.Position() { PosX = 50, PosY = 50 });
                Jupiter.Diameter = 50000;
                Jupiter.RotationPeriod = 500;
                Jupiter.RevolutionPeriod = 50;
                Jupiter.Type = PlanetType.Gas_Giant;
            }
            Planet Saturn = new Planet();
            {
                Saturn.Id = 6;
                Saturn.Name = "Saturn";
                Saturn.position = (new SpaceObjects.Position() { PosX = 60, PosY = 60 });
                Saturn.Diameter = 60000;
                Saturn.RotationPeriod = 600;
                Saturn.RevolutionPeriod = 60;
                Saturn.Type = PlanetType.Gas_Giant;
            }
            Planet Uranus = new Planet();
            {
                Uranus.Id = 7;
                Uranus.Name = "Ur-anus";
                Uranus.position = (new SpaceObjects.Position() { PosX = 70, PosY = 70 });
                Uranus.Diameter = 70000;
                Uranus.RotationPeriod = 700;
                Uranus.RevolutionPeriod = 70;
                Uranus.Type = PlanetType.Giant;
            }
            Planet Neptune = new Planet();
            {
                Neptune.Id = 8;
                Neptune.Name = "Neptune";
                Neptune.position = (new SpaceObjects.Position() { PosX = 80, PosY = 80 });
                Neptune.Diameter = 80000;
                Neptune.RotationPeriod = 800;
                Neptune.RevolutionPeriod = 80;
                Neptune.Type = PlanetType.Giant;
            }
            Moon Luna = new Moon();
            {
                Luna.Id = 1;
                Luna.Name = "Luna";
                Luna.Diameter = 1000;
                Luna.RotationPeriod = 100;
                Luna.RevolutionPeriod = 10;
                Luna.position = (new SpaceObjects.Position() { PosX = 15, PosY = 15 });
                Luna.Orbiting = Earth;
            }
            Moon Titan = new Moon();
            {
                Titan.Id = 2;
                Titan.Name = "Titan";
                Titan.Diameter = 2000;
                Titan.RotationPeriod = 200;
                Titan.RevolutionPeriod = 20;
                Titan.position = (new SpaceObjects.Position() { PosX = 65, PosY = 65 });
                Titan.Orbiting = Saturn;
            }
            Moon Phobos = new Moon();
            {
                Phobos.Id = 3;
                Phobos.Name = "Phobos";
                Phobos.Diameter = 3000;
                Phobos.RotationPeriod = 300;
                Phobos.RevolutionPeriod = 30;
                Phobos.position = (new SpaceObjects.Position() { PosX = 45, PosY = 45 });
                Phobos.Orbiting = Mars;
            }
            Moon Europa = new Moon();
            {
                Europa.Id = 4;
                Europa.Name = "Europa";
                Europa.Diameter = 4000;
                Europa.RotationPeriod = 400;
                Europa.RevolutionPeriod = 40;
                Europa.position = (new SpaceObjects.Position() { PosX = 55, PosY = 55 });
                Europa.Orbiting = Jupiter;
            }
            Moon Deimos = new Moon();
            {
                Deimos.Id = 5;
                Deimos.Name = "Deimos";
                Deimos.Diameter = 5000;
                Deimos.RotationPeriod = 500;
                Deimos.RevolutionPeriod = 50;
                Deimos.position = (new SpaceObjects.Position() { PosX = 48, PosY = 48 });
                Deimos.Orbiting = Mars;
            }
            Moon Ganymede = new Moon();
            {
                Ganymede.Id = 6;
                Ganymede.Name = "Ganymede";
                Ganymede.Diameter = 6000;
                Ganymede.RotationPeriod = 600;
                Ganymede.RevolutionPeriod = 60;
                Ganymede.position = (new SpaceObjects.Position() { PosX = 58, PosY = 58 });
                Ganymede.Orbiting = Jupiter;
            }
            Moon Io = new Moon();
            {
                Io.Id = 7;
                Io.Name = "Io";
                Io.Diameter = 7000;
                Io.RotationPeriod = 700;
                Io.RevolutionPeriod = 70;
                Io.position = (new SpaceObjects.Position() { PosX = 53, PosY = 53 });
                Io.Orbiting = Jupiter;
            }
            Moon Mimas = new Moon();
            {
                Mimas.Id = 8;
                Mimas.Name = "Mimas";
                Mimas.Diameter = 8000;
                Mimas.RotationPeriod = 800;
                Mimas.RevolutionPeriod = 80;
                Mimas.position = (new SpaceObjects.Position() { PosX = 68, PosY = 68 });
                Mimas.Orbiting = Saturn;
            }
            Earth.moons.Add(Luna);
            Saturn.moons.Add(Titan);
            Mars.moons.Add(Phobos);
            Jupiter.moons.Add(Europa);
            Mars.moons.Add(Deimos);
            Jupiter.moons.Add(Ganymede);
            Jupiter.moons.Add(Io);
            Saturn.moons.Add(Mimas);

            Sun.planets.Add(Mercury);
            Sun.planets.Add(Venus);
            Sun.planets.Add(Earth);
            Sun.planets.Add(Mars);
            Sun.planets.Add(Jupiter);
            Sun.planets.Add(Saturn);
            Sun.planets.Add(Uranus);
            Sun.planets.Add(Neptune);

            Console.WriteLine($"ID: {Sun.Id}    Name: {Sun.Name}    Type: {Sun.Type}\nTemperature: {Sun.Temperature}  Position: {Sun.position}");
            Console.WriteLine("\n\n######## Planets orbiting the Sun ########\n\n");
            foreach (var planet in Sun.planets)
            {
                Console.WriteLine($"ID: {planet.Id}     Name: {planet.Name}     Type: {planet.Type}" +
                    $"\nDiameter: {planet.Diameter}m     Rotation Period: {planet.RotationPeriod} hrs   Revolution Period: {planet.RevolutionPeriod} days" +
                    $"\nPosition: {planet.position}     Distance to Sun: {planet.Distance(Sun, planet)}\n\n");
                foreach (var moon in planet.moons)
                {
                    Console.WriteLine($"---------{planet.Name}'s moon---------");
                    Console.WriteLine($"ID: {moon.Id}     Name: {moon.Name}" +
                        $"\nOrbiting: {moon.Orbiting.Name}  Position: {moon.position}     Distance to {moon.Orbiting.Name}: {moon.Distance(moon, planet)}");
                    Console.WriteLine("--------------------------------------\n\n");
                }
            }
        }
    }
}
