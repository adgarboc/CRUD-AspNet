using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDASP.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora")]
        public DateTime Hora { get; set; }
    }
}
