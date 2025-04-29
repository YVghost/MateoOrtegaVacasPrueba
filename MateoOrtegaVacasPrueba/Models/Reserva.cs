using System.ComponentModel.DataAnnotations;

namespace MateoOrtegaVacasPrueba.Models
{
    public class Reserva
    {
        [Key]
        [MaxLength(10)]
        public int idReserva { set; get; }
        public DateTime fechaEntrada { set; get; }
        public DateTime fechaSalida { set; get; }
        public float pagoreserva { set; get; }
        public Cliente infoCliente { set; get; }

    }
}
