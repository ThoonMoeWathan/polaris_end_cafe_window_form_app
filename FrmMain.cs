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
    public partial class FrmMain : Form
    {
        DataSet1TableAdapters.ServiceTableAdapter sta = new DataSet1TableAdapters.ServiceTableAdapter();
        DataSet1TableAdapters.ReviewTableAdapter rta = new DataSet1TableAdapters.ReviewTableAdapter();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomerLogin cus = new FrmCustomerLogin();
            cus.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminLogin adm = new FrmAdminLogin();
            adm.Show();
            this.Hide();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dgvServiceList.DataSource = sta.GetData();
            dgvCusReview.DataSource = rta.GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
