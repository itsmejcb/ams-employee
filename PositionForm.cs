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
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        EmployeeClass employee = new EmployeeClass();
        DBconnect connect = new DBconnect();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.DataSource = employee.getdept(); ;
            this.comboBox1.DisplayMember = "Department";
            this.comboBox1.ValueMember = "department";
            this.comboBox1.SelectedIndex = -1;
            //this.comboBox1.AutoCompleteMode = AutoCompleteMode.Append;
            this.comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void albButton3_Click(object sender, EventArgs e)
        {
            if (customTextBox2.Texts == "")
            {
                MessageBox.Show("Need Student ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    string id = customTextBox2.Texts;
                    if (employee.deleteStudent(id))
                    {
                        //to show courses into DGV 

                        //albButton_reset.PerformClick();
                        MessageBox.Show("Department Deleted", "Removed Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //openChildForm(new AllStudents());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ex.Message", "Removed Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connect.closeConnect();
            }
        }
    }
}
