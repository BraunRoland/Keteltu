using System;
using System.Collections.Generic;
using System.Text;

namespace Keteltu
{
    internal class AmphibiousVehicle : ISailable, IDrivable
    {
        private int wheels;
        private int speed;
        private string anchored;

        public AmphibiousVehicle(int wheels, int speed)
        {
            this.wheels = wheels;
            this.speed = speed;
            this.anchored = "nincs horgonyozva";
        }

        public int Wheels { get => wheels; set => wheels = value; }
        public int Speed { get => speed; set => speed = value; }
        public string Anchored { get => anchored; set => anchored = value; }

        public void Drive(int km)
        {
            Console.WriteLine($"A kétéltű megtett {km} km-t.");
        }

        public string GetAnchorStatus()
        {
            return this.Anchored;
        }

        public int GetWheelsCount()
        {
            return this.Wheels;
        }

        public void Sail(int knots)
        {
            Console.WriteLine($"A kétéltű {knots} csomóval halad a vízen.");
            this.Speed = knots;
        }
    }
}
