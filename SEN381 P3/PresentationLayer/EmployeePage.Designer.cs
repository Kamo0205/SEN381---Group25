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
            this.lblemptitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblempLastname = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lvlempFname = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(189, 216);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 28);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 216);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 28);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblemptitle
            // 
            this.lblemptitle.AutoSize = true;
            this.lblemptitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemptitle.Location = new System.Drawing.Point(33, 22);
            this.lblemptitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemptitle.Name = "lblemptitle";
            this.lblemptitle.Size = new System.Drawing.Size(223, 31);
            this.lblemptitle.TabIndex = 28;
            this.lblemptitle.Text = "Employee page.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(185, 108);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email";
            // 
            // lblempLastname
            // 
            this.lblempLastname.AutoSize = true;
            this.lblempLastname.Location = new System.Drawing.Point(20, 108);
            this.lblempLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblempLastname.Name = "lblempLastname";
            this.lblempLastname.Size = new System.Drawing.Size(65, 17);
            this.lblempLastname.TabIndex = 25;
            this.lblempLastname.Text = "Surname";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(185, 60);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(108, 17);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "Contact number";
            // 
            // lvlempFname
            // 
            this.lvlempFname.AutoSize = true;
            this.lvlempFname.Location = new System.Drawing.Point(20, 60);
            this.lvlempFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlempFname.Name = "lvlempFname";
            this.lvlempFname.Size = new System.Drawing.Size(45, 17);
            this.lvlempFname.TabIndex = 22;
            this.lvlempFname.Text = "Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 128);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(24, 128);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 22);
            this.txtSurname.TabIndex = 19;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(189, 80);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(132, 22);
            this.txtNum.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAddSkill);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblempLastname);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lvlempFname);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 278);
            this.panel1.TabIndex = 32;
            // 
            // btnAddSkill
            // 
            this.btnAddSkill.Location = new System.Drawing.Point(24, 180);
            this.btnAddSkill.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(298, 28);
            this.btnAddSkill.TabIndex = 32;
            this.btnAddSkill.Text = "Add a skill";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 320);
            this.Controls.Add(this.lblemptitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblemptitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblempLastname;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lvlempFname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSkill;
    }
}