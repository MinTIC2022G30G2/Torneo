using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Municipio> Municipios { set; get; }
        public DbSet<Patrocinador> Patrocinadores { set; get; }
        public DbSet<Colegio> Colegios { set; get; }
        public DbSet<Torneo> Torneos { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Eventos30;Integrated Security=True;");
            }
        }
    }
}