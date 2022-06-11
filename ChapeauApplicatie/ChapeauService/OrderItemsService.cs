using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class OrderItemsService : BaseService
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

        public List<OrderItems> GetOrderItemsPerTable(int tableID)
        {
            List<OrderItems> orderItems = orderitemsdb.GetAllOrderItemsPerTable(tableID);
            return orderItems;
        }

        public void AddOrderItem(int tableID, int menuItemID)
        {
            orderitemsdb.OrderItemAdd(tableID, menuItemID);
        }

        public void QuantityAdd(int tableID, int menuItemID)
        {
            orderitemsdb.AddQuantity(tableID, menuItemID);
        }

        public void AddItem(int selectedItemID)
        {
            orderitemsdb.ItemAdd(selectedItemID);
        }

        public void RemoveItem(int selectedItemID)
        {
            orderitemsdb.ItemRemove(selectedItemID);
        }

        public void VerwijderOrder(int tableID)
        {
            orderitemsdb.OrderVerwijderen(tableID);
        }

        public void VerwijderItem(int selectedItemID)
        {
            orderitemsdb.ItemVerwijderen(selectedItemID);
        }
    }
}
