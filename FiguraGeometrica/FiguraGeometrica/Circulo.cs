using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
    class Circulo
    {
        public double Raio { get; set; }
        public double Pi = 3.14;
        public double Area { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
            Area = (raio * raio) * Pi;

        }
    }
}
