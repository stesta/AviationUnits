using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    public class Degree : Angle<Degree>
    {
        public Degree()
            : this(0.0)
        {

        }

        public static implicit operator Degree(double value)
        {
            return new Degree(value);
        }

        public Degree(double value)
        {
            this.Factor = Factors.RadiansPerDegree;
            this.Label = "Degrees";
            this.Symbol = "°";
            this.Value = value;
        }
    }
}
