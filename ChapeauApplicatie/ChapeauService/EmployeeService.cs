using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class EmployeeService
    {
        EmployeeDAO employeeDb;

        public EmployeeService()
        {
            this.employeeDb = new EmployeeDAO();
        }

        public string CheckEmployeeLogIn(string checkPassword)
        {
            return employeeDb.CheckEmployeeLogIn(checkPassword);
        }
        
    }
}
