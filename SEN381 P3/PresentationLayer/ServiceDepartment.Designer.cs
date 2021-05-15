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
            this.lblCreateJib = new System.Windows.Forms.Label();
            this.pnlJobs = new System.Windows.Forms.Panel();
            this.lblExperationDate = new System.Windows.Forms.Label();
            this.lblServiceLevel = new System.Windows.Forms.Label();
            this.btnCreateJob = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.btnUpdateJob = new System.Windows.Forms.Button();
            this.lblContractJobs = new System.Windows.Forms.Label();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.pnlJobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateJib
            // 
            this.lblCreateJib.AutoSize = true;
            this.lblCreateJib.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCreateJib.Location = new System.Drawing.Point(16, 85);
            this.lblCreateJib.Name = "lblCreateJib";
            this.lblCreateJib.Size = new System.Drawing.Size(79, 19);
            this.lblCreateJib.TabIndex = 1;
            this.lblCreateJib.Text = "Create Job:";
            // 
            // pnlJobs
            // 
            this.pnlJobs.BackColor = System.Drawing.Color.White;
            this.pnlJobs.Controls.Add(this.lstJobs);
            this.pnlJobs.Controls.Add(this.btnAssignJob);
            this.pnlJobs.Controls.Add(this.btnDeleteJob);
            this.pnlJobs.Controls.Add(this.lblContractJobs);
            this.pnlJobs.Controls.Add(this.btnUpdateJob);
            this.pnlJobs.Controls.Add(this.lblExperationDate);
            this.pnlJobs.Controls.Add(this.lblServiceLevel);
            this.pnlJobs.Controls.Add(this.btnCreateJob);
            this.pnlJobs.Controls.Add(this.textBox1);
            this.pnlJobs.Controls.Add(this.lblDescription);
            this.pnlJobs.Controls.Add(this.comboBox1);
            this.pnlJobs.Controls.Add(this.lblType);
            this.pnlJobs.Controls.Add(this.lblCategory);
            this.pnlJobs.Controls.Add(this.cmbService);
            this.pnlJobs.Controls.Add(this.lblCreateJib);
            this.pnlJobs.Location = new System.Drawing.Point(3, 4);
            this.pnlJobs.Name = "pnlJobs";
            this.pnlJobs.Size = new System.Drawing.Size(845, 514);
            this.pnlJobs.TabIndex = 11;
            // 
            // lblExperationDate
            // 
            this.lblExperationDate.AutoSize = true;
            this.lblExperationDate.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lblExperationDate.Location = new System.Drawing.Point(15, 45);
            this.lblExperationDate.Name = "lblExperationDate";
            this.lblExperationDate.Size = new System.Drawing.Size(146, 25);
            this.lblExperationDate.TabIndex = 21;
            this.lblExperationDate.Text = "experation date";
            // 
            // lblServiceLevel
            // 
            this.lblServiceLevel.AutoSize = true;
            this.lblServiceLevel.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lblServiceLevel.Location = new System.Drawing.Point(15, 5);
            this.lblServiceLevel.Name = "lblServiceLevel";
            this.lblServiceLevel.Size = new System.Drawing.Size(130, 25);
            this.lblServiceLevel.TabIndex = 20;
            this.lblServiceLevel.Text = "service detail";
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCreateJob.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateJob.Location = new System.Drawing.Point(18, 220);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(141, 36);
            this.btnCreateJob.TabIndex = 14;
            this.btnCreateJob.Text = "Create Job";
            this.btnCreateJob.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox1.Location = new System.Drawing.Point(104, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(712, 26);
            this.textBox1.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDescription.Location = new System.Drawing.Point(17, 121);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblType.Location = new System.Drawing.Point(17, 183);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblCategory.Location = new System.Drawing.Point(17, 153);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category:";
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(104, 151);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(109, 21);
            this.cmbService.TabIndex = 14;
            // 
            // btnUpdateJob
            // 
            this.btnUpdateJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnUpdateJob.ForeColor = System.Drawing.Color.Magenta;
            this.btnUpdateJob.Location = new System.Drawing.Point(165, 220);
            this.btnUpdateJob.Name = "btnUpdateJob";
            this.btnUpdateJob.Size = new System.Drawing.Size(141, 36);
            this.btnUpdateJob.TabIndex = 22;
            this.btnUpdateJob.Text = "Update Job";
            this.btnUpdateJob.UseVisualStyleBackColor = true;
            // 
            // lblContractJobs
            // 
            this.lblContractJobs.AutoSize = true;
            this.lblContractJobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblContractJobs.Location = new System.Drawing.Point(16, 264);
            this.lblContractJobs.Name = "lblContractJobs";
            this.lblContractJobs.Size = new System.Drawing.Size(97, 19);
            this.lblContractJobs.TabIndex = 23;
            this.lblContractJobs.Text = "Contract Jobs:";
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDeleteJob.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteJob.Location = new System.Drawing.Point(312, 220);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(141, 36);
            this.btnDeleteJob.TabIndex = 24;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAssignJob.Location = new System.Drawing.Point(675, 220);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(141, 36);
            this.btnAssignJob.TabIndex = 25;
            this.btnAssignJob.Text = "Assign Job";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            // 
            // lstJobs
            // 
            this.lstJobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 19;
            this.lstJobs.Location = new System.Drawing.Point(20, 286);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(796, 213);
            this.lstJobs.TabIndex = 26;
            // 
            // FrmServiceDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 538);
            this.Controls.Add(this.pnlJobs);
            this.MaximizeBox = false;
            this.Name = "FrmServiceDepartment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceDepartment";
            this.Load += new System.EventHandler(this.FrmServiceDepartment_Load);
            this.pnlJobs.ResumeLayout(false);
            this.pnlJobs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCreateJib;
        private System.Windows.Forms.Panel pnlJobs;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label lblExperationDate;
        private System.Windows.Forms.Label lblServiceLevel;
        private System.Windows.Forms.Button btnCreateJob;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnUpdateJob;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Label lblContractJobs;
        private System.Windows.Forms.ListBox lstJobs;
    }
}