using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace craft.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public string Editor { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
    }
}
