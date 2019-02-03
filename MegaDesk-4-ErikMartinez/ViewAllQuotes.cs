using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_3_ErikMartinez
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            String quoteFile = @"quoteFile.txt";
            StreamReader Reader = new StreamReader(quoteFile);
            int row = 0;

            while (Reader.EndOfStream == false)
            {
                string rowData = Reader.ReadLine();

                if (rowData.Length > 0)
                {
                    string[] values = rowData.Split(',');
                    ViewQuotesGrid.Rows.Add();
                    
                    for (int i = 0; i < 8; i++)
                    {
                        ViewQuotesGrid[i, row].Value = values[i];
                       
                    }
                    row++;
                }
                else
                {
                    MessageBox.Show("Nothing to see here.");
                }

            }
        }
    }
}
