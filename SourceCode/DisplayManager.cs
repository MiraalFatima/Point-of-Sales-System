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
    public partial class DisplayManager : Form
    {
        public DisplayManager()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void DisplayManager_Load(object sender, EventArgs e)
        {
            gridbind();
        }
        private void gridbind()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=MAHROSH\SQLEXPRESS01;Initial Catalog=loginpage;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from Inventory", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                conn.Close();
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
