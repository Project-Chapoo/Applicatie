using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModels
{
    public class TableOrder
    {
        public int tableId { get; set; }
        public int menuId { get; set; }
        public string category { get; set; }
        public bool readyOrderItem { get; set; }
    }
}
