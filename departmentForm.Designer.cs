
namespace GenerateReport
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.albButton3 = new GenerateReport.ALBButton();
            this.albButton1 = new GenerateReport.ALBButton();
            this.label1 = new System.Windows.Forms.Label();
            this.customTextBox1 = new GenerateReport.CustomShapes.CustomTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 680);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.albButton3);
            this.panel1.Controls.Add(this.albButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.customTextBox1);
            this.panel1.Location = new System.Drawing.Point(6, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 167);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // albButton3
            // 
            this.albButton3.BackColor = System.Drawing.Color.White;
            this.albButton3.BackgroundColor = System.Drawing.Color.White;
            this.albButton3.BorderColor = System.Drawing.Color.Maroon;
            this.albButton3.BorderRadius = 8;
            this.albButton3.BorderSize = 2;
            this.albButton3.FlatAppearance.BorderSize = 0;
            this.albButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albButton3.ForeColor = System.Drawing.Color.Maroon;
            this.albButton3.Location = new System.Drawing.Point(18, 109);
            this.albButton3.Name = "albButton3";
            this.albButton3.Size = new System.Drawing.Size(300, 40);
            this.albButton3.TabIndex = 5;
            this.albButton3.Text = "DELETE";
            this.albButton3.TextColor = System.Drawing.Color.Maroon;
            this.albButton3.UseVisualStyleBackColor = false;
            this.albButton3.Click += new System.EventHandler(this.albButton3_Click);
            // 
            // albButton1
            // 
            this.albButton1.BackColor = System.Drawing.Color.Maroon;
            this.albButton1.BackgroundColor = System.Drawing.Color.Maroon;
            this.albButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.albButton1.BorderRadius = 8;
            this.albButton1.BorderSize = 0;
            this.albButton1.FlatAppearance.BorderSize = 0;
            this.albButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albButton1.ForeColor = System.Drawing.Color.White;
            this.albButton1.Location = new System.Drawing.Point(18, 63);
            this.albButton1.Name = "albButton1";
            this.albButton1.Size = new System.Drawing.Size(300, 40);
            this.albButton1.TabIndex = 3;
            this.albButton1.Text = "SAVE";
            this.albButton1.TextColor = System.Drawing.Color.White;
            this.albButton1.UseVisualStyleBackColor = false;
            this.albButton1.Click += new System.EventHandler(this.albButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department";
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.Black;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.Maroon;
            this.customTextBox1.BorderRadius = 8;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(18, 21);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.ReadOnly = false;
            this.customTextBox1.Size = new System.Drawing.Size(300, 36);
            this.customTextBox1.TabIndex = 0;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(356, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 706);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(757, 26);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 706);
            this.panel2.TabIndex = 5;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1113, 706);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepartmentForm";
            this.Text = "Add Department";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private ALBButton albButton3;
        private ALBButton albButton1;
        private System.Windows.Forms.Label label1;
        private CustomShapes.CustomTextBox customTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}