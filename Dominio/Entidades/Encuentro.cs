using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Encuentro
    {
        //Llave primaria
        public int Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Puntaje_Equipo1 {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Puntaje_Equipo2 {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime Fecha_Encuentro {get;set;}
        //Llave Foranea
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Equipo1Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Equipo2Id {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int FixtureId {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int ArbitroId {get;set;}
    }
}