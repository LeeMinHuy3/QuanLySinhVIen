using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_6
{
    class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}
