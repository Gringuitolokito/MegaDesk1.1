using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ErikMartinez
{
    public class Desk
    {        
        //Enums
        public enum Surface
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int Drawers { get; set; }

        public Surface SurfaceMaterial { get; set; }

        

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
