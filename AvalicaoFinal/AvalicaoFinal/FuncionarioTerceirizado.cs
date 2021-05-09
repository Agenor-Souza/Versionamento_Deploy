using System;
using System.Collections.Generic;
using System.Text;

namespace AvalicaoFinal
{
    class FuncionarioTerceirizado : Funcionario
    {
        public string EmpresaOrigem { get; set; }
        public double TaxaServico { get; set; }


        public FuncionarioTerceirizado(String nome, int cargaHoraria, double valorHora, string empresaNome, double txServico)
            : base(nome, cargaHoraria, valorHora)
        {
            EmpresaOrigem = empresaNome;
            TaxaServico = txServico;
            
        }

        public double calculaSalario(int cargaH, double valorH, double taxaServico)
        {
            double result = (cargaH * valorH) + ((taxaServico / 100) * (cargaH * valorH));
            return result;
        
        }
    
    
    }
}
