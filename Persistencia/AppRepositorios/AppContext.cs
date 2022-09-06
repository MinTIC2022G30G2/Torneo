using Microsoft.EntityFrameworkCore;
using Dominio;
namespace Persistencia
{
    public class AppContext:DbContext
    {
        //Atributos
        public DbSet<Patrocinador> Patrocinadores {get;set;}
        public DbSet<Colegio> Colegios {get;set;}
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Torneo> Torneos {get;set;}
        public DbSet<Escenario> Escenarios {get;set;}
        public DbSet<Unidad_Deportiva> Unidades_Deportivas {get;set;}
        public DbSet<Arbitro> Arbitros {get;set;}
        public DbSet<Deportista> Deportistas {get;set;}
        public DbSet<Encuentro> Encuentros {get;set;}
        public DbSet<Entrenador> Entrenadores {get;set;}
        public DbSet<Equipo> Equipos {get;set;}
        public DbSet<Fixture> Fixtures {get;set;}
        public DbSet<Torneo_Equipo> Torneos_Equipos {get;set;}
        
        
        //Crer la conexion con la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
             optionsBuilder.UseSqlServer("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=Eventos30");
            }   
        }

    }
}