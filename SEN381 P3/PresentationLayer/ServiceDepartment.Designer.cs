namespace Presentation_Layer
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
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.lblContractJobs = new System.Windows.Forms.Label();
            this.btnUpdateJob = new System.Windows.Forms.Button();
            this.lblExperationDate = new System.Windows.Forms.Label();
            this.lblServiceLevel = new System.Windows.Forms.Label();
            this.btnCreateJob = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbJobType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbJobCategory = new System.Windows.Forms.ComboBox();
            this.pnlJobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateJib
            // 
            this.lblCreateJib.AutoSize = true;
            this.lblCreateJib.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblCreateJib.Location = new System.Drawing.Point(21, 105);
            this.lblCreateJib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateJib.Name = "lblCreateJib";
            this.lblCreateJib.Size = new System.Drawing.Size(101, 22);
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
            this.pnlJobs.Controls.Add(this.txtDescription);
            this.pnlJobs.Controls.Add(this.lblDescription);
            this.pnlJobs.Controls.Add(this.cmbJobType);
            this.pnlJobs.Controls.Add(this.lblType);
            this.pnlJobs.Controls.Add(this.lblCategory);
            this.pnlJobs.Controls.Add(this.cmbJobCategory);
            this.pnlJobs.Controls.Add(this.lblCreateJib);
            this.pnlJobs.Location = new System.Drawing.Point(4, 5);
            this.pnlJobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlJobs.Name = "pnlJobs";
            this.pnlJobs.Size = new System.Drawing.Size(1127, 633);
            this.pnlJobs.TabIndex = 11;
            // 
            // lstJobs
            // 
            this.lstJobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 22;
            this.lstJobs.Location = new System.Drawing.Point(27, 352);
            this.lstJobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(1060, 246);
            this.lstJobs.TabIndex = 26;
            this.lstJobs.SelectedIndexChanged += new System.EventHandler(this.lstJobs_SelectedIndexChanged);
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAssignJob.Location = new System.Drawing.Point(900, 271);
            this.btnAssignJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(188, 44);
            this.btnAssignJob.TabIndex = 25;
            this.btnAssignJob.Text = "Assign Job";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            this.btnAssignJob.Click += new System.EventHandler(this.btnAssignJob_Click);
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDeleteJob.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteJob.Location = new System.Drawing.Point(416, 271);
            this.btnDeleteJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(188, 44);
            this.btnDeleteJob.TabIndex = 24;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // lblContractJobs
            // 
            this.lblContractJobs.AutoSize = true;
            this.lblContractJobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblContractJobs.Location = new System.Drawing.Point(21, 325);
            this.lblContractJobs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContractJobs.Name = "lblContractJobs";
            this.lblContractJobs.Size = new System.Drawing.Size(124, 22);
            this.lblContractJobs.TabIndex = 23;
            this.lblContractJobs.Text = "Contract Jobs:";
            // 
            // btnUpdateJob
            // 
            this.btnUpdateJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnUpdateJob.ForeColor = System.Drawing.Color.Magenta;
            this.btnUpdateJob.Location = new System.Drawing.Point(220, 271);
            this.btnUpdateJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateJob.Name = "btnUpdateJob";
            this.btnUpdateJob.Size = new System.Drawing.Size(188, 44);
            this.btnUpdateJob.TabIndex = 22;
            this.btnUpdateJob.Text = "Update Job";
            this.btnUpdateJob.UseVisualStyleBackColor = true;
            this.btnUpdateJob.Click += new System.EventHandler(this.btnUpdateJob_Click);
            // 
            // lblExperationDate
            // 
            this.lblExperationDate.AutoSize = true;
            this.lblExperationDate.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lblExperationDate.Location = new System.Drawing.Point(20, 55);
            this.lblExperationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExperationDate.Name = "lblExperationDate";
            this.lblExperationDate.Size = new System.Drawing.Size(182, 31);
            this.lblExperationDate.TabIndex = 21;
            this.lblExperationDate.Text = "experation date";
            // 
            // lblServiceLevel
            // 
            this.lblServiceLevel.AutoSize = true;
            this.lblServiceLevel.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lblServiceLevel.Location = new System.Drawing.Point(20, 6);
            this.lblServiceLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceLevel.Name = "lblServiceLevel";
            this.lblServiceLevel.Size = new System.Drawing.Size(156, 31);
            this.lblServiceLevel.TabIndex = 20;
            this.lblServiceLevel.Text = "service detail";
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCreateJob.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateJob.Location = new System.Drawing.Point(24, 271);
            this.btnCreateJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(188, 44);
            this.btnCreateJob.TabIndex = 14;
            this.btnCreateJob.Text = "Create Job";
            this.btnCreateJob.UseVisualStyleBackColor = true;
            this.btnCreateJob.Click += new System.EventHandler(this.btnCreateJob_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDescription.Location = new System.Drawing.Point(139, 142);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(948, 30);
            this.txtDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDescription.Location = new System.Drawing.Point(23, 149);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 19);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:";
            // 
            // cmbJobType
            // 
            this.cmbJobType.FormattingEnabled = true;
            this.cmbJobType.Location = new System.Drawing.Point(139, 225);
            this.cmbJobType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJobType.Name = "cmbJobType";
            this.cmbJobType.Size = new System.Drawing.Size(144, 24);
            this.cmbJobType.TabIndex = 17;
            this.cmbJobType.SelectedIndexChanged += new System.EventHandler(this.cmbJobType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblType.Location = new System.Drawing.Point(23, 225);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 19);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblCategory.Location = new System.Drawing.Point(23, 188);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 19);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category:";
            // 
            // cmbJobCategory
            // 
            this.cmbJobCategory.FormattingEnabled = true;
            this.cmbJobCategory.Location = new System.Drawing.Point(139, 186);
            this.cmbJobCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJobCategory.Name = "cmbJobCategory";
            this.cmbJobCategory.Size = new System.Drawing.Size(144, 24);
            this.cmbJobCategory.TabIndex = 14;
            this.cmbJobCategory.SelectedIndexChanged += new System.EventHandler(this.cmbJobCategory_SelectedIndexChanged);
            // 
            // FrmServiceDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 662);
            this.Controls.Add(this.pnlJobs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox cmbJobCategory;
        private System.Windows.Forms.Label lblExperationDate;
        private System.Windows.Forms.Label lblServiceLevel;
        private System.Windows.Forms.Button btnCreateJob;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbJobType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnUpdateJob;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Label lblContractJobs;
        private System.Windows.Forms.ListBox lstJobs;
    }
}