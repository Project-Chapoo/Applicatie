using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class OrderItemsService
    {
        OrderItemsDao orderitemsdb;

        public OrderItemsService()
        {
            orderitemsdb = new OrderItemsDao();
        }

        public List<OrderItems> GetOrderItems()
        {
            List<OrderItems> orderItems = orderitemsdb.GetAllOrderItems();
            return orderItems;
        }

    }
}
