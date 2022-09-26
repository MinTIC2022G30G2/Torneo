using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio{
    public class Colegio{
        public int Id { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Nit { get; set; } = default!;

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string RazonSocial { get; set; } = default!;

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Direccion { get; set; } = default!;

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Telefono { get; set; } = default!;

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Licencia { get; set; } = default!;

        [Required(ErrorMessage="Este campo es obligatorio")]
        public int ModalidadId { get; set; } = default!;

        public Modalidad Modalidad { get; set; }

        public Colegio(){}
        public Colegio(int id, string nit, string razonSocial, string direccion, string telefono, string licencia, int modalidadId){
            this.Id = id;
            this.Nit = nit;
            this.RazonSocial = razonSocial;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Licencia = licencia;
            this.ModalidadId = modalidadId;
        }

    }
}