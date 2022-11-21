using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YummyApp.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Image { get; set; }
        [Column (TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public List<MealIngredient> MealIngredients { get; set; }
    }
}
