using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taxi.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }

        [StringLength(7, MinimumLength = 7, ErrorMessage = "El {0} campo no puede tener más de {1} Caracteres.")]
        [RegularExpression(@"^([A-Za-z]{3}\d{4})$", ErrorMessage = "El campo {0} debe tener tres caracteres y tres números.")]
        [Required(ErrorMessage = "El campo {0} es Obligatorio.")]
        public string Plaque { get; set; }

        public ICollection<TripEntity> Trips { get; set; }

        public UserEntity User { get; set; }
    }
}
