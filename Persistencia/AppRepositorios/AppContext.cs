using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Colegio> Colegios { set; get; }
        public DbSet<Deportista> Deportistas { set; get; }
        public DbSet<DeportistaEquipo> DeportistaEquipos { set; get; }
        public DbSet<Encuentro> Encuentros { set; get; }
        public DbSet<Entrenador> Entrenadores { set; get; }
        public DbSet<EntrenadorEquipo> EntrenadorEquipos { set; get; }
        public DbSet<Equipo> Equipos { set; get; }
        public DbSet<Escenario> Escenarios { set; get; }
        public DbSet<EscenarioTorneo> EscenarioTorneos { set; get; }
        public DbSet<Fixture> Fixtures { set; get; }
        public DbSet<Juez> Jueces { set; get; }
        public DbSet<JuezEncuentro> JuezEncuentros { set; get; }
        public DbSet<Modalidad> Modalidades { set; get; }
        public DbSet<ModalidadEscenario> ModalidadEscenarios { set; get; }
        public DbSet<Municipio> Municipios { set; get; }
        public DbSet<Patrocinador> Patrocinadores { set; get; }
        public DbSet<PatrocinadorEquipo> PatrocinadorEquipos { set; get; }
        public DbSet<Torneo> Torneos { set; get; }
        public DbSet<TorneoEquipo> TorneoEquipos { set; get; }
        public DbSet<TorneoMunicipio> TorneoMunicipios { set; get; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Eventos30;Integrated Security=True;");
            }
        }
    }
}