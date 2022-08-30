using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia{
    public class RMunicipio:IRMunicipio{
        private readonly AppContext _appContext;

        public RMunicipio(AppContext appContext){
            this._appContext=appContext;

        }

        public bool CrearMunicipio(Municipio municipio){
            bool bandera=false;
            try{
                this._appContext.Municipios.Add(municipio);
                this._appContext.SaveChanges();
                bandera = true;
            }catch (System.Exception){
                bandera=false;
            }
            return bandera;
        }
        public Municipio BuscarMunicipio(int idMunicipio){
            Municipio municipio=null;
            return municipio;
        }
        public bool ActualizarMunicipio(Municipio municipio){
            bool bandera=false;
            return bandera;

        }

        public bool EliminarMunicipio(Municipio municipio){
            bool bandera=false;
            return bandera;

        }
        public List<Municipio> ListarMunicipios1(){
            return this._appContext.Municipios.ToList();
        }

        public IEnumerable<Municipio> ListarMunicipios(){
            return this._appContext.Municipios;
        }

    }
}