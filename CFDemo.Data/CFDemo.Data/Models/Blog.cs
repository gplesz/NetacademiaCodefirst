using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDemo.Data.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public string BloggerName  { get; set; }
        public string Address { get; set; }
    }
}
