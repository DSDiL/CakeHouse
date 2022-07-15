using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeHouse.View
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderForm order = new orderForm();
            order.Show();
            this.Hide();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm.status.Equals("Admin"))
            {
                employeeForm employee = new employeeForm();
                employee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not Authorized");
            }
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm.status.Equals("Admin"))
            {
                employeeForm employee = new employeeForm();
                employee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not Authorized");
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm.status.Equals("Admin"))
            {
                employeeForm employee = new employeeForm();
                employee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not Authorized");
            }
        }
    }
}
