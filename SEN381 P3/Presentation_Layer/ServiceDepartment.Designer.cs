namespace PresentationLayer
{
    partial class FrmServiceDepartment
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
            this.lstQueuedJobs = new System.Windows.Forms.ListBox();
            this.lblQueuedJobs = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnLockInJob = new System.Windows.Forms.Button();
            this.pnlJobs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTechnicians = new System.Windows.Forms.Label();
            this.btnLockInTechnicians = new System.Windows.Forms.Button();
            this.lstTechnicians = new System.Windows.Forms.ListBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtClassfication = new System.Windows.Forms.TextBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.lblClassification = new System.Windows.Forms.Label();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLockInEquipment = new System.Windows.Forms.Button();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlJobs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstQueuedJobs
            // 
            this.lstQueuedJobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lstQueuedJobs.FormattingEnabled = true;
            this.lstQueuedJobs.ItemHeight = 19;
            this.lstQueuedJobs.Location = new System.Drawing.Point(7, 28);
            this.lstQueuedJobs.Name = "lstQueuedJobs";
            this.lstQueuedJobs.Size = new System.Drawing.Size(257, 213);
            this.lstQueuedJobs.TabIndex = 0;
            // 
            // lblQueuedJobs
            // 
            this.lblQueuedJobs.AutoSize = true;
            this.lblQueuedJobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblQueuedJobs.Location = new System.Drawing.Point(8, 5);
            this.lblQueuedJobs.Name = "lblQueuedJobs";
            this.lblQueuedJobs.Size = new System.Drawing.Size(92, 19);
            this.lblQueuedJobs.TabIndex = 1;
            this.lblQueuedJobs.Text = "Queued Jobs:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblClientName.Location = new System.Drawing.Point(281, 5);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(88, 19);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "Client Name:";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtClientName.Location = new System.Drawing.Point(285, 28);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(155, 26);
            this.txtClientName.TabIndex = 3;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtStartDate.Location = new System.Drawing.Point(285, 77);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(120, 26);
            this.txtStartDate.TabIndex = 5;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblStartDate.Location = new System.Drawing.Point(281, 54);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 19);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtEndDate.Location = new System.Drawing.Point(415, 76);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(120, 26);
            this.txtEndDate.TabIndex = 7;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblEndDate.Location = new System.Drawing.Point(411, 53);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 19);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDetails.Location = new System.Drawing.Point(285, 126);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(250, 86);
            this.txtDetails.TabIndex = 9;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDetails.Location = new System.Drawing.Point(281, 103);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(53, 19);
            this.lblDetails.TabIndex = 8;
            this.lblDetails.Text = "Details:";
            // 
            // btnLockInJob
            // 
            this.btnLockInJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLockInJob.Location = new System.Drawing.Point(285, 219);
            this.btnLockInJob.Name = "btnLockInJob";
            this.btnLockInJob.Size = new System.Drawing.Size(75, 23);
            this.btnLockInJob.TabIndex = 10;
            this.btnLockInJob.Text = "Lock In";
            this.btnLockInJob.UseVisualStyleBackColor = true;
            // 
            // pnlJobs
            // 
            this.pnlJobs.BackColor = System.Drawing.Color.White;
            this.pnlJobs.Controls.Add(this.lblQueuedJobs);
            this.pnlJobs.Controls.Add(this.btnLockInJob);
            this.pnlJobs.Controls.Add(this.lstQueuedJobs);
            this.pnlJobs.Controls.Add(this.txtDetails);
            this.pnlJobs.Controls.Add(this.lblClientName);
            this.pnlJobs.Controls.Add(this.lblDetails);
            this.pnlJobs.Controls.Add(this.txtClientName);
            this.pnlJobs.Controls.Add(this.txtEndDate);
            this.pnlJobs.Controls.Add(this.lblStartDate);
            this.pnlJobs.Controls.Add(this.lblEndDate);
            this.pnlJobs.Controls.Add(this.txtStartDate);
            this.pnlJobs.Location = new System.Drawing.Point(3, 4);
            this.pnlJobs.Name = "pnlJobs";
            this.pnlJobs.Size = new System.Drawing.Size(551, 259);
            this.pnlJobs.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTechnicians);
            this.panel1.Controls.Add(this.btnLockInTechnicians);
            this.panel1.Controls.Add(this.lstTechnicians);
            this.panel1.Controls.Add(this.lblEmployeeName);
            this.panel1.Controls.Add(this.txtEmployeeName);
            this.panel1.Controls.Add(this.txtClassfication);
            this.panel1.Controls.Add(this.lblSkill);
            this.panel1.Controls.Add(this.lblClassification);
            this.panel1.Controls.Add(this.txtSkill);
            this.panel1.Location = new System.Drawing.Point(3, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 259);
            this.panel1.TabIndex = 12;
            // 
            // lblTechnicians
            // 
            this.lblTechnicians.AutoSize = true;
            this.lblTechnicians.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTechnicians.Location = new System.Drawing.Point(8, 5);
            this.lblTechnicians.Name = "lblTechnicians";
            this.lblTechnicians.Size = new System.Drawing.Size(81, 19);
            this.lblTechnicians.TabIndex = 1;
            this.lblTechnicians.Text = "Technicians:";
            // 
            // btnLockInTechnicians
            // 
            this.btnLockInTechnicians.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLockInTechnicians.Location = new System.Drawing.Point(285, 219);
            this.btnLockInTechnicians.Name = "btnLockInTechnicians";
            this.btnLockInTechnicians.Size = new System.Drawing.Size(75, 23);
            this.btnLockInTechnicians.TabIndex = 10;
            this.btnLockInTechnicians.Text = "Lock In";
            this.btnLockInTechnicians.UseVisualStyleBackColor = true;
            this.btnLockInTechnicians.Click += new System.EventHandler(this.btnLockInTechnicians_Click);
            // 
            // lstTechnicians
            // 
            this.lstTechnicians.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lstTechnicians.FormattingEnabled = true;
            this.lstTechnicians.ItemHeight = 19;
            this.lstTechnicians.Location = new System.Drawing.Point(7, 28);
            this.lstTechnicians.Name = "lstTechnicians";
            this.lstTechnicians.Size = new System.Drawing.Size(257, 213);
            this.lstTechnicians.TabIndex = 0;
            this.lstTechnicians.SelectedIndexChanged += new System.EventHandler(this.lstTechnicians_SelectedIndexChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblEmployeeName.Location = new System.Drawing.Point(281, 5);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(113, 19);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtEmployeeName.Location = new System.Drawing.Point(285, 28);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(155, 26);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // txtClassfication
            // 
            this.txtClassfication.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtClassfication.Location = new System.Drawing.Point(285, 129);
            this.txtClassfication.Name = "txtClassfication";
            this.txtClassfication.Size = new System.Drawing.Size(155, 26);
            this.txtClassfication.TabIndex = 7;
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblSkill.Location = new System.Drawing.Point(281, 54);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(38, 19);
            this.lblSkill.TabIndex = 4;
            this.lblSkill.Text = "Skill:";
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblClassification.Location = new System.Drawing.Point(281, 106);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(91, 19);
            this.lblClassification.TabIndex = 6;
            this.lblClassification.Text = "Classification:";
            // 
            // txtSkill
            // 
            this.txtSkill.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSkill.Location = new System.Drawing.Point(285, 77);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.Size = new System.Drawing.Size(155, 26);
            this.txtSkill.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnLockInEquipment);
            this.panel2.Controls.Add(this.txtEquipment);
            this.panel2.Location = new System.Drawing.Point(569, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 259);
            this.panel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(8, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Equipment:";
            // 
            // btnLockInEquipment
            // 
            this.btnLockInEquipment.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLockInEquipment.Location = new System.Drawing.Point(12, 127);
            this.btnLockInEquipment.Name = "btnLockInEquipment";
            this.btnLockInEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnLockInEquipment.TabIndex = 10;
            this.btnLockInEquipment.Text = "Lock In";
            this.btnLockInEquipment.UseVisualStyleBackColor = true;
            this.btnLockInEquipment.Click += new System.EventHandler(this.btnLockInEquipment_Click);
            // 
            // txtEquipment
            // 
            this.txtEquipment.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtEquipment.Location = new System.Drawing.Point(12, 34);
            this.txtEquipment.Multiline = true;
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(250, 86);
            this.txtEquipment.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSave.Location = new System.Drawing.Point(569, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnBack.Location = new System.Drawing.Point(773, 283);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmServiceDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 538);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlJobs);
            this.MaximizeBox = false;
            this.Name = "FrmServiceDepartment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceDepartment";
            this.pnlJobs.ResumeLayout(false);
            this.pnlJobs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstQueuedJobs;
        private System.Windows.Forms.Label lblQueuedJobs;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnLockInJob;
        private System.Windows.Forms.Panel pnlJobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTechnicians;
        private System.Windows.Forms.Button btnLockInTechnicians;
        private System.Windows.Forms.ListBox lstTechnicians;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtClassfication;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLockInEquipment;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}