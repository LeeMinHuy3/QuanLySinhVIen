using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_6_Bai_2
{
    class CodeFirstContext : DbContext
    {
        public CodeFirstContext(): base()
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<CodeFirstContext>());
        }
        public DbSet<ThongTinSach> ThongTinSaches { get; set; }
    }
}
