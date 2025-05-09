using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ServiceBookingSystem_Eg
{
    public partial class FrmService : Form
    {
        DataSet1TableAdapters.ServiceTypeTableAdapter st = new DataSet1TableAdapters.ServiceTypeTableAdapter();
        DataSet1TableAdapters.ServiceTableAdapter s = new DataSet1TableAdapters.ServiceTableAdapter();
        string servicetypeid;
        string imglocation;
        public FrmService()
        {
            InitializeComponent();
        }
        public void SelectServiceType()
        {
            DataTable dt = new DataTable();
            dt = st.GetData();
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.NewRow();
                r[0] = 0;
                r[1] = "ChooseServiceType";
                dt.Rows.InsertAt(r, 0);
                cboServiceTypeID.DataSource = dt;
                //cboServiceTypeID.DisplayMember = "ServiceType";
                cboServiceTypeID.ValueMember = "ServiceTypeName";
            }
        }
        public void AutoServiceID()
        {
            DataTable dt = new DataTable();
            dt = s.GetData();
            if (dt.Rows.Count == 0)
            {
                lblSTID.Text = "S_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 3));



                if (newid >= 1 && newid < 9)
                {
                    lblSTID.Text = "S_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblSTID.Text = "S_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblSTID.Text = "S_" + (newid + 1);
                }
            }
        }
        private void FrmService_Load(object sender, EventArgs e)
        {
            SelectServiceType();
            AutoServiceID();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "All Pictures(*.emf; *.wmf; *.jpg; *.jpeg; *.jfif; *.jpe; *.png; *.bmp; *.dib; *.rle; *.gif; *.emz; *.wmz; *.tif; *.tiff; *.svg; *.ico|*.emf;*.wmf;*.jpg;*.jpeg;*.jfif;*.jpe;*.png;*.bmp;*.dib;*.rle;*.gif;*.emz;*.wmz;*.tif;*.tiff;*.svg;*.ico|All Files (*.*)|*.*";
            if (o.ShowDialog() == DialogResult.OK)
            {
                imglocation = o.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSName.Text = "";
            txtSPrice.Text = "";
            txtSDescription.Text = "";
        }
        private void cboServiceTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cboServiceTypeID.SelectedValue.ToString();
            DataTable dt = new DataTable();
            dt = st.CheckServiceType(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                servicetypeid = dt.Rows[0][0].ToString();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                images = br.ReadBytes((int)stream.Length);
                int sqlQuery = s.InsertQuery(lblSTID.Text, txtSName.Text, servicetypeid, Convert.ToInt32(txtSPrice.Text), imglocation, txtSDescription.Text);
                if (sqlQuery > 0)
                {
                    MessageBox.Show("Service Save Successful", "Service Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoServiceID();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill out the text areas provided with information regarding the specific service.Please revise and try again.", "Service Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
            
        
