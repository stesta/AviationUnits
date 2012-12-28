using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    public class Kilometer : Distance<Kilometer>
    {
        public Kilometer()
            : this(0.0)
        {

        }

        public static implicit operator Kilometer(double value)
        {
            return new Kilometer(value);
        }

        public Kilometer(double value)
        {
            this.Factor = Factors.Kilometer;
            this.Label = "Kilometers";
            this.Symbol = "km";
            this.Value = value;
        }
    }
}
