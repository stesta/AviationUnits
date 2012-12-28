using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Pound : Mass<Pound>
    {
        public Pound()
            : this (0.0)
        {

        }

        public Pound(IMass mass)
            : this(mass.To<Pound>().Value)
        {

        }

        public Pound(double value)
        {
            this.Factor = Factors.KilogramsPerPound;
            this.Label = "Pounds";
            this.Symbol = "lbs";
            this.Value = value;
        }

        public static implicit operator Pound(double value)
        {
            return new Pound(value);
        }
    }
}
