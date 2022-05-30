using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModels;
using ChapeauDAL;


namespace ChapeauService
{
    public class TablesService
    {
        TablesDAO tablesdb;

        public TablesService()
        {
            this.tablesdb = new TablesDAO();
        }

        public bool Reserved(int tafelNummer)
        {
            return tablesdb.Reserved(tafelNummer);
        }

        public List<Tables> GetTables()
        {
            List<Tables> tables = tablesdb.GetAllTables();
            return tables;
        }

    }
}
