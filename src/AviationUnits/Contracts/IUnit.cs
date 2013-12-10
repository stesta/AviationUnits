using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits.Contracts
{
    public interface IUnit
    {
        double Value { get; set; }
        double Factor { get; }
        string Symbol { get; }

        Type BaseUnit { get; }
        double BaseUnitValue { get; }
    }
}
