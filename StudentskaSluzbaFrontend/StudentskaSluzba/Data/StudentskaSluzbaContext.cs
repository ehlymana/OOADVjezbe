using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentskaSluzba.Models;

namespace StudentskaSluzba.Data
{
    public class StudentskaSluzbaContext : DbContext
    {
        public StudentskaSluzbaContext (DbContextOptions<StudentskaSluzbaContext> options)
            : base(options)
        {
        }

        public DbSet<StudentskaSluzba.Models.Predmet> Predmet { get; set; }
    }
}
