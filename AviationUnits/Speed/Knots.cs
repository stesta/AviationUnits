using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits.Speed
{
    public class Knots : Speed<Knots>
    {
        public Knots()
            : this(0.0)
        {

        }

        public static implicit operator Knots(double value)
        {
            return new Knots(value);
        }

        public Knots(double value)
        {
            this.Factor = Factors.KilometersPerHourPerKnot;
            this.Label = "Knots";
            this.Symbol = "knot";
            this.Value = value;
        }
    }
}
