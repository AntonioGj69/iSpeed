using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSpeed
{
    public class Brief : Sendung
    {

        public Brief(double Grundtarif) : base(Grundtarif)
        {
            
        }
        public int Größe { get; set; }
    }
}