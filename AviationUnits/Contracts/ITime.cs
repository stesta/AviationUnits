using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits.Contracts
{
    public interface ITime : IUnit
    {
        int Hours { get; set; }
        int Minutes { get; set; }
        int Seconds { get; set; }
    }
}
