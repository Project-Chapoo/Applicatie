﻿using ChapeauDAL;
using ChapeauModels;

namespace ChapeauService
{
    public class PayingService : BaseService
    {
        private const double twentyOnePercentFactor = 21;
        private const double sixPercentFactor = 6;
        private const double oneHunderdTwentyOnePercentFactor = 121;
        private const double oneHunderdsixPercentFactor = 106;
        private const string billItemTipDescription = "tip";
        PayingDAO payingDAO = new PayingDAO();
        public Bill GetOrder()
        {
            return payingDAO.GetOrderInfo(1);
        }

        public Bill AddTip(Bill bill, double tip)
        {
            bill.billItems.Add(new BillItem(bill.billItems.Count + 1, 1, billItemTipDescription, tip, false));
            return bill;
        }

        public double CalculateBTW(Bill bill)
        {
            double btwPrice = 0;

            foreach (BillItem b in bill.billItems)
            {
                if (b.Description == billItemTipDescription)
                {
                    continue;
                }
                else if (b.Alcohol)
                {
                    btwPrice += (b.Price / oneHunderdTwentyOnePercentFactor * twentyOnePercentFactor) * b.Quantity;
                }
                else
                {
                    btwPrice += (b.Price / oneHunderdsixPercentFactor * sixPercentFactor) * b.Quantity;
                }
            }

            return btwPrice;
        }
    }
}
