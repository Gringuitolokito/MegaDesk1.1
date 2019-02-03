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

            //populate surface material com-box 
            var materials = new List<Desk.Surface>();
            materials = Enum.GetValues(typeof(Desk.Surface))
                .Cast<Desk.Surface>()
                .ToList();
            surfaceMaterialComboBox.DataSource = materials;

            //set it to none
            surfaceMaterialComboBox.SelectedIndex = -1;

            //populate surface delivery com-box 
            var delivery = new List<DeskQuote.Delivery>();
            delivery = Enum.GetValues(typeof(DeskQuote.Delivery))
                .Cast<DeskQuote.Delivery>()
                .ToList();
            deliveryComboBox.DataSource = delivery;

            //set it to none
            deliveryComboBox.SelectedIndex = -1;
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
            //desk.DeliveryChoice = (Desk.Delivery)deliveryComboBox.SelectedIndex;
            

            var deskQoute = new DeskQuote();
           
            deskQoute.CustomerName = customerNameTextBox.Text;
            deskQoute.DeliveryChoice = (DeskQuote.Delivery)deliveryComboBox.SelectedIndex;
            deskQoute.TimeStamp = DateTime.Now;
            deskQoute.Desk = desk;
            var quote = deskQoute.GetQuoteTotal();
            deskQoute.QuoteTotal = quote;

            //AddQuoteToFile(deskQoute);
           
            try { 
            String quoteFile = @"quoteFile.txt";
            using (StreamWriter writer = File.AppendText(quoteFile))
                writer.WriteLine
               (
               deskQoute.TimeStamp + "," +
               deskQoute.CustomerName + "," +
               desk.Width + "," +
               desk.Depth + "," +
               desk.Drawers + "," +
               desk.SurfaceMaterial + "," +
               deskQoute.DeliveryChoice + "," +
               quote
               );
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating your quote. " +
                    "Please try again later. {0}", err.Message);
            }
            DisplayQuote displayForm = new DisplayQuote(deskQoute);
            displayForm.Tag = (MainMenu)Tag;
            displayForm.Show();
            this.Close();

        }
    }
}
