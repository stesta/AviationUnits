using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits.Speed
{
    public class MilesPerHour : Speed<MilesPerHour>
    {
        public MilesPerHour()
            : this(0.0)
        {

        }

        public static implicit operator MilesPerHour(double value)
        {
            return new MilesPerHour(value);
        }

        public MilesPerHour(double value)
        {
            this.Factor = Factors.KilometersPerHourPerMilePerHour;
            this.Label = "Miles Per Hour";
            this.Symbol = "mph";
            this.Value = value;
        }
    }
}
