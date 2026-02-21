using System.ComponentModel.DataAnnotations;

namespace ExamenU1Apiproject.Entities
{
    public class SaludEntity
    {
        [Required]
        public double Peso { get; set; }
        [Required]
        public double altura { get; set; }
        public double imc { get; set; }
        public string clasificacion { get; set; }
    }
}