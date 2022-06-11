using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class StockService : BaseService
    {
        StockDAO stockdb;

        public StockService()
        {
            stockdb = new StockDAO();
        }

        public List<Stock> GetAllStock()
        {
            List<Stock> stock = stockdb.GetStock();
            return stock;
        }

        public void SubstractStock(int menuItemID)
        {
            stockdb.StockSubstract(menuItemID);
        }

        public void DepleteFromStock(int stockItem)
        {
            stockdb.StockDepletion(stockItem);
        }

        public void AddToStock(int stockItem)
        {
            stockdb.AddStock(stockItem);
        }
    }
}