using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDemo.Data.Models
{
    [Table("Naplok")]
    public class Blog
    {
        [Column("Azonosito")]
        public int Id { get; set; }
        public string Title { get; set; }
        public int BloggerId { get; set; }
        public virtual Person Blogger { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        public Address Address { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }

    public class Address
    {
        public int Zip { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }

}
