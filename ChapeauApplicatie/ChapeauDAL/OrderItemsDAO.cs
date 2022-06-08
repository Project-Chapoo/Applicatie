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
                    quantity = (int)(dr["Quantity"]),
                };
                orderItems.Add(orderitem);
            }
            return orderItems;
        }
        

    }
}
