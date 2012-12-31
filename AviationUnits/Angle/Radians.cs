using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Radians : Angle<Radians>
    {
        public Radians()
            : this(0.0)
        {

        }

        public Radians(IAngle angle)
            : this(angle.To<Radians>().Value)
        {

        }

        public Radians(double value)
        {
            this.Factor = Factors.Radian;
            this.Label = "Radians";
            this.Symbol = "rad";
            this.Value = value;
        }

        public static implicit operator Radians(double value)
        {
            return new Radians(value);
        }
    }
}
