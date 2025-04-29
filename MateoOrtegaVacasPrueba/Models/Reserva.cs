using MateoOrtegaVacasPrueba.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MateoOrtegaVacasPrueba.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }

        [Required]
        [Range(1, 100000, ErrorMessage = "El pago debe ser mayor a 0")]
        public decimal PagoReserva { get; set; }

        // Relación con cliente
        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
    }
}
