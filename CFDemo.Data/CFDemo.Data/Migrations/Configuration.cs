namespace CFDemo.Data.Migrations
{
    using CFDemo.Data.Models;
    using System;
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
            context.Blogs.AddOrUpdate(new Blog {Id=1, Title = "Title1", Blogger=new Person { Id = 1, Name="Blogger1", Address="Address1" }});
            context.Blogs.AddOrUpdate(new Blog { Id = 1, Title = "Title1", Blogger = new Person { Id = 1, Name = "Blogger2", Address = "Address2" } });



            context.SaveChanges();
        }
    }
}
