using System.ComponentModel.DataAnnotations;
using static API.Models.Dtos.TrailDto;

namespace API.Models.Dtos
{
    #pragma warning disable CS1591    // Missing XML comment for publicly visible type or number
    public class TrailUpdateDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Distance { get; set; }
        public DifficultyType Difficulty { get; set; }
        [Required]
        public int NationalParkId { get; set; }
    }
}