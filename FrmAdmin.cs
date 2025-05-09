using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ServiceBookingSystem_Eg
{
    public partial class FrmAdmin : Form
    {
        DataSet1TableAdapters.AdminInfoTableAdapter adta= new DataSet1TableAdapters.AdminInfoTableAdapter();    
        public FrmAdmin()
        {
            InitializeComponent();
        }
        public void AutoAdminID()
        {
            DataTable dt = new DataTable();
            dt = adta.GetData();
            if (dt.Rows.Count == 0)
            {
                lblAdminID.Text = "A_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 3));
                if (newid >= 1 && newid < 9)
                {
                    lblAdminID.Text = "A_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblAdminID.Text = "A_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblAdminID.Text = "A_" + (newid + 1);
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var EmailRule = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            var PasswordRule = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            var PhoneRule = new Regex(@"[0-9]{2}[0-9]{9}$");
            if (txtAdminName.Text == "")
            {
                MessageBox.Show("Please Enter Admin Name", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAdminName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtAdminName.Text))
            {
                MessageBox.Show("Invalid Name Characters. Please try again.", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtAdminUserName.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAdminUserName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtAdminUserName.Text))
            {
                MessageBox.Show("Invalid User Name Characters. Please try again.", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtAdminPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAdminPassword.Focus();
            }
            else if (!PasswordRule.IsMatch(txtAdminPassword.Text))
            {
                MessageBox.Show("At least one uppercase letter and one lowercase letter, numbers, and numeric special characters (@,#,$,%) must be included in the password. Please try again.", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtAdminEmailAdds.Text == "")
            {
                MessageBox.Show("Please Enter Email Address", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAdminEmailAdds.Focus();
            }
            else if (!EmailRule.IsMatch(txtAdminEmailAdds.Text))
            {
                MessageBox.Show("Invalid Email Fomat. Please try again.", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtAdminPhoneNumber.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAdminPhoneNumber.Focus();
            }
            else if (!PhoneRule.IsMatch(txtAdminPhoneNumber.Text))
            {
                MessageBox.Show("Invalid Phone Number. The phone number must have 11 digits. Please try again.", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtAdminAdds.Text == "")
            {
                MessageBox.Show("Please Enter Address", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAdminAdds.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtAdminAdds.Text))
            {
                MessageBox.Show("Invalid Address. Please try again.", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                clsAdmin ad = new clsAdmin();
                ad.AdID = lblAdminID.Text;
                ad.AdName = txtAdminName.Text;
                ad.UName = txtAdminUserName.Text;
                ad.PW = txtAdminPassword.Text;
                ad.Email = txtAdminEmailAdds.Text;
                ad.PN = txtAdminPhoneNumber.Text;
                ad.Adds = txtAdminAdds.Text;
                int data;
                data = adta.Insert(ad.AdID, ad.AdName, ad.UName, ad.PW, ad.Email, ad.PN, ad.Adds);
                if (data > 0)
                {
                    MessageBox.Show("Admin Info has been saved Successfully", "Admin Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            AutoAdminID();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdminName.Text = "";
            txtAdminUserName.Text = "";
            txtAdminPassword.Text = "";
            txtAdminEmailAdds.Text = "";
            txtAdminPhoneNumber.Text = "";
            txtAdminAdds.Text = "";
        }
    }
}
