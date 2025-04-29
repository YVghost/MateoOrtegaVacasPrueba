using System.ComponentModel.DataAnnotations;

namespace MateoOrtegaVacasPrueba.Models
{
    public class Recompensa
    {
        [Key]
        public int idRecompensa { get; set; }

        public string nombre { get; set; }

        public DateTime fechaInicio { get; set; }

        public int puntos { get; set; }

        public string tipoRecompensa { get; set; }
    }
}
