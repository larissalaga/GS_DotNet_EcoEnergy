using System.ComponentModel.DataAnnotations;

namespace WebApplicationOdontoPrev.ViewModels
{
    public class SimulacaoViewModel
    {
        // Entradas
        public double NrConsumoMensal { get; set; }
        public double NrAreaPlaca { get; set; }
        public bool DsOrcamentoSolicitado { get; set; }
        // Calculado
        public double NrCustoEstimado { get; set; }
        public double NrEconomia { get; set; }
        public DateOnly DtSimulacao { get; set; }
        public double NrPotenciaEstimada { get; set; }
        public double NrProducaoMensal { get; set; }
        public double NrTempoRetornoInvestimento { get; set; }
        
    }
}
