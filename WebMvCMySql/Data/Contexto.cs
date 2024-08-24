using Microsoft.EntityFrameworkCore;
using WebMvCMySql.Models;

namespace WebMvCMySql.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
            
        }   

        public DbSet<Usuario> Usuario { get; set; }
    }
}
