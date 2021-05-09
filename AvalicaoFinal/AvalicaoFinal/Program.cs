using System;

namespace AvalicaoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 3)
            {
                Console.WriteLine("Funcionario terceirizado? [Sim/Não]");
                string resp = Console.ReadLine();
                if (resp.ToUpper() == "SIM")
                {
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Carga horária:");
                    int cargaH = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor da hora:");
                    double valorH = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Empresa de origem:");
                    string nomeEmp = Console.ReadLine();
                    Console.WriteLine("Valor da taxa adicional (%):");
                    double tx = Convert.ToDouble(Console.ReadLine());


                    FuncionarioTerceirizado funcionarioTerc = new FuncionarioTerceirizado(nome, cargaH, valorH, nomeEmp, tx);
                    Console.WriteLine("Nome: " + funcionarioTerc.Nome);
                    Console.WriteLine("Nome da empresa de origem: " + funcionarioTerc.EmpresaOrigem);
                    Console.WriteLine("Salário: " + funcionarioTerc.calculaSalario(cargaH, valorH, tx));

                }
                else
                {
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Carga horária: ");
                    int cargaH = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor da hora: ");
                    double valorH = Convert.ToDouble(Console.ReadLine());

                    Funcionario funcionario = new Funcionario(nome, cargaH, valorH);
                    Console.WriteLine("Nome: " + funcionario.Nome);
                    Console.WriteLine("Salário: " + funcionario.calculaSalario(cargaH, valorH));
                }
                i += 1;
            }
        }
    }
}
