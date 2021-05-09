using System;

namespace BancoAula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente cliente = new Cliente("Roberto", 213405, 302, 1000.00);

            //cliente.Saque(100);
            //cliente.Deposito(50);

            //Console.WriteLine("Nome: " + cliente.GetNome());
            //Console.WriteLine("Conta: " + cliente.GetContaCorrente());
            //Console.WriteLine("Agência: " + cliente.GetAgencia());
            //Console.WriteLine("Saldo: R$ " + cliente.GetSaldo().ToString("F2"));


            ContaCorrente contaCorrente = new ContaCorrente("Agenor", 12345, 10000.00);
            contaCorrente.Deposito(100);
            contaCorrente.Transferencia(200);
            contaCorrente.Saque(150);
            contaCorrente.SetTaxa(15);

            Console.WriteLine("Nome: " + contaCorrente.GetNome());
            Console.WriteLine("Conta Corrente: " + contaCorrente.GetContaCorrente());
            Console.WriteLine("Saldo: R$ " + contaCorrente.GetSaldo().ToString("F2"));
            Console.WriteLine("");
            Console.WriteLine("Extrato: " + contaCorrente.GetExtrato());

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            ContaPoupanca contaPoupanca = new ContaPoupanca("Agenor", 12345, 10000.00, 65656, 0.05);
            Console.WriteLine("Nome: " + contaPoupanca.GetNome());
            Console.WriteLine("Conta Corrente: " + contaPoupanca.GetContaCorrente());
            
            Console.WriteLine("Conta Poupança: " + contaPoupanca.GetNumContaPoup());
            contaPoupanca.Rendimento();
            Console.WriteLine("Saldo: R$ " + contaPoupanca.GetSaldo().ToString("F2"));
            Console.WriteLine("Rendimento: " + contaPoupanca.GetRendimentos());
            Console.WriteLine("");
            Console.WriteLine("Extrato: " + contaPoupanca.GetExtrato());

        }
    }
}
