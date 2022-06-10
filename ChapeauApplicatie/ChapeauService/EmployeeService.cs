using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class EmployeeService : BaseService
    {
        EmployeeDAO employeeDb;

        public EmployeeService()
        {
            this.employeeDb = new EmployeeDAO();
        }

        public EmployeeModel CheckEmployeeLogIn(string checkPassword)
        {
            return employeeDb.CheckEmployeeLogIn(checkPassword);
        }
        
    }
}
