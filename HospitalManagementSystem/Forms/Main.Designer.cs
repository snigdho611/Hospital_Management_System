﻿using System.Windows.Forms;

namespace HospitalManagementSystem.Windows
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDept = new System.Windows.Forms.Button();
            this.usrBtn = new System.Windows.Forms.Button();
            this.phrBtn = new System.Windows.Forms.Button();
            this.apnBtn = new System.Windows.Forms.Button();
            this.docBtn = new System.Windows.Forms.Button();
            this.ptnBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.txtLoggedInAs = new System.Windows.Forms.TextBox();
            this.btnLoggedInAs = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.tblLbl = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.addPtnBtn = new System.Windows.Forms.Button();
            this.updPtnBtn = new System.Windows.Forms.Button();
            this.delPtnBtn = new System.Windows.Forms.Button();
            this.addDocBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnDept);
            this.panel1.Controls.Add(this.usrBtn);
            this.panel1.Controls.Add(this.phrBtn);
            this.panel1.Controls.Add(this.apnBtn);
            this.panel1.Controls.Add(this.docBtn);
            this.panel1.Controls.Add(this.ptnBtn);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 675);
            this.panel1.TabIndex = 0;
            // 
            // btnDept
            // 
            this.btnDept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDept.BackgroundImage")));
            this.btnDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDept.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDept.Location = new System.Drawing.Point(6, 273);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(141, 129);
            this.btnDept.TabIndex = 5;
            this.btnDept.Text = "DEPARTMENTS";
            this.btnDept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Visible = false;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // usrBtn
            // 
            this.usrBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usrBtn.BackgroundImage")));
            this.usrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usrBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.usrBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usrBtn.Location = new System.Drawing.Point(3, 543);
            this.usrBtn.Name = "usrBtn";
            this.usrBtn.Size = new System.Drawing.Size(141, 129);
            this.usrBtn.TabIndex = 4;
            this.usrBtn.Text = "USER";
            this.usrBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.usrBtn.UseVisualStyleBackColor = true;
            this.usrBtn.Visible = false;
            this.usrBtn.Click += new System.EventHandler(this.usrBtn_Click);
            // 
            // phrBtn
            // 
            this.phrBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phrBtn.BackgroundImage")));
            this.phrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.phrBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.phrBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phrBtn.Location = new System.Drawing.Point(3, 408);
            this.phrBtn.Name = "phrBtn";
            this.phrBtn.Size = new System.Drawing.Size(141, 129);
            this.phrBtn.TabIndex = 3;
            this.phrBtn.Text = "PHARMACY";
            this.phrBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.phrBtn.UseVisualStyleBackColor = true;
            this.phrBtn.Visible = false;
            // 
            // apnBtn
            // 
            this.apnBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apnBtn.BackgroundImage")));
            this.apnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apnBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.apnBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.apnBtn.Location = new System.Drawing.Point(3, 273);
            this.apnBtn.Name = "apnBtn";
            this.apnBtn.Size = new System.Drawing.Size(141, 129);
            this.apnBtn.TabIndex = 2;
            this.apnBtn.Text = "APPOINTMENTS";
            this.apnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.apnBtn.UseVisualStyleBackColor = true;
            this.apnBtn.Visible = false;
            // 
            // docBtn
            // 
            this.docBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("docBtn.BackgroundImage")));
            this.docBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.docBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.docBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.docBtn.Location = new System.Drawing.Point(3, 138);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(141, 129);
            this.docBtn.TabIndex = 1;
            this.docBtn.Text = "DOCTORS";
            this.docBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.docBtn.UseVisualStyleBackColor = true;
            this.docBtn.Click += new System.EventHandler(this.docBtn_Click);
            // 
            // ptnBtn
            // 
            this.ptnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(200)))), ((int)(((byte)(157)))));
            this.ptnBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptnBtn.BackgroundImage")));
            this.ptnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptnBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptnBtn.Location = new System.Drawing.Point(3, 3);
            this.ptnBtn.Name = "ptnBtn";
            this.ptnBtn.Size = new System.Drawing.Size(141, 129);
            this.ptnBtn.TabIndex = 0;
            this.ptnBtn.Text = "PATIENTS";
            this.ptnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ptnBtn.UseVisualStyleBackColor = false;
            this.ptnBtn.Click += new System.EventHandler(this.ptnBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblAdministrator);
            this.panel2.Controls.Add(this.txtLoggedInAs);
            this.panel2.Controls.Add(this.btnLoggedInAs);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnDischarge);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.tblLbl);
            this.panel2.Controls.Add(this.dataGridViewMain);
            this.panel2.Location = new System.Drawing.Point(224, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 663);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAdministrator.ForeColor = System.Drawing.Color.Indigo;
            this.lblAdministrator.Location = new System.Drawing.Point(597, 635);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(150, 19);
            this.lblAdministrator.TabIndex = 13;
            this.lblAdministrator.Text = "Administrator Mode";
            this.lblAdministrator.Visible = false;
            // 
            // txtLoggedInAs
            // 
            this.txtLoggedInAs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtLoggedInAs.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoggedInAs.Location = new System.Drawing.Point(569, 610);
            this.txtLoggedInAs.Name = "txtLoggedInAs";
            this.txtLoggedInAs.ReadOnly = true;
            this.txtLoggedInAs.Size = new System.Drawing.Size(199, 22);
            this.txtLoggedInAs.TabIndex = 12;
            this.txtLoggedInAs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoggedInAs
            // 
            this.btnLoggedInAs.AutoSize = true;
            this.btnLoggedInAs.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLoggedInAs.ForeColor = System.Drawing.Color.Indigo;
            this.btnLoggedInAs.Location = new System.Drawing.Point(462, 610);
            this.btnLoggedInAs.Name = "btnLoggedInAs";
            this.btnLoggedInAs.Size = new System.Drawing.Size(101, 19);
            this.btnLoggedInAs.TabIndex = 11;
            this.btnLoggedInAs.Text = "Logged in as:";
            this.btnLoggedInAs.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Indigo;
            this.btnLogOut.Location = new System.Drawing.Point(783, 610);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(92, 29);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDischarge
            // 
            this.btnDischarge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDischarge.Enabled = false;
            this.btnDischarge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDischarge.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDischarge.Location = new System.Drawing.Point(783, 136);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(92, 25);
            this.btnDischarge.TabIndex = 7;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.UseVisualStyleBackColor = false;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBox1.Location = new System.Drawing.Point(20, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(121, 93);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(342, 26);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // tblLbl
            // 
            this.tblLbl.AutoSize = true;
            this.tblLbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLbl.ForeColor = System.Drawing.Color.Indigo;
            this.tblLbl.Location = new System.Drawing.Point(17, 14);
            this.tblLbl.Name = "tblLbl";
            this.tblLbl.Size = new System.Drawing.Size(97, 25);
            this.tblLbl.TabIndex = 1;
            this.tblLbl.Text = "ABCDE";
            this.tblLbl.Visible = false;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.Location = new System.Drawing.Point(22, 136);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(755, 446);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // addPtnBtn
            // 
            this.addPtnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(166)))), ((int)(((byte)(126)))));
            this.addPtnBtn.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPtnBtn.ForeColor = System.Drawing.Color.White;
            this.addPtnBtn.Location = new System.Drawing.Point(155, 20);
            this.addPtnBtn.Name = "addPtnBtn";
            this.addPtnBtn.Size = new System.Drawing.Size(63, 36);
            this.addPtnBtn.TabIndex = 2;
            this.addPtnBtn.Text = "Add Patient";
            this.addPtnBtn.UseVisualStyleBackColor = false;
            this.addPtnBtn.Click += new System.EventHandler(this.addPtnBtn_Click);
            // 
            // updPtnBtn
            // 
            this.updPtnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(166)))), ((int)(((byte)(126)))));
            this.updPtnBtn.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updPtnBtn.ForeColor = System.Drawing.Color.White;
            this.updPtnBtn.Location = new System.Drawing.Point(155, 57);
            this.updPtnBtn.Name = "updPtnBtn";
            this.updPtnBtn.Size = new System.Drawing.Size(63, 36);
            this.updPtnBtn.TabIndex = 3;
            this.updPtnBtn.Text = "Update Patient";
            this.updPtnBtn.UseVisualStyleBackColor = false;
            this.updPtnBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // delPtnBtn
            // 
            this.delPtnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(166)))), ((int)(((byte)(126)))));
            this.delPtnBtn.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delPtnBtn.ForeColor = System.Drawing.Color.White;
            this.delPtnBtn.Location = new System.Drawing.Point(155, 93);
            this.delPtnBtn.Name = "delPtnBtn";
            this.delPtnBtn.Size = new System.Drawing.Size(63, 36);
            this.delPtnBtn.TabIndex = 4;
            this.delPtnBtn.Text = "Delete Patient";
            this.delPtnBtn.UseVisualStyleBackColor = false;
            this.delPtnBtn.Click += new System.EventHandler(this.delPtnBtn_Click);
            // 
            // addDocBtn
            // 
            this.addDocBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(138)))), ((int)(((byte)(61)))));
            this.addDocBtn.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDocBtn.ForeColor = System.Drawing.Color.White;
            this.addDocBtn.Location = new System.Drawing.Point(155, 151);
            this.addDocBtn.Name = "addDocBtn";
            this.addDocBtn.Size = new System.Drawing.Size(63, 36);
            this.addDocBtn.TabIndex = 5;
            this.addDocBtn.Text = "Add Doctor";
            this.addDocBtn.UseVisualStyleBackColor = false;
            this.addDocBtn.Click += new System.EventHandler(this.addDocBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(200)))), ((int)(((byte)(157)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 681);
            this.Controls.Add(this.addDocBtn);
            this.Controls.Add(this.delPtnBtn);
            this.Controls.Add(this.updPtnBtn);
            this.Controls.Add(this.addPtnBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCH Ltd.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        public void AdminAccess()
        {
            this.usrBtn.Visible = true;
            this.lblAdministrator.Visible = true;
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ptnBtn;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.Button apnBtn;
        private System.Windows.Forms.Button phrBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label tblLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button usrBtn;
        private System.Windows.Forms.Button addPtnBtn;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Button updPtnBtn;
        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.Button delPtnBtn;
        private System.Windows.Forms.Button addDocBtn;
        private Button btnLogOut;
        private Label btnLoggedInAs;
        private TextBox txtLoggedInAs;
        private Label lblAdministrator;
    }
}