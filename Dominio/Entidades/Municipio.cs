using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Municipio
    {
        //Propiedades
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        //[RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Nombre {get;set;}

        public Municipio(){}

        public Municipio(int id, string nombre){
            Id=id;
            Nombre=nombre;
        }

        //Relacion con torneo y propiedad navigacional
        public List<Torneo> Torneos {get;set;}
    }
}
