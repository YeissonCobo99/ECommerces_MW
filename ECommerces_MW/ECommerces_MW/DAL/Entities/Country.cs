using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ECommerces_MW.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        public String Name { get; set; }
          
    }
}
