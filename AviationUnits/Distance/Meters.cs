using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Meters : Distance<Meters>
    {
        public Meters()
            : this(0.0)
        {

        }

        public Meters(IDistance distance)
            : this(distance.To<Meters>().Value)
        {
            
        }

        public Meters(double value)
        {
            this.Factor = Factors.Meter;
            this.Label = "Meters";
            this.Symbol = "m";
            this.Value = value;
        }

        public static implicit operator Meters(double value)
        {
            return new Meters(value);
        }
    }
}
