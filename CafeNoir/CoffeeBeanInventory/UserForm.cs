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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SF314-511\SQLEXPRESS;Initial Catalog=CoffeeBeanInventory;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbUser", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
            }
            rdr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.btnSave.Enabled = true;
            userModule.btnUpdate.Enabled = false;
            userModule.ShowDialog();
            LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvUser.Columns[e.ColumnIndex].Name;
            if(ColName == "Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.txtUname.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtFname.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtPass.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtphone.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.txtUname.Enabled = false;
                userModule.ShowDialog();
            } 
            else if(ColName == "delete") 
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Reecord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tbUser WHERE username LIKE '"+ dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() +"'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted.");
                }

            }
            LoadUser();
        }
    }
}
