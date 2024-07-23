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

namespace WinFormsApp1
{
    public partial class ExchangeReceipt : Form
    {
        public ExchangeReceipt()
        {
            InitializeComponent();
            richTextBox1.ZoomFactor = 1;
            DisplayReceipt("receipt.txt");
        }
        private void DisplayReceipt(string filePath)
        {
            try
            {
                // Clear existing text in RichTextBox
                richTextBox1.Clear();

                // Display the shop's name at the top of the receipt with centered alignment, bigger and bold font
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 14, FontStyle.Bold);
                richTextBox1.AppendText("Choice Center Cosmetics" + Environment.NewLine + Environment.NewLine);

                // Display column headings in bold
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText("Item:\t\tQnty:\t\tPrice:" + Environment.NewLine);

                int total = 0; // Variable to store the sum

                // Horizontal line function for column headers
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                richTextBox1.AppendText(new string('-', 48) + Environment.NewLine);

                // Read lines from the file
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // Split the line into words
                    string[] words = line.Split(' ');

                    // Format the line with proper spacing
                    string formattedLine = $"{words[0],-20}\t   {words[1],-10}\t               {words[2],-10}";
                    richTextBox1.AppendText(formattedLine + Environment.NewLine);

                    // Convert the third word to an integer and add it to the total
                    if (words.Length >= 3)
                    {
                        int quantity;
                        if (int.TryParse(words[2], out quantity))
                        {
                            total += quantity;
                        }
                    }
                }

                // Horizontal line after the items
                richTextBox1.AppendText(new string('-', 48) + Environment.NewLine);

                // Append the total at the end
                richTextBox1.AppendText($"Total:\t\t\t               {total}" + Environment.NewLine);
                richTextBox1.AppendText(new string('-', 48) + Environment.NewLine);

                // You can further customize formatting if needed
                // Read lines from the exchangereceipt.txt file
                string exchangeFilePath = "exchangereceipt.txt";
                if (File.Exists(exchangeFilePath))
                {
                    string[] exchangeLines = File.ReadAllLines(exchangeFilePath);
                    foreach (string line in exchangeLines)
                    {
                        // Split the line into strings
                        string[] parts = line.Split(':');
                        if (parts.Length >= 2)
                        {
                            string string1 = parts[0].Trim();
                            string string2 = parts[1].Trim();

                            // Display string1 and string2
                            richTextBox1.AppendText($"{string1}:\t\t\t{string2}" + Environment.NewLine);
                            richTextBox1.AppendText(new string('-', 48) + Environment.NewLine);

                            // Convert string2 to integer and subtract from 'total'
                            int priceDue;
                            if (int.TryParse(string2.Split(' ')[0], out priceDue))
                            {
                                total -= priceDue;

                                // Display appropriate message based on the subtraction result
                                if (total < 0)
                                {
                                    int returnedPrice = -total;
                                    richTextBox1.AppendText($"Price Returned:\t\t\t{returnedPrice}" + Environment.NewLine);
                                }
                                else
                                {
                                    richTextBox1.AppendText($"Price Paid:\t\t\t{total}" + Environment.NewLine);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Clear the contents of the exchangereceipt.txt file
            string FilePath = "exchangereceipt.txt";
            File.WriteAllText(FilePath, string.Empty);
        }




        private void ExchangeReceipt_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ExchangeReceipt_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            string receiptFilePath = "receipt.txt";
            string transactionLogsFilePath = "transaction_logs.txt";

            try
            {
                // Read existing transaction logs
                List<string> existingLogs = new List<string>();
                if (File.Exists(transactionLogsFilePath))
                {
                    existingLogs = File.ReadAllLines(transactionLogsFilePath).ToList();
                }

                // Read contents of the receipt file
                string[] receiptContents = File.ReadAllLines(receiptFilePath);

                // Create a new transaction log entry with the current date/time and receipt details
                string currentTime = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
                foreach (string line in receiptContents)
                {
                    // Concatenate elements with a single space between them
                    string[] elements = line.Split(' '); // Assuming elements are already separated by spaces
                    string transactionLog = string.Join(" ", elements) + " " + currentTime;

                    existingLogs.Add(transactionLog);
                }

                // Write all the logs back to the transaction logs file
                File.WriteAllLines(transactionLogsFilePath, existingLogs);

                // Clear the content of the receipt.txt file
                File.WriteAllText(receiptFilePath, string.Empty);
                MessageBox.Show("Transaction completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                // After clearing the file, proceed to the Sales form
                TransactionsPage form = new TransactionsPage();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
