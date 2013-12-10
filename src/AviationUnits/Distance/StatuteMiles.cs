using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class StatuteMiles : Distance<StatuteMiles>
    {
        public StatuteMiles()
            : this(0.0)
        {

        }

        public StatuteMiles(IDistance distance)
            : this(distance.To<StatuteMiles>().Value)
        {

        }

        public StatuteMiles(double value)
        {
            this.Factor = Factors.MetersPerStatuteMile;
            this.Label = "Statute Miles";
            this.Symbol = "mi";
            this.Value = value;
        }

        public static implicit operator StatuteMiles(double value)
        {
            return new StatuteMiles(value);
        }
    }
}
