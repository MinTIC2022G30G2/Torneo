using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio{
    public class Torneo{
        public int Id { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(10, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Categoria { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Modalidad { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public string FechaInicio { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public string FechaFin { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Equipos { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(15, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Fixture { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        public int MunicipioId { get; set; }
        //public Municipio Municipio { set; get; }
   }
}