using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio{
    public class Municipio{
        // Propiedades
        public int Id { get; set; }

        [Required(ErrorMessage="El campo {0} es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="El campo {0} debe ser minimo de {1} caracteres")]
        public string Nombre { get; set; }

        // Metodos
        public Municipio(){}
        public Municipio(int id, string nombre){
            this.Id = id;
            this.Nombre = nombre;
        }

    }
}