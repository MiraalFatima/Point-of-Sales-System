namespace WinFormsApp1
{
    partial class Assisstance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(10, 13);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(917, 498);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(328, 522);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 62);
            this.button4.TabIndex = 10;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Assisstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 600);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Assisstance";
            this.Text = "Assisstance";
            this.Load += new System.EventHandler(this.Assisstance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button4;
    }
}