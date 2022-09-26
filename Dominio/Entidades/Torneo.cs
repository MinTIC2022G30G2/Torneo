using System;
using System.Collections.Generic;
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
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

		[Required(ErrorMessage="Este campo es obligatorio")]
        public int ModalidadId { get; set; }

        //public Municipio Municipio { set; get; }
        //public List<UnidadDeportiva> UnidadDeportivas { get; set; }

        public Modalidad Modalidad { get; set; }

        public Torneo(){}
        public Torneo(int id, string nombre, string categoria, DateTime fechaInicio, DateTime fechaFin, int modalidadId){
            this.Id = id;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.ModalidadId = modalidadId;
        }
   }
}