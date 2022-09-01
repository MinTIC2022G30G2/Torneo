using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio{
    public class UnidadDeportiva{
        public int Id { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(6, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        public int TorneoId { get; set; }
    }
}