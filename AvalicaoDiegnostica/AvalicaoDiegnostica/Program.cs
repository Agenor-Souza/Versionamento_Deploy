using System;

namespace AvalicaoDiegnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int busca;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("digite o " + (i+1) + "º numero");
                n[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Qual numero deseja buscar?");
            busca = int.Parse(Console.ReadLine());
            
            
            for (int i = 0; i < n.Length; i++)
            {
                if (busca == n[i])
                {
                    Console.WriteLine("Número " + busca + " foi encontrado com sucesso!");
                    if (busca % 2 == 0 )
                    {
                        Console.WriteLine("É par");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("É impar");
                        break;
                    }
                }
                else if (busca != n[i] && i == n.Length)
                {
                    Console.WriteLine("O Número " + busca + " não foi encontrado");
                }
            }
        }
    }
}
