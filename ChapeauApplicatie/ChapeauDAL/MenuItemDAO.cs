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
    public class MenuItemDAO : BaseDao
    {
        public List<MenuItem> GetAllMenuItems()
        {
            string query = "select menuitemid, menuid, category, description, price, alcohol, stock from menuitem";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuItem> GetStockForMenuItems(int menuItemID)
        {
            string query = "select menuitemid, stock " +
                           "from menuitem" +
                          $"where menuitemid = {menuItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesForStock(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    menuItemID = (int)dr["menuItemid"],
                    menuID = (int)(dr["menuID"]),
                    Category = (string)(dr["category"]),
                    description = (string)(dr["description"]),
                    price = Convert.ToDouble(dr["price"]),
                    alcohol = (bool)(dr["alcohol"]),
                    stock = (int)(dr["stock"]),
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        private List<MenuItem> ReadTablesForStock(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    menuItemID = (int)dr["menuItemid"],
                    stock = (int)(dr["stock"]),
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        public void SteakLunch()
        {
            string query = $"update menuitems set stock = stock - 1 where menuitemID = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
