using Dominio;
using System.Collections.Generic;

namespace Persistencia{
    public interface IRMunicipio{
        public bool Crear(Municipio item);
        public Municipio Buscar(int id);
        public bool Actualizar(Municipio item);
        public bool Eliminar(int id);
        public String Cadena(Municipio item);
        public List<Municipio> Listar1();
        public IEnumerable<Municipio> Listar();
    }
}
