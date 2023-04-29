using System.ComponentModel.DataAnnotations;
namespace P2_2020ZA601_2020AA603_2020SC603.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int id_departamento { get; set; }
        [Display(Name = "Nombre del departamento")]
        public string? nombre_departamento { get; set; }
    }
}
