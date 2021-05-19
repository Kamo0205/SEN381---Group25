
namespace Presentation_Layer
{
    partial class AvailableJobsScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTakeJob = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.lblClientServiceLevel = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.txtServiceLevel = new System.Windows.Forms.TextBox();
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Jobs:";
            // 
            // btnTakeJob
            // 
            this.btnTakeJob.Location = new System.Drawing.Point(635, 394);
            this.btnTakeJob.Name = "btnTakeJob";
            this.btnTakeJob.Size = new System.Drawing.Size(148, 44);
            this.btnTakeJob.TabIndex = 2;
            this.btnTakeJob.Text = "Take Job";
            this.btnTakeJob.UseVisualStyleBackColor = true;
            this.btnTakeJob.Click += new System.EventHandler(this.btnTakeJob_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(15, 394);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(148, 44);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client details:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(24, 249);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(125, 25);
            this.lblClientName.TabIndex = 5;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(21, 284);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(146, 25);
            this.lblClientAddress.TabIndex = 6;
            this.lblClientAddress.Text = "Client Address:";
            // 
            // lblClientServiceLevel
            // 
            this.lblClientServiceLevel.AutoSize = true;
            this.lblClientServiceLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientServiceLevel.Location = new System.Drawing.Point(24, 320);
            this.lblClientServiceLevel.Name = "lblClientServiceLevel";
            this.lblClientServiceLevel.Size = new System.Drawing.Size(136, 25);
            this.lblClientServiceLevel.TabIndex = 7;
            this.lblClientServiceLevel.Text = "Service Level:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(173, 255);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(317, 20);
            this.txtClientName.TabIndex = 8;
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(173, 290);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.ReadOnly = true;
            this.txtClientAddress.Size = new System.Drawing.Size(317, 20);
            this.txtClientAddress.TabIndex = 9;
            // 
            // txtServiceLevel
            // 
            this.txtServiceLevel.Location = new System.Drawing.Point(173, 326);
            this.txtServiceLevel.Name = "txtServiceLevel";
            this.txtServiceLevel.ReadOnly = true;
            this.txtServiceLevel.Size = new System.Drawing.Size(317, 20);
            this.txtServiceLevel.TabIndex = 10;
            // 
            // lstJobs
            // 
            this.lstJobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 19;
            this.lstJobs.Location = new System.Drawing.Point(26, 40);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(757, 194);
            this.lstJobs.TabIndex = 11;
            this.lstJobs.SelectedIndexChanged += new System.EventHandler(this.lstJobs_SelectedIndexChanged);
            // 
            // AvailableJobsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstJobs);
            this.Controls.Add(this.txtServiceLevel);
            this.Controls.Add(this.txtClientAddress);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientServiceLevel);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnTakeJob);
            this.Controls.Add(this.label1);
            this.Name = "AvailableJobsScreen";
            this.Text = "AvailableJobsScreen";
            this.Load += new System.EventHandler(this.AvailableJobsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTakeJob;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.Label lblClientServiceLevel;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.TextBox txtServiceLevel;
        private System.Windows.Forms.ListBox lstJobs;
    }
}