using System.ComponentModel.DataAnnotations;

namespace DarvynLuisLavandier_AP1_P1.Models
{
    public class Registros
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombres { get; set; }
    }
}
