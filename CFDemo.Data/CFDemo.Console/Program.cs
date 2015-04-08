using CFDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDemo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new CFDemoContext();
            System.Console.WriteLine("Naplók");

            foreach (var blogger in db.Persons
                                      .ToList())
            {
                foreach (var blog in blogger.Blogs.ToList())
                {
                    System.Console.WriteLine(string.Format("{0}: {1}, {2}", blog.Blogger.Name, blog.Title, blog.Blogger.Address.City));
                }
                                    
            }
            System.Console.WriteLine("Naplók vége");
            System.Console.ReadLine();
        }
    }
}
