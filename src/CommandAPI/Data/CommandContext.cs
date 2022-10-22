using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Data
{
    public class CommandContext : DbContext
    {
        public DbSet<Command> CommandItems {get;set;} = default!;

        public CommandContext(DbContextOptions<CommandContext> options) 
            : base(options)
        {
            
        }
    }
}