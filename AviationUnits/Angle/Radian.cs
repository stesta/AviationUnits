using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Radian : Angle<Radian>
    {
        public Radian()
            : this(0.0)
        {

        }

        public Radian(IAngle angle)
            : this(angle.To<Radian>().Value)
        {

        }

        public Radian(double value)
        {
            this.Factor = Factors.Radian;
            this.Label = "Radians";
            this.Symbol = "rad";
            this.Value = value;
        }

        public static implicit operator Radian(double value)
        {
            return new Radian(value);
        }
    }
}
