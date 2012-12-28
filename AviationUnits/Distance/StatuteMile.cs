using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    public class StatuteMile : Distance<StatuteMile>
    {
        public StatuteMile()
            : this(0.0)
        {

        }

        public static implicit operator StatuteMile(double value)
        {
            return new StatuteMile(value);
        }

        public StatuteMile(double value)
        {
            this.Factor = Factors.MetersPerStatuteMile;
            this.Label = "Statute Miles";
            this.Symbol = "mi";
            this.Value = value;
        }
    }
}
