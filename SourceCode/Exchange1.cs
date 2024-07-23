using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Exchange1 : Form
    {
        private SqlConnection conn;
        public Exchange1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            conn = new SqlConnection(@"Data Source=MAHROSH\SQLEXPRESS01;Initial Catalog=loginpage;Integrated Security=True");
            conn.Open();
            this.KeyPress += textBox1_KeyPress;
            numericUpDown1.KeyPress += numericUpDown1_KeyPress;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
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


        private void button2_Click(object sender, EventArgs e)
        {
    //        int totalPrice = 0;
    //        // Create a copy of listBox1.Items
    //        var itemsCopy = new object[listBox1.Items.Count];
    //        listBox1.Items.CopyTo(itemsCopy, 0);

    //        foreach (var item in itemsCopy)
    //        {
    //            string[] parts = item.ToString().Split('-');
    //            string barcode = parts[0].Trim();
    //            int quantity = int.Parse(parts[1].Trim());

    //            // SQL command to fetch item information based on barcode
    //            string query = $"SELECT Name, Price, Quantity FROM Inventory WHERE Barcode = '{barcode}'";
    //            SqlCommand cmd = new SqlCommand(query, conn);

    //            // Execute SQL command and read the data
    //            SqlDataReader reader = cmd.ExecuteReader();

    //            if (reader.Read())
    //            {
    //                string itemName = reader["Name"].ToString();
    //                int price = int.Parse(reader["Price"].ToString());
    //                int availableQuantity = int.Parse(reader["Quantity"].ToString());

    //                totalPrice = price * quantity;

    //                int newQuantity = availableQuantity + quantity;
    //                if (newQuantity < 0)
    //                {
    //                    MessageBox.Show($"Not enough quantity available for {itemName}");
    //                    reader.Close(); // Close the reader in case of insufficient quantity
    //                    continue;
    //                }

    //                reader.Close(); // Close the reader before executing update command

    //                // Update the database with decreased quantity
    //                string updateQuery = $"UPDATE Inventory SET Quantity = {newQuantity} WHERE Barcode = '{barcode}'";
    //                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
    //                updateCmd.ExecuteNonQuery();



    //                // Generate receipt text
    //                //string receipt = $"{itemName} {quantity} {totalPrice}";
    //                //GenerateReceipt(receipt);

    //                // Remove the sold item from the ListBox after processing all the data
    //                listBox1.Items.Remove(item);
    //            }
    //            else
    //            {
    //                reader.Close();
    //                MessageBox.Show("Item not found");
    //            }
    //        }
    //        DialogResult dialogResult = MessageBox.Show("Do you want to deduct 2% from the total price?", "Deduct 2%", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    //        if (dialogResult == DialogResult.Yes)
    //        {
    //            // Calculate 2% of the total price and deduct it
    //            decimal deduction = totalPrice * 0.02m;
    //            totalPrice -= (int)deduction;
    //        }

    //        string show = $"Item has been returned to the Inventory.";
    //        MessageBox.Show(show,
    //"Return Process Completed",
    //MessageBoxButtons.OK, MessageBoxIcon.Information);

    //        // Create and write to the text file
    //        string filePath = "exchangereceipt.txt";
    //        using (StreamWriter writer = new StreamWriter(filePath))
    //        {
    //            writer.WriteLine($"Price Returned: {totalPrice} PKR");
    //        }


    //        // Uncomment the following line once the Receipt form is created
    //        // OpenReceiptForm();
    //        Exchange2 form3 = new Exchange2();
    //        form3.Show();
    //        this.Hide();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
        }






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Exchange2 form3 = new Exchange2();
            //form3.Show();
            //this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TransactionsPage form3 = new TransactionsPage();
            form3.Show();
            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
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

                    int newQuantity = availableQuantity + quantity;
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
                    //string receipt = $"{itemName} {quantity} {totalPrice}";
                    //GenerateReceipt(receipt);

                    // Remove the sold item from the ListBox after processing all the data
                    listBox1.Items.Remove(item);
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Item not found");
                }
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to deduct 2% from the total price?", "Deduct 2%", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Calculate 2% of the total price and deduct it
                decimal deduction = totalPrice * 0.02m;
                totalPrice -= (int)deduction;
            }

            string show = $"Item has been returned to the Inventory.";
            MessageBox.Show(show,
    "Return Process Completed",
    MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Create and write to the text file
            string filePath = "exchangereceipt.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Price Due: {totalPrice}");
            }


            // Uncomment the following line once the Receipt form is created
            // OpenReceiptForm();
            Exchange2 form3 = new Exchange2();
            form3.Show();
            this.Hide();
        }
    }
}
