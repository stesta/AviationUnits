using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Knots : Speed<Knots>
    {
        public Knots()
            : this(0.0)
        {

        }

        public Knots(ISpeed speed)
            : this(speed.To<Knots>().Value)
        {

        }

        public Knots(double value)
        {
            this.Factor = Factors.KilometersPerHourPerKnot;
            this.Label = "Knots";
            this.Symbol = "knot";
            this.Value = value;
        }

        public static implicit operator Knots(double value)
        {
            return new Knots(value);
        }
    }
}
