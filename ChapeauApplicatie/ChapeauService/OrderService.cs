﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class OrderService
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

        public void CreateNewOrder(int TableID)
        {
            orderdb.OrderCreateNew(TableID);
        }
        
        public void ConfirmOrder(int IDTable, string commentaar)
        {
            orderdb.OrderConfirm(IDTable, commentaar);
        }

    }
}
