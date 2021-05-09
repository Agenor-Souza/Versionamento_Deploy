using System;
using System.Collections.Generic;
using System.Text;

namespace AvalicaoFinal
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public double ValorHora { get; set; }

        public Funcionario(String nome, int cargaHoraria, double valorHora)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;

        }

        public virtual double calculaSalario(int cargaH, double valorH)
        {
            return cargaH * valorH;
        }

    

    }
}
