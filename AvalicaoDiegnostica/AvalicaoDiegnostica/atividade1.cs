using System;

namespace AvalicaoDiegnostica
{
    class Atividade1
    {
        static void Main(string[] args)
        {
            float[] salario = new float[10];
            int[] anos = new int[10];
            int reajuste = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("digite o salário do " + (i+1) + "º funcionário");
                salario[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ha quanto tempo ele esta na empresa?");
                anos[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Os salários reajustados são: ");
            
            
            for (int i = 0; i < salario.Length; i++)
            {
                if (anos[i] < 5)
                {
                    reajuste = 0;
                }
                else if (anos[i] == 5)
                {
                    reajuste = 20;
                }
                else if (anos[i] == 6)
                {
                    reajuste = 25;
                }
                else if (anos[i] == 7)
                {
                    reajuste = 30;
                }
                else if (anos[i] == 8)
                {
                    reajuste = 40;
                }
                else if (anos[i] == 9)
                {
                    reajuste = 50;
                }
                else if (anos[i] >= 10)
                {
                    reajuste = 60;
                }
                Console.WriteLine($"O funcionario esta na empresa a {anos[i]} anos");
                Console.WriteLine($"O novo salário é: R${salario[i] * (1 + reajuste/100)}, reajustado em {reajuste}%");
            }
        }
    }
}
