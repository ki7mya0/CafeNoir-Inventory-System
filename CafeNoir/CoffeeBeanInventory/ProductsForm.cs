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
    public partial class ProductsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SF314-511\SQLEXPRESS;Initial Catalog=CoffeeBeanInventory;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        public ProductsForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void dgvBeans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvBeans.Columns[e.ColumnIndex].Name;
            if (ColName == "Edit")
            {
                ProductModuleForm productModule = new ProductModuleForm();
                productModule.txtname.Text = dgvBeans.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.txtlevel.Text = dgvBeans.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.txtorigin.Text = dgvBeans.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.txtprice.Text = dgvBeans.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.txtweight.Text = dgvBeans.Rows[e.RowIndex].Cells[5].Value.ToString();


                productModule.btnSave.Enabled = false;
                productModule.btnUpdate.Enabled = true;
                productModule.txtname.Enabled = false;
                productModule.ShowDialog();
            }
            else if (ColName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this bean?", "Delete Reecord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tbBeans WHERE pid LIKE '" + dgvBeans.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted.");
                }

            }
            LoadProduct();
        }
        public void LoadProduct()
        {
            int i = 0;
            dgvBeans.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbBeans", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                i++;
                dgvBeans.Rows.Add(i, rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
            }
            rdr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModuleForm productModule = new ProductModuleForm();
            productModule.btnSave.Enabled = true;
            productModule.btnUpdate.Enabled = false;
            productModule.ShowDialog();
            LoadProduct();
        }
    }
}
