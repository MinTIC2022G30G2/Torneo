using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio{
    public class Municipio{
        public int Id { get; set; } = 0;

        [Required(ErrorMessage="El campo {0} es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Nombre { get; set; } = "";

        public Municipio(){}

        public Municipio(int id, string nombre){
            Id = id;
            Nombre = nombre;
        }
    }
}