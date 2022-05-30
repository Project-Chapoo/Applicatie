using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModels
{
    public class EmployeeModel
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string employeeFunction { get; set; }
        public string loginPassword { get; set; }
        public string loginUsername { get; set; }
        public bool isAdmin { get; set; }
    }
}
