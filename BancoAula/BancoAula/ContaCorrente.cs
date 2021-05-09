using System;
using System.Collections.Generic;
using System.Text;

namespace BancoAula
{
    class ContaCorrente
    {
        private int _numContaCorrente;
        private double _transferencia;
        private string _extrato;
        private double _deposito;
        private double _saque;
        private double _saldo;
        private string _nome;
        private double _taxa;

        public ContaCorrente() { }

        public ContaCorrente(String nome, int contaCorrente, double saldo)
        {
            _nome = nome;
            _numContaCorrente = contaCorrente;
            _saldo = saldo;
        }

        public String GetNome()
        {
            return _nome;
        }
        public void SetNome(String nome)
        {
            _nome = nome;
        }
        public double GetSaldo()
        {
            return _saldo;
        }
        public double GetContaCorrente()
        {
            return _numContaCorrente;
        }

        public void SetTaxa(double valor)
        {
            _taxa = valor;
        }

        public void Deposito(double valor)
        {
            Extrato("Deposito ", "+", valor);
            _saldo += valor;
        }
        public string GetExtrato()
        {
            return _extrato;
        }

        public void Extrato(String acao, String sinal, double valor)
        {
            _extrato += "\r\n" + acao + sinal + "R$ " + valor;
        }
        public void Saque(double valor)
        {
            Extrato("Saque ", "-", valor);
            _saldo -= valor;
        }
        public void Transferencia(double valor)
        {
            Extrato("Transferencia ", "-", valor);
            _saldo -= valor;
        }

        public void TaxaConta(double _taxa)
        {
            Extrato("Taxa da conta ", "-", _taxa);
            _saldo -= _taxa;
        }

    }
    

}
