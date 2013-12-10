using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Kilometers : Distance<Kilometers>
    {
        public Kilometers()
            : this(0.0)
        {

        }

        public Kilometers(IDistance distance)
            : this(distance.To<Kilometers>().Value)
        {

        }

        public Kilometers(double value)
        {
            this.Factor = Factors.Kilometer;
            this.Label = "Kilometers";
            this.Symbol = "km";
            this.Value = value;
        }

        public static implicit operator Kilometers(double value)
        {
            return new Kilometers(value);
        }
    }
}
