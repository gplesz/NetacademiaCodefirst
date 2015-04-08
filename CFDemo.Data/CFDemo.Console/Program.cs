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
            foreach (var blog in db.Blogs
                                   .ToList())
            {
                System.Console.WriteLine(string.Format("{0}: {1}", blog.Blogger.Name, blog.Title));
            }
            System.Console.WriteLine("Naplók vége");
            System.Console.ReadLine();
        }
    }
}
