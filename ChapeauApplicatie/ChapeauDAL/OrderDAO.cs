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
    public class OrderDAO : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT OrderID, TableID, Comment, timeOrdered, OrderReady, OrderServed, OrderedLatest FROM [order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetOrderFromTable(int tableID)
        {
            string query = $"SELECT orderid, tableid FROM [Order] WHERE TableID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["OrderID"],
                    TableId = (int)(dr["TableID"]),
                    Comment = (string)dr["Comment"],
                    TimeOrdered = (DateTime)dr["timeOrdered"],
                    OrderReady = (bool)dr["OrderReady"],
                    OrderServed = (bool)dr["OrderServed"],
                    OrderedLatest = (int)dr["OrderedLatest"]
                };
                orders.Add(order);
            }
            return orders;
        }
        
        public void OrderNewest(int tableID)
        {
            string updateQuery;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            for (int i = 1; i < 11; i++)
            {
                updateQuery = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = {i}";
                ExecuteEditQuery(updateQuery, sqlParameters);

            }
            string setQuery = $"update [Order] set orderedlatest = 1 where OrderID = {tableID}";
            ExecuteEditQuery(setQuery, sqlParameters);
        }
        public void OrderConfirm(int tableID, string commentaar)
        {
            string query = $"update [Order] set comment = '{commentaar}', TimeOrdered = @DateAndTime where OrderID = {tableID}";        
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DateAndTime", SqlDbType.DateTime) { Value = DateTime.Now };
            ExecuteEditQuery(query, sqlParameters);
        }

        //TafelOverzicht
        public List<OrderStatusTable> BestellingPerTafel(int tableID)
        {
            string query = "SELECT TableID, TimeOrdered, OrderReady, OrderServed, [OrderedLatest], BarServed, KitchenServed FROM [Order] WHERE TableID = @tableID ";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@tableID", tableID)};
            return ReadOrderTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderStatusTable> OrderGereed()
        {
            string query = "SELECT TableID, TimeOrdered, OrderReady, OrderServed, [OrderedLatest], BarServed, KitchenServed FROM [Order] ORDER BY [OrderedLatest] DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderStatusTable> ReadOrderTable(DataTable dataTable)
        {
            List<OrderStatusTable> orderStatusTables = new List<OrderStatusTable>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderStatusTable orderStatusTable = new OrderStatusTable()
                {
                    tableId = (int)(dr["TableID"]),
                    timeOrdered = (DateTime)dr["timeOrdered"],
                    orderReady = (bool)dr["OrderReady"],
                    orderServed = (bool)dr["OrderServed"],
                    orderedLatest = (int)dr["OrderedLatest"],
                    barServed = (bool)dr["BarServed"],
                    kitchenServed = (bool)dr["KitchenServed"]
                };
                orderStatusTables.Add(orderStatusTable);
            }
            return orderStatusTables;
        }
        public void UpdateOrderServed(int served, int tableID)
        {
            string query = $"UPDATE [Order] SET OrderServed = {served} WHERE TableID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateOrderReady(int ready, int tableID)
        {
            string query = $"UPDATE [Order] SET OrderReady = {ready} WHERE TableID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateBarServed(int barServed, int tableID)
        {
            string query = $"UPDATE [Order] SET BarServed = {barServed} WHERE TableID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateKitchenServed(int kitchenServed, int tableID)
        {
            string query = $"UPDATE [Order] SET KitchenServed = {kitchenServed} WHERE TableID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
