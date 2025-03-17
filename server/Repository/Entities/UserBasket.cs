using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class UserBasket
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("User")]
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ProductInBasket> ProductInBasket { get; set; }

    }
}
