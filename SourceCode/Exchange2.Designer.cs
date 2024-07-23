namespace WinFormsApp1
{
    partial class Exchange2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(394, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "TO SALE";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Barcode:";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(157, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 33);
            this.textBox1.TabIndex = 5;
            this.textBox1.UseWaitCursor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(559, 98);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(188, 31);
            this.numericUpDown1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(828, 86);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 49);
            this.button3.TabIndex = 16;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(79, 184);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(769, 304);
            this.listBox1.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(79, 525);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 62);
            this.button4.TabIndex = 18;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(653, 525);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 62);
            this.button1.TabIndex = 19;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exchange2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Exchange2";
            this.Text = "Exchange2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private ListBox listBox1;
        private Button button4;
        private Button button1;
    }
}