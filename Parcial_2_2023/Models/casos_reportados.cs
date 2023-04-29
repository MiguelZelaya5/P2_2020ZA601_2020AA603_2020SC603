using System.ComponentModel.DataAnnotations;

namespace P2_2020ZA601_2020AA603_2020SC603.Models
{
    public class casos_reportados
    {
        [Key]

        [Display(Name = "ID Departamento")]
        public int id_departamento { get; set; }
        [Display(Name = "ID Genero")]
        public int id_genero { get; set; }
        [Display(Name = "Confirmados")]
        public int confirmados { get; set; }
        [Display(Name = "Recuperados")]
        public int recuperados { get; set; }
        [Display(Name = "Fallecidos")]
        public int fallecidos { get; set; }

    }
}
