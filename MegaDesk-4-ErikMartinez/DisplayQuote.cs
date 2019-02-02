using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ErikMartinez
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {

            InitializeComponent();

            lblCustomerName.Text = deskQuote.CustomerName;
            //lbWidth;
            //lbDepth;
            //lbDrawers;
            //lbSurfaceMaterial;
            //lbDelivery;
            

        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
