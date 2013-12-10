using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class KilometersPerHour : Speed<KilometersPerHour>
    {
        public KilometersPerHour()
            : this(0.0)
        {

        }

        public KilometersPerHour(ISpeed speed)
            : this(speed.To<KilometersPerHour>().Value)
        {
        }

        public KilometersPerHour(double value)
        {
            this.Factor = Factors.KilometersPerHour;
            this.Label = "Kilometers Per Hour";
            this.Symbol = "km/h";
            this.Value = value;
        }

        public static implicit operator KilometersPerHour(double value)
        {
            return new KilometersPerHour(value);
        }
    }
}
