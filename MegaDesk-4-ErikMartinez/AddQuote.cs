using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ErikMartinez
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void addNewQoute_Button_Click(object sender, EventArgs e)
        {
            var desk = new Desk();
            desk.Width = widthNumeric.Value;
            desk.Depth = depthNumeric.Value;
            desk.Drawers = (int)drawersNumeric.Value;
            desk.SurfaceMaterial = (Desk.Surface)surfaceMaterialComboBox.SelectedIndex;
            desk.DeliveryChoice = (Desk.Delivery)deliveryComboBox.SelectedIndex;

            StreamWriter writer;
            writer = new StreamWriter("quotes.txt");
        }
    }
}
