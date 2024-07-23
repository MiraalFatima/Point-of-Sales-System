using WinFormsApp1;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoginManager loginPage = new LoginManager();
            loginPage.Show();
            this.Hide();
        }
    }
}