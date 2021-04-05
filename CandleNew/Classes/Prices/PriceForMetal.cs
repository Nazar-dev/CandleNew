using CandleNew.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.MyClasses
{
    class PriceForMetal
        
    {

        public readonly Dictionary<string, double> PricesForMetal
            = new Dictionary<string, double>
            {
                { "HK 0.8mm", 3.76},
                { "HK 1mm", 4.37 },
                { "HK 1.5mm", 6.58},
                { "OC 0.8mm", 3.76},
                { "OC 1mm", 4.79},
                { "OC 1.5mm", 7.32},
                { "GK 2mm", 7.75 },
                { "GK 3mm", 13.45 },
                { "GK 4mm", 16.58 },
                { "GK 5mm", 18 },
                { "GK 6mm", 23.91 } ,
                { "GK 8mm", 31.87 },
                { "GK 10mm", 39.86},
                { "GK 12mm", 42.47},
                { "GK 14mm", 58.42},
                { "GK 16mm", 65.49},


            };


    }
}
