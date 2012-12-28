using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public abstract class Volume<T> : Unit<IVolume>, IVolume
        where T : IVolume
    {
        public override Type BaseUnit { get { throw new NotImplementedException(); } }
        public override double BaseUnitValue { get { throw new NotImplementedException(); } }
    }
}
