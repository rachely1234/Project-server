using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class TodoDto
    {
        public int id { get; set; }
        public string descreprion { get; set; }
        public bool status { get; set; }
        public string date { get; set; }
        public bool disable { get; set; }
    }
}
