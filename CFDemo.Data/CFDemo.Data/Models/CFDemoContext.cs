using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDemo.Data.Models
{
    public class CFDemoContext : DbContext
    {
        static CFDemoContext()
        {
            Database.SetInitializer<CFDemoContext>(new DropCreateDatabaseIfModelChanges<CFDemoContext>());
        }

        public CFDemoContext() : base("DefaultConnection") {}
            
        public DbSet<Blog> Blogs { get; set; }
    }
}
