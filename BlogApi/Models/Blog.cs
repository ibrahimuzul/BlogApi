using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.Models
{
    public class Blog
    {
        public long id { get; set; }
        public string title { get; set; }
        public string categories { get; set; }
        public string content { get; set; }
    }
}
