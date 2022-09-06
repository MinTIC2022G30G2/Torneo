using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Equipo
    {
        //Llave primaria
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Nombre {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Modalidad {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Jugadores {get;set;}
        //Llave foranea
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int PatrocinadorId {get;set;}
        //Relacion con Deportista, Propiedad Navegacional
        public List<Deportista> Deportistas {get;set;}
        //Relacion con Entrenador, Propiedad Navigacional
        public Entrenador Tecnico {get;set;} 
        //Relacion con Torneo_Equipo, propiedad navegcional
        public  List<Torneo_Equipo> Torneos_Equipos {get;set;}
        
    }
}