using System.ComponentModel.DataAnnotations;

namespace YummyApp.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Desc { get; set; }
        [Required]
        public int Star { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        public Position Positions { get; set; }
    }
}
