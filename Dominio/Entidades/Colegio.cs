using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Dominio
{
    public class Colegio
    {
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(10,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Nit {get;set;}
        [MaxLength(35,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Razon_Social {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(35,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Direccion {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(13,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(7,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Telefono {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(25,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Modalidad {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(25,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Licencia {get;set;}
        //Relacion con Arbitro, propiedad navegacional
        public List<Arbitro> Arbitros {get;set;}

    }    
}