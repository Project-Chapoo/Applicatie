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
    public class BarDAO : BaseDao
    {
        public List<OrderModel> GetOrderListByLatest()
        {
            string query = "SELECT OrderID, TableID, Comment, TimeOrdered, OrderReady, OrderServed, OrderedLatest FROM [ORder] WHERE OrderReady = 0 AND orderID IN (SELECT OrderID FROM OrderItem WHERE MenuItemID > 21 AND ReadyOrderItem = 0 GROUP BY OrderID HAVING COUNT(OrderID) > 0) ORDER BY [OrderedLatest] DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public bool CheckBarOnOrderID(int orderID)
        {
            string query = $"SELECT OrderID FROM [ORder] WHERE OrderReady = 0 AND OrderID = {orderID} AND orderID IN (SELECT OrderID FROM OrderItem WHERE MenuItemID > 21 AND ReadyOrderItem = 0 GROUP BY OrderID HAVING COUNT(OrderID) > 0) ORDER BY [OrderedLatest] DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<BarItemModel> barItemList = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            if (barItemList[0].OrderID == 0)
                return false;
            return true;
        }
        public List<BarItemModel> GetOrderByID(int OrderID)
        {
            string query = $"SELECT [OI].OrderItemID, [OI].Quantity, [MI].[Description], [OI].OrderID FROM OrderItem AS[OI] JOIN MenuItem AS[MI] ON[OI].MenuItemID = [MI].MenuItemID WHERE OrderID = {OrderID} AND [OI].MenuItemID > 21 AND [OI].ReadyOrderItem = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void ReadyOrderItem(int orderItemID)
        {
            string query = $"UPDATE OrderItem SET ReadyOrderItem = 1 WHERE OrderItemID = {orderItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ReadyOrder(int orderID)
        {
            string query = $"Update [Order] SET OrderReady = 1 WHERE OrderID = {orderID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ReadyAllBarOrderItems(int orderID)
        {
            string query2 = $"UPDATE OrderItem SET ReadyOrderItem = 1 WHERE OrderID = {orderID} AND MenuItemID > 21";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query2, sqlParameters);

        }
        private List<OrderModel> ReadOrderTables(DataTable dataTable)
        {
            List<OrderModel> orderItems = new List<OrderModel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderModel orderItem = new OrderModel()
                {
                    OrderId = (int)dr["OrderID"],
                    TableId = (int)(dr["TableID"]),
                    Comment = (string)(dr["Comment"]),
                    TimeOrdered = (DateTime)(dr["TimeOrdered"]),
                    OrderReady = (bool)(dr["OrderReady"]),
                    OrderServed = (bool)(dr["OrderServed"]),
                    OrderedLatest = (int)(dr["OrderedLatest"]),
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        private List<BarItemModel> ReadTables(DataTable dataTable)
        {
            List<BarItemModel> keukenItems = new List<BarItemModel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                BarItemModel keukenItem = new BarItemModel()
                {
                    OrderItemID = (int)dr["OrderItemID"],
                    Description = (string)(dr["Description"]),
                    OrderID = (int)dr["OrderID"],
                    quantity = (int)(dr["Quantity"]),
                };
                keukenItems.Add(keukenItem);
            }
            return keukenItems;
        }
    }
}