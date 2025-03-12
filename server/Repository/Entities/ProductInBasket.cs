using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class ProductInBasket
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }
        public int BasketId { get; set; }
        [ForeignKey("UserBasket")]
        
        public virtual UserBasket userBasket { get; set; }
        
    }
}
