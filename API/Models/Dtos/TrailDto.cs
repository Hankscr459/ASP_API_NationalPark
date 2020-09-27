using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models.Dtos
{
    #pragma warning disable CS1591    // Missing XML comment for publicly visible type or number
    public class TrailDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Distance { get; set; }
        public enum DifficultyType { Easy, Moderate, Difficult, Export }
        public DifficultyType Difficulty { get; set; }
        [Required]
        public int NationalParkId { get; set; }
        [ForeignKey("NationalParkId")]
        public NationalParkDto NationalPark { get; set; }
    }
}