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
    public partial class LoginManager : Form
    {
        public LoginManager()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=MAHROSH\SQLEXPRESS01;Initial Catalog=loginpage;Integrated Security=True");
       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String username, password;
            username = textBox1.Text;
            password = textBox2.Text;

            try
            {
                String querry = "SELECT * FROM manager_login WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;

                    //page that needed to be loaded next
                    ManagerInterface form2 = new ManagerInterface();
                    form2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                    //to focus username
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void LoginManager_Load(object sender, EventArgs e)
        {

        }
    }
}
