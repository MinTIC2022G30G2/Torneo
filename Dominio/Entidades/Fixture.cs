using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Fixture
    {
        //Llave primaria
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Forma_Juego {get;set;}
        //Llave foranea
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int TorneoId {get;set;}
        //Relacion Con Encuentro, propiedad navegacional
        public List<Encuentro> Encuentros {get;set;}

    }
}