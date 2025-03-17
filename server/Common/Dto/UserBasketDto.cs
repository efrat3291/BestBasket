using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    class UserBasketDto
    {
        public int UserId { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
