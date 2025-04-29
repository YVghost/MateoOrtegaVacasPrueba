using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MateoOrtegaVacasPrueba.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [DisplayName("Nombre Completo")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Debe tener entre 5 y 100 caracteres")]
        public string NombreCliente { get; set; }

        [Required]
        [Range(0, 1000000, ErrorMessage = "Total de gastos debe ser positivo")]
        public decimal TotalGastos { get; set; }

        [Required]
        public bool ReservaVigente { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }

        [DisplayName("Código Referido (CordovaS)")]
        [MaxLength(15)]
        public string MateoOrtegaVacas { get; set; }

        // Relaciones
        public ICollection<Reserva>? Reservas { get; set; }

        public Recompensa? Recompensa { get; set; }

        // Puntos
        public int PuntosAcumulados { get; set; }

        [NotMapped]
        public string TipoRecompensa => PuntosAcumulados < 500 ? "SILVER" : "GOLD";
    }
}
