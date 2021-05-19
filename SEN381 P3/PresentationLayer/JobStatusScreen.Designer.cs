
namespace Presentation_Layer
{
    partial class JobStatusScreen
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
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.lblContractJobs = new System.Windows.Forms.Label();
            this.trvJobStatus = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstJobs
            // 
            this.lstJobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 19;
            this.lstJobs.Location = new System.Drawing.Point(12, 45);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(776, 175);
            this.lstJobs.TabIndex = 27;
            this.lstJobs.SelectedIndexChanged += new System.EventHandler(this.lstJobs_SelectedIndexChanged);
            // 
            // lblContractJobs
            // 
            this.lblContractJobs.AutoSize = true;
            this.lblContractJobs.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblContractJobs.Location = new System.Drawing.Point(6, 9);
            this.lblContractJobs.Name = "lblContractJobs";
            this.lblContractJobs.Size = new System.Drawing.Size(170, 31);
            this.lblContractJobs.TabIndex = 28;
            this.lblContractJobs.Text = "Contract Jobs:";
            // 
            // trvJobStatus
            // 
            this.trvJobStatus.Location = new System.Drawing.Point(12, 272);
            this.trvJobStatus.Name = "trvJobStatus";
            this.trvJobStatus.Size = new System.Drawing.Size(776, 122);
            this.trvJobStatus.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Job Status:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 36);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // JobStatusScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trvJobStatus);
            this.Controls.Add(this.lblContractJobs);
            this.Controls.Add(this.lstJobs);
            this.Name = "JobStatusScreen";
            this.Text = "JobStatusScreen";
            this.Load += new System.EventHandler(this.JobStatusScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstJobs;
        private System.Windows.Forms.Label lblContractJobs;
        private System.Windows.Forms.TreeView trvJobStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}