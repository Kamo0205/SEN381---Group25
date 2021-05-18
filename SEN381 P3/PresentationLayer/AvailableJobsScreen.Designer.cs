
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
            this.lstAvailableJobs = new System.Windows.Forms.ListView();
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
            this.SuspendLayout();
            // 
            // lstAvailableJobs
            // 
            this.lstAvailableJobs.HideSelection = false;
            this.lstAvailableJobs.Location = new System.Drawing.Point(20, 52);
            this.lstAvailableJobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAvailableJobs.Name = "lstAvailableJobs";
            this.lstAvailableJobs.Size = new System.Drawing.Size(1023, 198);
            this.lstAvailableJobs.TabIndex = 0;
            this.lstAvailableJobs.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Jobs:";
            // 
            // btnTakeJob
            // 
            this.btnTakeJob.Location = new System.Drawing.Point(847, 485);
            this.btnTakeJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTakeJob.Name = "btnTakeJob";
            this.btnTakeJob.Size = new System.Drawing.Size(197, 54);
            this.btnTakeJob.TabIndex = 2;
            this.btnTakeJob.Text = "Take Job";
            this.btnTakeJob.UseVisualStyleBackColor = true;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(20, 485);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(197, 54);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client details:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(32, 306);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(160, 29);
            this.lblClientName.TabIndex = 5;
            this.lblClientName.Text = "Client Name:";
            this.lblClientName.Visible = false;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(28, 350);
            this.lblClientAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(185, 29);
            this.lblClientAddress.TabIndex = 6;
            this.lblClientAddress.Text = "Client Address:";
            this.lblClientAddress.Visible = false;
            // 
            // lblClientServiceLevel
            // 
            this.lblClientServiceLevel.AutoSize = true;
            this.lblClientServiceLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientServiceLevel.Location = new System.Drawing.Point(32, 394);
            this.lblClientServiceLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientServiceLevel.Name = "lblClientServiceLevel";
            this.lblClientServiceLevel.Size = new System.Drawing.Size(173, 29);
            this.lblClientServiceLevel.TabIndex = 7;
            this.lblClientServiceLevel.Text = "Service Level:";
            this.lblClientServiceLevel.Visible = false;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(231, 314);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(421, 22);
            this.txtClientName.TabIndex = 8;
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(231, 357);
            this.txtClientAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.ReadOnly = true;
            this.txtClientAddress.Size = new System.Drawing.Size(421, 22);
            this.txtClientAddress.TabIndex = 9;
            // 
            // txtServiceLevel
            // 
            this.txtServiceLevel.Location = new System.Drawing.Point(231, 401);
            this.txtServiceLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServiceLevel.Name = "txtServiceLevel";
            this.txtServiceLevel.ReadOnly = true;
            this.txtServiceLevel.Size = new System.Drawing.Size(421, 22);
            this.txtServiceLevel.TabIndex = 10;
            // 
            // AvailableJobsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Controls.Add(this.lstAvailableJobs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AvailableJobsScreen";
            this.Text = "AvailableJobsScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstAvailableJobs;
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
    }
}