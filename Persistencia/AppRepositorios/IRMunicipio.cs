using Dominio;
using System.Collections.Generic;

namespace Persistencia{
    public interface IRMunicipio{
        public bool Crear(Municipio municipio);
        public Municipio Buscar(int id);
        public bool Actualizar(Municipio municipio);
        public bool Eliminar(int id);
        public List<Municipio> Listar1();
        public IEnumerable<Municipio> Listar();
    }
}
