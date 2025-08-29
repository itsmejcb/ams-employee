using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace GenerateReport
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }
        EmployeeClass employee = new EmployeeClass();
        DBconnect connect = new DBconnect();
        string id;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void albButton1_Click(object sender, EventArgs e)
        {
            string dept = customTextBox1.Texts;
            try
            {
                if (employee.InsertDept(dept))
                {
                    //Button_clear.PerformClick();
                    MessageBox.Show("New Department Added", "Add Department", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            connect.closeConnect();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

            show();
            //this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            /*dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = employee.getdept();*/
        }

        public void show()
        {
            dataGridView1.DataSource = getCourse(new MySqlCommand("SELECT * FROM `department`"));
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public DataTable getCourse(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void albButton3_Click(object sender, EventArgs e)
        {
            if (customTextBox1.Texts == "")
            {
                MessageBox.Show("Need Student ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    string ids = id;
                    if (deleteStudent(ids))
                    {
                        //to show courses into DGV 

                        //albButton_reset.PerformClick();
                        MessageBox.Show("Department Deleted", "Removed Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        show();
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

        public bool deleteStudent(string ids)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `department` WHERE `id`=@no", connect.GetConnection);

            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = ids;

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            customTextBox1.Texts = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
