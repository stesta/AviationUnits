using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class USGallons : Volume<USGallons>
    {
        public USGallons()
            : this(0.0)
        {

        }

        public USGallons(IVolume volume)
            : this(volume.To<USGallons>().Value)
        {

        }

        public USGallons(double value)
        {
            this.Factor = Factors.LitersPerUSGallon;
            this.Label = "U.S. Gallons";
            this.Symbol = "gal";
            this.Value = value;
        }

        public static implicit operator USGallons(double value)
        {
            return new USGallons(value);
        }
    }
}
