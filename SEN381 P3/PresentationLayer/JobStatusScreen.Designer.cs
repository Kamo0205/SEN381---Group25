
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
            this.grbRating = new System.Windows.Forms.GroupBox();
            this.rdFiveStar = new System.Windows.Forms.RadioButton();
            this.rdFourStar = new System.Windows.Forms.RadioButton();
            this.rdThreeStar = new System.Windows.Forms.RadioButton();
            this.rdTwoStar = new System.Windows.Forms.RadioButton();
            this.rdOneStar = new System.Windows.Forms.RadioButton();
            this.grbRating.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstJobs
            // 
            this.lstJobs.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 22;
            this.lstJobs.Location = new System.Drawing.Point(16, 55);
            this.lstJobs.Margin = new System.Windows.Forms.Padding(4);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(1033, 202);
            this.lstJobs.TabIndex = 27;
            this.lstJobs.SelectedIndexChanged += new System.EventHandler(this.lstJobs_SelectedIndexChanged);
            // 
            // lblContractJobs
            // 
            this.lblContractJobs.AutoSize = true;
            this.lblContractJobs.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblContractJobs.Location = new System.Drawing.Point(8, 11);
            this.lblContractJobs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContractJobs.Name = "lblContractJobs";
            this.lblContractJobs.Size = new System.Drawing.Size(209, 39);
            this.lblContractJobs.TabIndex = 28;
            this.lblContractJobs.Text = "Contract Jobs:";
            // 
            // trvJobStatus
            // 
            this.trvJobStatus.Location = new System.Drawing.Point(16, 335);
            this.trvJobStatus.Margin = new System.Windows.Forms.Padding(4);
            this.trvJobStatus.Name = "trvJobStatus";
            this.trvJobStatus.Size = new System.Drawing.Size(1033, 149);
            this.trvJobStatus.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.label1.Location = new System.Drawing.Point(16, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "Job Status:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 516);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 44);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grbRating
            // 
            this.grbRating.Controls.Add(this.rdFiveStar);
            this.grbRating.Controls.Add(this.rdFourStar);
            this.grbRating.Controls.Add(this.rdThreeStar);
            this.grbRating.Controls.Add(this.rdTwoStar);
            this.grbRating.Controls.Add(this.rdOneStar);
            this.grbRating.Location = new System.Drawing.Point(750, 506);
            this.grbRating.Margin = new System.Windows.Forms.Padding(4);
            this.grbRating.Name = "grbRating";
            this.grbRating.Padding = new System.Windows.Forms.Padding(4);
            this.grbRating.Size = new System.Drawing.Size(299, 54);
            this.grbRating.TabIndex = 32;
            this.grbRating.TabStop = false;
            this.grbRating.Text = "Rating";
            // 
            // rdFiveStar
            // 
            this.rdFiveStar.AutoSize = true;
            this.rdFiveStar.Location = new System.Drawing.Point(237, 23);
            this.rdFiveStar.Margin = new System.Windows.Forms.Padding(4);
            this.rdFiveStar.Name = "rdFiveStar";
            this.rdFiveStar.Size = new System.Drawing.Size(45, 21);
            this.rdFiveStar.TabIndex = 15;
            this.rdFiveStar.TabStop = true;
            this.rdFiveStar.Text = "🌟";
            this.rdFiveStar.UseVisualStyleBackColor = true;
            this.rdFiveStar.CheckedChanged += new System.EventHandler(this.rdFiveStar_CheckedChanged);
            // 
            // rdFourStar
            // 
            this.rdFourStar.AutoSize = true;
            this.rdFourStar.Location = new System.Drawing.Point(180, 23);
            this.rdFourStar.Margin = new System.Windows.Forms.Padding(4);
            this.rdFourStar.Name = "rdFourStar";
            this.rdFourStar.Size = new System.Drawing.Size(45, 21);
            this.rdFourStar.TabIndex = 14;
            this.rdFourStar.TabStop = true;
            this.rdFourStar.Text = "🌟";
            this.rdFourStar.UseVisualStyleBackColor = true;
            this.rdFourStar.CheckedChanged += new System.EventHandler(this.rdFourStar_CheckedChanged);
            // 
            // rdThreeStar
            // 
            this.rdThreeStar.AutoSize = true;
            this.rdThreeStar.Location = new System.Drawing.Point(123, 23);
            this.rdThreeStar.Margin = new System.Windows.Forms.Padding(4);
            this.rdThreeStar.Name = "rdThreeStar";
            this.rdThreeStar.Size = new System.Drawing.Size(45, 21);
            this.rdThreeStar.TabIndex = 13;
            this.rdThreeStar.TabStop = true;
            this.rdThreeStar.Text = "🌟";
            this.rdThreeStar.UseVisualStyleBackColor = true;
            this.rdThreeStar.CheckedChanged += new System.EventHandler(this.rdThreeStar_CheckedChanged);
            // 
            // rdTwoStar
            // 
            this.rdTwoStar.AutoSize = true;
            this.rdTwoStar.Location = new System.Drawing.Point(65, 23);
            this.rdTwoStar.Margin = new System.Windows.Forms.Padding(4);
            this.rdTwoStar.Name = "rdTwoStar";
            this.rdTwoStar.Size = new System.Drawing.Size(45, 21);
            this.rdTwoStar.TabIndex = 12;
            this.rdTwoStar.TabStop = true;
            this.rdTwoStar.Text = "🌟";
            this.rdTwoStar.UseVisualStyleBackColor = true;
            this.rdTwoStar.CheckedChanged += new System.EventHandler(this.rdTwoStar_CheckedChanged);
            // 
            // rdOneStar
            // 
            this.rdOneStar.AutoSize = true;
            this.rdOneStar.Location = new System.Drawing.Point(8, 23);
            this.rdOneStar.Margin = new System.Windows.Forms.Padding(4);
            this.rdOneStar.Name = "rdOneStar";
            this.rdOneStar.Size = new System.Drawing.Size(45, 21);
            this.rdOneStar.TabIndex = 11;
            this.rdOneStar.TabStop = true;
            this.rdOneStar.Text = "🌟";
            this.rdOneStar.UseVisualStyleBackColor = true;
            this.rdOneStar.CheckedChanged += new System.EventHandler(this.rdOneStar_CheckedChanged);
            // 
            // JobStatusScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 575);
            this.Controls.Add(this.grbRating);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trvJobStatus);
            this.Controls.Add(this.lblContractJobs);
            this.Controls.Add(this.lstJobs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobStatusScreen";
            this.Text = "JobStatusScreen";
            this.Load += new System.EventHandler(this.JobStatusScreen_Load);
            this.grbRating.ResumeLayout(false);
            this.grbRating.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstJobs;
        private System.Windows.Forms.Label lblContractJobs;
        private System.Windows.Forms.TreeView trvJobStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grbRating;
        private System.Windows.Forms.RadioButton rdFiveStar;
        private System.Windows.Forms.RadioButton rdFourStar;
        private System.Windows.Forms.RadioButton rdThreeStar;
        private System.Windows.Forms.RadioButton rdTwoStar;
        private System.Windows.Forms.RadioButton rdOneStar;
    }
}