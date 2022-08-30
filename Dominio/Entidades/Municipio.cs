using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{   
    public class Municipio
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Nombre { get; set; }

        public List<Torneo> Torneos { get; set; }
    }
}