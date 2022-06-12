using ChapeauDAL;
using ChapeauModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class KeukenService : BaseService
    {
        KeukenDAO keukenDAO;
        public KeukenService()
        {
            keukenDAO = new KeukenDAO();
        }
        public List<KeukenItemModel> GetOrderByID(int OrderID)
        {
            return keukenDAO.GetOrderByID(OrderID);
        }
        public void ReadyOrder(int orderID)
        {
            keukenDAO.ReadyOrder(orderID);
        }
        public List<OrderModel> GetOrderListByLatest()
        {
            return keukenDAO.GetOrderListByLatest();
        }
        public void ReadyOrderItem(int orderItemID)
        {
            keukenDAO.ReadyOrderItem(orderItemID);
        }
        public void ReadyAllKeukenOrderItems(int orderID)
        {
            keukenDAO.ReadyAllKeukenOrderItems(orderID);
        }
    }

}
