using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int AddressId { get; set; }
        [ForeignKey("Address")]

        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<UserBasket> userBasket { get; set; }

    }
}
