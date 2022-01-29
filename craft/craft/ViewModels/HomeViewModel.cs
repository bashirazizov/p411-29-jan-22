using craft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace craft.ViewModels
{
    public class HomeViewModel
    {
        public Banner banner { get; set; }
        public List<Service> services { get; set; }
        public List<Category> categories { get; set; }
        public List<Project> projects { get; set; }
        public List<Worker> workers { get; set; }
        public List<Testimonial> testimonials { get; set; }
        public List<News> news { get; set; }
    }
}
