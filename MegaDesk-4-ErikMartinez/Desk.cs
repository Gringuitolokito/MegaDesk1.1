using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ErikMartinez
{
    public class Desk
    {
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int Drawers { get; set; }

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

        //Enums 
        public enum Delivery
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }
        public Delivery DeliveryChoice { get; set; }

        public enum Surface
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }
        public Surface SurfaceMaterial { get; set; }

        public Desk desk { get; set; }

       /* No longer needed as NumericUpDown is being used
        // Constraints for Width and Depth

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWER = 0;
        public const int MAXDRAWER = 7;
        */
    }
}
