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

                };
                tables.Add(table);
            }
            return tables;
        }
        public bool Reserved(int tafelNummer)
        { //niet alle tafels af in database, maar sql query zoeken en returnen

            string query = "SELECT Reserved FROM Tables WHERE TableID = @tableID ";
            SqlParameter[] sqlParameters = new SqlParameter[]{
            new SqlParameter("@tableID", tafelNummer)};
            List<Tables> reservedTable = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return Convert.ToBoolean(reservedTable[0]);
        }
    }
}
