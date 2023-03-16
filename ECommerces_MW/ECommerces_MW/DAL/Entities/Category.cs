using System.ComponentModel.DataAnnotations;

namespace ECommerces_MW.DAL.Entities
{
    public class Category : Entity
    {

        [Display(Name = "Categoria")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String Name { get; set; }
    }
}
