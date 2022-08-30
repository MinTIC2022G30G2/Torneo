namespace Dominio
{
    public class Colegio
    {
        public int Id { set; get; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Nombre { set; get; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(10, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Categoria { set; get; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Modalidad { set; get; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public string FechaInicio { set; get; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public string FechaFin { set; get; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Equipos { set; get; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage="Este campo {0} debe ser maximo de {1} caracteres")]
        [MinLength(15, ErrorMessage="Este campo {0} debe ser minimo de {1} caracteres")]
        public string Fixture { set; get; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        public int MunicipioId { set; get; }
        //public Municipio Municipio { set; get; }
   }
}