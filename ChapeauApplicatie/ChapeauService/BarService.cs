using ChapeauDAL;
using ChapeauModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class BarService
    {
        BarDAO barDAO;
        public BarService()
        {
            barDAO = new BarDAO();
        }
        public List<BarItemModel> GetOrderByID(int OrderID)
        {
            return barDAO.GetOrderByID(OrderID);
        }
        public void ReadyOrder(int orderID)
        {
            barDAO.ReadyOrder(orderID);
        }
        public List<OrderModel> GetOrderListByLatest()
        {
            return barDAO.GetOrderListByLatest();
        }
        public void ReadyOrderItem(int orderItemID)
        {
            barDAO.ReadyOrderItem(orderItemID);
        }
        public void ReadyAllBarOrderItems(int orderID)
        {
            barDAO.ReadyAllBarOrderItems(orderID);
        }
    }

}
