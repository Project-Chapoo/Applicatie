using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using ChapeauModels;

namespace ChapeauDAL
{
    public class PayingDAO : BaseDao
    {
        public Bill GetOrderInfo(int orderID)
        {
            string query = "SELECT * FROM[dbo].[Order] AS O JOIN[dbo].[Tables] AS T ON O.TableID = T.TableID JOIN[dbo].[Employee] AS E ON T.EmployeeID = E.EmployeeID WHERE O.OrderID = @orderID";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderID", SqlDbType.Int) { Value = orderID };
            return ReadTablesGetOrderInfo(ExecuteSelectQuery(query, sqlParameters));
        }

        private Bill ReadTablesGetOrderInfo(DataTable dataTable)
        {
            Bill bill = new Bill();
            foreach (DataRow dr in dataTable.Rows)
            {

                DataRow test = dr;
                int orderID = (int)dr["OrderID"];
                int tableID = (int)dr["TableID"];
                string employeeFirstName = (string)dr["FirstName"];
                string employeeLastName = (string)dr["LastName"];
                bill = new Bill(orderID, tableID, employeeFirstName, employeeLastName);
            }
            bill.billItems = GetOrderItems();
            return bill;
        }

        public List<BillItem> GetOrderItems()
        {
            string query = "SELECT Quantity, [Description], Price, Alcohol FROM[dbo].[OrderItem] AS O " +
                            "JOIN[dbo].[MenuItem] AS M ON O.MenuItemID = M.MenuItemID; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesBillItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<BillItem> ReadTablesBillItems(DataTable dataTable)
        {
            List<BillItem> billItems = new List<BillItem>();
            int currentItemID = 1;
            foreach (DataRow dr in dataTable.Rows)
            {
                BillItem billItem = new BillItem();
                billItem.BillItemID = currentItemID;
                billItem.Quantity = (int)dr["Quantity"];
                billItem.Description = (string)dr["Description"];
                billItem.Price = Convert.ToDouble(dr["Price"]);
                billItem.Alcohol = (bool)dr["Alcohol"];
                billItems.Add(billItem);
                currentItemID++;
            }
            return billItems;
        }

        public void SendBill(Bill bill)
        {
            string query = "INSERT INTO [dbo].[Receipt] ([TableID], [commentary], [DateAndTime], [EmployeeFirstName], [EmployeeLastName]) VALUES (@TableID, @commentary, @DateAndTime, @EmployeeFirstName, @EmployeeLastName)";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@TableID", SqlDbType.Int) { Value = bill.TableID },
                new SqlParameter("@commentary", SqlDbType.VarChar) { Value = bill.Comment },
                new SqlParameter("@DateAndTime", SqlDbType.DateTime) { Value = DateTime.Now },
                new SqlParameter("@EmployeeFirstName", SqlDbType.VarChar) { Value = bill.EmployeeFirstName },
                new SqlParameter("@EmployeeLastName", SqlDbType.VarChar) { Value = bill.EmployeeLastName }
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void SendBillItems(Bill bill)
        {
            string query = "INSERT INTO [dbo].[ReceiptItem] ([ReceiptID], [MenuItemID], [Quantity]) VALUES (@ReceiptID, @MenuItemID, @Quantity)";
            // Sql parameters with ReceiptID, MenuItemID, Quantity
            foreach (BillItem billItem in bill.billItems)
            {
                SqlParameter[] sqlParameters = {
                new SqlParameter("@ReceiptID", SqlDbType.Int) { Value = bill.ReceiptID },
                new SqlParameter("@MenuItemID", SqlDbType.Int) { Value = billItem.MenuItemID },
                new SqlParameter("@Quantity", SqlDbType.Int) { Value = billItem.Quantity }
            };
            ExecuteEditQuery(query, sqlParameters);
            }
        }
    }
}
