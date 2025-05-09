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
    public partial class FrmAdminHomePage : Form
    {
        public FrmAdminHomePage()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            FrmAdminLogin al = new FrmAdminLogin();
            al.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
            FrmMain m = new FrmMain();
            m.Show();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnST_Click(object sender, EventArgs e)
        {
            FrmServiceType st = new FrmServiceType();
            st.Show();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            FrmService s = new FrmService();
            s.Show();
        }

        private void btnCustomersBooking_Click(object sender, EventArgs e)
        {
            FrmCustomersBooking_from_AdminView cbav = new FrmCustomersBooking_from_AdminView();
            cbav.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmAdmin a = new FrmAdmin();
            a.Show();
        }
    }
}
