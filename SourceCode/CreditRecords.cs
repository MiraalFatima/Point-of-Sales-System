using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CreditRecords : Form
    {
        public CreditRecords()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void CreditRecords_Load(object sender, EventArgs e)
        {
            string transactionLogsFilePath = "Credit.txt";

            try
            {
                // Read contents of the transaction logs file
                string[] logs = File.ReadAllLines(transactionLogsFilePath);

                for (int i = 0; i < logs.Length; i++)
                {
                    string[] logDetails = logs[i].Split(',');

                    // Add a new row to the DataGridView
                    int rowIndex = dataGridView1.Rows.Add();

                    // Fill each cell of the row with log details
                    for (int j = 0; j < logDetails.Length; j++)
                    {
                        dataGridView1.Rows[rowIndex].Cells[j].Value = logDetails[j];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ManagerInterface form3 = new ManagerInterface();
            form3.Show();
            this.Hide();
        }
    }
}
