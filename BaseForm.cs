using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateReport
{
    public partial class BaseForm : Form
    {
        //StudentClass student = new StudentClass();

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            studentCount();
            CourseCount();
            SubjectCount();
        }

        //Create a function to display student count
        private void studentCount()
        {
            //Display the values
/*            label_totalStd.Text = student.totalStudent();
            label_maleStd.Text = "Male : " + student.maleStudent();
            label_femaleStd.Text = "Female : " + student.femaleStudent();*/
        }

        private void CourseCount()
        {
            //Display the values
/*            label_totalCourses.Text = student.totalCourses();*/
        }

        private void SubjectCount()
        {
            //Display the values
/*            label_totalSubjects.Text = student.totalSubjects();*/
        }

        //To show registration form in main form
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_addSubjects_Click(object sender, EventArgs e)
        {
            openChildForm(new PayrollForm());
            panel1.Visible = false;
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            /*            openChildForm(new PrintForm());*/
            panel1.Visible = true;

        }

        private void button_manageSubjects_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeForm());
            panel1.Visible = false;
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            studentCount();
            CourseCount();
            SubjectCount();
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);

            panel1.Visible = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            this.Hide();
            Login.Show();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label_totalStd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new PositionForm());
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new DepartmentForm());
            panel1.Visible = false;
        }
    }
}
