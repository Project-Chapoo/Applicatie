using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapeauModels;

namespace ChapeauDAL
{
    public class TablesDAO : BaseDao
    {
        public List<Tables> GetAllTables()
        {
            string query = "SELECT TableID, Reserved, EmployeeID FROM [tables]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Tables> ReadTables(DataTable dataTable)
        {
            List<Tables> tables = new List<Tables>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tables table = new Tables()
                {
                    tableID = (int)dr["TableID"],
                    Reserved = (bool)dr["Reserved"],
                    EmployeeID = (int)dr["EmployeeID"],
                };
                tables.Add(table);
            }
            return tables;
        }
        public Tables IsGereserveerd(int tableID)
        {
            string query = $"SELECT Tableid, Reserved, EmployeeID FROM [tables] where tableid = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Tables> tables = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            Tables table = tables[0];
            return table;
        }
        public void UpdateTableStatus(int tableID, int reserved)
        {
            string query = $"UPDATE [Tables] SET Reserved = {reserved} WHERE TableID = {tableID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
