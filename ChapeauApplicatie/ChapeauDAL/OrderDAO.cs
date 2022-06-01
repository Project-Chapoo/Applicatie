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

        public void OrderCreateNew(int tableID)
        {
            
        }

        public void OrderConfirm(int tableID, string commentaar)
        {
            string query = $"update [Order] set comment = '{commentaar}', TimeOrdered = CURRENT_TIMESTAMP where OrderID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
