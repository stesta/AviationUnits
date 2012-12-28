using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    public class KilometersPerHour : Speed<KilometersPerHour>
    {
        public KilometersPerHour()
            : this(0.0)
        {

        }

        public static implicit operator KilometersPerHour(double value)
        {
            return new KilometersPerHour(value);
        }

        public KilometersPerHour(double value)
        {
            this.Factor = Factors.KilometersPerHour;
            this.Label = "Kilometers Per Hour";
            this.Symbol = "km/h";
            this.Value = value;
        }
    }
}
