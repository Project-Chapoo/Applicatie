using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModels
{
    public class OrderModel
    {

        public int OrderId { get; set; }
        public int TableId { get; set; }
        public string Comment { get; set; }
        public DateTime TimeOrdered { get; set; }
        public bool OrderReady { get; set; }
        public bool OrderServed { get; set; }
        public int OrderedLatest { get; set; }

    }
}
