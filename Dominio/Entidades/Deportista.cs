using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Deportista
    {
        //Llave Primaria
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
        [MaxLength(9,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Genero {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Modalidad {get;set;}
        [DataType(DataType.Date)]
        public DateTime Fecha_Nacimiento {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(3,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(2,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string RH {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(9,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Eps {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(13,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(7,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Celular {get;set;}
        [DataType(DataType.EmailAddress)]
        public string Correo {get;set;}
        //Llave foranea
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int EquipoId {get;set;}
    }   
}