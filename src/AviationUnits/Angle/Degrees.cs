using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Degrees : Angle<Degrees>
    {
        public Degrees()
            : this(0.0)
        {

        }

        public Degrees(IAngle angle)
            : this(angle.To<Degrees>().Value)
        {
            
        }

        public Degrees(double value)
        {
            this.Factor = Factors.RadiansPerDegree;
            this.Label = "Degrees";
            this.Symbol = "°";
            this.Value = value;
        }

        public static implicit operator Degrees(double value)
        {
            return new Degrees(value);
        }
    }
}
