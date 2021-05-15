namespace Presentation_Layer
{
    partial class EmployeePage
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chEdit = new System.Windows.Forms.CheckBox();
            this.lblemptitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lvlVatID = new System.Windows.Forms.Label();
            this.lblempLastname = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblempPassword = new System.Windows.Forms.Label();
            this.lvlempFname = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtVatID = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(374, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chEdit
            // 
            this.chEdit.AutoSize = true;
            this.chEdit.Location = new System.Drawing.Point(25, 277);
            this.chEdit.Name = "chEdit";
            this.chEdit.Size = new System.Drawing.Size(44, 17);
            this.chEdit.TabIndex = 29;
            this.chEdit.Text = "Edit";
            this.chEdit.UseVisualStyleBackColor = true;
            this.chEdit.CheckedChanged += new System.EventHandler(this.chEdit_CheckedChanged);
            // 
            // lblemptitle
            // 
            this.lblemptitle.AutoSize = true;
            this.lblemptitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemptitle.Location = new System.Drawing.Point(25, 18);
            this.lblemptitle.Name = "lblemptitle";
            this.lblemptitle.Size = new System.Drawing.Size(181, 25);
            this.lblemptitle.TabIndex = 28;
            this.lblemptitle.Text = "Employee page.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(371, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email";
            // 
            // lvlVatID
            // 
            this.lvlVatID.AutoSize = true;
            this.lvlVatID.Location = new System.Drawing.Point(190, 196);
            this.lvlVatID.Name = "lvlVatID";
            this.lvlVatID.Size = new System.Drawing.Size(37, 13);
            this.lvlVatID.TabIndex = 26;
            this.lvlVatID.Text = "Vat ID";
            // 
            // lblempLastname
            // 
            this.lblempLastname.AutoSize = true;
            this.lblempLastname.Location = new System.Drawing.Point(25, 196);
            this.lblempLastname.Name = "lblempLastname";
            this.lblempLastname.Size = new System.Drawing.Size(49, 13);
            this.lblempLastname.TabIndex = 25;
            this.lblempLastname.Text = "Surname";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(371, 105);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(82, 13);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "Contact number";
            // 
            // lblempPassword
            // 
            this.lblempPassword.AutoSize = true;
            this.lblempPassword.Location = new System.Drawing.Point(190, 105);
            this.lblempPassword.Name = "lblempPassword";
            this.lblempPassword.Size = new System.Drawing.Size(53, 13);
            this.lblempPassword.TabIndex = 23;
            this.lblempPassword.Text = "Password";
            // 
            // lvlempFname
            // 
            this.lvlempFname.AutoSize = true;
            this.lvlempFname.Location = new System.Drawing.Point(25, 105);
            this.lvlempFname.Name = "lvlempFname";
            this.lvlempFname.Size = new System.Drawing.Size(35, 13);
            this.lvlempFname.TabIndex = 22;
            this.lvlempFname.Text = "Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(374, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtVatID
            // 
            this.txtVatID.Location = new System.Drawing.Point(193, 227);
            this.txtVatID.Name = "txtVatID";
            this.txtVatID.Size = new System.Drawing.Size(100, 20);
            this.txtVatID.TabIndex = 20;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(13, 215);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 19;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(374, 140);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 18;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(25, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 340);
            this.panel1.TabIndex = 32;
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chEdit);
            this.Controls.Add(this.lblemptitle);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lvlVatID);
            this.Controls.Add(this.lblempLastname);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblempPassword);
            this.Controls.Add(this.lvlempFname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtVatID);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chEdit;
        private System.Windows.Forms.Label lblemptitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lvlVatID;
        private System.Windows.Forms.Label lblempLastname;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblempPassword;
        private System.Windows.Forms.Label lvlempFname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtVatID;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
    }
}