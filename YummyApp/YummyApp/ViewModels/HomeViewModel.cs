using System.Collections.Generic;
using YummyApp.Models;

namespace YummyApp.ViewModels
{
    public class HomeViewModel
    {
        public List<Testimonial> Testimonials { set; get; }
        public List<Position> Positions { set; get; }
        public List<Meal> Meals { set; get; }
        public List<Category> Categories { set; get; }
    }
}
