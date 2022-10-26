using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; } = String.Empty;
        public string Platform { get; set; } = String.Empty;
        public string CommandLine { get; set; } = String.Empty;
    }
}