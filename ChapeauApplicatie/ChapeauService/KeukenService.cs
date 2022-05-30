using ChapeauDAL;
using ChapeauModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class KeukenService
    {
        KeukenDAO keukenDAO;
        public KeukenService()
        {
            keukenDAO = new KeukenDAO();
        }
        public List<KeukenItemModel> GetFirstOrder()
        {
            return keukenDAO.GetFirstOrder();
        }
        public List<KeukenItemModel> GetSecondOrder()
        {
            return keukenDAO.GetSecondOrder();
        }
        public List<KeukenItemModel> GetThirdOrder()
        {
            return keukenDAO.GetThirdOrder();
        }
    }

}
