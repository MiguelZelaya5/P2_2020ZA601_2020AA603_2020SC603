using System.ComponentModel.DataAnnotations;
namespace P2_2020ZA601_2020AA603_2020SC603.Models
{
    public class generos
    {
        [Key]
        [Display(Name = "ID")]
        public int id_genero { get; set; }
        [Display(Name = "Genero")]
        public string? genero { get; set; }
    }
}
