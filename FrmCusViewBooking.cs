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
    public partial class FrmCusViewBooking : Form
    {
        DataSet1TableAdapters.BookingTableAdapter b = new DataSet1TableAdapters.BookingTableAdapter();
        public FrmCusViewBooking()
        {
            InitializeComponent();
        }

        private void FrmCusViewBooking_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string cid = FrmCustomerLogin.cusid;
            dt = b.CheckBooking(cid);
            if (dt.Rows.Count>0)
            {
                dgvDisplay.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please apply booking first!", "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCancel.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string id = dgvDisplay.CurrentRow.Cells["BookingID"].Value.ToString();
            b.UpdateStatus("Cancel", id);
            string CustomerID = FrmCustomerLogin.cusid;
            dgvDisplay.DataSource = b.CheckBooking(CustomerID);
            dgvDisplay.Refresh();
            MessageBox.Show("This Booking has been Successfully Cancelled.", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancel.Enabled = true;
        }
    }
}
