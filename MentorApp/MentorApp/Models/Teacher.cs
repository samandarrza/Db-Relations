using System.ComponentModel.DataAnnotations;

namespace MentorApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

    }
}
