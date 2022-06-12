using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class TableOrderService
    {
        TableOrderDAO orderdb;

        public TableOrderService()
        {
            orderdb = new TableOrderDAO();
        }
        public List<TableOrder> TableOrders(int tableID)
        {
            return orderdb.TableOrders(tableID);
        }
    }
}
