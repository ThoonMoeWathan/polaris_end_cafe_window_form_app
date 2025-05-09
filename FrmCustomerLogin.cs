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
    public partial class FrmCustomerLogin : Form
    {
        DataSet1TableAdapters.CustomerInfoTableAdapter cus=new DataSet1TableAdapters.CustomerInfoTableAdapter();
        private int logincount=0;
        public static string cusid, cusname, cphonenumber, caddress, cusername, cpassword, cemail;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            FrmMain M = new FrmMain();
            M.Show();
        }
        public FrmCustomerLogin()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCustomer cusentry = new FrmCustomer();
            cusentry.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (logincount == 3)
            {
                MessageBox.Show("Login Fail, Reached Limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                FrmMain m = new FrmMain();
                m.Show();
            }
            else if(txtName.Text=="")
            {
                MessageBox.Show("Please Enter User Name", "Customer Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
            }
            else if (txtPW.Text=="")
            {
                MessageBox.Show("Please Enter Password", "Customer Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPW.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                string UserName, Password;
                UserName=txtName.Text; 
                Password=txtPW.Text;
                dt = cus.GetDataBy(UserName, Password);
                if (dt.Rows.Count > 0)
                {
                    cusid = dt.Rows[0][0].ToString();
                    cusname = dt.Rows[0][1].ToString();
                    cphonenumber = dt.Rows[0][5].ToString();
                    caddress = dt.Rows[0][6].ToString();
                    cusername = dt.Rows[0][2].ToString();
                    cpassword = dt.Rows[0][3].ToString();
                    cemail = dt.Rows[0][4].ToString();
                    MessageBox.Show("Customer Login Successful", "Customer Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmCustomerHomePage CHP = new FrmCustomerHomePage();
                    CHP.Show();
                    this.Hide();
                }
                else
                {
                    logincount += 1;
                    MessageBox.Show("Wrong UserName or Wrong Password", "Customer Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
