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
    public partial class FrmServiceType : Form
    {
        DataSet1TableAdapters.ServiceTypeTableAdapter st= new DataSet1TableAdapters.ServiceTypeTableAdapter();
        public FrmServiceType()
        {
            InitializeComponent();
        }
        public void AutoServiceTypeID()
        {
            DataTable dt = new DataTable();
            dt = st.GetData();
            if (dt.Rows.Count == 0)
            {
                lblSTID.Text = "ST_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(3, 3));



                if (newid >= 1 && newid < 9)
                {
                    lblSTID.Text = "ST_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblSTID.Text = "ST_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblSTID.Text = "ST_" + (newid + 1);
                }
            }
        }
        private void FrmServiceType_Load(object sender, EventArgs e)
        {
            AutoServiceTypeID();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtSTTypeName.Text=="")
            {
                MessageBox.Show("Please Enter The Service Type Name", "Service Type Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTTypeName.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                clsServiceType stt = new clsServiceType();
                stt.ServiceTID = lblSTID.Text;
                stt.ServiceTName = txtSTTypeName.Text;
                int data=st.Insert(stt.ServiceTID, stt.ServiceTName);
                if (data>0)
                {
                    MessageBox.Show("Service Type has been saved successfully", "Service Type Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoServiceTypeID();
                }
            }
        }

        
    }
}
