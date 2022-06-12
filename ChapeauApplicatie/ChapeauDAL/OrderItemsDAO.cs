using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauModels;


namespace ChapeauDAL
{
    public class OrderItemsDao : BaseDao
    {
        public List<OrderItems> GetAllOrderItems()
        {
            string query = "SELECT orderitemid, orderid, menuitemid, quantity FROM [orderitem]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItems> ReadTables(DataTable dataTable)
        {
            List<OrderItems> orderItems = new List<OrderItems>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItems orderitem = new OrderItems()
                {
                    OrderItemID = (int)dr["OrderItemID"],
                    OrderID = (int)(dr["OrderID"]),
                    MenuItemID = (int)(dr["MenuItemID"]),
                    Quantity = (int)(dr["Quantity"]),
                };
                orderItems.Add(orderitem);
            }
            return orderItems;
        }
        

        public List<OrderItems> GetAllOrderItemsPerTable(int tableID)
        {
            string query = $"SELECT mi.menuitemid, oi.orderitemid, O.TableID, oi.Quantity, mi.description, mi.Stock FROM OrderItem AS OI " +
                           $"JOIN[dbo].[MenuItem] AS MI ON MI.MenuItemID = oi.MenuItemID " +
                           $"join[dbo].[Order] as O on o.OrderID = OI.OrderID " +
                           $"where oi.OrderID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesPerTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItems> ReadTablesPerTable(DataTable dataTable)
        {
            List<OrderItems> orderItems = new List<OrderItems>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItems orderItem = new OrderItems()
                {
                    MenuItemID = (int)dr["menuitemid"],
                    OrderItemID = (int)dr["orderitemid"],
                    Quantity = (int)(dr["quantity"]),
                    TableID = (int)(dr["tableid"]),
                    Description = (string)(dr["description"]),
                    Stock = (int)(dr["stock"]),
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        public void OrderItemAdd(int tableID, int MenuItemID)
        {
            string query = $"INSERT INTO [orderitem] (OrderID, MenuItemID, quantity, ReadyOrderItem) VALUES ({tableID}, {MenuItemID}, 1, 0)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddQuantity(int tableID, int menuItemID)
        {
            string query = $"update OrderItem set Quantity = Quantity +1 where OrderID = {tableID} and MenuItemID = {menuItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void ItemAdd(int selectedItemID)
        {
            string query = $"update OrderItem set Quantity = Quantity + 1 where OrderItemID = {selectedItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ItemRemove(int selectedItemID)
        {
            string query = $"update OrderItem set Quantity = Quantity - 1 where OrderItemID = {selectedItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void OrderVerwijderen(int tableID)
        {
            string query = $"delete from OrderItem where OrderID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void ItemVerwijderen(int selectedItemID)
        {
            string query = $"delete from OrderItem where orderitemID = {selectedItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
