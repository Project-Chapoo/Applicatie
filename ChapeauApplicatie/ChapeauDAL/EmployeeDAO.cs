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
    public class EmployeeDAO : BaseDao
    {
        public List<EmployeeModel> GetAllEmployees()
        {
            string query = "SELECT FirstName, LastName, EmployeeFunction, LoginPassword, LoginUsername, [Admin] FROM Employee";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<EmployeeModel> ReadTables(DataTable dataTable)
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    firstName = (string)dr["FirstName"],
                    lastName = (string)dr["LastName"],
                    employeeFunction = (string)dr["EmployeeFunction"],
                    loginPassword = (string)dr["LoginPassword"],
                    loginUsername = (string)dr["LoginUsername"],
                    isAdmin = (bool)dr["Admin"],
                };
                employees.Add(employee);
            }
            return employees;
        }
        public EmployeeModel CheckEmployeeLogIn(string checkPassword)
        {
            string query = "SELECT FirstName, LastName, EmployeeFunction, LoginPassword, LoginUsername, [Admin] FROM Employee WHERE LoginPassword = @loginPassword ";
            SqlParameter[] sqlParameters = new SqlParameter[]{
            new SqlParameter("@loginPassword", checkPassword)};
            List<EmployeeModel> employeeName = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            EmployeeModel employee = employeeName[0];
            return employee;
        }
        
    }
}
