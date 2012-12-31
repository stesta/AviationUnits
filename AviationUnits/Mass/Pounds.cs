using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Pounds : Mass<Pounds>
    {
        public Pounds()
            : this (0.0)
        {

        }

        public Pounds(IMass mass)
            : this(mass.To<Pounds>().Value)
        {

        }

        public Pounds(double value)
        {
            this.Factor = Factors.KilogramsPerPound;
            this.Label = "Pounds";
            this.Symbol = "lbs";
            this.Value = value;
        }

        public static implicit operator Pounds(double value)
        {
            return new Pounds(value);
        }
    }
}
