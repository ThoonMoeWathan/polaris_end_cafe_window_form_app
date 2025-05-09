namespace ServiceBookingSystem_Eg
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.gbxCustomerBtns = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmailAdds = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblAdds = new System.Windows.Forms.Label();
            this.txtCustomerUserName = new System.Windows.Forms.TextBox();
            this.txtCustomerPassword = new System.Windows.Forms.TextBox();
            this.txtCustomerEmailAdds = new System.Windows.Forms.TextBox();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerAdds = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.gbxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblShowID = new System.Windows.Forms.Label();
            this.gbxCustomerBtns.SuspendLayout();
            this.gbxCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCustomerBtns
            // 
            this.gbxCustomerBtns.BackColor = System.Drawing.Color.Transparent;
            this.gbxCustomerBtns.Controls.Add(this.btnClose);
            this.gbxCustomerBtns.Controls.Add(this.btnClear);
            this.gbxCustomerBtns.Controls.Add(this.btnRegister);
            this.gbxCustomerBtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerBtns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxCustomerBtns.Location = new System.Drawing.Point(12, 476);
            this.gbxCustomerBtns.Name = "gbxCustomerBtns";
            this.gbxCustomerBtns.Size = new System.Drawing.Size(645, 50);
            this.gbxCustomerBtns.TabIndex = 1;
            this.gbxCustomerBtns.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(453, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(281, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(114, 13);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(74, 33);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(8, 81);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 16);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(8, 127);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(8, 178);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblEmailAdds
            // 
            this.lblEmailAdds.AutoSize = true;
            this.lblEmailAdds.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailAdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAdds.Location = new System.Drawing.Point(8, 230);
            this.lblEmailAdds.Name = "lblEmailAdds";
            this.lblEmailAdds.Size = new System.Drawing.Size(95, 16);
            this.lblEmailAdds.TabIndex = 4;
            this.lblEmailAdds.Text = "Email Address";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(8, 278);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(97, 16);
            this.lblPhoneNum.TabIndex = 5;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // lblAdds
            // 
            this.lblAdds.AutoSize = true;
            this.lblAdds.BackColor = System.Drawing.Color.Transparent;
            this.lblAdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdds.Location = new System.Drawing.Point(8, 318);
            this.lblAdds.Name = "lblAdds";
            this.lblAdds.Size = new System.Drawing.Size(58, 16);
            this.lblAdds.TabIndex = 6;
            this.lblAdds.Text = "Address";
            // 
            // txtCustomerUserName
            // 
            this.txtCustomerUserName.Location = new System.Drawing.Point(211, 121);
            this.txtCustomerUserName.Name = "txtCustomerUserName";
            this.txtCustomerUserName.Size = new System.Drawing.Size(378, 22);
            this.txtCustomerUserName.TabIndex = 9;
            // 
            // txtCustomerPassword
            // 
            this.txtCustomerPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerPassword.Location = new System.Drawing.Point(211, 172);
            this.txtCustomerPassword.Name = "txtCustomerPassword";
            this.txtCustomerPassword.PasswordChar = '*';
            this.txtCustomerPassword.Size = new System.Drawing.Size(378, 22);
            this.txtCustomerPassword.TabIndex = 10;
            // 
            // txtCustomerEmailAdds
            // 
            this.txtCustomerEmailAdds.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerEmailAdds.Location = new System.Drawing.Point(211, 224);
            this.txtCustomerEmailAdds.Name = "txtCustomerEmailAdds";
            this.txtCustomerEmailAdds.Size = new System.Drawing.Size(378, 22);
            this.txtCustomerEmailAdds.TabIndex = 11;
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(211, 272);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(378, 22);
            this.txtCustomerPhoneNumber.TabIndex = 12;
            // 
            // txtCustomerAdds
            // 
            this.txtCustomerAdds.Location = new System.Drawing.Point(211, 315);
            this.txtCustomerAdds.Multiline = true;
            this.txtCustomerAdds.Name = "txtCustomerAdds";
            this.txtCustomerAdds.Size = new System.Drawing.Size(378, 86);
            this.txtCustomerAdds.TabIndex = 13;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(211, 75);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(378, 22);
            this.txtCustomerName.TabIndex = 8;
            // 
            // gbxCustomerInfo
            // 
            this.gbxCustomerInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxCustomerInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbxCustomerInfo.BackgroundImage")));
            this.gbxCustomerInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxCustomerInfo.Controls.Add(this.lblShowID);
            this.gbxCustomerInfo.Controls.Add(this.txtCustomerName);
            this.gbxCustomerInfo.Controls.Add(this.txtCustomerAdds);
            this.gbxCustomerInfo.Controls.Add(this.txtCustomerPhoneNumber);
            this.gbxCustomerInfo.Controls.Add(this.txtCustomerEmailAdds);
            this.gbxCustomerInfo.Controls.Add(this.txtCustomerPassword);
            this.gbxCustomerInfo.Controls.Add(this.txtCustomerUserName);
            this.gbxCustomerInfo.Controls.Add(this.lblAdds);
            this.gbxCustomerInfo.Controls.Add(this.lblPhoneNum);
            this.gbxCustomerInfo.Controls.Add(this.lblEmailAdds);
            this.gbxCustomerInfo.Controls.Add(this.lblPassword);
            this.gbxCustomerInfo.Controls.Add(this.lblUserName);
            this.gbxCustomerInfo.Controls.Add(this.lblCustomerName);
            this.gbxCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomerInfo.ForeColor = System.Drawing.Color.Black;
            this.gbxCustomerInfo.Location = new System.Drawing.Point(12, 23);
            this.gbxCustomerInfo.Name = "gbxCustomerInfo";
            this.gbxCustomerInfo.Size = new System.Drawing.Size(645, 458);
            this.gbxCustomerInfo.TabIndex = 0;
            this.gbxCustomerInfo.TabStop = false;
            this.gbxCustomerInfo.Text = "Customer Info :";
            // 
            // lblShowID
            // 
            this.lblShowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowID.ForeColor = System.Drawing.Color.Black;
            this.lblShowID.Location = new System.Drawing.Point(211, 35);
            this.lblShowID.Name = "lblShowID";
            this.lblShowID.Size = new System.Drawing.Size(378, 21);
            this.lblShowID.TabIndex = 14;
            this.lblShowID.Visible = false;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 534);
            this.Controls.Add(this.gbxCustomerInfo);
            this.Controls.Add(this.gbxCustomerBtns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Entry";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.gbxCustomerBtns.ResumeLayout(false);
            this.gbxCustomerInfo.ResumeLayout(false);
            this.gbxCustomerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxCustomerBtns;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmailAdds;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblAdds;
        private System.Windows.Forms.TextBox txtCustomerUserName;
        private System.Windows.Forms.TextBox txtCustomerPassword;
        private System.Windows.Forms.TextBox txtCustomerEmailAdds;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.TextBox txtCustomerAdds;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox gbxCustomerInfo;
        private System.Windows.Forms.Label lblShowID;
    }
}