using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Exchange2 : Form
    {
        private SqlConnection conn;
        public Exchange2()
        {
            InitializeComponent();
            
            conn = new SqlConnection(@"Data Source=MAHROSH\SQLEXPRESS01;Initial Catalog=loginpage;Integrated Security=True");
            conn.Open();
            // Set KeyPreview to true
            this.KeyPreview = true;

            // Add the KeyPress event handler for the form
            this.KeyPress += textBox1_KeyPress;

            // Add the ValueChanged event handler for numericUpDown1
            numericUpDown1.KeyPress += numericUpDown1_KeyPress;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Get the entered text
                string newText = textBox1.Text;

                // Get the selected number from numericUpDown1
                int selectedNumber = (int)numericUpDown1.Value;
                if (selectedNumber == 0)
                {
                    MessageBox.Show("Please enter the quantity before proceeding.");

                }
                else
                {

                    // Add the text and number to the ListBox
                    listBox1.Items.Add($"{newText} - {selectedNumber}");

                    // Clear the TextBox for the next input
                    textBox1.Clear();
                    numericUpDown1.Value = 0;
                }
                // Suppress the Enter key so it doesn't appear in the TextBox
                e.Handled = true;
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Get the entered text
                string newText = textBox1.Text;

                // Get the selected number from numericUpDown1
                int selectedNumber = (int)numericUpDown1.Value;
                if (selectedNumber == 0)
                {
                    MessageBox.Show("Please enter the quantity before proceeding.");

                }
                else
                {

                    // Add the text and number to the ListBox
                    listBox1.Items.Add($"{newText} - {selectedNumber}");

                    // Clear the TextBox for the next input
                    textBox1.Clear();
                    numericUpDown1.Value = 0;
                }
                // Suppress the Enter key so it doesn't appear in the TextBox
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransactionsPage form3 = new TransactionsPage();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalPrice = 0;
            // Create a copy of listBox1.Items
            var itemsCopy = new object[listBox1.Items.Count];
            listBox1.Items.CopyTo(itemsCopy, 0);

            foreach (var item in itemsCopy)
            {
                string[] parts = item.ToString().Split('-');
                string barcode = parts[0].Trim();
                int quantity = int.Parse(parts[1].Trim());

                // SQL command to fetch item information based on barcode
                string query = $"SELECT Name, Price, Quantity FROM Inventory WHERE Barcode = '{barcode}'";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Execute SQL command and read the data
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string itemName = reader["Name"].ToString();
                    int price = int.Parse(reader["Price"].ToString());
                    int availableQuantity = int.Parse(reader["Quantity"].ToString());

                    totalPrice = price * quantity;

                    int newQuantity = availableQuantity - quantity;
                    if (newQuantity < 0)
                    {
                        MessageBox.Show($"Not enough quantity available for {itemName}");
                        reader.Close(); // Close the reader in case of insufficient quantity
                        continue;
                    }

                    reader.Close(); // Close the reader before executing update command

                    // Update the database with decreased quantity
                    string updateQuery = $"UPDATE Inventory SET Quantity = {newQuantity} WHERE Barcode = '{barcode}'";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.ExecuteNonQuery();



                    // Generate receipt text
                    string receipt = $"{itemName} {quantity} {totalPrice}";
                    GenerateReceipt(receipt);

                    // Remove the sold item from the ListBox after processing all the data
                    listBox1.Items.Remove(item);
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Item not found");
                }
            }
          
            // Uncomment the following line once the Receipt form is created
            OpenReceiptForm();
        }
        private void OpenReceiptForm()
        {
            // Uncomment this method when the Receipt form is created and needs to be opened
            ExchangeReceipt receiptForm = new ExchangeReceipt();
            receiptForm.Show();
            this.Hide();
        }

        private void GenerateReceipt(string receipt)
        {
            // Create or append to a text file with the receipt information
            string filePath = "receipt.txt";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(receipt);
            }
        }
    }
}