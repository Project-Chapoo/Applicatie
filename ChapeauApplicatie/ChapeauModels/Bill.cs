namespace ChapeauModels
{
    public class Bill
    {
        public Bill() { }

        public Bill(int orderID, int tableID, string employeeFirstName, string employeeLastName)
        {
            OrderID = orderID;
            TableID = tableID;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
        }

        public int OrderID { get; }
        public int TableID { get; }
        public string EmployeeFirstName { get; }
        public string EmployeeLastName { get; }
        public List<BillItem> billItems { get; set; }
        public string EmployeeFullName
        {
            get
            {
                return EmployeeFirstName + " " + EmployeeLastName;
            }
        }

        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach (BillItem item in billItems)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            }
        }
    }
}
