using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModels;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace ChapeauDAL
{
    public class StockDAO : BaseDao
    {
        public List<Stock> GetStock()
        {
            string query = $"SELECT menuID, stock FROM [stock]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Stock> ReadTables(DataTable dataTable)
        {
            List<Stock> stocks = new List<Stock>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Stock stock = new Stock()
                {
                    MenuItemID = (int)dr["menuID"],
                    StockAmount = (int)(dr["Stock"]),
                   
                };
                stocks.Add(stock);
            }
            return stocks;
        }

        public void StockSubstract(int menuItemID)
        {
            string query = $"update stock set stock = stock - 1 where MenuID = {menuItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void StockDepletion(int stockItem)
        {
            string query = $"update stock set stock = stock - 1 where MenuID = {stockItem}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddStock(int stockItem)
        {
            string query = $"update stock set stock = stock + 1 where MenuID = {stockItem}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
