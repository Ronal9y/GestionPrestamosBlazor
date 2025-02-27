using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestionPrestamos.Models
{
    public class PrestamosDetalle
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El número de cuota es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de cuota debe ser mayor a 0.")]
        public int CuotaNo { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El valor es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El valor debe ser mayor a 0.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "El balance es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El balance debe ser mayor a 0.")]
        public decimal Balance { get; set; }

        [Required(ErrorMessage ="El ID del prestamo es obligatorio")]
        public int PrestamoId { get; set; }

        [ForeignKey("PrestamoId")]
        public virtual Prestamos Prestamos { get; set; }

    }
}