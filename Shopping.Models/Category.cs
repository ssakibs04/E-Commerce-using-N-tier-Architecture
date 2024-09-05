using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
    
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        public int displayOrder { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }=DateTime.Now;

    }
}
