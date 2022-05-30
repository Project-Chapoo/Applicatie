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

        public void AddTip(double tip)
        {
            billItems.Add(new BillItem(billItems.Count, 1, "fooi", tip, false));
        }
    }
}
