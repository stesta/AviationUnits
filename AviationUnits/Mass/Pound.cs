using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    public class Pound : Mass<Pound>
    {
        public Pound()
            : this (0.0)
        {

        }

        public static implicit operator Pound(double value)
        {
            return new Pound(value);
        }

        public Pound(double value)
        {
            this.Factor = Factors.KilogramsPerPound;
            this.Label = "Pounds";
            this.Symbol = "lbs";
            this.Value = value;
        }
    }
}
