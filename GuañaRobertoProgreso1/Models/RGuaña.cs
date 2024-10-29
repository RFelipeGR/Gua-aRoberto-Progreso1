using System.ComponentModel.DataAnnotations;
using System;

namespace GuañaRobertoProgreso1.Models
{
    
    public class RGuaña
    {
        public ICollection<Celular> Celulares { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo AtributoInt es obligatorio.")]
        public int AtributoInt { get; set; }

        [Range(0.0, Double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0.")]
        public decimal AtributoDecimal { get; set; }

        [StringLength(100, ErrorMessage = "El campo no puede exceder 100 caracteres.")]
        public string AtributoString { get; set; }

        public bool AtributoBool { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo AtributoFecha es obligatorio.")]
        public DateTime AtributoFecha { get; set; }

    }
}