using System.ComponentModel.DataAnnotations;

namespace YummyApp.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
