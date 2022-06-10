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
            string query = "SELECT orderid, tableid FROM [order]";
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
                };
                orders.Add(order);
            }
            return orders;
        }

        public void OrderNewest(int tableID)
        {
            string query = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 1";
            string query2 = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 2";
            string query3 = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 3";
            string query4 = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 4";
            string query5 = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 5";
            string query6 = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 6";
            string query7 = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 7";
            string query8 = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 8";
            string query9 = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 9";
            string query10 = $"update [Order] set orderedlatest = orderedlatest + 1 where tableID = 10";
            string query11 = $"update [Order] set orderedlatest = 1 where OrderID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
            ExecuteEditQuery(query2, sqlParameters);
            ExecuteEditQuery(query3, sqlParameters);
            ExecuteEditQuery(query4, sqlParameters);
            ExecuteEditQuery(query5, sqlParameters);
            ExecuteEditQuery(query6, sqlParameters);
            ExecuteEditQuery(query7, sqlParameters);
            ExecuteEditQuery(query8, sqlParameters);
            ExecuteEditQuery(query9, sqlParameters);
            ExecuteEditQuery(query10, sqlParameters);
            ExecuteEditQuery(query11, sqlParameters);
        }

        public void OrderConfirm(int tableID, string commentaar)
        {
            string query = $"update [Order] set comment = '{commentaar}', TimeOrdered = CURRENT_TIMESTAMP where OrderID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
