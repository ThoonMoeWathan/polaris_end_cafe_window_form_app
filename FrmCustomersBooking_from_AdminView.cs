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
    public partial class FrmCustomersBooking_from_AdminView : Form
    {
        DataSet1TableAdapters.BookingTableAdapter bdta = new DataSet1TableAdapters.BookingTableAdapter();
        //string BkID;
        public FrmCustomersBooking_from_AdminView()
        {
            InitializeComponent();
        }
        private void FrmCustomersBooking_from_AdminView_Load(object sender, EventArgs e)
        {
            dgvCustomersBooking.DataSource = bdta.GetData();
            btnApprove.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void dgvCustomersBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnApprove.Enabled = true;
            btnCancel.Enabled = true;
            //BkID = dgvCustomersBooking.CurrentRow.Cells["BookingID"].ToString();
        }
        
        private void btnApprove_Click(object sender, EventArgs e)
        {
            string bkid = dgvCustomersBooking.CurrentRow.Cells["BookingID"].Value.ToString();
            bdta.UpdateStatus("Confirmed", bkid);
            dgvCustomersBooking.DataSource = bdta.GetData();
            dgvCustomersBooking.Refresh();
            MessageBox.Show("This Booking has been Successfully Confirmed.", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string id = dgvCustomersBooking.CurrentRow.Cells["BookingID"].Value.ToString();
            bdta.UpdateStatus("Cancelled", id);
            dgvCustomersBooking.DataSource = bdta.GetData();
            dgvCustomersBooking.Refresh();
            MessageBox.Show("This Booking has been Successfully Cancelled.", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
