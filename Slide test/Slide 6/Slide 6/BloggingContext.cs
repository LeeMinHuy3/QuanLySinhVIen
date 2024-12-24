using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Slide_6
{
    class BloggingContext: DbContext
    {
        public BloggingContext(): base("name = Dbname")
        {
            var initializer = new MigrateDatabaseToLatestVersion<BloggingContext,
                Migrations.Configuration>();
            Database.SetInitializer(initializer);
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
