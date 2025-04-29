using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MateoOrtegaVacasPrueba.Models
{
    public class Recompensa
    {
        [Key]
        public int IdRecompensa { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public int Puntos { get; set; }

        [Required]
        public string TipoRecompensa { get; set; }

        // Relación 1:1 con Cliente
        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
    }
}
