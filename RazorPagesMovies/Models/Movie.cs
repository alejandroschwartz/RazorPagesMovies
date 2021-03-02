using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }                         // Número identificación

        [Required(ErrorMessage = "El título es requerido. Debe tener entre 3 a 60 caracteres")]
        [Display(Name = "Título")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }                   // Título

        [Display(Name = "Fecha lanzamiento")]
        [DataType(DataType.Date, ErrorMessage = "La fecha ingresada no es válida.")]
        public DateTime ReleaseDate { get; set; }           // Fecha de lanzamiento

        [Required(ErrorMessage = "El género es requerido. Máximo 30 caracteres")]
        [Display(Name = "Género")]
        [StringLength(30)]
        public string Genre { get; set; }                   // Género

        [Range(1, 200, ErrorMessage = "El precio va de 1 a 200.")]
        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }                  // Precio

        [Required(ErrorMessage = "La clasificacíon es requerido.")]
        [Display(Name = "Clasificación")]
        public string Rating { get; set; }                  // Clasificación
    }
}
