using System.ComponentModel.DataAnnotations;

namespace GuañaRobertoProgreso1.Models
{
    public class Celular
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Modelo es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo no puede exceder 100 caracteres.")]
        public string Modelo { get; set; }

        [Range(2000, 2100, ErrorMessage = "El año debe estar entre 2000 y 2100.")]
        public int Año { get; set; }

        [Range(0.0, Double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0.")]
        public decimal Precio { get; set; }

       
        public int RGuañaId { get; set; }
        public RGuaña RGuaña { get; set; }

    }
}
