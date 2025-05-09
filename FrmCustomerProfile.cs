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
    public partial class FrmCustomerProfile : Form
    {
        public FrmCustomerProfile()
        {
            InitializeComponent();
        }

        private void FrmCustomerProfile_Load(object sender, EventArgs e)
        {
            lblCusN.Text = FrmCustomerLogin.cusname;
            lblCusEmail.Text = FrmCustomerLogin.cemail;
            lblCusPW.Text = FrmCustomerLogin.cpassword;
            lblCusN.Text = FrmCustomerLogin.cusname;
            lblCusUserN.Text = FrmCustomerLogin.cusername;
            lblCusAddress.Text = FrmCustomerLogin.caddress;
            lblCusPNo.Text = FrmCustomerLogin.cphonenumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
