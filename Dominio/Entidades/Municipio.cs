using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Municipio
    {
        //Propiedades
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Nombre {get;set;}
    }
}