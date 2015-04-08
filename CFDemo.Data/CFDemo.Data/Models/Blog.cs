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
        public string Title { get; set; }
        public int BloggerId { get; set; }
        public virtual Person Blogger { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

}
