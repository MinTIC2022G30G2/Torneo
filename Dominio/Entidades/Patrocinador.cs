using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Patrocinador
    {
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
        [MinLength(5,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Tipo {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(35,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Direccion {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(13,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(7,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Telefono {get;set;}
         //Relacion con Equipo, propiedad navegacional
        public List<Equipo> Equipos {get;set;}
        //Relacion con Torneo, propiedad navegacional
        public List<Torneo> Torneos {get;set;}

    }    
}