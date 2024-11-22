using EcoEnergy.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcoEnergy.Dtos
{
    public class OrcamentoDtos
    {
        [Required]
        public double NrValorProposto { get; set; } = 0;

        [Required]
        [MaxLength(20)]
        public string DsPrazo { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateOnly DtOrcamento { get; set; } = new DateOnly();

        [Required]
        [MaxLength(200)]
        public string DsServicos { get; set; } = string.Empty;

        [Required]
        [Column("id_simulacao")]
        [ForeignKey("Simulacao")]
        public int IdSimulacao { get; set; }
        public SimulacaoDtos? Simulacao { get; set; }

        [Required]
        [Column("id_empresa")]
        [ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }
        public Empresa? Empresa { get; set; }


    }
}