using System.ComponentModel.DataAnnotations;

namespace ECommerces_MW.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required] // lo mismo que NOT NULL en sql server
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; } //"?" lo mismo que nullable campo nuleable
        public DateTime? ModifiedDate { get; set;}


    }
}
            