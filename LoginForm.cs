using MySqlConnector;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GenerateReport
{
    public partial class LoginForm : Form
    {
        EmployeeClass employee = new EmployeeClass();

        //To make the form draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //To Make a rounded Corner form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox_username__TextChanged(object sender, EventArgs e)
        {
            customTextBox_username.BorderSize = 2;
            customTextBox_password.BorderSize = 1;
        }

        private void customTextBox_password__TextChanged(object sender, EventArgs e)
        {
            customTextBox_password.BorderSize = 2;
            customTextBox_username.BorderSize = 1;
        }

        private void pictureBox_showPass_MouseHover(object sender, EventArgs e)
        {
            customTextBox_password.PasswordChar = false;
        }

        private void pictureBox_showPass_MouseLeave(object sender, EventArgs e)
        {
            customTextBox_password.PasswordChar = true;
        }

        private void albComboBox_role_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            label_role.Visible = false;
        }

        private void albButton_login_Click(object sender, EventArgs e)
        {
            if (customTextBox_username.Texts == "" || customTextBox_password.Texts == "")
            {
                MessageBox.Show("Empty Field", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string username = customTextBox_username.Texts;
            string password = customTextBox_password.Texts;

            DataTable table = employee.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + username + "' AND `password`= '" + password + "'"));
            if (table.Rows.Count > 0)
            {
                //if (role = "Admin")
                //{
                BaseForm main = new BaseForm();
                this.Hide();
                main.Show();
                //}
            }
            else
            {
                MessageBox.Show("Either username or password is not correct", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = System.Drawing.Color.Maroon;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = System.Drawing.Color.Transparent;
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }

}
