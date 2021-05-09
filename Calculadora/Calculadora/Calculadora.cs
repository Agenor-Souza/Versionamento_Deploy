using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculadora
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Resultado { get; set; }

        public Calculadora(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;

        }


        public double Soma(double num1, double num2)
        {
            Resultado = num1 + num2;
            return Resultado;
        }

        public double Subtracao(double num1, double num2)
        {
            Resultado = num1 - num2;
            return Resultado;
        }
        public double Divisao(double num1, double num2)
        {
            Resultado = num1 / num2;
            return Resultado;
        }
        public double Multiplicacao(double num1, double num2)
        {
            Resultado = num1 * num2;
            return Resultado;
        }
    }
}
