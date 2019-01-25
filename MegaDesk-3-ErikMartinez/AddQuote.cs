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
            desk.Width = Int32.Parse(widthTextBox.Text);
            desk.Depth = Int32.Parse(depthTextBox.Text);
            desk.Drawers = Int32.Parse(drawerTextBox.Text);
            
        }

        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(widthTextBox.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MINWIDTH + " to " + Desk.MAXWIDTH + " inches");
                    widthTextBox.Text = String.Empty;
                    widthTextBox.BackColor = Color.DarkOrange;
                    widthTextBox.Focus();
                }
                else
                {
                    widthTextBox.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(widthTextBox.Text, out WidthInput) == false && widthTextBox.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                widthTextBox.Text = String.Empty;
                widthTextBox.BackColor = Color.DarkOrange;
                widthTextBox.Focus();
            }
            else
            {
                widthTextBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void depthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(depthTextBox.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MINDEPTH || DepthInput > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MINDEPTH + " to " + Desk.MAXDEPTH + " inches");
                    depthTextBox.Text = String.Empty;
                    depthTextBox.BackColor = Color.DarkOrange;
                    depthTextBox.Focus();
                }
                else
                {
                    depthTextBox.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(depthTextBox.Text, out DepthInput) == false && depthTextBox.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                depthTextBox.Text = String.Empty;
                depthTextBox.BackColor = Color.DarkOrange;
                depthTextBox.Focus();
            }
            else
            {
                depthTextBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }
    }
}
