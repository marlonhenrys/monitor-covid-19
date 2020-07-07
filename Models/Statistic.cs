using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace monitor_covid19.Models
{
    [Table("statistics")]
    public class Statistic
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Casos confirmados")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int ConfirmedCases { get; set; }

        [Display(Name = "Mortes")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int Deaths { get; set; }

        [Display(Name = "Recuperados")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int Recovereds { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        [Display(Name = "País")]
        public Country Country { get; set; }
    }
}
