using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma [1]");
            Console.WriteLine("Subtração [2]");
            Console.WriteLine("Divisão [3]");
            Console.WriteLine("Multiplicação [4]");
            Console.WriteLine("Raiz Quadrada [5]");
            Console.WriteLine("\r\nEscolha uma operação: ");
            int operacao = Convert.ToInt32(Console.ReadLine());

            if (operacao == 5)
            {
                Console.WriteLine("\r\nInforme o número: ");
                double n = Convert.ToDouble(Console.ReadLine());
                CalculadoraCientifica calculadoraCien = new CalculadoraCientifica(n, 0);
                Console.WriteLine("A raiz quadrada de " + n1 + " é igual a " + CalculadoraCientifica(n1, n2));
                
            }

            Console.WriteLine("\r\nInforme o primeiro número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\r\nInforme o segundo número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Calculadora calculadora = new Calculadora(n1, n2);
            if (operacao == 1)
            {
                Console.WriteLine("A soma entre " + n1 + " e " + n2 + " é igual a " + calculadora.Soma(n1, n2));
            }
            else if (operacao == 2)
            {
                Console.WriteLine("A subtração entre " + n1 + " e " + n2 + " é igual a " + calculadora.Subtracao(n1, n2));
            }
            else if (operacao == 3)
            {
                Console.WriteLine("A divisão entre " + n1 + " e " + n2 + " é igual a " + calculadora.Divisao(n1, n2));
            }
            else if (operacao == 4)
            {
                Console.WriteLine("A multiplicação entre " + n1 + " e " + n2 + " é igual a " + calculadora.Multiplicacao(n1, n2));
            }
            else if (operacao == 5)
            {
                CalculadoraCientifica calculadoraCien = new CalculadoraCientifica(n1);
                Console.WriteLine("A raiz quadrada de " + n1 + " é igual a " + CalculadoraCientifica(n1, n2));
            }
            else 
            {
                Console.WriteLine("Operação Inválida!!! ");
            }
        }
    }
}
