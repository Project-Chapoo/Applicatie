using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class PayingService
    {
        PayingDAO pd = new PayingDAO();
        public Bill GetBill()
        {
            return pd.GetOrderInfo(1);
        }
    }
}
