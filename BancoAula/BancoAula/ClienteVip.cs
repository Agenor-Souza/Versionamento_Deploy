using System;
using System.Collections.Generic;
using System.Text;

namespace BancoAula
{
    class ClienteVip : Cliente
    {
        public double Salario { get; set; }
        public double LimiteEmprestimo { get; private set; }
        public ClienteVip(String nome, int contaCorrente, int agencia, double saldo, double salario)
            : base(nome, contaCorrente, agencia, saldo)
        {
            Salario = salario;
            LimiteEmprestimo = 0;

        }
    }
}
