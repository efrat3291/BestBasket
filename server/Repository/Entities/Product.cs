using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondaryName { get; set; }
        public virtual Category Category { get; set; }
    }
}
