using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object1Box
{
    class Box
    {
        public double c { get; set; }
        public double sa;
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double pricePerInch2 { get; set; }

        public double Volume()
        {
            return x * y * z;
        }
        public double SurfaceArea()
        {
            sa = ((x * y) + (y * z) + (z * x)) * 2;
            return sa;
        }
        public double Cost()
        {
            return (sa * c);
        }

    }
}
