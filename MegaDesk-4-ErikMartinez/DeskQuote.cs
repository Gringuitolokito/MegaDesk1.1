using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ErikMartinez
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }        
        public DateTime TimeStamp { get; set; }

        //Pricing structure
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal DT_SURFACE_AREA = 1.00M;
        const decimal DRAWERS = 50.00M;

        //Surface material
        const decimal SM_LAMINATE = 100.00M;
        const decimal SM_OAK = 200.00M;
        const decimal SM_ROSEWOOD = 300.00M;
        const decimal SM_VENEER = 125.00M;
        const decimal SM_PINE = 50.00M;

        //Rush cost
        const decimal R_3DAY_LT_1000 = 60.00M;
        const decimal R_3DAY_1000_2000 = 70.00M;
        const decimal R_3DAY_GT_2000 = 80.00M;

        const decimal R_5DAY_LT_1000 = 40.00M;
        const decimal R_5DAY_1000_2000 = 50.00M;
        const decimal R_5DAY_GT_2000 = 60.00M;

        const decimal R_7DAY_LT_1000 = 30.00M;
        const decimal R_7DAY_1000_2000 = 35.00M;
        const decimal R_7DAY_GT_2000 = 40.00M;

        public decimal QuoteTotal { get; set; }
        public decimal GetQuoteTotal()
        {
            decimal quotePrice = BASE_DESK_PRICE;
                       
            return quotePrice;
        }

        public enum Delivery
        {
            Rush_3_Days,
            Rush_5_Days,
            Rush_7_Days,
            Normal_14_Days
        }
        public Delivery DeliveryChoice { get; set; }


    }
}
