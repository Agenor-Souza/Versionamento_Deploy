using System;
using System.Collections.Generic;
using System.Text;

namespace BancoAula
{
    class ContaPoupanca: ContaCorrente
    {
        private int _numContaPoupanca;
        private double _rendimentos;
        private double _saldo;

        public ContaPoupanca(String nome, int contaCorrente, double saldo, int numContaPoup, double rendimentos)
            : base(nome, contaCorrente, saldo)
        {
            _saldo = saldo;
            _numContaPoupanca = numContaPoup;
            _rendimentos = rendimentos;

        }
        public double GetNumContaPoup()
        {
            return _numContaPoupanca;
        }
        public double GetRendimentos()
        {
            return _rendimentos;
        }
        public double GetSaldo()
        {
            return _saldo;
        }

        public void Rendimento()
        {
            Extrato("Rendimento ", "+", _rendimentos);
            _saldo += _saldo * _rendimentos;
        }




    }
}
