using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSpeed
{
    public class Sendung
    {
        public Sendung(double km)
        {
            this.Grundtarif = 0.30 + km * 0.05;
        }

        public double Grundtarif { get; set; }
    }
    public override string ToString()
    {

    }
}