using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServiceBookingSystem_Eg
{
    public partial class FrmAdminLogin : Form
    {
        DataSet1TableAdapters.AdminInfoTableAdapter adta=new DataSet1TableAdapters.AdminInfoTableAdapter();
        private int logincount = 0;
        public static string adid, adname;
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            FrmMain M = new FrmMain();
            M.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (logincount == 3)
            {
                MessageBox.Show("Login Fail, Reached Limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                FrmMain m = new FrmMain();
                m.Show();
            }
            else if (txtAdminName.Text == "") 
            {
                MessageBox.Show("Please Enter User Name","Admin Login",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtAdminName.Focus();
            }
            else if (txtAdminPW.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAdminPW.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                string UserName, Password;
                UserName = txtAdminName.Text;
                Password = txtAdminPW.Text;
                dt = adta.GetDataBy(UserName, Password);
                if (dt.Rows.Count > 0)
                {
                    adid = dt.Rows[0][0].ToString();
                    adname = dt.Rows[0][1].ToString();
                    MessageBox.Show("Admin Login Successful", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAdminHomePage amp = new FrmAdminHomePage();
                    amp.Show();
                    this.Hide();
                }
                else
                {
                    logincount += 1;
                    MessageBox.Show("Wrong UserName or Wrong Password", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
