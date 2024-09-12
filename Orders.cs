using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_09
{
    internal class Orders
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public Clients Client { get; set; }


        public DateTime OrderDate { get; set; }

      

        public ICollection<OrderDetails> OrderDetail { get; set; } 
    }
}
