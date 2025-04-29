using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MateoOrtegaVacasPrueba.Models
{
    public class Cliente
    {
        [Key]
        [MaxLength(10)]
        public int idCliente { get; set; }

        [Required]
        [DisplayName ("Ingresar un Nombre y Apellido")]
        public string nombreCliente { get; set; }
        
        public DateTime fechaRegistro { get; set; }
        public bool reservaVigente { get; set; }

        [AllowNull]
        public float totalGastos { get; set; }
        public string mateoOrtegaVacas { get; set; }


        [AllowNull]
        public int idRecompensa { get; set; }
        [ForeignKey("idRecompensa")]
        public Recompensa? Recompensa { get; set; }

        [AllowNull]
        public int idReserva { get; set; }
        [ForeignKey("idReserva")]
        public Reserva? Reserva { get; set; }

    }
}
