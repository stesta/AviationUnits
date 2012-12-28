using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    public sealed class Meter : Distance<Meter>
    {
        public Meter()
            : this (0.0)
        {

        }

        public static implicit operator Meter(double value)
        {
            return new Meter(value);
        }

        public Meter(double value)
        {
            this.Factor = Factors.Meter;
            this.Label = "Meters";
            this.Symbol = "m";
            this.Value = value;
        }
    }
}
