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
    public partial class orderForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=cakeshop;Password=Dilanka000112");
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        private MySqlCommandBuilder builder;

        public orderForm()
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
                string query2 = "SELECT * from cakeshop.orders";
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

        private void orderID()
        {
            con.Open();
            string query = "select orderID from cakeshop.orders order by orderID desc limit 1";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string orderID = dr["orderID"].ToString();
                int ID = int.Parse(orderID);
                orderId.Text = (ID + 1).ToString();
            }
            con.Close();
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            orderID();

            con.Open();
            string query1 = "select name from cakeshop.products";
            cmd = new MySqlCommand(query1, con);
            MySqlDataReader dr1 = cmd.ExecuteReader();

            while (dr1.Read())
            {
                orderItems.Items.Add(dr1["name"]);
            }
            con.Close();

            populate();
        }

        private void orderItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderItem = orderItems.Text;

            con.Close();

            con.Open();
            string query = "select * from cakeshop.products where name = '" + orderItem + "'";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string Price = dr["price"].ToString();
                price.Text = Price;
            }
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            string Qty = qty.Text;
            string Price = price.Text;

            if (Qty.Equals("") || Price.Equals(""))
            {

            }
            else
            {
                try
                {
                    float p = float.Parse(Price);
                    float q = float.Parse(Qty);

                    price.Text = (q * p).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string ID = orderId.Text;
            string Item = orderItems.Text;
            string Qty = qty.Text;
            string Price = price.Text;
            string Total = total.Text;

            int i = int.Parse(ID);

            con.Close();

            con.Open();
            string query = "select orderID from cakeshop.orders order by orderID desc limit 1";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string orderID = dr["orderID"].ToString();
                int Id = int.Parse(orderID);

                if (i == (Id + 1))
                {
                    con.Close();
                    con.Open();

                    try
                    {
                        string query1 = "insert into cakeshop.orderitems values('" + ID + "', '" + Item + "', '" + Qty + "',  '" + Price + "')";
                        cmd = new MySqlCommand(query1, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item Added");

                        float t = float.Parse(Total);
                        float p = float.Parse(Price);

                        total.Text = (t + p).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            con.Close();

            populate();

            orderItems.SelectedItem = null;
            qty.Text = "";
            price.Text = "";
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            string ID = orderId.Text;
            string Name = cusName.Text;
            string Total = total.Text;
            string Date = date.Text;
            
            int i = int.Parse(ID);

            con.Close();

            con.Open();

            string query = "select orderID from cakeshop.orders order by orderID desc limit 1";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string orderID = dr["orderID"].ToString();
                int Id = int.Parse(orderID);

                if (i == (Id + 1))
                {
                    if (Total.Equals("0"))
                    {
                        MessageBox.Show("Total is empty");
                    }
                    else
                    {
                        con.Close();
                        con.Open();

                        try
                        {
                            string query1 = "insert into cakeshop.orders values('" + ID + "', '" + Name + "', '" + Date + "', '" + Total + "',  'Pending')";
                            cmd = new MySqlCommand(query1, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Order Added");

                            cusName.Text = "";
                            total.Text = "";
                            orderId.Text = (i + 1).ToString();
                            date.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            con.Close();

            populate();
        }

        private void ordersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ordersTable.Rows[e.RowIndex];

                orderId.Text = row.Cells[0].Value.ToString();
                cusName.Text = row.Cells[1].Value.ToString();
                date.Text = row.Cells[2].Value.ToString();
                total.Text = row.Cells[3].Value.ToString();
            }

            populate();
        }

        private void orderItemsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = orderItemsTable.Rows[e.RowIndex];

                orderItems.SelectedItem = row.Cells[1].Value.ToString();
                qty.Text = row.Cells[2].Value.ToString();
                price.Text = row.Cells[3].Value.ToString();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            orderItems.SelectedItem = null;
            qty.Text = "";
            price.Text = "";
        }

        private void delOrderBtn_Click(object sender, EventArgs e)
        {
            string ID = orderId.Text;

            con.Open();
            string query = "delete from cakeshop.orders where orderID = '" + ID + "'";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            string query2 = "delete from cakeshop.orderitems where orderID = '" + ID + "'";
            cmd = new MySqlCommand(query2, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("order Deleted");

            orderID();

            populate();

            cusName.Text = "";
            total.Text = "";
            date.Text = "";
            orderItems.SelectedItem = null;
            qty.Text = "";
            price.Text = "";
        }
    }
}
