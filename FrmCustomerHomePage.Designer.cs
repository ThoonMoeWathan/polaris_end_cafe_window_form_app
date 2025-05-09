namespace ServiceBookingSystem_Eg
{
    partial class FrmCustomerHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerHomePage));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gbxReviewList = new System.Windows.Forms.GroupBox();
            this.btnComment = new System.Windows.Forms.Button();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReviewList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnVO = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxReviewList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviewList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(222, 377);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 37);
            this.lblWelcome.TabIndex = 1;
            // 
            // gbxReviewList
            // 
            this.gbxReviewList.BackColor = System.Drawing.Color.LightSalmon;
            this.gbxReviewList.Controls.Add(this.btnComment);
            this.gbxReviewList.Controls.Add(this.txtReview);
            this.gbxReviewList.Controls.Add(this.label4);
            this.gbxReviewList.Controls.Add(this.dgvReviewList);
            this.gbxReviewList.Location = new System.Drawing.Point(353, 27);
            this.gbxReviewList.Name = "gbxReviewList";
            this.gbxReviewList.Size = new System.Drawing.Size(435, 203);
            this.gbxReviewList.TabIndex = 9;
            this.gbxReviewList.TabStop = false;
            this.gbxReviewList.Text = "Review List";
            // 
            // btnComment
            // 
            this.btnComment.AutoSize = true;
            this.btnComment.BackColor = System.Drawing.SystemColors.Window;
            this.btnComment.Location = new System.Drawing.Point(338, 32);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(85, 29);
            this.btnComment.TabIndex = 10;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(9, 32);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(301, 23);
            this.txtReview.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please Leave us a Review!";
            // 
            // dgvReviewList
            // 
            this.dgvReviewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviewList.Location = new System.Drawing.Point(9, 61);
            this.dgvReviewList.Name = "dgvReviewList";
            this.dgvReviewList.Size = new System.Drawing.Size(414, 131);
            this.dgvReviewList.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnVO);
            this.panel1.Controls.Add(this.btnLeave);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 88);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.PeachPuff;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProfile.Location = new System.Drawing.Point(0, 90);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(200, 60);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "&Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBooking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBooking.Location = new System.Drawing.Point(0, 150);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(200, 60);
            this.btnBooking.TabIndex = 5;
            this.btnBooking.Text = "&Book here";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnVO
            // 
            this.btnVO.BackColor = System.Drawing.Color.PeachPuff;
            this.btnVO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVO.Location = new System.Drawing.Point(0, 210);
            this.btnVO.Name = "btnVO";
            this.btnVO.Size = new System.Drawing.Size(200, 60);
            this.btnVO.TabIndex = 4;
            this.btnVO.Text = "&View your order";
            this.btnVO.UseVisualStyleBackColor = false;
            this.btnVO.Click += new System.EventHandler(this.btnVO_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLeave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLeave.Location = new System.Drawing.Point(0, 270);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(200, 60);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "&Leave the program";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.PeachPuff;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHome.Location = new System.Drawing.Point(0, 330);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 60);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "&Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PeachPuff;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(0, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 60);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // FrmCustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxReviewList);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomerHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Home Page";
            this.Load += new System.EventHandler(this.FrmCustomerHomePage_Load);
            this.gbxReviewList.ResumeLayout(false);
            this.gbxReviewList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviewList)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gbxReviewList;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReviewList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnVO;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
    }
}