using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_6_Bai_1
{
    class CodeFirstContext: DbContext
    {
        public CodeFirstContext(): base("name = Huy")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CodeFirstContext>());
        }
        public DbSet<Company> Companies { get; set; }
    }
}
