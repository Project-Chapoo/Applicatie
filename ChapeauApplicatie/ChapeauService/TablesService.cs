using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModels;
using ChapeauDAL;


namespace ChapeauService
{
    public class TablesService : BaseService
    {
        TablesDAO tablesdb;
        public TablesService()
        {
            this.tablesdb = new TablesDAO();
        }
        public Tables IsGereserveerd(int tableID)
        {
            return tablesdb.IsGereserveerd(tableID);
        }
        public List<Tables> GetTables()
        {
            List<Tables> tables = tablesdb.GetAllTables();
            return tables;
        }
        public void UpdateTableStatus(int tableID, int reserved)
        {
            tablesdb.UpdateTableStatus(tableID, reserved);
        }

        public void ReserveTable(int tableID)
        {
            tablesdb.TableReserve(tableID);
        }

    }
}
