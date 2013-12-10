using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class MilesPerHour : Speed<MilesPerHour>
    {
        public MilesPerHour()
            : this(0.0)
        {

        }

        public MilesPerHour(ISpeed speed)
            : this(speed.To<MilesPerHour>().Value)
        {

        }

        public MilesPerHour(double value)
        {
            this.Factor = Factors.KilometersPerHourPerMilePerHour;
            this.Label = "Miles Per Hour";
            this.Symbol = "mph";
            this.Value = value;
        }

        public static implicit operator MilesPerHour(double value)
        {
            return new MilesPerHour(value);
        }
    }
}
