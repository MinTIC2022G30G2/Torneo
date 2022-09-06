using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRMunicipio
    {
        public bool CrearMunicipio(Municipio municipio);
        public Municipio BuscarMunicipio(int IdMunicipio);
        public bool ActualizarMunicipio(Municipio municipio);
        public bool EliminarMunicipio(int IdMunicipio);
        public List<Municipio> ListarMunicipio1();
        public IEnumerable<Municipio> ListarMunicipio2();
    }    
}