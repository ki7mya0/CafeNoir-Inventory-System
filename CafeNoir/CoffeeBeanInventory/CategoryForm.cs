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
    public partial class CategoryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SF314-511\SQLEXPRESS;Initial Catalog=CoffeeBeanInventory;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }
        public void LoadCategory()
        {
            int i = 0;
            dgvCategories.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbCategory", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                i++;
                dgvCategories.Rows.Add(i, rdr[0].ToString(), rdr[1].ToString());
            }
            rdr.Close();
            con.Close();
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvCategories.Columns[e.ColumnIndex].Name;
            if (ColName == "Edit")
            {
                CategoryModuleForm categoryModule = new CategoryModuleForm();
                categoryModule.lblcatid.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryModule.txtcatname.Text = dgvCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
                categoryModule.btnSave.Enabled = false;
                categoryModule.btnUpdate.Enabled = true;
                categoryModule.ShowDialog();
            }
            else if (ColName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Reecord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tbCategory WHERE catid LIKE '" + dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted.");
                }

            }
            LoadCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModuleForm moduleForm = new CategoryModuleForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.ShowDialog();
            LoadCategory();
        }
    }
}
