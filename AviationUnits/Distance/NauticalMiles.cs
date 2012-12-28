using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class NauticalMiles : Distance<NauticalMiles>
    {
        public NauticalMiles()
            : this(0.0)
        {

        }

        public NauticalMiles(IDistance distance)
            : this(distance.To<NauticalMiles>().Value)
        {

        }

        public NauticalMiles(double value)
        {
            this.Factor = Factors.MetersPerNauticalMile;
            this.Label = "Nautical Miles";
            this.Symbol = "M";
            this.Value = value;
        }

        public static implicit operator NauticalMiles(double value)
        {
            return new NauticalMiles(value);
        }
    }
}
