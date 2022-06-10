using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class OrderService : BaseService
    {
        OrderDAO orderdb;

        public OrderService()
        {
            orderdb = new OrderDAO();
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = orderdb.GetAllOrders();
            return orders;
        }

        public List<Order> GetOrdersFromSelectedTable(int tableID)
        {
            List<Order> TableOrder = orderdb.GetOrderFromTable(tableID);
            return TableOrder;
        }

        public void ConfirmOrder(int IDTable, string commentaar)
        {
            orderdb.OrderConfirm(IDTable, commentaar);
        }

        public void NewestOrder(int tableID)
        {
            orderdb.OrderNewest(tableID);
        }
      
        public List<OrderStatusTable> BestellingPerTafel(int tableID)
        {
            return orderdb.BestellingPerTafel(tableID);
        }
        public List<OrderStatusTable> OrderGereed()
        {
            return orderdb.OrderGereed();
        }
        public void UpdateOrderServed(int served, int tableID)
        {
            orderdb.UpdateOrderServed(served, tableID);
        }
        public void UpdateOrderReady(int ready, int TableID)
        {
            orderdb.UpdateOrderReady(ready, TableID);
        }
    }
}
