using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Millibars : Pressure<Millibars>
    {
        public Millibars()
            : this(0.0)
        {

        }

        public Millibars(IPressure pressure)
            : this(pressure.To<Millibars>().Value)
        {

        }

        public Millibars(double value)
        {
            this.Factor = Factors.InchesOfMercuryPerMillibar;
            this.Label = "Millibars";
            this.Symbol = "millibars";
            this.Value = value;
        }

        public static implicit operator Millibars(double value)
        {
            return new Millibars(value);
        }
    }
}
