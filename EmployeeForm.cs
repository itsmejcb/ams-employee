using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MySqlConnector;
using MessagingToolkit.QRCode.Codec;
using GenerateReport.Includes;
using System.Windows.Media.Imaging;

namespace GenerateReport
{
    public partial class EmployeeForm : Form
    {
        
        public EmployeeForm()
        {
            InitializeComponent();

        }
        EmployeeClass employee = new EmployeeClass();
        DBconnect connect = new DBconnect();

        string employmentw;
        string status;
        string stats;
        string genders;


        private void list_Employee()
        {

        }


        private void clear()
        {
            TextBox_empid.Text = "";

        }


        /*private void ntp()
        {
            try
            {


                *//*                if (employee.insertPersonal(empid, name, age, address, number, birthday, gender)
                                {
                                    //Button_clear.PerformClick();
                                    MessageBox.Show("New Student Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }*//*
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connect.closeConnect();
        }*/

        private void dateTimePicker3_BindingContextChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            int  a = dateTimePicker3.Value.Year;
            int b = DateTime.Now.Year;

            int c = b - a;
            string x = c.ToString();
            TextBox_ages.Texts = x;
        }

        public void tp()
        {
            TextBox_search.Focus();

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = employee.getEmptpList();

            /*DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;*/

            //dataGridView1.Columns[0].Visible = false;

            /*dataGridView1.Columns[12].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[13].DefaultCellStyle.WrapMode = DataGridViewTriState.True;*/
        }

        public void ntp()
        {
            TextBox_search.Focus();

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.RowTemplate.Height = 50;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = employee.getEmpntpList();

            /*DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;*/

            dataGridView2.Columns[0].Visible = false;

            /*dataGridView1.Columns[12].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[13].DefaultCellStyle.WrapMode = DataGridViewTriState.True;*/
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            tp();
            ntp();
            customTextBox7.Visible = false;
            TextBox_salary.Visible = false;
            customTextBox2.Visible = false;
            customTextBox4.Visible = false;
            customTextBox3.Visible = false;
            label36.Visible = false;
            label2.Visible = false;
            label39.Visible = false;
            label38.Visible = false;
            label42.Visible = false;
            int zero = 0;
            if (TextBox_salary.Texts.Length == 0 )
            {
                TextBox_salary.Texts = Convert.ToInt32(zero).ToString();
            }

            if (customTextBox2.Texts.Length == 0)
            {
                customTextBox2.Texts = Convert.ToInt32(zero).ToString();
            }

            if (customTextBox4.Texts.Length == 0)
            {
                customTextBox4.Texts = Convert.ToInt32(zero).ToString();
            }

            if (customTextBox3.Texts.Length == 0)
            {
                customTextBox3.Texts = Convert.ToInt32(zero).ToString();
            }


            if (TextBox_privilege.Texts.Length == 0)
            {
                TextBox_privilege.Texts = Convert.ToInt32(zero).ToString();
            }

            if (TextBox_ages.Texts.Length == 0)
            {
                TextBox_ages.Texts = Convert.ToInt32(zero).ToString();
            }

            if (TextBox_number.Texts.Length == 0)
            {
                TextBox_number.Texts = Convert.ToInt32(zero).ToString();
            }

            if (TextBox_tpsss.Texts.Length == 0)
            {
                TextBox_tpsss.Texts = Convert.ToInt32(zero).ToString();
            }

            if (TextBox_ntpsss.Texts.Length == 0)
            {
                TextBox_ntpsss.Texts = Convert.ToInt32(zero).ToString();
            }

            if (TextBox_ntppagibig.Texts.Length == 0)
            {
                TextBox_ntppagibig.Texts = Convert.ToInt32(zero).ToString();
            }

            if (TextBox_ntpphilhealth.Texts.Length == 0)
            {
                TextBox_ntpphilhealth.Texts = Convert.ToInt32(zero).ToString();
            }

            if (TextBox_cashadvance.Texts.Length == 0)
            {
                TextBox_cashadvance.Texts = Convert.ToInt32(zero).ToString();
            }

            if (TextBox_others.Texts.Length == 0)
            {
                TextBox_others.Texts = Convert.ToInt32(zero).ToString();
            }

            if (TextBox_cashdedaction.Texts.Length == 0)
            {
                TextBox_cashdedaction.Texts = Convert.ToInt32(zero).ToString();
            }

            if (customTextBox8.Texts.Length == 0)
            {
                customTextBox8.Texts = Convert.ToInt32(zero).ToString();

            }
            if (customTextBox6.Texts.Length == 0)
            {
                customTextBox6.Texts = Convert.ToInt32(zero).ToString();
            }

            if (customTextBox7.Texts.Length == 0)
            {
                customTextBox7.Texts = Convert.ToInt32(zero).ToString();
            }



        }

        /*private void showData()
        {
            dataGridView1.DataSource = studentGrades.getGrades(new MySqlCommand("SELECT `empid`,`name`,`salary`,`employment`,`status`,`hired` FROM `employee_tp` ORDER BY `empid` DESC"));
            //dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            *//*this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[18].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;*//*
        }*/
        private void pictureBox_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*gif)|*.jpg;*.png;*gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_avatar.Image = Image.FromFile(opf.FileName);
        }




        private void Button_save_Click(object sender, EventArgs e)
        {

            /*MySqlCommand checkRowCommand = new MySqlCommand("SELECT `empid` FROM `employee` WHERE `StdNumber`=@no", connect.GetConnection);
            checkRowCommand.Parameters.Add("@no", MySqlDbType.VarChar).Value = TextBox_empid.Texts;

            connect.openConnect();
            MySqlDataReader dr = checkRowCommand.ExecuteReader();*/
            //add employee 28 numbers
            //switch statement
            
            //for gender
            if (radioButton6.Checked)
            {
                genders = "Male";
            }
            else if(radioButton7.Checked)
            {
                genders = "Female";
            }

            //for status
            if (radioButton9.Checked)
            {
                status = "Teaching Personnel";

            }
            else if(radioButton8.Checked)
            {
                status = "Non-Teaching Personnel";

            }

            //for employeer or employee
            if (radioButton4.Checked)
            {
                stats = "employeer";

            }
            else
            {
                stats = "employee";

            }

            //for employment
            if (radioButton1.Checked)
            {
                employmentw = "Permanent";
            }
            else if (radioButton2.Checked)
            {
                employmentw = "Probationary";
            }
            else if(radioButton3.Checked)
            {
                employmentw = "Contructual";
            }

            //strings
            string empid = TextBox_empid.Texts;
            decimal monthly = Convert.ToDecimal(TextBox_salary.Texts);
            decimal semimonthly = Convert.ToDecimal(customTextBox2.Texts);
/*            decimal salary = Convert.ToDecimal(customTextBox8.Texts);
            decimal semi_salary = Convert.ToDecimal(customTextBox6.Texts);*/

            decimal tphour = Convert.ToDecimal(customTextBox4.Texts);
            decimal tpperhour = Convert.ToDecimal(customTextBox3.Texts);
            decimal tptotal = Convert.ToDecimal(customTextBox7.Texts);

            string employment = employmentw;
            string status1 = status;
            string privilege = TextBox_privilege.Texts;
            DateTime hireds = dateTimePicker1.Value;

            //personnel information
            string firstname = TextBox_firstname.Texts;
            string middlename = TextBox_middlename.Texts;
            string lastname = TextBox_lastname.Texts;
            //string name = TextBox_firstname.Texts+ " " + TextBox_middlename.Texts +" "+ TextBox_lastname.Texts;
            string gender = genders;
            DateTime birthday = dateTimePicker3.Value;
            ///DateTime birthdays = dateTimePicker1.Value;
            string age = TextBox_ages.Texts;
            string number = TextBox_number.Texts;
            string address = TextBox_address.Texts;

            //for non teaching personnel
            /*decimal ntpsss = Convert.ToDecimal(TextBox_ntpsss.Texts);
            decimal ntppagibig = Convert.ToDecimal(TextBox_ntppagibig.Texts);
            decimal ntpphilhealth = Convert.ToDecimal(TextBox_ntpphilhealth.Texts);*/

            //for teaching personnnel
            //decimal tpsss = Convert.ToDecimal(TextBox_tpsss.Texts);

            //for others
            decimal cashadvance = Convert.ToDecimal(TextBox_cashadvance.Texts);
            decimal cashdedaction= Convert.ToDecimal(TextBox_cashdedaction.Texts);
            decimal others = Convert.ToDecimal(TextBox_others.Texts);

            //netpay
            decimal netpay = Convert.ToDecimal(customTextBox8.Texts);
            decimal seminetpay = Convert.ToDecimal(customTextBox6.Texts);
            


            try
            {
                //&& monthly > 0 && semimonthly > 0
                if (empid.Length > 0 && lastname.Length > 0 && firstname.Length > 0 && middlename.Length > 0 && gender.Length > 0 && number.Length > 0 && address.Length > 0)
                {


                    //save for employeer
                    if (stats == "employeer")
                    {

                        if (status == "Teaching Personnel")
                        {
                            //done
                            decimal tpsssr = Convert.ToDecimal(TextBox_tpsss.Texts);
                            if (employee.InsertEmployee_tp11(empid,
                                                             monthly,
                                                             semimonthly,
                                                             tphour,
                                                             tpperhour,
                                                             tptotal,
                                                             employment,
                                                             status1,
                                                             privilege,
                                                             hireds,
                                                             lastname,
                                                             firstname,
                                                             middlename,
                                                             gender,
                                                             birthday,
                                                             age,
                                                             number,
                                                             address,
                                                             tpsssr,
                                                             cashadvance,
                                                             cashdedaction,
                                                             others,
                                                             netpay,
                                                             seminetpay))
                            {
                                MessageBox.Show("New Teaching Employee Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else if (status == "Non-Teaching Personnel")
                        {//not done
                            decimal ntpsssr = Convert.ToDecimal(TextBox_ntpsss.Texts);
                            decimal ntppagibigr = Convert.ToDecimal(TextBox_ntppagibig.Texts);
                            decimal ntpphilhealthr = Convert.ToDecimal(TextBox_ntpphilhealth.Texts);
                            if (employee.InsertEmployee_ntp111(empid,
                                                               monthly,
                                                               semimonthly,
                                                               employment,
                                                               status1,
                                                               privilege,
                                                               hireds,
                                                               lastname,
                                                               firstname,
                                                               middlename,
                                                               gender,
                                                               birthday,
                                                               age,
                                                               number,
                                                               address,
                                                               ntpsssr,
                                                               ntppagibigr,
                                                               ntpphilhealthr,
                                                               cashadvance,
                                                               cashdedaction,
                                                               others,
                                                               netpay,
                                                               seminetpay))
                            {
                                //Button_clear.PerformClick();
                                MessageBox.Show("New Non-Teaching Employee Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                    //save for employee
                    else if (stats == "employee")
                    {
                        if (status == "Teaching Personnel")
                        {//done
                            decimal tpsss = Convert.ToDecimal(TextBox_tpsss.Texts);
                            if (employee.InsertEmployee_tp22(empid,
                                                             monthly,
                                                             semimonthly,
                                                             tphour,
                                                             tpperhour,
                                                             tptotal,
                                                             employment,
                                                             status1,
                                                             privilege,
                                                             hireds,
                                                             lastname,
                                                             firstname,
                                                             middlename,
                                                             gender,
                                                             birthday,
                                                             age,
                                                             number,
                                                             address,
                                                             tpsss,
                                                             cashadvance,
                                                             cashdedaction,
                                                             others,
                                                             netpay,
                                                             seminetpay))

                            {
                                MessageBox.Show("New Teaching Employee Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else if (status == "Non-Teaching Personnel")
                        {//not done
                            decimal ntpsss = Convert.ToDecimal(TextBox_ntpsss.Texts);
                            decimal ntppagibig = Convert.ToDecimal(TextBox_ntppagibig.Texts);
                            decimal ntpphilhealth = Convert.ToDecimal(TextBox_ntpphilhealth.Texts);
                            if (employee.InsertEmployee_ntp222(empid,
                                                               monthly,
                                                               semimonthly,
                                                               employment,
                                                               status1,
                                                               privilege,
                                                               hireds,
                                                               lastname,
                                                               firstname,
                                                               middlename,
                                                               gender,
                                                               birthday,
                                                               age,
                                                               number,
                                                               address,
                                                               ntpsss,
                                                               ntppagibig,
                                                               ntpphilhealth,
                                                               cashadvance,
                                                               cashdedaction,
                                                               others,
                                                               netpay,
                                                               seminetpay))
                            {
                                //Button_clear.PerformClick();
                                MessageBox.Show("New Non-Teaching Employee Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Fillup Employee Information", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
























                //save for employeer or employee
                /*if (radioButton4.Checked)
                {
                    //save for employeer
                    if (status == "Non-Teaching Personnel")
                    {
                        if (stats == "employeer")
                        {
                            if (employee.InsertEmployee_ntp1())
                            {
                                //Button_clear.PerformClick();
                                MessageBox.Show("New Non-Teaching Employee Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else if(stats == "employee")
                        {
                            if (employee.InsertEmployee_ntp1(empid,
                                                         salary,
                                                         employment,
                                                         status1,
                                                         privilege,
                                                         hireds,
                                                         name,
                                                         gender,
                                                         birthday,
                                                         age,
                                                         number,
                                                         address,

                                                         cashadvance,
                                                         cashdedaction,
                                                         others))
                            {
                                //Button_clear.PerformClick();
                                MessageBox.Show("New Non-Teaching Employee Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                    else if (status == "Teaching Personnel")
                    {
                        if (employee.InsertEmployee_tp1(empid, salary, employment, status1, privilege, hireds, name, gender, birthday, age, number, address, ntpcontri, ntploan, cashadvance, cashdedaction, others))
                        {
                            //Button_clear.PerformClick();
                            MessageBox.Show("New Teaching Employee Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else if (radioButton5.Checked)
                {
                    //save for employee


                }*/
                /*                empid,
                                                                         salary,
                                                                         employment,
                                                                         status1,
                                                                         privilege,
                                                                         hireds,
                                                                         lastname,
                                                                         firstname,
                                                                         middlename,
                                                                         gender,
                                                                         birthday,
                                                                         age,
                                                                         number,
                                                                         address,
                                                                         tpsss,
                                                                         cashadvance,
                                                                         cashdedaction,
                                                                         others,
                                                                         netpay,
                                                                         seminetpay,
                                                                         total*/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            

    connect.closeConnect();


            }

        private bool verify()
        {
            if ((TextBox_firstname.Texts == "") || (pictureBox_qrcode.Image == null) ||
                TextBox_lastname.Texts == "")

                return false;
            else
                return true;
        }

        private void TextBox_empid__TextChanged(object sender, EventArgs e)
        {
            string stdQRC = TextBox_empid.Texts;
            QRCodeEncoder enc = new QRCodeEncoder();
            enc.QRCodeScale = 20;
            Bitmap qrcode = enc.Encode(stdQRC);
            pictureBox_qrcode.Image = qrcode as Image;

/*            if (TextBox_empid.Texts == "")
            {
                BitmapImage image = new BitmapImage(new Uri("/;component/Images/down.png", UriKind.Relative));
            }*/
        }

        private void TextBox_privilege__TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_search__TextChanged(object sender, EventArgs e)
        {
            list_Employee();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void albButton1_Click(object sender, EventArgs e)
        {

        }

        private void albButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            //clear();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("empid LIKE '%{0}%' OR ID LIKE '%{0}%'", TextBox_search.Text);

            /*dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = employee.searchEmployee(TextBox_search.Texts);

            *//*DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;*//*

            dataGridView1.Columns[0].Visible = false;*/

            /*    dataGridView1.Columns[12].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.Columns[13].DefaultCellStyle.WrapMode = DataGridViewTriState.True;*/
        }

        private void TextBox_search__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void albButton1_Click_1(object sender, EventArgs e)
        {
            /*dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = employee.searchStudent(customTextBox1.Texts);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[12].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[13].DefaultCellStyle.WrapMode = DataGridViewTriState.True;*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

            panel9.Visible = true;
            label2.Visible = true;
            label36.Visible = true;
            label39.Visible = true;
            label38.Visible = true;
            panel12.Visible = true;
            panel13.Visible = false;
            panel8.Visible = true;
            customTextBox4.Visible = true;
            customTextBox3.Visible = true;
            TextBox_salary.Visible = true;
            customTextBox2.Visible = true;
            TextBox_salary.Enabled = true;
            customTextBox2.Enabled = true;
            customTextBox4.Enabled = true;
            customTextBox3.Enabled = true;
            label42.Visible = true;
            customTextBox7.Visible = true;
            
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            TextBox_salary.Visible = true;
            label36.Visible = true;
            panel9.Visible = true;
            panel12.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            panel13.Visible = true;
            panel8.Visible = true;
            customTextBox4.Visible = false;
            customTextBox3.Visible = false;
            TextBox_salary.Enabled = true;
            customTextBox2.Enabled = true;
            customTextBox4.Enabled = false;
            customTextBox3.Enabled = false;
            label42.Visible = false;
            customTextBox7.Visible = false;
            
        }


        public void cal()
        {
            int monthly_netpay = Convert.ToInt32(TextBox_salary.Texts);
            int semi_monthly_netpay = Convert.ToInt32(customTextBox2.Texts);
            int val1 = Convert.ToInt32(TextBox_tpsss.Texts);
            int val21 = Convert.ToInt32(TextBox_ntpsss.Texts);
            int val22 = Convert.ToInt32(TextBox_ntppagibig.Texts);
            int val23 = Convert.ToInt32(TextBox_ntpphilhealth.Texts);

            /*
                        int monthly_netpay = int.Parse(TextBox_salary.Texts);
                        int semi_monthly_netpay = int.Parse(customTextBox2.Texts);
                        int val1 = int.Parse(TextBox_tpsss.Texts);
                        int val21 = int.Parse(TextBox_ntpsss.Texts);
                        int val22 = int.Parse(TextBox_ntppagibig.Texts);
                        int val23 = int.Parse(TextBox_ntpphilhealth.Texts);*/
            


            int val31 = Convert.ToInt32(TextBox_cashadvance.Texts);
            int val32 = Convert.ToInt32(TextBox_cashdedaction.Texts);
            int val33 = Convert.ToInt32(TextBox_others.Texts);

            /*            int val31 = int.Parse(TextBox_cashadvance.Texts);
                        int val32 = int.Parse(TextBox_cashdedaction.Texts);
                        int val33 = int.Parse(TextBox_others.Texts);*/


            if (radioButton9.Checked)
            {
                //for tp calculation
                if (monthly_netpay > 0 || val1 > 0)
                {
                    int netpay1 = monthly_netpay - val1 - val31 - val32 - val33;
                    customTextBox8.Texts = Convert.ToInt32(netpay1).ToString();



                }
                if (monthly_netpay > 0 || val1 > 0)
                {
                    int netpay2 = semi_monthly_netpay - val1 - val31 - val32 - val33;
                    customTextBox6.Texts = Convert.ToInt32(netpay2).ToString();


                }
            }
            else if (radioButton8.Checked)
            {
                //for ntp calculation
                if (monthly_netpay > 0 || val31 > 0 || val32 > 0 || val33 > 0)
                {
                    int netpay3 = monthly_netpay - val21 - val22 - val23 - val31 - val32 - val33;
                    customTextBox8.Texts = Convert.ToInt32(netpay3).ToString();


                }
                if (semi_monthly_netpay > 0 || val31 > 0 || val32 > 0 || val33 > 0)
                {
                    int netpay4 = semi_monthly_netpay - val21 - val22 - val23 - val31 - val32 - val33;
                    customTextBox6.Texts = Convert.ToInt32(netpay4).ToString();


                }
            }

        }

        private void TextBox_cashadvance__TextChanged(object sender, EventArgs e)
        {
            //cal();
            if (TextBox_cashadvance.Texts.Length == 0)
            {
                TextBox_cashadvance.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void TextBox_others__TextChanged(object sender, EventArgs e)
        {
            //cal();
            if (TextBox_others.Texts.Length == 0)
            {
                TextBox_others.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void TextBox_cashdedaction__TextChanged(object sender, EventArgs e)
        {
            //cal();
            if (TextBox_cashdedaction.Texts.Length == 0)
            {
                TextBox_cashdedaction.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void TextBox_ntpphilhealth__TextChanged(object sender, EventArgs e)
        {
            //cal();
            if (TextBox_ntpphilhealth.Texts.Length == 0)
            {
                TextBox_ntpphilhealth.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void TextBox_ntppagibig__TextChanged(object sender, EventArgs e)
        {
            //cal();
            if (TextBox_ntppagibig.Texts.Length == 0)
            {
                TextBox_ntppagibig.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void TextBox_ntpsss__TextChanged(object sender, EventArgs e)
        {
            //cal();
            if (TextBox_ntpsss.Texts.Length == 0)
            {
                TextBox_ntpsss.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void TextBox_salary__TextChanged(object sender, EventArgs e)
        {
            //cal();
            if (TextBox_salary.Texts.Length == 0)
            {
                TextBox_salary.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {
            //cal();
            if (customTextBox2.Texts.Length == 0)
            {
                customTextBox2.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void TextBox_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            cal();
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_privilege_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void customTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void customTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_ages_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_tpsss_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_ntpsss_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_ntppagibig_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_ntpphilhealth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_cashadvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_others_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_cashdedaction_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void customTextBox4__TextChanged(object sender, EventArgs e)
        {
            if (customTextBox4.Texts.Length == 0)
            {
                customTextBox4.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void customTextBox3__TextChanged(object sender, EventArgs e)
        {
            if (customTextBox3.Texts.Length == 0)
            {
                customTextBox3.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void TextBox_tpsss__TextChanged(object sender, EventArgs e)
        {
            if (TextBox_tpsss.Texts.Length == 0)
            {
                TextBox_tpsss.Texts = "0";
            }
            else
            {

                cal();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public bool deleteDept(string id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `department` WHERE `department`=@no", connect.GetConnection);

            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = id;
            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_empid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBox_salary.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            customTextBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            customTextBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            customTextBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            TextBox_ages.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_number.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_address.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_privilege.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            TextBox_lastname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_firstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_middlename.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBox_firstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_ages.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_number.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_address.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            TextBox_tpsss.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_ntpsss.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_ntppagibig.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_ntpphilhealth.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_cashadvance.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_cashdedaction.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBox_others.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void albButton4_Click(object sender, EventArgs e)
        {
            DateTime Birth = dateTimePicker3.Value;
            DateTime Today = DateTime.Now;

            TimeSpan Span = Today - Birth;

            DateTime Age = DateTime.MinValue + Span;

            // note: MinValue is 1/1/1 so we have to subtract...
            int Years = Age.Year - 1;
/*            int Months = Age.Month - 1;
            int Days = Age.Day - 1;*/
            TextBox_ages.Text = Years.ToString();
            //TextBox_ages.Text = Years.ToString() + " Years, " + Months.ToString() + " Months, " + Days.ToString() + " Days";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //comments
        /*switch (x)
{
    case 1:
        // code block
        if(employee.InsertTp(empid, ssscontri, sssloan, ssscalamity, pagibigcontri, pagibigloan, calamityloan, cashadvance, cashdedaction, others))
        {

        }
        connect.closeConnect();

        break;
    case 2:
        // code block
        if(employee.InsertNtp(empid, ntpcontri, ntploan, cashadvance, cashdedaction, others))
        {

        }
        connect.closeConnect();
        break;
    default:
        // code block
        break;
}*/
        //to get the picture from pcturebox
        /*MemoryStream ms = new MemoryStream();
        pictureBox_avatar.Image.Save(ms, pictureBox_avatar.Image.RawFormat);
        byte[] id_picture = ms.ToArray();*/
        /*                if (employee.InsertEmployee( empid, salary, employment, status1, privilege, hired, name, gender, birthday, age, number, address ))
                        {
                            //Button_clear.PerformClick();
                            MessageBox.Show("New Employee Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }*/




        /*                if (employee.insertPersonal(empid, name, age, address, number, birthday, gender)
                        {
                            //Button_clear.PerformClick();
                            MessageBox.Show("New Student Added", "Add Employess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }*/
    }
}
