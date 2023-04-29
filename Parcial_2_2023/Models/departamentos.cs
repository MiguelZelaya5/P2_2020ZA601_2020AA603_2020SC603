using System.ComponentModel.DataAnnotations;
namespace P2_2020ZA601_2020AA603_2020SC603.Models
{
    public class departamentos
    {
        [Key]
        
        public int id_departamento { get; set; }
        
        public string? nombre_departamento { get; set; }
    }
}
