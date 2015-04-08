namespace CFDemo.Data.Migrations
{
    using CFDemo.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CFDemo.Data.Models.CFDemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CFDemo.Data.Models.CFDemoContext";
        }

        protected override void Seed(CFDemo.Data.Models.CFDemoContext context)
        {
            //context.Persons.AddOrUpdate(new Person
            //    {
            //        Id = 1,
            //        Name = "Blogger1",
            //        Address = new Address {City="Budapest", Number="2/B", Street="Nagyfa utca", Zip=1000 },
            //        Blogs = new List<Blog>() {new Blog { BloggerId=1, Title="Blog1"},new Blog { BloggerId=1, Title="Blog2"}}
            //    }
            //);
            //context.SaveChanges();
        }
    }
}
