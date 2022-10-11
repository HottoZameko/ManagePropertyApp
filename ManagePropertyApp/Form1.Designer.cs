
namespace ManagePropertyApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnAgency = new System.Windows.Forms.Button();
            this.btnSuburb = new System.Windows.Forms.Button();
            this.btnCity = new System.Windows.Forms.Button();
            this.btnProvince = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnPropertyType = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnAdmin);
            this.groupBox1.Controls.Add(this.btnReports);
            this.groupBox1.Controls.Add(this.btnRental);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnAgent);
            this.groupBox1.Controls.Add(this.btnAgency);
            this.groupBox1.Controls.Add(this.btnSuburb);
            this.groupBox1.Controls.Add(this.btnCity);
            this.groupBox1.Controls.Add(this.btnProvince);
            this.groupBox1.Controls.Add(this.btnProperty);
            this.groupBox1.Controls.Add(this.btnPropertyType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(13, 1);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 36);
            this.lblUser.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(806, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Location = new System.Drawing.Point(692, 321);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(223, 142);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Location = new System.Drawing.Point(437, 321);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(249, 142);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "Manage Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRental.Location = new System.Drawing.Point(221, 321);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(210, 142);
            this.btnRental.TabIndex = 9;
            this.btnRental.Text = "Manage Rental";
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(6, 321);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(209, 142);
            this.button9.TabIndex = 8;
            this.button9.Text = "Manage Property Agent";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(692, 200);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(223, 116);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Manage Tenant";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnTenant_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgent.Location = new System.Drawing.Point(437, 200);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(249, 116);
            this.btnAgent.TabIndex = 6;
            this.btnAgent.Text = "Manage Agent";
            this.btnAgent.UseVisualStyleBackColor = false;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnAgency
            // 
            this.btnAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgency.Location = new System.Drawing.Point(221, 200);
            this.btnAgency.Name = "btnAgency";
            this.btnAgency.Size = new System.Drawing.Size(210, 116);
            this.btnAgency.TabIndex = 5;
            this.btnAgency.Text = "Manage Agency";
            this.btnAgency.UseVisualStyleBackColor = false;
            this.btnAgency.Click += new System.EventHandler(this.btnAgency_Click);
            // 
            // btnSuburb
            // 
            this.btnSuburb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuburb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuburb.Location = new System.Drawing.Point(6, 200);
            this.btnSuburb.Name = "btnSuburb";
            this.btnSuburb.Size = new System.Drawing.Size(209, 116);
            this.btnSuburb.TabIndex = 4;
            this.btnSuburb.Text = "Manage Suburb";
            this.btnSuburb.UseVisualStyleBackColor = false;
            this.btnSuburb.Click += new System.EventHandler(this.btnSuburb_Click);
            // 
            // btnCity
            // 
            this.btnCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCity.Location = new System.Drawing.Point(692, 74);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(223, 120);
            this.btnCity.TabIndex = 3;
            this.btnCity.Text = "Manage Cities";
            this.btnCity.UseVisualStyleBackColor = false;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // btnProvince
            // 
            this.btnProvince.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvince.Location = new System.Drawing.Point(437, 74);
            this.btnProvince.Name = "btnProvince";
            this.btnProvince.Size = new System.Drawing.Size(249, 120);
            this.btnProvince.TabIndex = 2;
            this.btnProvince.Text = "Manage Province";
            this.btnProvince.UseVisualStyleBackColor = false;
            this.btnProvince.Click += new System.EventHandler(this.btnProvince_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty.Location = new System.Drawing.Point(221, 74);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(210, 120);
            this.btnProperty.TabIndex = 1;
            this.btnProperty.Text = "Manage Property";
            this.btnProperty.UseVisualStyleBackColor = false;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnPropertyType
            // 
            this.btnPropertyType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPropertyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropertyType.Location = new System.Drawing.Point(6, 74);
            this.btnPropertyType.Name = "btnPropertyType";
            this.btnPropertyType.Size = new System.Drawing.Size(209, 120);
            this.btnPropertyType.TabIndex = 0;
            this.btnPropertyType.Text = "Manage Property Type";
            this.btnPropertyType.UseVisualStyleBackColor = false;
            this.btnPropertyType.Click += new System.EventHandler(this.btnPropertyType_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 44);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(271, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(940, 487);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnAgency;
        private System.Windows.Forms.Button btnSuburb;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Button btnProvince;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnPropertyType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

