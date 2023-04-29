using System.ComponentModel.DataAnnotations;

namespace P2_2020ZA601_2020AA603_2020SC603.Models
{
    public class casos_reportados
    {
        [Key]
        public int id_casos { get; set; }

        public int id_departamento { get; set; }

        public int? id_genero { get; set; }

        public int? confirmados { get; set; }

        public int? recuperados { get; set; }
 
        public int? fallecidos { get; set; }

    }
}
