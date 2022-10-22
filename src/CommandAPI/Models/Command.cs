using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; } = String.Empty;
        [Required]
        public string? Platform { get; set; } = String.Empty;
        [Required]
        public string? CommandLine { get; set; } = String.Empty;
    }
}