
using System;
using System.Collections.Generic;
using System.Text;
//using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Data;
namespace GenerateReport
{
    class EmployeeClass
    {
        DBconnect connect = new DBconnect();


        /*        public DataTable getEmployees(MySqlCommand command)
                {
                    command.Connection = connect.GetConnection;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }*/

        public DataTable searchEmployee(string searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT `id`, `empid`, `salary`, `employment`, `status`, `hired`, `privilege`, concat(`lastname`, ' ', `firstname`, ' ', `middlename`) as name,  `gender`, `birthday`, `age`, `number`, `address`, `ssscontri`, `sssloan`, `ssscalamity`, `pagibigcontri`, `pagibigloan`, `calamityloan`, `cashadvance`, `cashdedaction`, `others` FROM `employee_tp`) LIKE '%" + searchData + "%'", connect.GetConnection);
            //MySqlCommand command = new MySqlCommand("SELECT `empid`, `StdIdPicture`'ID Picture', `StdNumber`'Student No.', `StdLastName`'Last Name', `StdFirstName`'First Name', `StdMiddleName`'Middle Name', `Sex`,  `ContactNumber`, `SY`, `Sem`, `YearLevel`'Year', `Block`, `Course`, `Status` FROM `student` WHERE CONCAT(`StdLastName`, `StdFirstName`, `StdNumber`, `Course`) LIKE '%" + searchData + "%'", connect.GetConnection);

            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal object getEmptpList2()
        {
            MySqlCommand command = new MySqlCommand("SELECT `empid`'Employee ID No.', CONCAT(`lastname`,', ', `firstname`,' ', `middlename`) as `Fullname` , `semi_monthly`'Semi Monthly Salary', `hours`'Hours', `per_hours`'Per Hours', `total`'Total', `ssscontri_employeer`'Employeer', `ssscontri_employee`'Employee', `semi_netpay`'NetPay' FROM `employee_tp` ORDER BY `semi_netpay` DESC;", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool InsertDept(string dept)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `department`(`department`)" +
                "VALUES (@a1)", connect.GetConnection);
            command.Parameters.Add("@a1", MySqlDbType.VarChar).Value = dept;

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

        public DataTable getdept()
        {
            MySqlCommand command = new MySqlCommand("SELECT `department`'Department' FROM `department`", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }//SELECT ORDER By `id` DESC `empid`'Employee ID No.',`name`'Fullname', `salary`'Salary', `employment`'Status of Employment', `status`'Status', `hired`'Date of Hired', `privilege`'No. of Leave Used',  `gender`'Gender', `birthday`'Birthday', `age`'Ages', `number`'Mobile Number', `address`'Address' 
        //ORDER BY `semi_netpay` DESC;
        internal object getEmpntpList2()
        {
            MySqlCommand command = new MySqlCommand("SELECT `empid`'Employee ID No.', concat(`lastname`,', ', `firstname`,' ', `middlename`) as `Fullname`, `semi_monthly`'Semi Monthly Salary', `sss_employeer`'Employeer', `sss_employee`'Employeer', `pagibig_employeer`'Employeer', `pagibig_employee`'Employee', `philhealth_employeer`'Employeer', `philhealth_employee`'Employee', `others`'Others',`semi_netpay`'NetPay' FROM `employee_ntp` ORDER BY `semi_netpay` DESC;", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getEmptpList()
        {//
            MySqlCommand command = new MySqlCommand("SELECT `empid`'Employee Id No', concat(`lastname`,', ', `firstname`,' ', `middlename`) as 'Fullname', `gender`'Gender', `birthday`'Birthday', `age`'Age', `number`'Number', `address`'Address' FROM `employee_tp` ", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmpntpList()
        {
            MySqlCommand command = new MySqlCommand("SELECT  `empid`'Employee Id No.',concat(`lastname`,', ', `firstname`,' ', `middlename`) as 'Fullname', `gender`'Gender', `birthday`'Birthday', `age`'Ages', `number`'Number', `address`'Address' FROM `employee_ntp`", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //tp is for teaching personnel
        public DataTable getEmptpList1()
        {//_netpay
            //SELECT `empid`'Employee Id No.', `name`'Name', `salary`'Monthly Salary',`salary1`Semi Monthly Salary',`hours`'Hours',`per_hours`'Per Hours',`total`'Total',`ssscontri_employeer`'Employeer', `ssscontri_employee`'Employee', `cashadvance`'Cash Advance', `cashdedaction`'Cash Dedaction', `others`'Others', `signature` FROM `employee_tp
            //SELECT `empid`'ID No.', `name`'Employee Name',`salary`'Monthly Salary', `salary1`'Semi Monthly Salary', `hours`'Hours', `per_hours`'Per Hours', `total`,`ssscontri_employeer`, `ssscontri_employee`, `cashadvance`, `cashdedaction`, `others`, `signature` FROM `employee_tp` test 1 `cashadvance`, `cashdedaction`, `others`,
            MySqlCommand command = new MySqlCommand("SELECT `empid`'Employee ID No.', CONCAT(`lastname`,', ', `firstname`,' ', `middlename`) as `Fullname` , `monthly`'Monthly Salary', `hours`'Hours', `per_hours`'Per Hours', `total`'Total', `ssscontri_employeer`'Employeer', `ssscontri_employee`'Employee', `netpay`'Netpay' FROM `employee_tp` ORDER BY `netpay` DESC;", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //ntp for non teachinh perosnnel
        public DataTable getEmpntpList1()
        {
            MySqlCommand command = new MySqlCommand("SELECT `empid`'Employee ID No.', concat(`lastname`,', ', `firstname`,' ', `middlename`) as `Fullname`, `monthly`'Monthly Salary', `sss_employeer`'Employeer', `sss_employee`'Employeer', `pagibig_employeer`'Employeer', `pagibig_employee`'Employee', `philhealth_employeer`'Employeer', `philhealth_employee`'Employee', `others`'Others',`netpay`'NetPay' FROM `employee_ntp` ORDER BY `netpay` DESC;", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal bool InsertEmployee_ntp(string empid,
                                         decimal salary,
                                         string employment,
                                         string status1,
                                         string privilege,
                                         DateTime hired,
                                         string name,
                                         string gender,
                                         DateTime birthday,
                                         string age,
                                         string number,
                                         string address,
                                         decimal ntpcontri,
                                         decimal ntploan,
                                         decimal cashadvance,
                                         decimal cashdedaction,
                                         decimal others)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_ntp`(`empid`,`salary`,`employment`,`status`,`privilege`,`hired`,`name`,`gender`,`birthday`," +
                "`age`,`number`,`address`,`ntpcontri`,`ntploan`,`cashadvance`,`cashdedaction`,`others`)VALUES (@q,@w,@e,@r,@t,@y,@u,@i,@o,@p,@a,@s,@d,@f,@g,@h,@j)", connect.GetConnection);


            command.Parameters.Add("@q", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@w", MySqlDbType.Decimal).Value = salary;
            command.Parameters.Add("@e", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@r", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@t", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@y", MySqlDbType.Date).Value = hired;
            command.Parameters.Add("@u", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@i", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@o", MySqlDbType.Date).Value = birthday;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@a", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@s", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@d", MySqlDbType.Decimal).Value = ntpcontri;
            command.Parameters.Add("@f", MySqlDbType.Decimal).Value = ntploan;
            command.Parameters.Add("@g", MySqlDbType.Decimal).Value = cashadvance;
            command.Parameters.Add("@h", MySqlDbType.Decimal).Value = cashdedaction;
            command.Parameters.Add("@j", MySqlDbType.Decimal).Value = others;


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

        public bool InsertEmployee_tp11(string empid,
                                          decimal monthly,
                                          decimal semimonthly,
                                          decimal tphour,
                                          decimal tpperhour,
                                          decimal tptotal,
                                          string employment,
                                          string status1,
                                          string privilege,
                                          DateTime hireds,
                                          string lastname,
                                          string firstname,
                                          string middlename,
                                          string gender,
                                          DateTime birthday,
                                          string age,
                                          string number,
                                          string address,
                                          decimal tpsssr,
                                          decimal cashadvance,
                                          decimal cashdedaction,
                                          decimal others,
                                          decimal netpay,
                                          decimal semi_salary)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_tp`(`empid`, `monthly`, `semi_monthly`, `hours`, `per_hours`, `total`, `employment`, `status`, `privilege`, `hired`, `lastname`, `firstname`, `middlename`, `gender`, `birthday`, `age`, `number`, `address`, `ssscontri_employeer`, `cashadvance`, `cashdedaction`, `others`,`netpay`, `semi_netpay`)"
                                        + "VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24)", connect.GetConnection);

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = monthly;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = semimonthly;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = tphour;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = tpperhour;
            command.Parameters.Add("@6", MySqlDbType.VarChar).Value = tptotal;
            command.Parameters.Add("@7", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@8", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@9", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@10", MySqlDbType.Datetime).Value = hireds;
            command.Parameters.Add("@11", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@12", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@13", MySqlDbType.VarChar).Value = middlename;
            command.Parameters.Add("@14", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@15", MySqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@16", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@17", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@18", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@19", MySqlDbType.VarChar).Value = tpsssr;
            command.Parameters.Add("@20", MySqlDbType.VarChar).Value = cashadvance;
            command.Parameters.Add("@21", MySqlDbType.VarChar).Value = cashdedaction;
            command.Parameters.Add("@22", MySqlDbType.VarChar).Value = others;
            command.Parameters.Add("@23", MySqlDbType.VarChar).Value = netpay;
            command.Parameters.Add("@24", MySqlDbType.VarChar).Value = semi_salary;

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

        public bool InsertEmployee_tp22(string empid,
                                        decimal monthly,
                                        decimal semimonthly,
                                        decimal tphour,
                                        decimal tpperhour,
                                        decimal tptotal,
                                        string employment,
                                        string status1,
                                        string privilege,
                                        DateTime hireds,
                                        string lastname,
                                        string firstname,
                                        string middlename,
                                        string gender,
                                        DateTime birthday,
                                        string age,
                                        string number,
                                        string address,
                                        decimal tpsss,
                                        decimal cashadvance,
                                        decimal cashdedaction,
                                        decimal others,
                                        decimal netpay,
                                        decimal seminetpay)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_tp`(`empid`, `monthly`, `semi_monthly`, `hours`, `per_hours`, `total`, `employment`, `status`," +
"`privilege`,`hired`, `lastname`, `firstname`, `middlename`, `gender`, `birthday`, `age`, `number`, `address`, `ssscontri_employee`, `cashadvance`, `cashdedaction`, `others`,`netpay`, `semi_netpay`)"
+ "VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24)", connect.GetConnection);

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = monthly;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = semimonthly;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = tphour;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = tpperhour;
            command.Parameters.Add("@6", MySqlDbType.VarChar).Value = tptotal;
            command.Parameters.Add("@7", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@8", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@9", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@10", MySqlDbType.DateTime).Value = hireds;
            command.Parameters.Add("@11", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@12", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@13", MySqlDbType.VarChar).Value = middlename;
            command.Parameters.Add("@14", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@15", MySqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@16", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@17", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@18", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@19", MySqlDbType.VarChar).Value = tpsss;
            command.Parameters.Add("@20", MySqlDbType.VarChar).Value = cashadvance;
            command.Parameters.Add("@21", MySqlDbType.VarChar).Value = cashdedaction;
            command.Parameters.Add("@22", MySqlDbType.VarChar).Value = others;
            command.Parameters.Add("@23", MySqlDbType.VarChar).Value = netpay;
            command.Parameters.Add("@24", MySqlDbType.VarChar).Value = seminetpay;

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

        public bool InsertEmployee_ntp222(string empid,
                                          decimal monthly,
                                          decimal semimonthly,
                                          string employment,
                                          string status1,
                                          string privilege,
                                          DateTime hireds,
                                          string lastname,
                                          string firstname,
                                          string middlename,
                                          string gender,
                                          DateTime birthday,
                                          string age,
                                          string number,
                                          string address,
                                          decimal ntpsss,
                                          decimal ntppagibig,
                                          decimal ntpphilhealth,
                                          decimal cashadvance,
                                          decimal cashdedaction,
                                          decimal others,
                                          decimal netpay,
                                          decimal seminetpay)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_ntp`(`empid`, `monthly`, `semi_monthly`, `employment`, `status`, `privilege`, `hired`,  `lastname`, `firstname`, `middlename`, `gender`, `birthday`, `age`, `number`, `address`, `sss_employeer`, `pagibig_employeer`, `philhealth_employeer`, `cashadvance`, `cashdedaction`, `others`,`netpay`, `semi_netpay`)VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23)", connect.GetConnection);

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = monthly;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = semimonthly;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@6", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@7", MySqlDbType.DateTime).Value = hireds;
            command.Parameters.Add("@8", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@9", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@10", MySqlDbType.VarChar).Value = middlename;
            command.Parameters.Add("@11", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@12", MySqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@13", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@14", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@15", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@16", MySqlDbType.VarChar).Value = ntpsss;
            command.Parameters.Add("@17", MySqlDbType.VarChar).Value = ntppagibig;
            command.Parameters.Add("@18", MySqlDbType.VarChar).Value = ntpphilhealth;
            command.Parameters.Add("@19", MySqlDbType.VarChar).Value = cashadvance;
            command.Parameters.Add("@20", MySqlDbType.VarChar).Value = cashdedaction;
            command.Parameters.Add("@21", MySqlDbType.VarChar).Value = others;
            command.Parameters.Add("@22", MySqlDbType.VarChar).Value = netpay;
            command.Parameters.Add("@23", MySqlDbType.VarChar).Value = seminetpay;


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

        public bool InsertEmployee_ntp111(string empid, decimal monthly, decimal semimonthly, string employment, string status1, string privilege, DateTime hireds, string lastname, string firstname, string middlename, string gender, DateTime birthday, string age, string number, string address, decimal ntpsssr, decimal ntppagibigr, decimal ntpphilhealthr, decimal cashadvance, decimal cashdedaction, decimal others, decimal netpay, decimal seminetpay)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_ntp`(`empid`, `monthly`, `semi_monthly`, `employment`, `status`,  `privilege`, `hired`, `lastname`, `firstname`, `middlename`, `gender`, `birthday`, `age`, `number`, `address`, `sss_employeer`, `pagibig_employeer`, `philhealth_employeer`, `cashadvance`, `cashdedaction`, `others`,`netpay`, `semi_netpay`)VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23)", connect.GetConnection);

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = monthly;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = semimonthly;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@6", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@7", MySqlDbType.DateTime).Value = hireds;
            command.Parameters.Add("@8", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@9", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@10", MySqlDbType.VarChar).Value = middlename;
            command.Parameters.Add("@11", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@12", MySqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@13", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@14", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@15", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@16", MySqlDbType.VarChar).Value = ntpsssr;
            command.Parameters.Add("@17", MySqlDbType.VarChar).Value = ntppagibigr;
            command.Parameters.Add("@18", MySqlDbType.VarChar).Value = ntpphilhealthr;
            command.Parameters.Add("@19", MySqlDbType.VarChar).Value = cashadvance;
            command.Parameters.Add("@20", MySqlDbType.VarChar).Value = cashdedaction;
            command.Parameters.Add("@21", MySqlDbType.VarChar).Value = others;
            command.Parameters.Add("@22", MySqlDbType.VarChar).Value = netpay;
            command.Parameters.Add("@23", MySqlDbType.VarChar).Value = seminetpay;


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

        public bool InsertEmployee_tp(string empid,
                                        decimal salary,
                                        string employment,
                                        string status1,
                                        string privilege,
                                        DateTime hired,
                                        string name,
                                        string gender,
                                        DateTime birthday,
                                        string age,
                                        string number,
                                        string address,
                                        decimal ssscontri,
                                        decimal sssloan,
                                        decimal ssscalamity,
                                        decimal pagibigcontri,
                                        decimal pagibigloan,
                                        decimal calamityloan,
                                        decimal cashadvance,
                                        decimal cashdedaction,
                                        decimal others)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_tp`(`empid`,`salary`,`employment`,`status`,`privilege`,`hired`,`name`,`gender`,`birthday`," +
                "`age`,`number`,`address`,`ssscontri`,`sssloan`,`ssscalamity`,`pagibigcontri`,`pagibigloan`,`calamityloan`,`cashadvance`,`cashdedaction`,`others`)VALUES (@q,@w,@e,@r,@t,@y,@u,@i,@o,@p,@a,@s,@d,@f,@g,@h,@j,@k,@l,@z,@x)", connect.GetConnection);


            command.Parameters.Add("@q", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@w", MySqlDbType.Decimal).Value = salary;
            command.Parameters.Add("@e", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@r", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@t", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@y", MySqlDbType.Date).Value = hired;
            command.Parameters.Add("@u", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@i", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@o", MySqlDbType.Date).Value = birthday;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@a", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@s", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@d", MySqlDbType.Decimal).Value = ssscontri;
            command.Parameters.Add("@f", MySqlDbType.Decimal).Value = sssloan;
            command.Parameters.Add("@g", MySqlDbType.Decimal).Value = ssscalamity;
            command.Parameters.Add("@h", MySqlDbType.Decimal).Value = pagibigcontri;
            command.Parameters.Add("@j", MySqlDbType.Decimal).Value = pagibigloan;
            command.Parameters.Add("@k", MySqlDbType.Decimal).Value = calamityloan;
            command.Parameters.Add("@l", MySqlDbType.Decimal).Value = cashadvance;
            command.Parameters.Add("@z", MySqlDbType.Decimal).Value = cashdedaction;
            command.Parameters.Add("@x", MySqlDbType.Decimal).Value = others;


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
/*
        public bool InsertEmployee_ntp111(string empid, decimal netpay, decimal semi_salary, string employment, string status1, string privilege, DateTime hireds, string lastname, string firstname, string middlename, string gender, DateTime birthday, string age, string number, string address, decimal ntpsssr, decimal ntppagibigr, decimal ntpphilhealthr, decimal cashadvance, decimal cashdedaction, decimal others)
        {

        }*/
/*
        public bool InsertEmployee_tp11(string empid,
                                        decimal salary,
                                        decimal semi_salary,
                                        decimal tphour,
                                        decimal tpperhour,
                                        decimal tptotal,
                                        string employment,
                                        string status1,
                                        string privilege,
                                        DateTime hireds,
                                        string lastname,
                                        string firstname,
                                        string middlename,
                                        string gender,
                                        DateTime birthday,
                                        string age,
                                        string number,
                                        string address,
                                        decimal tpsssr,
                                        decimal cashadvance,
                                        decimal cashdedaction,
                                        decimal others)
        {

        }*/

        public bool InsertEmployee_ntp222(string empid,
                                          decimal netpay,
                                          decimal semi_salary,
                                          string employment,
                                          string status1,
                                          string privilege,
                                          DateTime hireds,
                                          string lastname,
                                          string firstname,
                                          string middlename,
                                          string gender,
                                          DateTime birthday,
                                          string age,
                                          string number,
                                          string address,
                                          decimal ntpsss,
                                          decimal ntppagibig,
                                          decimal ntpphilhealth,
                                          decimal cashadvance,
                                          decimal cashdedaction,
                                          decimal others)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_ntp`(`empid`, `netpay`, `semi_netpay`, `employment`, `status`, `privilege`,`hired`, `lastname`, `firstname`, `middlename`, `gender`, `birthday`, `age`, `number`, `address`, `sss_employee`, `pagibig_employee`, `philhealth_employee`, `cashadvance`, `cashdedaction`, `others`)VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21)", connect.GetConnection);

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = netpay;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = semi_salary;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@6", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@7", MySqlDbType.DateTime).Value = hireds;
            command.Parameters.Add("@8", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@9", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@10", MySqlDbType.VarChar).Value = middlename;
            command.Parameters.Add("@11", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@12", MySqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@13", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@14", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@15", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@16", MySqlDbType.VarChar).Value = ntpsss;
            command.Parameters.Add("@17", MySqlDbType.VarChar).Value = ntppagibig;
            command.Parameters.Add("@18", MySqlDbType.VarChar).Value = ntpphilhealth;
            command.Parameters.Add("@19", MySqlDbType.VarChar).Value = cashadvance;
            command.Parameters.Add("@20", MySqlDbType.VarChar).Value = cashdedaction;
            command.Parameters.Add("@21", MySqlDbType.VarChar).Value = others;


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
/*
        public bool InsertEmployee_tp22(string empid, decimal salary, decimal semi_salary, decimal tphour, decimal tpperhour, decimal tptotal, string employment, string status1, string privilege, DateTime hireds, string lastname, string firstname, string middlename, string gender, DateTime birthday, string age, string number, string address, decimal tpsss, decimal cashadvance, decimal cashdedaction, decimal others)
        {
            
        }*/

        internal bool InsertEmployee_tp11(string empid, decimal salary, string employment, string status1, string privilege, DateTime hireds, string lastname, string firstname, string middlename, string gender, DateTime birthday, string age, string number, string address, decimal tpsssr, decimal cashadvance, decimal cashdedaction, decimal others, decimal netpay, decimal semi_salary, decimal total)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_tp`(`empid`, `salary`, `salary1`, `employment`, `status`, `privilege`,`hired`, `name`, `gender`, `birthday`, `age`, `number`, `address`, `ssscontri`, `sssloan`, `cashadvance`, `cashdedaction`, `others`)" +
                        "VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17)", connect.GetConnection);

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = salary;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = salary;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@6", MySqlDbType.DateTime).Value = hireds;
            command.Parameters.Add("@7", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@7", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@7", MySqlDbType.VarChar).Value = middlename;
            command.Parameters.Add("@8", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@9", MySqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@10", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@11", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@12", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@13", MySqlDbType.VarChar).Value = tpsssr;
            command.Parameters.Add("@14", MySqlDbType.VarChar).Value = cashadvance;
            command.Parameters.Add("@15", MySqlDbType.VarChar).Value = cashdedaction;
            command.Parameters.Add("@16", MySqlDbType.VarChar).Value = others;
            command.Parameters.Add("@17", MySqlDbType.VarChar).Value = netpay;
            command.Parameters.Add("@18", MySqlDbType.VarChar).Value = semi_salary;
            command.Parameters.Add("@19", MySqlDbType.VarChar).Value = total;

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

/*        internal bool InsertEmployee_ntp1(string empid, decimal salary, string employment, string status1, string privilege, DateTime hireds, string lastname, string firstname, string middlename, string gender, DateTime birthday, string age, string number, string address, decimal tpsss, decimal cashadvance, decimal cashdedaction, decimal others, decimal netpay, decimal seminetpay, decimal total)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_tp`(`empid`, `salary`, `employment`, `status`, `privilege`,`hired`, `name`, `gender`, `birthday`, `age`, `number`, `address`, `ssscontri`, `sssloan`, `cashadvance`, `cashdedaction`, `others`)" +
                        "VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17)", connect.GetConnection);
        }*/


        //INSERT INTO `employee_tp`(`id`, `empid`, `salary`, `employment`, `status`, `hired`, `privilege`, `name`, `gender`, `birthday`, `age`, `number`, `address`, `ntpcontri`, `ntploan`, `cashadvance`, `cashdedaction`, `others`
        public bool InsertEmployee_tp1(string empid,
                                       decimal salary,
                                       string employment,
                                       string status1,
                                       string privilege,
                                       DateTime hireds,
                                       string name,
                                       string gender,
                                       DateTime birthday,
                                       string age,
                                       string number,
                                       string address,
                                       decimal ssscontri,
                                       decimal sssloan,
                                       decimal cashadvance,
                                       decimal cashdedaction,
                                       decimal others)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_tp`(`empid`, `salary`, `employment`, `status`, `privilege`,`hired`, `name`, `gender`, `birthday`, `age`, `number`, `address`, `ssscontri`, `sssloan`, `cashadvance`, `cashdedaction`, `others`)" +
                        "VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17)", connect.GetConnection);
            /*            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = empid;
                        command.Parameters.Add("@2", MySqlDbType.VarChar).Value = salary;
                        command.Parameters.Add("@3", MySqlDbType.VarChar).Value = employment;
                        command.Parameters.Add("@4", MySqlDbType.VarChar).Value = status1;
                        command.Parameters.Add("@5", MySqlDbType.VarChar).Value = hired;
                        command.Parameters.Add("@6", MySqlDbType.VarChar).Value = privilege;
                        command.Parameters.Add("@7", MySqlDbType.VarChar).Value = name;
                        command.Parameters.Add("@8", MySqlDbType.VarChar).Value = gender;
                        command.Parameters.Add("@9", MySqlDbType.VarChar).Value = birthday;
                        command.Parameters.Add("@10", MySqlDbType.VarChar).Value = age;
                        command.Parameters.Add("@11", MySqlDbType.VarChar).Value = number;
                        command.Parameters.Add("@12", MySqlDbType.VarChar).Value = address;
                        command.Parameters.Add("@13", MySqlDbType.VarChar).Value = ntpcontri;
                        command.Parameters.Add("@14", MySqlDbType.VarChar).Value = ntploan;
                        command.Parameters.Add("@15", MySqlDbType.VarChar).Value = cashadvance;
                        command.Parameters.Add("@16", MySqlDbType.VarChar).Value = cashdedaction;
                        command.Parameters.Add("@17", MySqlDbType.VarChar).Value = others;*/

            command.Parameters.Add("@1", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@2", MySqlDbType.VarChar).Value = salary;
            command.Parameters.Add("@3", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@4", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@5", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@6", MySqlDbType.DateTime).Value = hireds;
            command.Parameters.Add("@7", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@8", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@9", MySqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@10", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@11", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@12", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@13", MySqlDbType.VarChar).Value = ssscontri;
            command.Parameters.Add("@14", MySqlDbType.VarChar).Value = sssloan;
            command.Parameters.Add("@15", MySqlDbType.VarChar).Value = cashadvance;
            command.Parameters.Add("@16", MySqlDbType.VarChar).Value = cashdedaction;
            command.Parameters.Add("@17", MySqlDbType.VarChar).Value = others;


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

        public bool InsertEmployee_ntp1(string empid,
                                          decimal salary,
                                          string employment,
                                          string status1,
                                          string privilege,
                                          DateTime hireds,
                                          string name,
                                          string gender,
                                          DateTime birthday,
                                          string age,
                                          string number,
                                          string address,
                                          decimal ssscontri,
                                          decimal sssloan,
                                          decimal ssscalamity,
                                          decimal pagibigcontri,
                                          decimal pagibigloan,
                                          decimal calamityloan,
                                          decimal cashadvance,
                                          decimal cashdedaction,
                                          decimal others)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee_ntp`(`empid`, `salary`, `employment`, `status`,`privilege`, `hired`, `name`, `gender`, `birthday`, `age`, `number`, `address`, `ssscontri`, `sssloan`, `ssscalamity`, `pagibigcontri`, `pagibigloan`, `calamityloan`, `cashadvance`, `cashdedaction`, `others`)" +
                        "VALUES (@q,@w,@e,@r,@t,@y,@u,@i,@o,@p,@a,@s,@d,@f,@g,@h,@j,@k,@l,@z,@x)", connect.GetConnection);
            command.Parameters.Add("@q", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@w", MySqlDbType.VarChar).Value = salary;
            command.Parameters.Add("@e", MySqlDbType.VarChar).Value = employment;
            command.Parameters.Add("@r", MySqlDbType.VarChar).Value = status1;
            command.Parameters.Add("@t", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@y", MySqlDbType.DateTime).Value = hireds;
            command.Parameters.Add("@u", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@i", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@o", MySqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@a", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@s", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@d", MySqlDbType.VarChar).Value = ssscontri;
            command.Parameters.Add("@f", MySqlDbType.VarChar).Value = sssloan;
            command.Parameters.Add("@g", MySqlDbType.VarChar).Value = ssscalamity;
            command.Parameters.Add("@h", MySqlDbType.VarChar).Value = pagibigcontri;
            command.Parameters.Add("@j", MySqlDbType.VarChar).Value = pagibigloan;
            command.Parameters.Add("@k", MySqlDbType.VarChar).Value = calamityloan;
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = cashadvance;
            command.Parameters.Add("@z", MySqlDbType.VarChar).Value = cashdedaction;
            command.Parameters.Add("@x", MySqlDbType.VarChar).Value = others;


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





        /*        internal bool InsertTp(string empid, string ssscontri, string sssloan, string ssscalamity, string pagibigcontri, string pagibigloan, string calamityloan, string cashadvance, string cashdedaction, string others)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `benefits`(`empid`,`name`,`age`,`number`,`birthday`,`gender`,`address`)" +
                        "VALUES (@q,@w,@e,@r,@t,@y,@u,@i,@o,@p)", connect.GetConnection);
                    command.Parameters.Add("@q", MySqlDbType.VarChar).Value = empid;
                    command.Parameters.Add("@w", MySqlDbType.VarChar).Value = ssscontri;
                    command.Parameters.Add("@e", MySqlDbType.VarChar).Value = sssloan;
                    command.Parameters.Add("@r", MySqlDbType.VarChar).Value = ssscalamity;
                    command.Parameters.Add("@t", MySqlDbType.VarChar).Value = pagibigcontri;
                    command.Parameters.Add("@y", MySqlDbType.VarChar).Value = pagibigloan;
                    command.Parameters.Add("@u", MySqlDbType.VarChar).Value = calamityloan;
                    command.Parameters.Add("@i", MySqlDbType.VarChar).Value = cashadvance;
                    command.Parameters.Add("@o", MySqlDbType.VarChar).Value = cashdedaction;
                    command.Parameters.Add("@p", MySqlDbType.VarChar).Value = others;

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

                public bool InsertNtp(string empid, string ntpcontri, string ntploan, string cashadvance, string cashdedaction, string others)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `benefits_ntp`(`empid`,`ssscontri`,`sssloan`,`cashadvance`,`cashdedaction`,`others`)" +
                        "VALUES (@a1,@a2,@a3,@a4,@a5,@a6)", connect.GetConnection);
                    command.Parameters.Add("@a1", MySqlDbType.VarChar).Value = empid;



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
        */




        /*internal bool InsertTp(string empid)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `benefits`(`empid`,`name`,`age`,`number`,`birthday`,`gender`,`address`)" +
                "VALUES (@nq,@nw,@ne,@nr,@nt,@ny,@nu)", connect.GetConnection);


            command.Parameters.Add("@nq", MySqlDbType.VarChar).Value = empid;
*//*            command.Parameters.Add("@nw", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@ne", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@nr", MySqlDbType.VarChar).Value = mobilenumber;
            command.Parameters.Add("@nt", MySqlDbType.Date).Value = birthday;
            command.Parameters.Add("@ny", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@nu", MySqlDbType.VarChar).Value = address;*//*

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
        }*/

        /*        internal bool insertPersonal(string empid, string name, string age, string address, string mobilenumber, DateTime birthday, string gender)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `personal`(`empid`,`name`,`age`,`number`,`birthday`,`gender`,`address`)" +
                        "VALUES (@nq,@nw,@ne,@nr,@nt,@ny,@nu)", connect.GetConnection);


                    command.Parameters.Add("@nq", MySqlDbType.VarChar).Value = empid;
                    command.Parameters.Add("@nw", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@ne", MySqlDbType.VarChar).Value = age;
                    command.Parameters.Add("@nr", MySqlDbType.VarChar).Value = mobilenumber;
                    command.Parameters.Add("@nt", MySqlDbType.Date).Value = birthday;
                    command.Parameters.Add("@ny", MySqlDbType.VarChar).Value = gender;
                    command.Parameters.Add("@nu", MySqlDbType.VarChar).Value = address;

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
                }*/

        /*        public bool InsertEmployee(string empid,
                                             string salary,
                                             string employement,
                                             string status1,
                                             string privilege,
                                             DateTime hired,
                                             string name,
                                             string gender,
                                             DateTime birthday,
                                             string age,
                                             string number,
                                             string address)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `employee`(`empid`,`salary`,`employment`,`status`,`privilege`,`hired`,`name`,`gender`,`birthday`," +
                        "`age`,`number`,`address`)VALUES (@q,@w,@a,@s,@e,@r,@t,@y,@u,@i,@o,@p)", connect.GetConnection);


                    command.Parameters.Add("@q", MySqlDbType.VarChar).Value = empid;
                    command.Parameters.Add("@w", MySqlDbType.VarChar).Value = salary;
                    command.Parameters.Add("@a", MySqlDbType.VarChar).Value = employement;
                    command.Parameters.Add("@s", MySqlDbType.VarChar).Value = status1;
                    command.Parameters.Add("@e", MySqlDbType.VarChar).Value = privilege;
                    command.Parameters.Add("@r", MySqlDbType.Date).Value = hired;
                    command.Parameters.Add("@t", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@y", MySqlDbType.VarChar).Value = gender;
                    command.Parameters.Add("@u", MySqlDbType.Date).Value = birthday;
                    command.Parameters.Add("@i", MySqlDbType.VarChar).Value = age;
                    command.Parameters.Add("@o", MySqlDbType.VarChar).Value = number;
                    command.Parameters.Add("@p", MySqlDbType.VarChar).Value = address;*/

        /*
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

                }*/



        /*        internal bool insertEmployee(string empid, string salary, string privilege, DateTime hired)
                {
                    throw new NotImplementedException();
                }*/

        //Create a function to a new student to the database


        /*                                byte[] avatar
 *                                string email,
                                  string scholarship,
                                  string lname,
                                  string fname,
                                  string mname,
                                  string contact_number,
                                  string sy,
                                  string sem,
                                  string year_level,
                                  string block,
                                  string course,
                                  DateTime date_of_reg,
                                  string civil_status,
                                  string age,
                                  string sex,
                                  DateTime date_of_birth,
                                  string place_of_birth,
                                  string nationality,
                                  string religion,
                                  string home_house_no,
                                  string home_street,
                                  string home_barangay,
                                  string home_town,
                                  string home_city,
                                  string home_zipcode,
                                  string prov_house_no,
                                  string prov_street,
                                  string prov_barangay,
                                  string prov_town,
                                  string prov_city,
                                  string prov_zipcode,

                                  string fathers_surname,
                                  string fathers_Given_Name,
                                  string fathers_Middle_Name,
                                  string fathers_occupation,
                                  string fathers_contact_no,

                                  string mothers_Maiden_Name,
                                  string mothers_Given_Name,
                                  string mothers_Middle_Name,
                                  string mothers_occupation,
                                  string mothers_contact_no,

                                  string guardians_name,
                                  string relationship_to_guardian,
                                  string guardians_occupation,
                                  string guardians_contact_no,
                                  string guardians_house_no,
                                  string guardians_street,
                                  string guardians_barangay,
                                  string guardians_town,
                                  string guardians_city,
                                  string guardians_zipcode,
                                  string financial_support,
                                  string std_nature,
                                  string elem_name,
                                  string elem_address,
                                  string elem_honors,
                                  string elem_sy,
                                  string jh_name,
                                  string jh_address,
                                  string jh_honors,
                                  string jh_sy,
                                  string sh_name,
                                  string sh_address,
                                  string sh_honors,
                                  string sh_sy,
                                  string college_name,
                                  string college_address,
                                  string college_sy,
                                  string vaccine,
                                  string status*/
        /*        public bool insertPersonal(string empid, string name, string ages, string address, DateTime birthday, string mobilenumber, string gender)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO `personal`(`empid`,`name`,`ages`,`mobilenumber`,`birthday`,`gender`,`address`)" +
                        "VALUES (@nq,@nw,@ne,@nr,@nt,@ny,@nu)", connect.GetConnection);


                    command.Parameters.Add("@nq", MySqlDbType.VarChar).Value = empid;
                    command.Parameters.Add("@nw", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@ne", MySqlDbType.VarChar).Value = ages;
                    command.Parameters.Add("@nr", MySqlDbType.VarChar).Value = mobilenumber;
                    command.Parameters.Add("@nt", MySqlDbType.Date).Value = birthday;
                    command.Parameters.Add("@ny", MySqlDbType.VarChar).Value = gender;
                    command.Parameters.Add("@nu", MySqlDbType.VarChar).Value = address;

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
                }*/

        //public bool insertEmployee(string empid, string salary, string employment, DateTime hired1, string status, string privilege, DateTime hired, string age, )
        /*{
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee`(`empid`,`salary`,`privilege`,`hired`)VALUES (@no,@ni,@nu,@ny)", connect.GetConnection);


            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = empid;
            command.Parameters.Add("@ni", MySqlDbType.VarChar).Value = salary;
            command.Parameters.Add("@nu", MySqlDbType.VarChar).Value = privilege;
            command.Parameters.Add("@ny", MySqlDbType.Date).Value = hired;
    
            *//*MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`empid`, `StdNumber`,`StdEmailAdd`, `Scholarship`, `StdLastName`, `StdFirstName`, `StdMiddleName`, `ContactNumber`, `SY`, `Sem`, `YearLevel`, `Block`, `Course`, `DateOfReg`, `CivilStatus`, `Age`, `Sex`, `DateOfBirth`, `PlaceOfBirth`, `Nationality`, `Religion`, `HomeHouseNo`, `HomeStreet`, `HomeBarangay`, `HomeTown`, `HomeCity`, `HomeZipCode`, `ProvHouseNo`, `ProvStreet`, `ProvBarangay`, `ProvTown`, `ProvCity`, `ProvZipCode`, `Fathers_Surname`, `Fathers_Given_Name`, `Fathers_Middle_Name`, `FathersOccupation`, `FathersContactNo`, `Mothers_Maiden_Name`, `Mothers_Given_Name`, `Mothers_Middle_Name`, `MothersOccupation`, `MothersContactNo`, `GuardiansName`, `Relationship_To_Guardian`, `GuardiansOccupation`, `GuardiansContactNo`, `GuardiansHouseNo`, `GuardiansStreet`, `GuardiansBarangay`, `GuardiansTown`, `GuardiansCity`, `GuardiansZipCode`, `FinancialSupport`, `StdNature`, `ElemName`, `ElemAddress`, `ElemHonors`, `ElemSY`, `JhName`, `JhAddress`, `JhHonors`, `JhSY`, `ShName`, `ShAddress`, `ShHonors`, `ShSY`, `CollegeName`, `CollegeAddress`, `CollegeSY`, `Vaccine`, `Status`)VALUES (@idpc,@no,@eml,@schlrshp,@ln,@fn,@mn,@cntctno,@sy,@sm,@ylvl,@blck,@crs,@dor,@ctatus,@ag,@sx,@dob,@pob,@ntnlty,@rlgn,@hhno,@hst,@hbrgy,@htwn,@hcty,@hzpcd,@phno,@pst,@pbrgy,@ptwn,@pcty,@pzpcd,@fathersSurname,@fathersGivenName,@fathersMiddleName,@fthrsoccptn,@fthrscntctn,@mothersMaidenName,@mothersGivenName,@mothersMiddleName,@mthrsoccptn,@mthrscntctno,@grdnsnm,@relationshipToGuardian,@grdnsoccptn,@grdnscntctno,@grdnshsno,@grdnsst,@grdnsbrgy,@grdnstwn,@grdnscty,@grdnszpcd,@fnnclspprt,@stdntr,@elmnm,@elmaddrss,@elmhnrs,@elmsy,@jhnm,@jhaddrss,@jhhnrs,@jhsy,@shmnm,@shaddrss,@shhnrs,@shsy,@cllgnm,@cllgaddrss,@cllgsy,@vaccine,@status)", connect.GetConnection);
*/
        /*
                    command.Parameters.Add("@idpc", MySqlDbType.Blob).Value = id_picture;*/

        /*command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
        command.Parameters.Add("@schlrshp", MySqlDbType.VarChar).Value = scholarship;
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
        command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
        command.Parameters.Add("@cntctno", MySqlDbType.VarChar).Value = contact_number;
        command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
        command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sem;
        command.Parameters.Add("@ylvl", MySqlDbType.VarChar).Value = year_level;
        command.Parameters.Add("@blck", MySqlDbType.VarChar).Value = block;
        command.Parameters.Add("@crs", MySqlDbType.VarChar).Value = course;
        command.Parameters.Add("@dor", MySqlDbType.Date).Value = date_of_reg;
        command.Parameters.Add("@ctatus", MySqlDbType.VarChar).Value = civil_status;
        command.Parameters.Add("@ag", MySqlDbType.VarChar).Value = age;
        command.Parameters.Add("@sx", MySqlDbType.VarChar).Value = sex;
        command.Parameters.Add("@dob", MySqlDbType.Date).Value = date_of_birth;
        command.Parameters.Add("@pob", MySqlDbType.VarChar).Value = place_of_birth;
        command.Parameters.Add("@ntnlty", MySqlDbType.VarChar).Value = nationality;
        command.Parameters.Add("@rlgn", MySqlDbType.VarChar).Value = religion;
        command.Parameters.Add("@hhno", MySqlDbType.VarChar).Value = home_house_no;
        command.Parameters.Add("@hst", MySqlDbType.VarChar).Value = home_street;
        command.Parameters.Add("@hbrgy", MySqlDbType.VarChar).Value = home_barangay;
        command.Parameters.Add("@htwn", MySqlDbType.VarChar).Value = home_town;
        command.Parameters.Add("@hcty", MySqlDbType.VarChar).Value = home_city;
        command.Parameters.Add("@hzpcd", MySqlDbType.VarChar).Value = home_zipcode;
        command.Parameters.Add("@phno", MySqlDbType.VarChar).Value = prov_house_no;
        command.Parameters.Add("@pst", MySqlDbType.VarChar).Value = prov_street;
        command.Parameters.Add("@pbrgy", MySqlDbType.VarChar).Value = prov_barangay;
        command.Parameters.Add("@ptwn", MySqlDbType.VarChar).Value = prov_town;
        command.Parameters.Add("@pcty", MySqlDbType.VarChar).Value = prov_city;
        command.Parameters.Add("@pzpcd", MySqlDbType.VarChar).Value = prov_zipcode;

        command.Parameters.Add("@fathersSurname", MySqlDbType.VarChar).Value = fathers_surname;
        command.Parameters.Add("@fathersGivenName", MySqlDbType.VarChar).Value = fathers_Given_Name;
        command.Parameters.Add("@fathersMiddleName", MySqlDbType.VarChar).Value = fathers_Middle_Name;
        command.Parameters.Add("@fthrsoccptn", MySqlDbType.VarChar).Value = fathers_occupation;
        command.Parameters.Add("@fthrscntctn", MySqlDbType.VarChar).Value = fathers_contact_no;

        command.Parameters.Add("@mothersMaidenName", MySqlDbType.VarChar).Value = mothers_Maiden_Name;
        command.Parameters.Add("@mothersGivenName", MySqlDbType.VarChar).Value = mothers_Given_Name;
        command.Parameters.Add("@mothersMiddleName", MySqlDbType.VarChar).Value = mothers_Middle_Name;
        command.Parameters.Add("@mthrsoccptn", MySqlDbType.VarChar).Value = mothers_occupation;
        command.Parameters.Add("@mthrscntctno", MySqlDbType.VarChar).Value = mothers_contact_no;

        command.Parameters.Add("@grdnsnm", MySqlDbType.VarChar).Value = guardians_name;
        command.Parameters.Add("@relationshipToGuardian", MySqlDbType.VarChar).Value = relationship_to_guardian;
        command.Parameters.Add("@grdnsoccptn", MySqlDbType.VarChar).Value = guardians_occupation;
        command.Parameters.Add("@grdnscntctno", MySqlDbType.VarChar).Value = guardians_contact_no;
        command.Parameters.Add("@grdnshsno", MySqlDbType.VarChar).Value = guardians_house_no;
        command.Parameters.Add("@grdnsst", MySqlDbType.VarChar).Value = guardians_street;
        command.Parameters.Add("@grdnsbrgy", MySqlDbType.VarChar).Value = guardians_barangay;
        command.Parameters.Add("@grdnstwn", MySqlDbType.VarChar).Value = guardians_town;
        command.Parameters.Add("@grdnscty", MySqlDbType.VarChar).Value = guardians_city;
        command.Parameters.Add("@grdnszpcd", MySqlDbType.VarChar).Value = guardians_zipcode;
        command.Parameters.Add("@fnnclspprt", MySqlDbType.VarChar).Value = financial_support;
        command.Parameters.Add("@stdntr", MySqlDbType.VarChar).Value = std_nature;
        command.Parameters.Add("@elmnm", MySqlDbType.VarChar).Value = elem_name;
        command.Parameters.Add("@elmaddrss", MySqlDbType.VarChar).Value = elem_address;
        command.Parameters.Add("@elmhnrs", MySqlDbType.VarChar).Value = elem_honors;
        command.Parameters.Add("@elmsy", MySqlDbType.VarChar).Value = elem_sy;
        command.Parameters.Add("@jhnm", MySqlDbType.VarChar).Value = jh_name;
        command.Parameters.Add("@jhaddrss", MySqlDbType.VarChar).Value = jh_address;
        command.Parameters.Add("@jhhnrs", MySqlDbType.VarChar).Value = jh_honors;
        command.Parameters.Add("@jhsy", MySqlDbType.VarChar).Value = jh_sy;
        command.Parameters.Add("@shmnm", MySqlDbType.VarChar).Value = sh_name;
        command.Parameters.Add("@shaddrss", MySqlDbType.VarChar).Value = sh_address;
        command.Parameters.Add("@shhnrs", MySqlDbType.VarChar).Value = sh_honors;
        command.Parameters.Add("@shsy", MySqlDbType.VarChar).Value = sh_sy;
        command.Parameters.Add("@cllgnm", MySqlDbType.VarChar).Value = college_name;
        command.Parameters.Add("@cllgaddrss", MySqlDbType.VarChar).Value = college_address;
        command.Parameters.Add("@cllgsy", MySqlDbType.VarChar).Value = college_sy;
        command.Parameters.Add("@vaccine", MySqlDbType.VarChar).Value = vaccine;
        command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;*//*

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
    }*/
        //to get student table


        public DataTable getStudentList()
        {
            MySqlCommand command = new MySqlCommand("SELECT `stdId`, `StdIdPicture`'ID Picture', `StdNumber`'Student No.', `StdLastName`'Last Name', `StdFirstName`'First Name', `StdMiddleName`'Middle Name', `Sex`,  `ContactNumber`, `SY`, `Sem`, `YearLevel`'Year', `Block`, `Course`, `Status` FROM `student`", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Create a function to execute the count query(total, male, female, Course, Subject,)
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        // to get the total students
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM `student`");
        }

        // to get the MALE students
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM `student` WHERE `Sex`='Male'");
        }

        // to get the FEMALE students
        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM `student` WHERE `Sex`='Female'");
        }

        // to get the total Courses
        public string totalCourses()
        {
            return exeCount("SELECT COUNT(*) FROM `course`");
        }

        // to get the total Subjects
        public string totalSubjects()
        {
            return exeCount("SELECT COUNT(*) FROM `subjects`");
        }


        //function to search for a student id number name, last name, course
        public DataTable searchStudent(string searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT `id`, `empid`, `salary`, `employment`, `status`, `hired`, `privilege`, `name`, `gender`, `birthday`, `age`, `number`, `address`, `ssscontri`, `sssloan`, `ssscalamity`, `pagibigcontri`, `pagibigloan`, `calamityloan`, `cashadvance`, `cashdedaction`, `others` FROM `employee_tp` WHERE `empid` LIKE '%" + searchData + "%'", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Funtion to edit student data
        public bool updateStudent(int stdId, byte[] id_picture, string std_number, byte[] qrc, string email, string scholarship, string lname, string fname, string mname, string contact_number, string sy, string sem, string year_level, string block, string course, DateTime date_of_reg, string civil_status, string age, string sex, DateTime date_of_birth, string place_of_birth, string nationality, string religion, string home_house_no, string home_street, string home_barangay, string home_town, string home_city, string home_zipcode, string prov_house_no, string prov_street, string prov_barangay, string prov_town, string prov_city, string prov_zipcode, string fathers_name, string fathers_occupation, string fathers_contact_no, string mothers_name, string mothers_occupation, string mothers_contact_no, string guardians_name, string guardians_occupation, string guardians_contact_no, string guardians_house_no, string guardians_street, string guardians_barangay, string guardians_town, string guardians_city, string guardians_zipcode, string financial_support, string std_nature, string elem_name, string elem_address, string elem_honors, string elem_sy, string jh_name, string jh_address, string jh_honors, string jh_sy, string sh_name, string sh_address, string sh_honors, string sh_sy, string college_name, string college_address, string college_sy, string status)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `StdIdPicture`=@idpc, `StdNumber`=@no, `QR_Code`=@qrc, `StdEmailAdd`=@eml,`Scholarship`=@schlrshp,`StdLastName`=@ln,`StdFirstName`=@fn,`StdMiddleName`=@mn,`ContactNumber`=@cntctno,`SY`=@sy,`Sem`=@sm,`YearLevel`=@ylvl,`Block`=@blck,`Course`=@crs,`DateOfReg`=@dor,`CivilStatus`=@ctatus,`Age`=@ag,`Sex`=@sx,`DateOfBirth`=@dob,`PlaceOfBirth`=@pob,`Nationality`=@ntnlty,`Religion`=@rlgn,`HomeHouseNo`=@hhno,`HomeStreet`=@hst,`HomeBarangay`=@hbrgy,`HomeTown`=@htwn,`HomeCity`=@hcty,`HomeZipCode`=@hzpcd,`ProvHouseNo`=@phno,`ProvStreet`=@pst,`ProvBarangay`=@pbrgy,`ProvTown`=@ptwn,`ProvCity`=@pcty,`ProvZipCode`=@pzpcd,`FathersName`=@fthrsnm,`FathersOccupation`=@fthrsoccptn,`FathersContactNo`=@fthrscntctn,`MothersName`=@mthrsnm,`MothersOccupation`=@mthrsoccptn,`MothersContactNo`=@mthrscntctno,`GuardiansName`=@grdnsnm,`GuardiansOccupation`=@grdnsoccptn,`GuardiansContactNo`=@grdnscntctno,`GuardiansHouseNo`=@grdnshsno,`GuardiansStreet`=@grdnsst,`GuardiansBarangay`=@grdnsbrgy,`GuardiansTown`=@grdnstwn,`GuardiansCity`=@grdnscty,`GuardiansZipCode`=@grdnszpcd,`FinancialSupport`=@fnnclspprt,`StdNature`=@stdntr,`ElemName`=@elmnm,`ElemAddress`=@elmaddrss,`ElemHonors`=@elmhnrs,`ElemSY`=@elmsy,`JhName`=@jhnm,`JhAddress`=@jhaddrss,`JhHonors`=@jhhnrs,`JhSY`=@jhsy,`ShName`=@shmnm,`ShAddress`=@shaddrss,`ShHonors`=@shhnrs,`ShSY`=@shsy,`CollegeName`=@cllgnm,`CollegeAddress`=@cllgaddrss,`CollegeSY`=@cllgsy, `Status`=@status WHERE `stdId`=@stdId", connect.GetConnection);

            //command.Parameters.Add("@id", MySqlDbType.Int32).Value = std_id;
            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@idpc", MySqlDbType.Blob).Value = id_picture;
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = std_number;
            command.Parameters.Add("@qrc", MySqlDbType.Blob).Value = qrc;
            command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@schlrshp", MySqlDbType.VarChar).Value = scholarship;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
            command.Parameters.Add("@cntctno", MySqlDbType.VarChar).Value = contact_number;
            command.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sem;
            command.Parameters.Add("@ylvl", MySqlDbType.VarChar).Value = year_level;
            command.Parameters.Add("@blck", MySqlDbType.VarChar).Value = block;
            command.Parameters.Add("@crs", MySqlDbType.VarChar).Value = course;
            command.Parameters.Add("@dor", MySqlDbType.Date).Value = date_of_reg;
            command.Parameters.Add("@ctatus", MySqlDbType.VarChar).Value = civil_status;
            command.Parameters.Add("@ag", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@sx", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@dob", MySqlDbType.Date).Value = date_of_birth;
            command.Parameters.Add("@pob", MySqlDbType.VarChar).Value = place_of_birth;
            command.Parameters.Add("@ntnlty", MySqlDbType.VarChar).Value = nationality;
            command.Parameters.Add("@rlgn", MySqlDbType.VarChar).Value = religion;
            command.Parameters.Add("@hhno", MySqlDbType.VarChar).Value = home_house_no;
            command.Parameters.Add("@hst", MySqlDbType.VarChar).Value = home_street;
            command.Parameters.Add("@hbrgy", MySqlDbType.VarChar).Value = home_barangay;
            command.Parameters.Add("@htwn", MySqlDbType.VarChar).Value = home_town;
            command.Parameters.Add("@hcty", MySqlDbType.VarChar).Value = home_city;
            command.Parameters.Add("@hzpcd", MySqlDbType.VarChar).Value = home_zipcode;
            command.Parameters.Add("@phno", MySqlDbType.VarChar).Value = prov_house_no;
            command.Parameters.Add("@pst", MySqlDbType.VarChar).Value = prov_street;
            command.Parameters.Add("@pbrgy", MySqlDbType.VarChar).Value = prov_barangay;
            command.Parameters.Add("@ptwn", MySqlDbType.VarChar).Value = prov_town;
            command.Parameters.Add("@pcty", MySqlDbType.VarChar).Value = prov_city;
            command.Parameters.Add("@pzpcd", MySqlDbType.VarChar).Value = prov_zipcode;
            command.Parameters.Add("@fthrsnm", MySqlDbType.VarChar).Value = fathers_name;
            command.Parameters.Add("@fthrsoccptn", MySqlDbType.VarChar).Value = fathers_occupation;
            command.Parameters.Add("@fthrscntctn", MySqlDbType.VarChar).Value = fathers_contact_no;
            command.Parameters.Add("@mthrsnm", MySqlDbType.VarChar).Value = mothers_name;
            command.Parameters.Add("@mthrsoccptn", MySqlDbType.VarChar).Value = mothers_occupation;
            command.Parameters.Add("@mthrscntctno", MySqlDbType.VarChar).Value = mothers_contact_no;
            command.Parameters.Add("@grdnsnm", MySqlDbType.VarChar).Value = guardians_name;
            command.Parameters.Add("@grdnsoccptn", MySqlDbType.VarChar).Value = guardians_occupation;
            command.Parameters.Add("@grdnscntctno", MySqlDbType.VarChar).Value = guardians_contact_no;
            command.Parameters.Add("@grdnshsno", MySqlDbType.VarChar).Value = guardians_house_no;
            command.Parameters.Add("@grdnsst", MySqlDbType.VarChar).Value = guardians_street;
            command.Parameters.Add("@grdnsbrgy", MySqlDbType.VarChar).Value = guardians_barangay;
            command.Parameters.Add("@grdnstwn", MySqlDbType.VarChar).Value = guardians_town;
            command.Parameters.Add("@grdnscty", MySqlDbType.VarChar).Value = guardians_city;
            command.Parameters.Add("@grdnszpcd", MySqlDbType.VarChar).Value = guardians_zipcode;
            command.Parameters.Add("@fnnclspprt", MySqlDbType.VarChar).Value = financial_support;
            command.Parameters.Add("@stdntr", MySqlDbType.VarChar).Value = std_nature;
            command.Parameters.Add("@elmnm", MySqlDbType.VarChar).Value = elem_name;
            command.Parameters.Add("@elmaddrss", MySqlDbType.VarChar).Value = elem_address;
            command.Parameters.Add("@elmhnrs", MySqlDbType.VarChar).Value = elem_honors;
            command.Parameters.Add("@elmsy", MySqlDbType.VarChar).Value = elem_sy;
            command.Parameters.Add("@jhnm", MySqlDbType.VarChar).Value = jh_name;
            command.Parameters.Add("@jhaddrss", MySqlDbType.VarChar).Value = jh_address;
            command.Parameters.Add("@jhhnrs", MySqlDbType.VarChar).Value = jh_honors;
            command.Parameters.Add("@jhsy", MySqlDbType.VarChar).Value = jh_sy;
            command.Parameters.Add("@shmnm", MySqlDbType.VarChar).Value = sh_name;
            command.Parameters.Add("@shaddrss", MySqlDbType.VarChar).Value = sh_address;
            command.Parameters.Add("@shhnrs", MySqlDbType.VarChar).Value = sh_honors;
            command.Parameters.Add("@shsy", MySqlDbType.VarChar).Value = sh_sy;
            command.Parameters.Add("@cllgnm", MySqlDbType.VarChar).Value = college_name;
            command.Parameters.Add("@cllgaddrss", MySqlDbType.VarChar).Value = college_address;
            command.Parameters.Add("@cllgsy", MySqlDbType.VarChar).Value = college_sy;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;


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

        //function for anyb command for studentdb
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //create a function to delete student
        public bool deleteStudent(string std_number)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `StdNumber`=@no", connect.GetConnection);

            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = std_number;

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

        public DataTable loadComboBox()
        {
            MySqlCommand command = new MySqlCommand("SELECT `CourseName` FROM `course`", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            table.Columns.Add("CourseName", typeof(string));
            adapter.Fill(table);
            return table;
        }
        public DataTable loaddept()
        {
            MySqlCommand command = new MySqlCommand("SELECT `department` FROM `department`", connect.GetConnection);
            // MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            table.Columns.Add("department", typeof(string));
            adapter.Fill(table);
            return table;
        }
        public bool deleteEmployee(string std_number)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `em` WHERE `StdNumber`=@no", connect.GetConnection);

            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = std_number;
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

    }
}
