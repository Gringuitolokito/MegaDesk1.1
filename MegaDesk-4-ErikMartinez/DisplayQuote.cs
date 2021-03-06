﻿using System;
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

            lbDate.Text = deskQuote.TimeStamp.ToString("M/d/yyyy");
            lblCustomerName.Text = deskQuote.CustomerName;
            lbWidth.Text = deskQuote.Desk.Width.ToString();
            lbDepth.Text = deskQuote.Desk.Depth.ToString();
            lbDrawers.Text = deskQuote.Desk.Drawers.ToString();
            lbSurfaceMaterial.Text = deskQuote.Desk.SurfaceMaterial.ToString();
            lbDelivery.Text = deskQuote.DeliveryChoice.ToString();
            lbTotal.Text = deskQuote.QuoteTotal.ToString("C");

        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
