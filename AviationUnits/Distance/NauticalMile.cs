using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    public class NauticalMile : Distance<NauticalMile>
    {
        public NauticalMile()
            : this(0.0)
        {

        }

        public static implicit operator NauticalMile(double value)
        {
            return new NauticalMile(value);
        }

        public NauticalMile(double value)
        {
            this.Factor = Factors.MetersPerNauticalMile;
            this.Label = "Nautical Miles";
            this.Symbol = "M";
            this.Value = value;
        }
    }
}
