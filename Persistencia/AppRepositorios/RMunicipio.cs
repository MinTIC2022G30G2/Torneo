using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia{
    public class RMunicipio:IRMunicipio{
        private readonly AppContext _appContext;
        public RMunicipio(AppContext appContext){
            this._appContext=appContext;
        }
        public bool Crear(Municipio item){
            bool bandera = false;
            if(!Existe(item)){
                try{
                    this._appContext.Municipios.Add(item);
                    this._appContext.SaveChanges();
                    bandera = true;
                }catch (System.Exception){
                    bandera=false;
                }
            }
            return bandera;
        }
        public Municipio Buscar(int id){
            Municipio? item = _appContext.Municipios.Find(id);
            return item;
        }
        public bool Actualizar(Municipio item){
            bool bandera = false;
            var municipio = _appContext.Municipios.Find(item.Id);
            if(municipio != null){
                try{
                    municipio.Nombre = item.Nombre;
                    _appContext.SaveChanges();
                    bandera = true;
                }catch(System.Exception){
                    bandera = false;
                }
            }
            return bandera;
        }
        public bool Eliminar(int id){
            bool bandera = false;
            var municipio = this._appContext.Municipios.Find(id);
            if(municipio != null){
                try{
                    this._appContext.Municipios.Remove(municipio);
                    this._appContext.SaveChanges();
                    bandera = true;
                }catch (System.Exception){
                    bandera = false;
                }
            }
            return bandera;
        }
        public List<Municipio> Listar1(){
            return this._appContext.Municipios.ToList();
        }
        public IEnumerable<Municipio> Listar(){
            return this._appContext.Municipios;
        }
        private bool Existe(Municipio item){
            bool bandera = false;
            if(item.Nombre == null){
                item.Nombre = "";
            }
            Municipio? municipio = _appContext.Municipios.FirstOrDefault(m=> m.Nombre == item.Nombre);
            if(municipio != null){
                bandera = true;
            }
            return bandera;
        }
    }
}