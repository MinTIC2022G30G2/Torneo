using System;
using Persistencia;
using Dominio;

namespace Consola{
    class Program{
        private static IRMunicipio _repoMunicipio= new RMunicipio(new Persistencia.AppContext());
        static void Main(String[] args){
            Municipio mun = new Municipio();
            mun.Nombre = "Bogota";
            bool rta = _repoMunicipio.CrearMunicipio(mun);
            if(rta){
                Console.WriteLine("El municipio {0}, se ha creado exitosamente", mun.Nombre);
            }else{
                Console.WriteLine("Error en la creacion...");
            }
        }
    }
}
