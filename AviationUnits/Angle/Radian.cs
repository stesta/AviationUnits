using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    public class Radian : Angle<Radian>
    {
        public Radian()
            : this(0.0)
        {

        }

        public static implicit operator Radian(double value)
        {
            return new Radian(value);
        }

        public Radian(double value)
        {
            this.Factor = Factors.Radian;
            this.Label = "Radians";
            this.Symbol = "rad";
            this.Value = value;
        }
    }
}
