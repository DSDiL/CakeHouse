using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CakeHouse.View
{
    public partial class employeeForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=cakeshop;Password=Dilanka000112");
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        private MySqlCommandBuilder builder;
        public employeeForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            con.Open();
            string query = "SELECT * from cakeshop.employees";
            sda = new MySqlDataAdapter(query, con);
            builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            employeeTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            string ID = empId.Text;
            string Name = empName.Text;
            string Position = position.Text;
            string Salary = salary.Text;
            string Status = admin.Text;
            string Password = password.Text;

            if (ID == "-" || ID == "")
            {
                if (Password.Equals("Generate"))
                {
                    MessageBox.Show("Generate a valid password");
                }
                else
                {
                    con.Open();
                    string query = "insert into cakeshop.employees values(0, '" + Name + "', '" + Position + "', '" + Salary + "',  '" + Status + "',  '" + Password + "')";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                    con.Close();

                    empId.Text = "";
                    empName.Text = "";
                    position.Text = "";
                    salary.Text = "";
                    admin.SelectedItem = null;
                    password.Text = "Generate";

                    populate();
                }
            }
            else
            {
                MessageBox.Show("Employee is already in the system");
            }
        }

        private void password_Click(object sender, EventArgs e)
        {
            string elements = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder build = new StringBuilder();
            Random rdm = new Random();

            for (int i = 0; i < 8; i++)
            {
                build.Append(elements[rdm.Next(elements.Length)]);
            }

            string PW = build.ToString();

            password.Text = PW;
        }

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employeeTable.Rows[e.RowIndex];

                empId.Text = row.Cells[0].Value.ToString();
                empName.Text = row.Cells[1].Value.ToString();
                position.Text = row.Cells[2].Value.ToString();
                salary.Text = row.Cells[3].Value.ToString();
                admin.SelectedItem = row.Cells[4].Value.ToString();
                password.Text = row.Cells[5].Value.ToString();
            }
        }

        private void editEmpBtn_Click(object sender, EventArgs e)
        {
            string ID = empId.Text;
            string Name = empName.Text;
            string Position = position.Text;
            string Salary = salary.Text;
            string Status = admin.Text;
            string Password = password.Text;

            con.Close();

            try
            {
                if (ID != "-" || ID != "")
                {
                    con.Open();
                    string query = "update cakeshop.employees set empName = '" + Name + "', position = '" + Position + "', salary = '" + Salary + "', status = '" + Status + "', password = '" + Password + "' where empID = '" + ID + "'";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated");
                    con.Close();

                    empId.Text = "";
                    empName.Text = "";
                    position.Text = "";
                    salary.Text = "";
                    admin.SelectedItem = null;
                    password.Text = "Generate";

                    populate();
                }
                else
                {
                    MessageBox.Show("Employee is not in the system");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void deleteEmpBtn_Click_1(object sender, EventArgs e)
        {
            string ID = empId.Text;

            con.Open();
            string query = "delete from cakeshop.employees where empID = '" + ID + "'";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("employee Deleted");
            con.Close();

            empId.Text = "";
            empName.Text = "";
            position.Text = "";
            salary.Text = "";
            admin.SelectedItem = null;
            password.Text = "Generate";

            populate();
        }
    }
}
