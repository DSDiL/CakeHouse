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

namespace CakeHouse
{
    public partial class loginForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=cakeshop;Password=Dilanka000112");
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static string status;

        public loginForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            string passWord = password.Text;
            string roles = role.Text;

            try
            {
                con.Open();
                string query = "SELECT * FROM cakeshop.employees WHERE empName='" + userName + "'";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                if (cmd != null)
                {
                    dt = new DataTable();
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        string uName = dr["empName"].ToString();
                        string pw = dr["password"].ToString();
                        string r = dr["status"].ToString();

                        if (passWord.Equals(pw) && roles.Equals(r))
                        {
                            MessageBox.Show("Login Succesfull");

                            if (r.Equals("Admin"))
                            {
                                View.homeForm home = new View.homeForm();
                                status = r;
                                home.Show();
                                this.Hide();
                            }

                            else
                            {
                                MessageBox.Show("Details are incorrect");
                                username.Text = "";
                                password.Text = "";
                                role.SelectedItem = "";
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

