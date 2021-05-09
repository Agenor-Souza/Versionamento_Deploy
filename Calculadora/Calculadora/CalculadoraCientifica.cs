using System;
using System.Collections.Generic;
using System.Text;


namespace Calculadora
{
    class CalculadoraCientifica : Calculadora
    {
        public double Num { get; set; }

        CalculadoraCientifica(double num1, double num2)
            : base(num1, num2)
        {
            Num = num1;

        }
        
        public double Raiz(double num)
        {
            Resultado = Math.Sqrt(num);
            return Resultado;
        }



    }
}
