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
    public partial class UpdateInventory : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MAHROSH\SQLEXPRESS01;Initial Catalog=loginpage;Integrated Security=True");

        public UpdateInventory()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManagerInterface form3 = new ManagerInterface();
            form3.Show();
            this.Hide();
        }

        private void UpdateInventory_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT ID, Name, Quantity, Barcode, Price FROM Inventory", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //delete
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int idToDelete = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["ID"].Value);

                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Inventory WHERE ID=@ID", conn);
                cmd.Parameters.AddWithValue("@ID", idToDelete);
                cmd.ExecuteNonQuery();
                conn.Close();

                dataGridView1.Rows.RemoveAt(selectedIndex); // Remove row from the grid
                MessageBox.Show("Item Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update
            conn.Open();

            for (int item = 0; item < dataGridView1.Rows.Count; item++)
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE Inventory SET Name=@Name, Quantity=@Quantity, Barcode=@Barcode, Price=@Price WHERE ID=@ID", conn);
                cmd2.Parameters.AddWithValue("@Name", dataGridView1.Rows[item].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@Quantity", dataGridView1.Rows[item].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@Barcode", dataGridView1.Rows[item].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@Price", dataGridView1.Rows[item].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@ID", dataGridView1.Rows[item].Cells[0].Value);

                cmd2.ExecuteNonQuery();
            }

            conn.Close();
            MessageBox.Show("Updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a new row for the DataTable
            DataRow newRow = ((DataTable)dataGridView1.DataSource).NewRow();

            // Add the new row to the DataTable
            ((DataTable)dataGridView1.DataSource).Rows.Add(newRow);

            // Refresh the DataGridView to display the new row
            dataGridView1.Refresh();

            // Insert a new row into the database excluding the ID column
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Inventory (Name, Quantity, Barcode, Price) VALUES (@Name, @Quantity, @Barcode, @Price)", conn);
            cmd.Parameters.AddWithValue("@Name", DBNull.Value);
            cmd.Parameters.AddWithValue("@Quantity", DBNull.Value);
            cmd.Parameters.AddWithValue("@Barcode", DBNull.Value);
            cmd.Parameters.AddWithValue("@Price", DBNull.Value);
            cmd.ExecuteNonQuery();
            conn.Close();
        }




    }
}
