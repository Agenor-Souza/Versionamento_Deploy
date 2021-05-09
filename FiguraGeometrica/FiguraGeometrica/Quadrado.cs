using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
    class Quadrado 
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Area { get; set; }


        public Quadrado(double altura, double b)
        {
            Altura = altura;
            Base = b;
            Area = Base * Altura;
        }



    }
}
