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
    public partial class productForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;persistsecurityinfo=True;database=cakeshop;Password=Dilanka000112");
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        private MySqlCommandBuilder builder;
        public productForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            string ID = id.Text;
            string Name = name.Text;
            string Price = price.Text;
            string Qty = qty.Text;

            try
            {
                if (ID == "-" || ID == "")
                {
                    con.Open();
                    string query = "insert into cakeshop.products values(0, '" + Name + "', '" + Price + "', '" + Qty + "')";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added");
                    con.Close();

                    id.Text = "";
                    name.Text = "";
                    price.Text = "";
                    qty.Text = "";

                    populate();
                }
                else
                {
                    MessageBox.Show("Product is already in the system");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            con.Open();
            string query = "SELECT * from cakeshop.products";
            sda = new MySqlDataAdapter(query, con);
            builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            productTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void productForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ProductTable_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productTable.Rows[e.RowIndex];
                id.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                price.Text = row.Cells[2].Value.ToString();
                qty.Text = row.Cells[3].Value.ToString();
            }
        }

        private void editProductBtn_Click(object sender, EventArgs e)
        {
            string ID = id.Text;
            string Name = name.Text;
            string Price = price.Text;
            string Qty = qty.Text;

            con.Close();

            try
            {
                if (ID != "-" || ID != "")
                {
                    con.Open();
                    string query = "update cakeshop.products set name = '" + Name + "', price = '" + Price + "', qty = '" + Qty + "' where pID = '" + ID + "'";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated");
                    con.Close();

                    id.Text = "";
                    name.Text = "";
                    price.Text = "";
                    qty.Text = "";

                    populate();
                }
                else
                {
                    MessageBox.Show("Product is not in the system");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            string ID = id.Text;

            con.Open();
            string query = "delete from cakeshop.products where pID = '" + ID + "'";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Deleted");
            con.Close();

            id.Text = "";
            name.Text = "";
            price.Text = "";
            qty.Text = "";

            populate();

        }
    }
}
