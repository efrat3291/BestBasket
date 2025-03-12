using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int ChainId { get; set; }
        [ForeignKey("Chain")]

        public int AddressId { get; set; }
        [ForeignKey("Address")]
        public virtual Chain Chain { get; set; }
        public virtual Address Address { get; set; }
    }
}
