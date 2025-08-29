using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace GenerateReport
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }
        EmployeeClass employee = new EmployeeClass();
        DBconnect connect = new DBconnect();



        public void tpm()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = employee.getEmptpList1();
        }

        public void tpsm()
        {
            //TextBox_search.Focus();

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.RowTemplate.Height = 50;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.DataSource = employee.getEmptpList2();
            //  dataGridView1.Columns[12].Visible = false;
            /*DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;*/
            /*dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;*/
            /*dataGridView1.Columns[12].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[13].DefaultCellStyle.WrapMode = DataGridViewTriState.True;*/
        }


        public void ntpm()
        {
            //dataGridView2.Columns[0].Visible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.RowTemplate.Height = 50;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = employee.getEmpntpList1();
            //dataGridView2.Columns[0].Visible = false;
            //dataGridView2.Columns[1].Visible = false;
            /*DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;*/
        }


        public void ntpsm()
        {
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.RowTemplate.Height = 50;
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.DataSource = employee.getEmpntpList2();
            //  dataGridView1.Columns[12].Visible = false;
            /*DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;*/
            /*dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;*/
            /*dataGridView1.Columns[12].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[13].DefaultCellStyle.WrapMode = DataGridViewTriState.True;*/
        }







        private void PayrollForm_Load(object sender, EventArgs e)
        {
            //monthly salary for tp employee
            tpm();
            //semi monthly salary for tp employee
            tpsm();
            //monthly salary for ntp employee
            ntpm();
            //semi monthly salary for ntp employee
            ntpsm();

            
        }

        private void albButton3_Click(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Monthly Income", typeof(string));
            t.Columns.Add("SSS Contribution", typeof(string));
            t.Columns.Add("SSS Loan", typeof(string));
            t.Columns.Add("SSS Calamity", typeof(string));
            t.Columns.Add("Pagibig Contribution", typeof(string));
            t.Columns.Add("Pagibig Loan", typeof(string));
            t.Columns.Add("Calamity Loan", typeof(string));
            t.Columns.Add("Cash Advance", typeof(string));
            t.Columns.Add("Net Pay", typeof(string));

            foreach (DataGridViewRow dgv in dataGridView2.Rows)
            {
                t.Rows.Add(
                    dgv.Cells[0].Value,
                    dgv.Cells[1].Value,
                    dgv.Cells[2].Value,
                    dgv.Cells[3].Value,
                    dgv.Cells[4].Value,
                    dgv.Cells[5].Value,
                    dgv.Cells[6].Value,
                    dgv.Cells[7].Value,
                    dgv.Cells[8].Value,
                    dgv.Cells[9].Value
                    );
            }

            ds.Tables.Add(t);
            ds.WriteXmlSchema("ntps.xml");
            EmpntpprintForms sdtSubReportViewer = new EmpntpprintForms();
            CrystalReport2 cr = new CrystalReport2();/*

            TextObject stdNumber = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text16"];
            *//*stdNumber = dataGridView2.CurrentRow.Cells[0].Value;*//*
            stdNumber.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            //stdNumber.Text = textBox_stdNo.Text;

            TextObject name = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text17"];
            //name.Text = textBox_lname.Text + ", " + textBox_fname.Text + " " + textBox_mname.Text;
            name.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

            TextObject course = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text18"];
            course.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

            TextObject year = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text19"];
            //year.Text = textBox_year.Text;

            year.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

            TextObject address = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text20"];
            //address.Text = textBox_houseNo.Text + " " + textBox_street.Text + " " + textBox_barangay.Text + " " + textBox_town.Text + " " + textBox_city.Text;
            address.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

            TextObject sem = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text21"];
            //sem.Text = comboBox_sem.Text;
            sem.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

            TextObject block = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text22"];
            //block.Text = textBox_block.Text;
            block.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();

            TextObject sy = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text23"];
            //sy.Text = textBox_sy.Text;
            sy.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();

            TextObject contact = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text24"];
            //contact.Text = textBox_contact.Text;
            contact.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();

            TextObject email = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text25"];
            //il.Text = textBox_email.Text;
            email.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
*/
            /*TextObject scholarship = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_scholarship"];
            scholarship.Text = textBox_scholarship.Text;

            TextObject guardian = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_guardian"];
            guardian.Text = textBox_guardian.Text;

            TextObject dateEnrolled = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_dor"];
            dateEnrolled.Text = String.Format("{0:MMMM dd, yyyy}", Convert.ToDateTime(dateTimePicker_dor.Value));

            TextObject sex = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_sex"];
            sex.Text = textBox_sex.Text;

            TextObject dob = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_dob"];
            dob.Text = String.Format("{0:MMMM dd, yyyy}", Convert.ToDateTime(dateTimePicker_dob.Value));

            TextObject age = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_age"];
            age.Text = textBox_age.Text;

            TextObject civilStatus = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_civilStatus"];
            civilStatus.Text = textBox_civilStatus.Text;

            TextObject guardiansContactNo = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_guardiansContactNo"];
            guardiansContactNo.Text = textBox_guardiansContact.Text;

            TextObject totalLecUnits = (TextObject)cr.ReportDefinition.Sections["Section4"].ReportObjects["Text_totalLecUnits"];
            totalLecUnits.Text = textBox_totalLecUnits.Text;

            TextObject totalLabUnits = (TextObject)cr.ReportDefinition.Sections["Section4"].ReportObjects["Text_totalLabUnits"];
            totalLabUnits.Text = textBox_totalLabUnits.Text;

            TextObject totalUnits = (TextObject)cr.ReportDefinition.Sections["Section4"].ReportObjects["Text_totalUnits"];
            totalUnits.Text = textBox_totalUnits.Text;*/

            cr.SetDataSource(ds);
            sdtSubReportViewer.crystalReportViewer1.ReportSource = cr;
            sdtSubReportViewer.crystalReportViewer1.Refresh();
            sdtSubReportViewer.Show();
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void albButton2_Click(object sender, EventArgs e)
        {




            /*DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Monthly Income", typeof(decimal));
            t.Columns.Add("SSS Contribution", typeof(decimal));
            t.Columns.Add("SSS Loan", typeof(decimal));
            t.Columns.Add("SSS Calamity", typeof(decimal));
            t.Columns.Add("Pagibig Contribution", typeof(decimal));
            t.Columns.Add("Pagibig Loan", typeof(decimal));
            t.Columns.Add("Calamity Loan", typeof(decimal));
            t.Columns.Add("Cash Advance", typeof(decimal));
            t.Columns.Add("Net Pay", typeof(decimal));
            foreach (DataGridViewRow dgv in dataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value,
                        dgv.Cells[1].Value,
                        dgv.Cells[2].Value,
                        dgv.Cells[3].Value,
                        dgv.Cells[4].Value,
                        dgv.Cells[5].Value,
                        dgv.Cells[6].Value,
                        dgv.Cells[7].Value,
                        dgv.Cells[8].Value,
                        dgv.Cells[9].Value
                        );
                cr.SetDataSource(ds);
                sdtSubReportViewer.crystalReportViewer1.ReportSource = cr;
                sdtSubReportViewer.crystalReportViewer1.Refresh();
                sdtSubReportViewer.Show();
            }
*/





            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            t.Columns.Add("empid", typeof(string));
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Monthly Income", typeof(string));
            t.Columns.Add("Hours", typeof(string));
            t.Columns.Add("Per Hours", typeof(string));
            t.Columns.Add("Total", typeof(string));
            t.Columns.Add("SSS Contribution for employeer", typeof(string));
            t.Columns.Add("SSS Contribution for employee", typeof(string));
            t.Columns.Add("Net Pay", typeof(string));

            foreach (DataGridViewRow dgv in dataGridView1.Rows)
            {
                t.Rows.Add(
                    dgv.Cells[0].Value,
                    dgv.Cells[1].Value,
                    dgv.Cells[2].Value,
                    dgv.Cells[3].Value,
                    dgv.Cells[4].Value,
                    dgv.Cells[5].Value,
                    dgv.Cells[6].Value,
                    dgv.Cells[7].Value,
                    dgv.Cells[8].Value
                    );
            }

            ds.Tables.Add(t);
            ds.WriteXmlSchema("tpm.xml");

            TpMontlyIncome sdtSubReportViewer = new TpMontlyIncome();
            tpmonthlyincome cr = new tpmonthlyincome();
            cr.SetDataSource(ds);
            sdtSubReportViewer.crystalReportViewer1.ReportSource = cr;
            sdtSubReportViewer.crystalReportViewer1.Refresh();
            sdtSubReportViewer.Show();

            /*ds.Tables.Add(t);
            ds.WriteXmlSchema("stdSubjects.xml");
            ViewrCRTPForm sdtSubReportViewer = new ViewrCRTPForm();
            CrystalReport1 cr = new CrystalReport1();*/

            /*  //CrystalReport1 cr = new CrystalReport1();
              cr.SetDataSource(ds);
              CrystalReport1.ReportSource = cr;*/

            /*TextObject stdNumber = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text1_stdNUmber"];
            stdNumber.Text = textBox_stdNo.Text;

            TextObject name = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_name"];
            name.Text = textBox_lname.Text + ", " + textBox_fname.Text + " " + textBox_mname.Text;

            TextObject course = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_course"];
            course.Text = textBox_course.Text;

            TextObject year = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_yearLevel"];
            year.Text = textBox_year.Text;

            TextObject address = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_address"];
            address.Text = textBox_houseNo.Text + " " + textBox_street.Text + " " + textBox_barangay.Text + " " + textBox_town.Text + " " + textBox_city.Text;

            TextObject sem = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_sem"];
            sem.Text = comboBox_sem.Text;

            TextObject block = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_block"];
            block.Text = textBox_block.Text;

            TextObject sy = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_sy"];
            sy.Text = textBox_sy.Text;

            TextObject contact = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_contactNo"];
            contact.Text = textBox_contact.Text;

            TextObject email = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_email"];
            email.Text = textBox_email.Text;

            TextObject scholarship = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_scholarship"];
            scholarship.Text = textBox_scholarship.Text;

            TextObject guardian = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_guardian"];
            guardian.Text = textBox_guardian.Text;

            TextObject dateEnrolled = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_dor"];
            dateEnrolled.Text = String.Format("{0:MMMM dd, yyyy}", Convert.ToDateTime(dateTimePicker_dor.Value));

            TextObject sex = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_sex"];
            sex.Text = textBox_sex.Text;

            TextObject dob = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_dob"];
            dob.Text = String.Format("{0:MMMM dd, yyyy}", Convert.ToDateTime(dateTimePicker_dob.Value));

            TextObject age = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_age"];
            age.Text = textBox_age.Text;

            TextObject civilStatus = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_civilStatus"];
            civilStatus.Text = textBox_civilStatus.Text;

            TextObject guardiansContactNo = (TextObject)cr.ReportDefinition.Sections["Section2"].ReportObjects["Text_guardiansContactNo"];
            guardiansContactNo.Text = textBox_guardiansContact.Text;

            TextObject totalLecUnits = (TextObject)cr.ReportDefinition.Sections["Section4"].ReportObjects["Text_totalLecUnits"];
            totalLecUnits.Text = textBox_totalLecUnits.Text;

            TextObject totalLabUnits = (TextObject)cr.ReportDefinition.Sections["Section4"].ReportObjects["Text_totalLabUnits"];
            totalLabUnits.Text = textBox_totalLabUnits.Text;

            TextObject totalUnits = (TextObject)cr.ReportDefinition.Sections["Section4"].ReportObjects["Text_totalUnits"];
            totalUnits.Text = textBox_totalUnits.Text;*/
            /*
                        cr.SetDataSource(ds);
                        sdtSubReportViewer.crystalReportViewer1.ReportSource = cr;
                        sdtSubReportViewer.crystalReportViewer1.Refresh();
                        sdtSubReportViewer.Show();*/


            /*


            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Receipt_Number", typeof(Int32));
            dt.Columns.Add("Debit", typeof(Int32));
            dt.Columns.Add("Credit", typeof(Int32));
            dt.Columns.Add("Balance", typeof(Int32));

            foreach (DataGridViewRow dgv in dataGridView2.Rows)
            {
                dt.Rows.Add(
                    dgv.Cells[0].Value,
                    dgv.Cells[1].Value,
                    dgv.Cells[2].Value,
                    dgv.Cells[3].Value,
                    dgv.Cells[4].Value
                    );
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("receipt.xml");
            */



        }

        private void albButton5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            //t.Columns.Add("id", typeof(Int16));
            t.Columns.Add("empid", typeof(string));
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Semi Monthly", typeof(string));
            t.Columns.Add("Hours", typeof(string));
            t.Columns.Add("Per Hours", typeof(string));
            t.Columns.Add("Total", typeof(string));
            t.Columns.Add("SSS Contribution for employeer", typeof(string));
            t.Columns.Add("SSS Contribution for employee", typeof(string));
            /*          t.Columns.Add("SSS Loan for employeer", typeof(string));
                        t.Columns.Add("SSS Loan for employee", typeof(string));*/
            t.Columns.Add("Net Pay", typeof(string));

            foreach (DataGridViewRow dgv in dataGridView3.Rows)
            {
                t.Rows.Add(
                    dgv.Cells[0].Value,
                    dgv.Cells[1].Value,
                    dgv.Cells[2].Value,
                    dgv.Cells[3].Value,
                    dgv.Cells[4].Value,
                    dgv.Cells[5].Value,
                    dgv.Cells[6].Value,
                    dgv.Cells[7].Value,
                    dgv.Cells[8].Value
                    );
            }
            /*                    dgv.Cells[11].Value,
                    dgv.Cells[12].Value*/
            ds.Tables.Add(t);
            ds.WriteXmlSchema("tpsm.xml");


            TpSemiMontlyIncome sdtSubReportViewer = new TpSemiMontlyIncome();
            tpsemimonthlyincomerpt cr = new tpsemimonthlyincomerpt();
            cr.SetDataSource(ds);
            sdtSubReportViewer.crystalReportViewer1.ReportSource = cr;
            sdtSubReportViewer.crystalReportViewer1.Refresh();
            sdtSubReportViewer.Show();


            /*            crystalReportViewer1 sdtSubReportViewer = new crystalReportViewer1();
                        Cachedtpsemimonthlyincomerpt cr = new Cachedtpsemimonthlyincomerpt();

                        cr.SetDataSource(ds);
                        sdtSubReportViewer.crystalReportViewer1.ReportSource = cr;
                        sdtSubReportViewer.crystalReportViewer1.Refresh();
                        sdtSubReportViewer.Show();*/
        }

        private void albButton3_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            t.Columns.Add("empid", typeof(string));
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Monthly", typeof(string));
            t.Columns.Add("SSS for employeer", typeof(string));
            t.Columns.Add("SSS for employee", typeof(string));
            t.Columns.Add("Pagibig for employeer", typeof(string));
            t.Columns.Add("Pagibig for employee", typeof(string));
            t.Columns.Add("Philhealth for employeer", typeof(string));
            t.Columns.Add("Philhealth for employee", typeof(string));
            t.Columns.Add("Others", typeof(string));
            t.Columns.Add("Net Pay", typeof(string));

            foreach (DataGridViewRow dgv in dataGridView2.Rows)
            {
                t.Rows.Add(
                    dgv.Cells[0].Value,
                    dgv.Cells[1].Value,
                    dgv.Cells[2].Value,
                    dgv.Cells[3].Value,
                    dgv.Cells[4].Value,
                    dgv.Cells[5].Value,
                    dgv.Cells[6].Value,
                    dgv.Cells[7].Value,
                    dgv.Cells[8].Value,
                    dgv.Cells[9].Value,
                    dgv.Cells[10].Value
                    );
            }
            ds.Tables.Add(t);
            ds.WriteXmlSchema("ntpm.xml");

            nTpMonthlyIncomes sdtSubReportViewer = new nTpMonthlyIncomes();
            ntpmonthlyincome cr = new ntpmonthlyincome();
            cr.SetDataSource(ds);
            sdtSubReportViewer.crystalReportViewer1.ReportSource = cr;
            sdtSubReportViewer.crystalReportViewer1.Refresh();
            sdtSubReportViewer.Show();

        }

        private void albButton7_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            t.Columns.Add("empid", typeof(string));
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Semi Monthly", typeof(string));
            t.Columns.Add("SSS for employeer", typeof(string));
            t.Columns.Add("SSS for employee", typeof(string));
            t.Columns.Add("Pagibig for employeer", typeof(string));
            t.Columns.Add("Pagibig for employee", typeof(string));
            t.Columns.Add("Philhealth for employeer", typeof(string));
            t.Columns.Add("Philhealth for employee", typeof(string));
            t.Columns.Add("Others", typeof(string));
            t.Columns.Add("Net Pay", typeof(string));

            foreach (DataGridViewRow dgv in dataGridView4.Rows)
            {
                t.Rows.Add(
                    dgv.Cells[0].Value,
                    dgv.Cells[1].Value,
                    dgv.Cells[2].Value,
                    dgv.Cells[3].Value,
                    dgv.Cells[4].Value,
                    dgv.Cells[5].Value,
                    dgv.Cells[6].Value,
                    dgv.Cells[7].Value,
                    dgv.Cells[8].Value,
                    dgv.Cells[9].Value,
                    dgv.Cells[10].Value
                    );
            }
            ds.Tables.Add(t);
            ds.WriteXmlSchema("ntpsm.xml");


            nTpSemiMontlyIncome sdtSubReportViewer = new nTpSemiMontlyIncome();
            ntpsemimonthlyincome cr = new ntpsemimonthlyincome();
            cr.SetDataSource(ds);
            sdtSubReportViewer.crystalReportViewer1.ReportSource = cr;
            sdtSubReportViewer.crystalReportViewer1.Refresh();
            sdtSubReportViewer.Show();
        }
    }
}
