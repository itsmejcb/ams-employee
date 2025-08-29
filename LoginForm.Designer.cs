
namespace GenerateReport
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedShapes1 = new GenerateReport.RoundedShapes();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_role = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_showPass = new System.Windows.Forms.PictureBox();
            this.albButton_login = new GenerateReport.ALBButton();
            this.customTextBox_password = new GenerateReport.CustomShapes.CustomTextBox();
            this.customTextBox2 = new GenerateReport.CustomShapes.CustomTextBox();
            this.customTextBox_username = new GenerateReport.CustomShapes.CustomTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedShapes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showPass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.roundedShapes1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 504);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(58, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "DR. RUBY LANTING CASAUL EDUCATIONAL \r\nFOUNDATION , INC.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedShapes1
            // 
            this.roundedShapes1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.roundedShapes1.BorderColor = System.Drawing.Color.Turquoise;
            this.roundedShapes1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.roundedShapes1.BorderSize = 0;
            this.roundedShapes1.GradientAngle = 50F;
            this.roundedShapes1.Image = global::GenerateReport.Properties.Resources.logoForLogin3;
            this.roundedShapes1.Location = new System.Drawing.Point(34, 59);
            this.roundedShapes1.Name = "roundedShapes1";
            this.roundedShapes1.Size = new System.Drawing.Size(327, 327);
            this.roundedShapes1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundedShapes1.TabIndex = 11;
            this.roundedShapes1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 10;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "© 2022 - DRLCEFI - AMS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(19)))), ((int)(((byte)(14)))));
            this.label1.Location = new System.Drawing.Point(468, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOGIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(407, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "ACCOUNTING MANAGEMENT SYSTEM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(539, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "For Employees";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_role.ForeColor = System.Drawing.Color.Gray;
            this.label_role.Location = new System.Drawing.Point(490, 32);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(41, 20);
            this.label_role.TabIndex = 10;
            this.label_role.Text = "Role";
            this.label_role.Visible = false;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label_close.ForeColor = System.Drawing.Color.Transparent;
            this.label_close.Location = new System.Drawing.Point(755, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(27, 29);
            this.label_close.TabIndex = 10;
            this.label_close.Text = "x";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GenerateReport.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(672, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox_showPass
            // 
            this.pictureBox_showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_showPass.Image = global::GenerateReport.Properties.Resources.showPass;
            this.pictureBox_showPass.Location = new System.Drawing.Point(672, 275);
            this.pictureBox_showPass.Name = "pictureBox_showPass";
            this.pictureBox_showPass.Size = new System.Drawing.Size(24, 23);
            this.pictureBox_showPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_showPass.TabIndex = 8;
            this.pictureBox_showPass.TabStop = false;
            this.pictureBox_showPass.MouseLeave += new System.EventHandler(this.pictureBox_showPass_MouseLeave);
            this.pictureBox_showPass.MouseHover += new System.EventHandler(this.pictureBox_showPass_MouseHover);
            // 
            // albButton_login
            // 
            this.albButton_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.albButton_login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.albButton_login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.albButton_login.BorderRadius = 5;
            this.albButton_login.BorderSize = 0;
            this.albButton_login.FlatAppearance.BorderSize = 0;
            this.albButton_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albButton_login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.albButton_login.ForeColor = System.Drawing.Color.White;
            this.albButton_login.Location = new System.Drawing.Point(468, 320);
            this.albButton_login.Name = "albButton_login";
            this.albButton_login.Size = new System.Drawing.Size(239, 32);
            this.albButton_login.TabIndex = 9;
            this.albButton_login.Text = "Login";
            this.albButton_login.TextColor = System.Drawing.Color.White;
            this.albButton_login.UseVisualStyleBackColor = false;
            this.albButton_login.Click += new System.EventHandler(this.albButton_login_Click);
            // 
            // customTextBox_password
            // 
            this.customTextBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(140)))));
            this.customTextBox_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customTextBox_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customTextBox_password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customTextBox_password.BorderRadius = 5;
            this.customTextBox_password.BorderSize = 1;
            this.customTextBox_password.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.customTextBox_password.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox_password.Location = new System.Drawing.Point(468, 272);
            this.customTextBox_password.Multiline = false;
            this.customTextBox_password.Name = "customTextBox_password";
            this.customTextBox_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox_password.PasswordChar = true;
            this.customTextBox_password.PlaceholderColor = System.Drawing.Color.Gray;
            this.customTextBox_password.PlaceholderText = "Password";
            this.customTextBox_password.ReadOnly = false;
            this.customTextBox_password.Size = new System.Drawing.Size(239, 36);
            this.customTextBox_password.TabIndex = 7;
            this.customTextBox_password.Texts = "";
            this.customTextBox_password.UnderlinedStyle = true;
            this.customTextBox_password._TextChanged += new System.EventHandler(this.customTextBox_password__TextChanged);
            // 
            // customTextBox2
            // 
            this.customTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(140)))));
            this.customTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customTextBox2.BorderRadius = 5;
            this.customTextBox2.BorderSize = 1;
            this.customTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(484, 25);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.Gray;
            this.customTextBox2.PlaceholderText = "Username";
            this.customTextBox2.ReadOnly = false;
            this.customTextBox2.Size = new System.Drawing.Size(239, 36);
            this.customTextBox2.TabIndex = 7;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = true;
            this.customTextBox2.Visible = false;
            // 
            // customTextBox_username
            // 
            this.customTextBox_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(140)))));
            this.customTextBox_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customTextBox_username.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customTextBox_username.BorderRadius = 5;
            this.customTextBox_username.BorderSize = 1;
            this.customTextBox_username.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.customTextBox_username.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox_username.Location = new System.Drawing.Point(468, 234);
            this.customTextBox_username.Multiline = false;
            this.customTextBox_username.Name = "customTextBox_username";
            this.customTextBox_username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox_username.PasswordChar = false;
            this.customTextBox_username.PlaceholderColor = System.Drawing.Color.Gray;
            this.customTextBox_username.PlaceholderText = "Username";
            this.customTextBox_username.ReadOnly = false;
            this.customTextBox_username.Size = new System.Drawing.Size(239, 36);
            this.customTextBox_username.TabIndex = 7;
            this.customTextBox_username.Texts = "";
            this.customTextBox_username.UnderlinedStyle = true;
            this.customTextBox_username._TextChanged += new System.EventHandler(this.customTextBox_username__TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(784, 504);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albButton_login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox_showPass);
            this.Controls.Add(this.customTextBox_password);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox_username);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedShapes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        //private CustomShapes.RoundedShapes roundedShapes1;
        //private CustomShapes.CustomTextBox textbox_username;
        //private CustomShapes.CustomTextBox textbox_password;
        private CustomShapes.CustomTextBox customTextBox_username;
        private CustomShapes.CustomTextBox customTextBox_password;
        //private CustomShapes.CustomTextBox customTextBox1;
        private System.Windows.Forms.PictureBox pictureBox_showPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private ALBButton albButton_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomShapes.CustomTextBox customTextBox2;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label_close;
        private RoundedShapes roundedShapes1;
    }
}