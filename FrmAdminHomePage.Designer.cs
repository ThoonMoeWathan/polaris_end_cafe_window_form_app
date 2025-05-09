namespace ServiceBookingSystem_Eg
{
    partial class FrmAdminHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminHomePage));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnST = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnCustomersBooking = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PeachPuff;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(0, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.PeachPuff;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHome.Location = new System.Drawing.Point(0, 350);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "&Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLeave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLeave.Location = new System.Drawing.Point(0, 300);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(200, 50);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "&Leave the program";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnST
            // 
            this.btnST.BackColor = System.Drawing.Color.PeachPuff;
            this.btnST.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnST.Location = new System.Drawing.Point(0, 250);
            this.btnST.Name = "btnST";
            this.btnST.Size = new System.Drawing.Size(200, 50);
            this.btnST.TabIndex = 4;
            this.btnST.Text = "Service &Type";
            this.btnST.UseVisualStyleBackColor = false;
            this.btnST.Click += new System.EventHandler(this.btnST_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.PeachPuff;
            this.btnS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnS.Location = new System.Drawing.Point(0, 200);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(200, 50);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "&Service";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnCustomersBooking
            // 
            this.btnCustomersBooking.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCustomersBooking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCustomersBooking.Location = new System.Drawing.Point(0, 150);
            this.btnCustomersBooking.Name = "btnCustomersBooking";
            this.btnCustomersBooking.Size = new System.Drawing.Size(200, 50);
            this.btnCustomersBooking.TabIndex = 6;
            this.btnCustomersBooking.Text = "Customers\' &Bookings";
            this.btnCustomersBooking.UseVisualStyleBackColor = false;
            this.btnCustomersBooking.Click += new System.EventHandler(this.btnCustomersBooking_Click);
            // 
            // button7
            // 
            this.button7.AccessibleDescription = "btnStaffRegist";
            this.button7.BackColor = System.Drawing.Color.PeachPuff;
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.Location = new System.Drawing.Point(0, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "Staff &Register";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnCustomersBooking);
            this.panel1.Controls.Add(this.btnS);
            this.panel1.Controls.Add(this.btnST);
            this.panel1.Controls.Add(this.btnLeave);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 94);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminHomePage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnST;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnCustomersBooking;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}