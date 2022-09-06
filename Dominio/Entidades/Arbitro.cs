using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Arbitro
    {
        //LLave primria
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(8,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[0-9]*$",ErrorMessage="Error solo se aceptan Numeros")]
        public string Documento {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Nombres {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Apellidos {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Modalidad {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(3,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(2,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string RH {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(13,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(7,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Celular {get;set;}
    }
}