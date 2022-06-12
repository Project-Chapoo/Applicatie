using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauModels;
using ChapeauDAL;

namespace ChapeauService
{
    public class MenuItemService : BaseService
    {
        MenuItemDAO Menuitemsdb;
        public MenuItemService()
        {
            Menuitemsdb = new MenuItemDAO();
        }
        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItem = Menuitemsdb.GetAllMenuItems();
            return menuItem;
        }

        public void DepleteFromStock(int menuItemID)
        {
            Menuitemsdb.StockDepletion(menuItemID);
        }

        public void DepleteFromStockWhileAddindQuantity(int menuItemID)
        {
            Menuitemsdb.StockDepletionWhileAddindQuantity(menuItemID);
        }

        public void IncreaseStockWhileAddindQuantity(int menuItemID)
        {
            Menuitemsdb.StockIncreaseWhileAddindQuantity(menuItemID);
        }

        public void AddToStock(int menuItemId)
        {
            Menuitemsdb.AddStock(menuItemId);
        }

    }
    
}
