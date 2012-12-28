using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits.Pressure
{
    public class Pressure<T> : Unit<IPressure>, IUnit
        where T : IPressure
    {
        public override Type BaseUnit
        {
            get { throw new NotImplementedException(); }
        }
    }
}
