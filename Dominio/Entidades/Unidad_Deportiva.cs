using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Unidad_Deportiva
    {
        //Llave Primaria
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Nombre {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(35,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Direccion {get;set;}
        //Llave foranea
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int TorneoId {get;set;}
        //Relacion con Escenario y propiedad navegacional
        public List<Escenario> Escenarios {get;set;}
    }
}