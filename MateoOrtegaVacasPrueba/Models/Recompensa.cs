using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MateoOrtegaVacasPrueba.Models
{
    public class Recompensa
    {
        [Key]
        public int idRecompensa { set; get; }
        public string nombre { set; get; }
        public DateTime fechaInicio { set; get; }
        public int puntos { set; get; }
        public string tipoRecompensa { set; get; }


    }
}
