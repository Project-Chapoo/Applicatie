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
    public class KeukenDAO : BaseDao
    {
        public List<KeukenItemModel> GetFirstOrder()
        {
            string query = "SELECT [OI].OrderItemID, [OI].Quantity, [MI].[Description] FROM OrderItem AS[OI] JOIN MenuItem AS[MI] ON[OI].MenuItemID = [MI].MenuItemID WHERE [OI].OrderID = (SELECT MIN(OrderID) FROM OrderItem)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<KeukenItemModel> GetSecondOrder()
        {
            string query = "SELECT [OI].OrderItemID, [OI].Quantity, [MI].[Description] FROM OrderItem AS[OI] JOIN MenuItem AS[MI] ON[OI].MenuItemID = [MI].MenuItemID WHERE [OI].OrderID = (SELECT MIN(OrderID) + 1 FROM OrderItem)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<KeukenItemModel> GetThirdOrder()
        {
            string query = "SELECT [OI].OrderItemID, [OI].Quantity, [MI].[Description] FROM OrderItem AS[OI] JOIN MenuItem AS[MI] ON[OI].MenuItemID = [MI].MenuItemID WHERE [OI].OrderID = (SELECT MIN(OrderID) + 2 FROM OrderItem)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<KeukenItemModel> ReadTables(DataTable dataTable)
        {
            List<KeukenItemModel> keukenItems = new List<KeukenItemModel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                KeukenItemModel keukenItem = new KeukenItemModel()
                {
                    OrderItemID = (int)dr["OrderItemID"],
                    Description = (string)(dr["Description"]),
                    quantity = (int)(dr["Quantity"]),
                };
                keukenItems.Add(keukenItem);
            }
            return keukenItems;
        }
    }
}
