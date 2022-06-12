using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModels
{
    public class OrderStatusTable
    {
        public int tableId { get; set; }
        public DateTime timeOrdered { get; set; }
        public bool orderReady { get; set; }
        public bool orderServed { get; set; }
        public int orderedLatest { get; set; }
        public bool barServed { get; set; }
        public bool kitchenServed { get; set; }
    }
}
