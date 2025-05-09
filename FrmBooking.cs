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
    public partial class FrmBooking : Form
    {
        DataSet1TableAdapters.ViewServiceTableAdapter v = new DataSet1TableAdapters.ViewServiceTableAdapter();
        DataSet1TableAdapters.ServiceTableAdapter s = new DataSet1TableAdapters.ServiceTableAdapter();
        DataSet1TableAdapters.BookingDetailTableAdapter bdt = new DataSet1TableAdapters.BookingDetailTableAdapter();
        DataSet1TableAdapters.BookingTableAdapter bt = new DataSet1TableAdapters.BookingTableAdapter();
        DataTable dat = new DataTable();
        string sid;
        DataRow dr;
        string bit;
        public FrmBooking()
        {
            InitializeComponent();
        }
        public void SelectServiceType()
        {
            DataTable dt = new DataTable();
            dt = s.GetData();
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.NewRow();
                r[0] = 0;
                r[1] = "ChooseService";
                dt.Rows.InsertAt(r, 0);
                cboService.DataSource = dt;
                //cboServiceTypeID.DisplayMember = "ServiceType";
                cboService.ValueMember = "ServiceName";
            }
        }
        public void AutoBookingID()
        {
            DataTable dt = new DataTable();
            dt = bdt.GetData();
            if (dt.Rows.Count == 0)
            {
                lblBookingID.Text = "BD_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(3, 3));



                if (newid >= 1 && newid < 9)
                {
                    lblBookingID.Text = "BD_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblBookingID.Text = "BD_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblBookingID.Text = "BD_" + (newid + 1);
                }
            }
        }
        public int totalamountT()
        {
            int totalamount = 0;
            String bookingamount;
            int totalrow;
            totalrow = dat.Rows.Count;
            for (int i = 0; i <= totalrow - 1; i++)
            {
                bookingamount = dat.Rows[i]["Service Amount"].ToString();
                totalamount += Convert.ToInt32(bookingamount);
            }
            lblTotalAmount.Text = totalamount.ToString();
            return totalamount;
        }
        public int totalquantityT()
        {
            int totalquantity = 0;
            String bookingquantity;
            int totalrow;
            totalrow = dat.Rows.Count;
            for (int i = 0; i <= totalrow - 1; i++)
            {
                bookingquantity = dat.Rows[i]["Service Quantity"].ToString();
                totalquantity += Convert.ToInt32(bookingquantity);
            }
            lblServiceQuantity.Text=totalquantity.ToString();
            return totalquantity;
        }
        private void FrmBooking_Load(object sender, EventArgs e)
        {
            //dgvDisplay.DataSource = s.GetData();
            SelectServiceType();
            AutoBookingID();
            lblCustomerName.Text = FrmCustomerLogin.cusname;
            lblPhoneNumber.Text = FrmCustomerLogin.cphonenumber;
            lblAddress.Text = FrmCustomerLogin.caddress;
            ServiceList();
            btnRemove.Enabled = false;
            lblBookingDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public void ServiceList()
        {
            dr = dat.NewRow();
            dat.Columns.Add("Booking ID").ToString();
            dat.Columns.Add("Service ID").ToString();
            dat.Columns.Add("Service Type").ToString();
            dat.Columns.Add("Service Name").ToString();
            dat.Columns.Add("Service Quantity").ToString();
            dat.Columns.Add("Service Price").ToString();
            dat.Columns.Add("Service Amount").ToString();
            dgvDisplay.Refresh();
            dgvDisplay.DataSource = dat;
        }
        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ServiceName = cboService.SelectedValue.ToString();
            DataTable dt = new DataTable();
            dt = v.CheckService(ServiceName);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lblServiceType.Text = dt.Rows[0][2].ToString();
                lblServicePrice.Text = dt.Rows[0][1].ToString();
                sid=dt.Rows[0][3].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int unitp, unitqt, totalp;
                unitp = Convert.ToInt32(lblServicePrice.Text);
                unitqt = Convert.ToInt32(txtTotalUser.Text);
                totalp = unitqt * unitp;
                foreach (DataGridViewRow row in dgvDisplay.Rows)
                {
                    if (Convert.ToString(row.Cells["Service Name"].Value) == cboService.Text)
                    {
                        row.Cells["Service Quantity"].Value = Convert.ToInt32(txtTotalUser.Text) + Convert.ToInt32(row.Cells["Service Quantity"].Value);
                        row.Cells["Service Amount"].Value = Convert.ToInt32(row.Cells["Service Price"].Value) * Convert.ToInt32(row.Cells["Service Quantity"].Value);
                        totalamountT();
                        totalquantityT();
                        break;
                    }
                    else
                    {
                        dr = dat.NewRow();
                        dr["Booking ID"] = lblBookingID.Text;
                        dr["Service ID"] = sid;
                        dr["Service Type"] = lblServiceType.Text;
                        dr["Service Name"] = cboService.Text;
                        dr["Service Quantity"] = txtTotalUser.Text;
                        dr["Service Price"] = lblServicePrice.Text;
                        dr["Service Amount"] = totalp;
                        lblTotalAmount.Text = Convert.ToString(totalamountT() + totalp);
                        int i = 0;
                        i = Convert.ToInt32(txtTotalUser.Text);
                        lblServiceQuantity.Text = Convert.ToString(totalquantityT() + i);
                        dat.Rows.Add(dr);
                        dgvDisplay.Refresh();
                        dgvDisplay.DataSource = dat;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int deleterow = dgvDisplay.CurrentCell.RowIndex;
            dgvDisplay.Rows.RemoveAt(deleterow);
            totalamountT();
            totalquantityT();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
            string Status = "Booking";
            int ttluser = Convert.ToInt32(txtTotalUser.Text);
            bit = lblBookingID.Text;
            int ttlamount = Convert.ToInt32(lblTotalAmount.Text);
            int ttlservice = Convert.ToInt32(lblServiceQuantity.Text);
            string cusid = FrmCustomerLogin.cusid;
            string bdate = lblBookingDate.Text;
            bt.Insert(bit, bdate, Convert.ToDateTime(dtpBookingConfirmDate.Value), cusid, ttluser, ttlamount, ttlservice, Status);
            for (int i = 0; i < dat.Rows.Count; i++) 
            {
                string BookingID = dat.Rows[i]["Booking ID"].ToString();
                string ServiceID = dat.Rows[i]["Service ID"].ToString();
                int ServiceQuantity = Convert.ToInt32(dat.Rows[i]["Service Quantity"].ToString());
                int ServicePrice = Convert.ToInt32(dat.Rows[i]["Service Price"].ToString());
                bdt.Insert(BookingID, ServiceID, ServiceQuantity, ServicePrice);
            }
                MessageBox.Show("Thank you for applying Booking! Booking has been placed Successfully!", "Booking Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Information.Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
