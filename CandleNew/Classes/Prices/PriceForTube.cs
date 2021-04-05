using CandleNew.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.MyClasses
{
    class PriceForTube
    {
        public readonly Dictionary<string, double> PricesForTube
            = new Dictionary<string, double>
            {
                { "KV 10x10 mm", 0.50},
                { "KV 12x12 mm", 0.69},
                { "KV 14x14 mm", 0.97},
                { "TP 10x10x1,5", 0.25},
                { "TP 100x100x6", 8.84},
                { "TP 120x120x4", 7.37},
                { "TP 15x15x1,2", 0.34},
                { "TP 20x20x1,2", 0.47},
                { "TP 20x20x1,5", 0.58},
                { "TP 20x30x1,5", 0.82},
                { "TP 25x25x1,2", 0.59},
                { "TP 30x20x1,2", 0.68},
                { "TP 30x20x1,5", 0.74},
                { "TP 30x20x1,8", 0.63},
                { "TP 30x20x2", 0.73},
                { "TP 30x30x1,2", 0.72},
                { "TP 30x30x1,5", 0.90},
                { "TP 40x20x1,2", 0.72},
                { "TP 40x30x2", 0.81},
                { "TP 40x30x1,5", 1.07},
                { "TP 40x40x1,2", 0.97},
                { "TP 40x40x1,8", 1.04},
                { "TP 40x40x2", 1.11},
                { "TP 50x30x1,5", 1.23},
                { "TP 50x30x2", 1.11},
                { "TP 60x20x1,5", 1.20},
                { "TP 60x30x1,5", 1.36},
                { "TP 60x30x1,8", 1.27},
                { "TP 60x30x2", 1.28},
                { "TP 60x40x1,5", 1.47},
                { "TP 60x40x2", 1.41},
                { "TP 60x40x3", 2.36},
                { "TP 60x60x2", 2.02},
                { "TP 80x20x1,5", 1.63},
                { "TP 80x40x1,5", 1.85},
                { "TP 80x40x3", 2.62},
                { "TP 80x40x4", 3.40},
                { "TP 80x80x1,5", 3.29},
                { "TP 80x80x3", 3.83},
                { "TO 20x20x1,2", 0.75},
                { "TO 20x20x1,5", 0.92},
                { "TO 40x20x1,0", 0.98},
                { "TO 40x20x1,5", 1.43},
                { "TO 40x40x1,3", 1.26},
                { "TO 40x40x1,5", 1.94},
                { "TO 60x60x2", 3.92},
                { "TO 80x20x1,0", 1.67},
                { "TO 80x20x1,5", 2.46},

            };

    }
}

