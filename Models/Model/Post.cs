using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Post
    {
        public int id { get; set; }
        public string name { get; set; }

        public string content { get; set; }
        public bool like { get; set; }
        public bool disable { get; set; }
    }
}
