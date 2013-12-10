using System;
using System.Net;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public struct Vector
    {
        private readonly ISpeed speed;
        private readonly Degrees direction;

        public Vector(ISpeed speed, Degrees direction)
        {
            this.speed = speed;
            this.direction = direction;
        }

        public ISpeed Speed { get { return speed; } }
        public Degrees Direction { get { return direction; } }
    }
}
