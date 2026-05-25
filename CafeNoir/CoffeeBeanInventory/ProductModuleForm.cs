using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeBeanInventory
{
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SF314-511\SQLEXPRESS;Initial Catalog=CoffeeBeanInventory;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        public ProductModuleForm()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtname.Clear();
            txtlevel.Clear();
            txtorigin.Clear();
            txtprice.Clear();
            txtweight.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this coffee bean?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbBeans(name,roastlevel,origin,price,weight)VALUES(@name,@roastlevel,@origin,@price,@weight)", con);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@roastlevel", txtlevel.Text);
                    cmd.Parameters.AddWithValue("@origin", txtorigin.Text);
                    cmd.Parameters.AddWithValue("@price", txtweight.Text);
                    cmd.Parameters.AddWithValue("@weight", txtweight.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Coffee bean has been successfully saved.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this bean?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tbBeans SET name=@name, roastlevel=@roastlevel, price=@price, weight=@weight WHERE pid LIKE '" + lblpid.Text + "'", con);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@roastlevel", txtlevel.Text);
                    cmd.Parameters.AddWithValue("@origin", txtorigin.Text);
                    cmd.Parameters.AddWithValue("@price", txtweight.Text);
                    cmd.Parameters.AddWithValue("@weight", txtweight.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bean has been successfully updated.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
