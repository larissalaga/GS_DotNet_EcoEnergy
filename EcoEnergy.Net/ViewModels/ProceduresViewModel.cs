using System;
using System.ComponentModel.DataAnnotations;

namespace EcoEnergy.ViewModels
{
    public class ProceduresViewModel
    {
        // Empresa
        public int IdEmpresa { get; set; }
        public string NrCnpj { get; set; }
        public string NmEmpresa { get; set; }
        public string NrTelefone { get; set; }
        public string DsEspecialidade { get; set; }

        // Usuario
        public int IdUsuario { get; set; }
        public string NmUsuario { get; set; }
        public string DsEmail { get; set; }
        public string NrCpf { get; set; }
        public string NrTelefoneU { get; set; }

        // Endereco
        public int IdEndereco { get; set; }
        public string DsCep { get; set; }
        public string DsLogradouro { get; set; }
        public int NrLogradouro { get; set; }
        public string DsBairro { get; set; }
        public string DsCidade { get; set; }
        public string DsEstado { get; set; }
        public string DsPais { get; set; }

        // Orcamento
        public int IdOrcamento { get; set; }
        public decimal NrValorProposto { get; set; }
        public string DsPrazo { get; set; }
        public DateOnly DtOrcamento { get; set; }
        public string DsServicos { get; set; }

        // Simulacao
        public int IdSimulacao { get; set; }
        public decimal NrCustoEstimado { get; set; }
        public decimal NrEconomia { get; set; }
        public DateOnly DtSimulacao { get; set; }
        public int NrConsumoMensal { get; set; }
        public int NrAreaPlaca { get; set; }
        public int NrPotenciaEstimada { get; set; }
        public int NrProducaoMensal { get; set; }
        public int NrTempoRetornoInvestimento { get; set; }
        public int DsOrcamentoSolicitado { get; set; }        
    }
}
