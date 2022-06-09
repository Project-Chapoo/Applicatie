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
    public class TableOrderDAO : BaseDao
    {
        public List<TableOrder> TableOrders(int tableID)
        {
            string query = $"SELECT orderitem.Tableid, menuitem.menuID, menuitem.Category, menuitem.courseID, orderitem.ReadyOrderItem FROM[OrderItem] JOIN MenuItem ON[OrderItem].MenuItemID = MenuItem.MenuItemID WHERE orderitem.Tableid = {tableID} ORDER BY courseID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTableOrders(ExecuteSelectQuery(query, sqlParameters));
            
        }
        private List<TableOrder> ReadTableOrders(DataTable dataTable)
        {
            List<TableOrder> tableOrders = new List<TableOrder>();

            foreach (DataRow dr in dataTable.Rows)
            {
                TableOrder tableOrder = new TableOrder()
                {
                    tableId = (int)(dr["Tableid"]),
                    menuId = (int)(dr["menuID"]),
                    category = (string)dr["Category"],
                    readyOrderItem = (bool)dr["ReadyOrderItem"]
                };
                tableOrders.Add(tableOrder);
            }
            return tableOrders;
        }
    }
}
