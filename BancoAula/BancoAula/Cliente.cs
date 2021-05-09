using System;
using System.Collections.Generic;
using System.Text;

namespace BancoAula
{
    class Cliente
    {
        private string _nome;
        private int _contaCorrente;
        private int _agencia;
        private double _saldo;

        public Cliente() { }

        public Cliente(String nome, int contaCorrente, int agencia, double saldo)
        {
            _nome = nome;
            _contaCorrente = contaCorrente;
            _agencia = agencia;
            _saldo = saldo;
        }
        public void Saque(double valor)
        {
            if(valor > _saldo)
            {
                Console.WriteLine("Erro: saldo insuficiente.");
            }
            else
            {
                _saldo -= valor;    
            }
            
        }
        public void Deposito(double valor)
        {
            _saldo += valor;
        }

        public String GetNome()
        {
            return _nome;
        }
        public void SetNome(String nome)
        {
            _nome = nome;
        }
        public int GetAgencia()
        {
            return _agencia;
        }
        public void SetAgencia(int agencia)
        {
            _agencia = agencia;
        }
        public double GetSaldo()
        {
            return _saldo;
        }
        
        public int GetContaCorrente()
        {
            return _contaCorrente;
        }
        public void SetContaCorrente(int contaCorrente)
        {
            _contaCorrente = contaCorrente;
        }
    }
}
