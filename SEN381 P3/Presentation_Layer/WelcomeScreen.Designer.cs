namespace PresentationLayer
{
    partial class FrmWelcomeScreen
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
            this.lblClientsOrEmployees = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClientSatisfaction = new System.Windows.Forms.Button();
            this.btnServiceDepartment = new System.Windows.Forms.Button();
            this.btnCallCenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientsOrEmployees
            // 
            this.lblClientsOrEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblClientsOrEmployees.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsOrEmployees.Location = new System.Drawing.Point(336, 103);
            this.lblClientsOrEmployees.Name = "lblClientsOrEmployees";
            this.lblClientsOrEmployees.Size = new System.Drawing.Size(133, 31);
            this.lblClientsOrEmployees.TabIndex = 2;
            this.lblClientsOrEmployees.Text = "Clients/Employees";
            this.lblClientsOrEmployees.UseVisualStyleBackColor = true;
            this.lblClientsOrEmployees.Click += new System.EventHandler(this.lblBusinessFunctions_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 103);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClientSatisfaction
            // 
            this.btnClientSatisfaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientSatisfaction.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClientSatisfaction.Location = new System.Drawing.Point(341, 10);
            this.btnClientSatisfaction.Name = "btnClientSatisfaction";
            this.btnClientSatisfaction.Size = new System.Drawing.Size(128, 74);
            this.btnClientSatisfaction.TabIndex = 7;
            this.btnClientSatisfaction.Text = "Client Satisfaction";
            this.btnClientSatisfaction.UseVisualStyleBackColor = true;
            this.btnClientSatisfaction.Click += new System.EventHandler(this.btnClientSatisfaction_Click);
            // 
            // btnServiceDepartment
            // 
            this.btnServiceDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServiceDepartment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnServiceDepartment.Location = new System.Drawing.Point(179, 10);
            this.btnServiceDepartment.Name = "btnServiceDepartment";
            this.btnServiceDepartment.Size = new System.Drawing.Size(128, 74);
            this.btnServiceDepartment.TabIndex = 6;
            this.btnServiceDepartment.Text = "Service Department";
            this.btnServiceDepartment.UseVisualStyleBackColor = true;
            this.btnServiceDepartment.Click += new System.EventHandler(this.btnServiceDepartment_Click);
            // 
            // btnCallCenter
            // 
            this.btnCallCenter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCallCenter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCallCenter.Location = new System.Drawing.Point(12, 10);
            this.btnCallCenter.Name = "btnCallCenter";
            this.btnCallCenter.Size = new System.Drawing.Size(128, 74);
            this.btnCallCenter.TabIndex = 5;
            this.btnCallCenter.Text = "Call Center";
            this.btnCallCenter.UseVisualStyleBackColor = true;
            this.btnCallCenter.Click += new System.EventHandler(this.btnCallCenter_Click);
            // 
            // FrmWelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 141);
            this.Controls.Add(this.btnClientSatisfaction);
            this.Controls.Add(this.btnServiceDepartment);
            this.Controls.Add(this.btnCallCenter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblClientsOrEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmWelcomeScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeScreen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button lblClientsOrEmployees;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClientSatisfaction;
        private System.Windows.Forms.Button btnServiceDepartment;
        private System.Windows.Forms.Button btnCallCenter;
    }
}