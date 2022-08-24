using Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    class StudentsDbContext:DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options):base (options)
        {

        }
        public DbSet<Student> Students { get; set; }


    }
}
