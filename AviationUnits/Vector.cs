using System;
using System.Net;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public struct Vector
    {
        private readonly ISpeed speed;
        private readonly Degree direction;

        public Vector(ISpeed speed, Degree direction)
        {
            this.speed = speed;
            this.direction = direction;
        }

        public ISpeed Speed { get { return speed; } }
        public Degree Direction { get { return direction; } }
    }
}
