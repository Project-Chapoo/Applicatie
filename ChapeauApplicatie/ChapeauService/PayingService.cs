using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class PayingService
    {
        PayingDAO payingDAO = new PayingDAO();
        public Bill GetOrder()
        {
            return payingDAO.GetOrderInfo(1);
        }

        public Bill AddTip(Bill bill, double tip)
        {
            bill.billItems.Add(new BillItem(bill.billItems.Count + 1, 1, "Tip", tip, false));
            return bill;
        }
    }
}
