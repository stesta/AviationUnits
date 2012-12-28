using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Degree : Angle<Degree>
    {
        public Degree()
            : this(0.0)
        {

        }

        public Degree(IAngle distance)
            : this(distance.To<Degree>().Value)
        {
            
        }

        public Degree(double value)
        {
            this.Factor = Factors.RadiansPerDegree;
            this.Label = "Degrees";
            this.Symbol = "°";
            this.Value = value;
        }

        public static implicit operator Degree(double value)
        {
            return new Degree(value);
        }
    }
}
