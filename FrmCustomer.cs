using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ServiceBookingSystem_Eg
{
    public partial class FrmCustomer : Form
    {
        DataSet1TableAdapters.CustomerInfoTableAdapter cu = new DataSet1TableAdapters.CustomerInfoTableAdapter();
        public FrmCustomer()
        {
            InitializeComponent();
        }
        public void AutoCustomerID()
        {
            DataTable dt = new DataTable();
            dt = cu.GetData();
            if (dt.Rows.Count == 0)
            {
                lblShowID.Text = "C_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid =Convert.ToInt32(oldid.Substring(2,3));
                if (newid >= 1 && newid < 9)
                {
                    lblShowID.Text = "C_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblShowID.Text = "C_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblShowID.Text = "C_" + (newid + 1);
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var EmailRule = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            var PasswordRule = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            var PhoneRule = new Regex(@"[0-9]{2}[0-9]{9}$");
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Invalid Name Characters. Please try again.", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtCustomerUserName.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerUserName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCustomerUserName.Text))
            {
                MessageBox.Show("Invalid User Name Characters. Please try again.", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtCustomerPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerPassword.Focus();
            }
            else if (!PasswordRule.IsMatch(txtCustomerPassword.Text))
            {
                MessageBox.Show("At least one uppercase letter and one lowercase letter, numbers, and numeric special characters (@,#,$,%) must be included in the password. Please try again.", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtCustomerEmailAdds.Text == "")
            {
                MessageBox.Show("Please Enter Email Address", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerEmailAdds.Focus();
            }
            else if (!EmailRule.IsMatch(txtCustomerEmailAdds.Text))
            {
                MessageBox.Show("Invalid Email Fomat. Please try again.", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtCustomerPhoneNumber.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerPhoneNumber.Focus();
            }
            else if (!PhoneRule.IsMatch(txtCustomerPhoneNumber.Text))
            {
                MessageBox.Show("Invalid Phone Number. The phone number must have 11 digits. Please try again.", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtCustomerAdds.Text == "")
            {
                MessageBox.Show("Please Enter Address", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerAdds.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCustomerAdds.Text))
            {
                MessageBox.Show("Invalid Address. Please try again.", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                clsCustomer cus = new clsCustomer();
                cus.CustrID = lblShowID.Text;
                cus.CustrName = txtCustomerName.Text;
                cus.UName = txtCustomerUserName.Text;
                cus.PW = txtCustomerPassword.Text;
                cus.Email = txtCustomerEmailAdds.Text;
                cus.Phone = txtCustomerPhoneNumber.Text;
                cus.address = txtCustomerAdds.Text;
                int data;
                data = cu.Insert(cus.CustrID, cus.CustrName, cus.UName, cus.PW, cus.Email, cus.Phone, cus.address);
                if (data > 0)
                {
                    MessageBox.Show("Customer Info has been saved Successfully", "Customer Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmCustomerLogin c = new FrmCustomerLogin();
                c.Show();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            FrmCustomerLogin cl = new FrmCustomerLogin();
            cl.Show();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            AutoCustomerID();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtCustomerUserName.Text = "";
            txtCustomerPassword.Text = "";
            txtCustomerEmailAdds.Text = "";
            txtCustomerPhoneNumber.Text = "";
            txtCustomerAdds.Text = "";
        }
    }
}
