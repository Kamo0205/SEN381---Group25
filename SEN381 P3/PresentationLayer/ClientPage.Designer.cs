namespace Presentation_Layer
{
    partial class ClientPage
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(149, 114);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(23, 114);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(23, 57);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(146, 57);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(23, 98);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(49, 13);
            this.lblsurname.TabIndex = 9;
            this.lblsurname.Text = "Surname";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(146, 98);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 10;
            this.lbladdress.Text = "Address";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(37, 30);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(132, 25);
            this.lbltitle.TabIndex = 12;
            this.lbltitle.Text = "Client page";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(23, 199);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(100, 23);
            this.btnEXIT.TabIndex = 15;
            this.btnEXIT.Text = "Exit";
            this.btnEXIT.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.lblsurname);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.btnEXIT);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 252);
            this.panel1.TabIndex = 16;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(149, 154);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(100, 68);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 280);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.panel1);
            this.Name = "ClientPage";
            this.Text = "ClientPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePassword;
    }
}