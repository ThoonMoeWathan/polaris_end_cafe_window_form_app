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
    public partial class FrmCustomerHomePage : Form
    {
        DataSet1TableAdapters.ReviewTableAdapter r = new DataSet1TableAdapters.ReviewTableAdapter();
        string RID;
        public FrmCustomerHomePage()
        {
            InitializeComponent();
        }
        public void AutoReviewID()
        {
            DataTable dt = new DataTable();
            dt = r.GetData();
            if (dt.Rows.Count == 0)
            {
                RID = "R_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 3));
                if (newid >= 1 && newid < 9)
                {
                    RID = "R_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    RID = "R_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    RID = "R_" + (newid + 1);
                }
            }
        }
        private void FrmCustomerHomePage_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to The Page," + FrmCustomerLogin.cusname;
            string CID = FrmCustomerLogin.cusid;
            dgvReviewList.DataSource = r.CheckReview(CID);
            AutoReviewID();
        }
        private void btnComment_Click(object sender, EventArgs e)
        {
            if (txtReview.Text == "")
            {
                MessageBox.Show("Please Enter your Opinion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtReview.Focus();
            }
            else
            {
                try
                {
                    String reviewtxt = txtReview.Text;
                    r.Insert(RID, reviewtxt, FrmCustomerLogin.cusid);
                    MessageBox.Show("Thank you for your Time", "Comment has been Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReviewList.DataSource = r.GetData();
                    dgvReviewList.Refresh();
                    btnComment.Enabled = false;
                    txtReview.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("It seems like you have written a review with more than the limited word count! We appreciate your concern, but please limit your writing only within 100 words !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnVO_Click(object sender, EventArgs e)
        {
            FrmCusViewBooking vb = new FrmCusViewBooking();
            vb.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            FrmBooking b = new FrmBooking();
            b.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FrmCustomerProfile cprofile = new FrmCustomerProfile();
            cprofile.Show();
        }

        private void btnLeave_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmMain m = new FrmMain();
            m.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
            FrmCustomerLogin cl = new FrmCustomerLogin();
            cl.Show();
        }
    }
}
