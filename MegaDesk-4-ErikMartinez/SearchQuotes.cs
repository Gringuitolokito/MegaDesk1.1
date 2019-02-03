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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            var materials = new List<Desk.Surface>();
            materials = Enum.GetValues(typeof(Desk.Surface))
                .Cast<Desk.Surface>()
                .ToList();
            searchComboBox.DataSource = materials;

            //set it to none
            searchComboBox.SelectedIndex = -1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {      

            string quotefile = @"quotefile.txt";
            StreamReader reader = new StreamReader(quotefile);
            int row = 0;

            while (reader.EndOfStream == false)
            {
                string rowdata = reader.ReadLine();

                if (rowdata.Length > 0)
                {
                    string[] values = rowdata.Split(',');
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            String quoteFile = @"quoteFile.txt";
            StreamReader streamReader = new StreamReader(quoteFile);
            
            int row = 0;

            ViewQuotesGrid.Rows.Clear();

            while (!streamReader.EndOfStream)
            {
                string rowData = streamReader.ReadLine();

                if (rowData.Length > 0)
                {
                    string[] values = rowData.Split(',');

                    if (values[5] == searchComboBox.SelectedValue.ToString())
                    {
                        ViewQuotesGrid.Rows.Add();
                        for (int i = 0; i < 8; i++)
                        {
                            ViewQuotesGrid[i, row].Value = values[i];
                        }

                        row++;
                    }
                }
                else
                {
                    MessageBox.Show("There are no quotes to show.");
                }

            }
        }
    }
}

