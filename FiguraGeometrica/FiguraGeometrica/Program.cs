using System;

namespace FiguraGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Círculo [1]");
            Console.WriteLine("Quadrado [2]");
            Console.WriteLine("Retangulo [3]");

            Console.WriteLine("Escolha um tipo:");
            int tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 1)
            {
                Console.WriteLine("Infome o valor do Raio:");
                double raio = Convert.ToDouble(Console.ReadLine());
                Circulo circulo = new Circulo(raio);
                Console.WriteLine("A área do círculo é: " + circulo.Area);
            }
            else if (tipo == 2)
            {

                Console.WriteLine("Infome o valor da base:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Infome o valor da altura:");
                double altura = Convert.ToDouble(Console.ReadLine());
                Quadrado quadrado = new Quadrado(altura, b);
                Console.WriteLine("A área do quadrado é: " + quadrado.Area);

            }
            else if (tipo == 3)
            {
                Console.WriteLine("Infome o valor da base:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Infome o valor da altura:");
                double altura = Convert.ToDouble(Console.ReadLine());
                Retangulo retangulo = new Retangulo(altura, b);
                Console.WriteLine("A área do retângulo é: " + retangulo.Area);

            }
        }
    }
}
