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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SF314-511\SQLEXPRESS;Initial Catalog=CoffeeBeanInventory;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
            {
                txtboxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtboxPassword.UseSystemPasswordChar= false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxPassword.Clear();
            txtboxUserName.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtboxUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtboxPassword.Text);
                con.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                if(rdr.HasRows)
                {
                    MessageBox.Show("Welcome"+ rdr["fullname"].ToString()+" | ", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    main.ShowDialog();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
