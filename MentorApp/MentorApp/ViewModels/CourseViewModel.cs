using MentorApp.Models;
using System.Collections.Generic;

namespace MentorApp.ViewModels
{
    public class CourseViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Course> Courses { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }
    }
}
