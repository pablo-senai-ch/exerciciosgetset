using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace dia_1506
{
    public class Retangulo
    {
        private double _Area;
        public double Base { get; set; }
        public double Altura { get; set; }
        
        public double CalcularArea()
        {
            double Altura = 100;
            double Base = 2;
            return _Area = Base * Altura;
        }
    }
}