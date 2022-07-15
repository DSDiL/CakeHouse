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
    public partial class orderHandleForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=cakeshop;Password=Dilanka000112");
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        private MySqlCommandBuilder builder;


        public orderHandleForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            try
            {
                con.Open();
                string query = "SELECT * from cakeshop.orderitems where orderID = '" + orderId.Text + "'";
                sda = new MySqlDataAdapter(query, con);
                builder = new MySqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                orderItemsTable.DataSource = ds.Tables[0];
                con.Close();

                con.Open();
                string query2 = "SELECT * from cakeshop.orders where status = 'Pending'";
                sda = new MySqlDataAdapter(query2, con);
                builder = new MySqlCommandBuilder(sda);
                var ds2 = new DataSet();
                sda.Fill(ds2);
                ordersTable.DataSource = ds2.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderHandleForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ordersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ordersTable.Rows[e.RowIndex];

                orderId.Text = row.Cells[0].Value.ToString();
                orderStatus.SelectedItem = row.Cells[4].Value.ToString();
            }
            populate();
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                string query = "update cakeshop.orders set status = '" + orderStatus.Text + "' where orderID = '" + orderId.Text + "'";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            populate();

            orderId.Text = "";
            orderStatus.SelectedItem = null;
        }
    }
}
