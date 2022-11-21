using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentorApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Image { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(200)]
        public string Desc { get; set; }
        public Category Category { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }
    }
}
