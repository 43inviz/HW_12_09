using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_09
{
    internal class OrderDetails
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Orders Order { get; set; }




        public int ProductId { get; set; }
        public Products Product { get; set; } 

        

        public int ProductCount { get; set; }


    }
}
