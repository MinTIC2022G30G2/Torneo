using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Dominio
{
    public class Torneo
    {
        //Llave primaria
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Nombre {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(10,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Categoria {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage="Error solo se aceptan letras")]
        public string Modalidad {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Inicio {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Fin {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Equipos {get;set;}
        //Llave foranea
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int MunicipioId {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int PatrocinadorId {get;set;}
        //Relacion con Unidad_Deportiva, propiedad navegacional
        public List<Unidad_Deportiva> Unidades_Deportivas {get;set;}
        //Relacion Con Arbitro, propiedad navegacional
        public List<Arbitro> Arbitros {get;set;}
        //Relacion con Fixture, propiedad navegcional
        public Fixture Tabla_Fixture {get;set;}
        //Relacion con Torneo_Equipo, propiedad navegcional
        public  List<Torneo_Equipo> Torneos_Equipos {get;set;}
    }
}