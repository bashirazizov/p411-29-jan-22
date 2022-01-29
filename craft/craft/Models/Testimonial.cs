using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace craft.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string CommenterImage { get; set; }
        public string CommenterName { get; set; }
        public string CommenterPosition { get; set; }
    }
}
