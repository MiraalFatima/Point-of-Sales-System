using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Assisstance : Form
    {
        public Assisstance()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Assisstance_Load(object sender, EventArgs e)
        {
            // Assuming the file name is hardcoded, replace "example.txt" with your actual file name
            string fileName = "Assisstance.txt";

            try
            {
                // Read the file content
                string fileContent = File.ReadAllText(fileName);

                // Split the content by lines
                string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                // Clear any existing text in the RichTextBox
                richTextBox1.Clear();

                // Loop through the lines and apply formatting to specific lines and first words
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 11 || i == 19) // Lines 1, 2, 12, 20 (remember, arrays are zero-indexed)
                    {
                        // Apply bold formatting to the specific lines
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                        richTextBox1.AppendText(lines[i]); // Append the line
                    }
                    else
                    {
                        // Split the line into words
                        string[] words = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (i == 7 || i == 8 || i == 9) // Lines 8, 9, 10 for first words bold
                        {
                            if (words.Length > 0)
                            {
                                // Apply bold formatting to the first word
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                                richTextBox1.AppendText(words[0]); // Append the first word
                                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular); // Reset font to regular
                                if (words.Length > 1)
                                {
                                    // Append the rest of the words in the line
                                    for (int j = 1; j < words.Length; j++)
                                    {
                                        richTextBox1.AppendText(" " + words[j]);
                                    }
                                }
                            }
                        }
                        else
                        {
                            richTextBox1.AppendText(lines[i]); // Append the line without formatting
                        }
                    }

                    // Append a new line character except for the last line
                    if (i != lines.Length - 1)
                        richTextBox1.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the file: {ex.Message}");
            }
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            CashierInterface form3 = new CashierInterface();
            form3.Show();
            this.Hide();
        }
    }
}
