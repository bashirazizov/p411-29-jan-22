using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace craft.Models
{
    public class Banner
    {
        public int Id { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
    }
}
