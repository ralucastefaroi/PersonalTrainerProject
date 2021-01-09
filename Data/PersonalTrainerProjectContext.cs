using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalTrainerProject.Models;

namespace PersonalTrainerProject.Data
{
    public class PersonalTrainerProjectContext : DbContext
    {
        public PersonalTrainerProjectContext (DbContextOptions<PersonalTrainerProjectContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalTrainerProject.Models.Client> Client { get; set; }

        public DbSet<PersonalTrainerProject.Models.Produs> Produs { get; set; }

        public DbSet<PersonalTrainerProject.Models.Supliment> Supliment { get; set; }
    }
}
