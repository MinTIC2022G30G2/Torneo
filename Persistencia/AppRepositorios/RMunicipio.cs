using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class RMunicipio:IRMunicipio
    {
        //Atributos
        private readonly AppContext _appContext;
        //Metodos
        //Constructor por defecto
        public RMunicipio(AppContext appContext)
        {
            this._appContext=appContext;
        }
        public bool CrearMunicipio(Municipio municipio)
        {
            bool creado=false;
            bool ex=Existe(municipio);
            if(!ex)
            {
                try
                {
                    this._appContext.Municipios.Add(municipio);
                    this._appContext.SaveChanges(); 
                    creado=true;       
                }
                catch (System.Exception)
                {
                    creado=false;
                }
            }
            return creado;
        }
        public Municipio BuscarMunicipio(int IdMunicipio)
        {
            Municipio municipio=_appContext.Municipios.Find(IdMunicipio);
            return municipio;
        }
        public bool ActualizarMunicipio(Municipio municipio)
        {
            bool actualizado=false;
            var num= _appContext.Municipios.Find(municipio.Id);
            if(num != null)
            {
                try
                {
                    num.Nombre=municipio.Nombre;
                    _appContext.SaveChanges();
                    actualizado=true;
                }
                catch (System.Exception)
                {
                    actualizado=false;
                }    
            }
            return actualizado;
        }
        public bool EliminarMunicipio(int IdMunicipio)
        {
            bool eliminado=false;
            return eliminado;
        }
        public List<Municipio> ListarMunicipio1()
        {
            return this._appContext.Municipios.ToList();
        }
        public IEnumerable<Municipio> ListarMunicipio2()
        {
            return this._appContext.Municipios;
        }
        private bool Existe(Municipio municipio)
        {
            bool ex=false;
            Municipio mun=_appContext.Municipios.FirstOrDefault(m=> m.Nombre == municipio.Nombre );
            if(mun != null)
            {
                ex=true;        
            }
            return ex;          
        }
    }
}