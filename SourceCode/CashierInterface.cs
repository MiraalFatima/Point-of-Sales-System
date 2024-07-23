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
    public partial class CashierInterface : Form
    {
        public CashierInterface()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sales form3 = new Sales();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DisplayCashier displayCashier = new DisplayCashier();
            displayCashier.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginPage form = new LoginPage();
            form.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TransactionsPage form3 = new TransactionsPage();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Assisstance form = new Assisstance();
            form.Show();
            this.Hide();
        }
    }
}
