using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; } = String.Empty;

        [Required]
        public string Platform { get; set; } = String.Empty;
        
        [Required]
        public string CommandLine { get; set; } = String.Empty;
    }
}