
namespace Presentation_Layer
{
    partial class AssignJobScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.lblTechnicians = new System.Windows.Forms.Label();
            this.lstTechnicians = new System.Windows.Forms.ListBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAssignJob);
            this.panel1.Controls.Add(this.lblTechnicians);
            this.panel1.Controls.Add(this.lstTechnicians);
            this.panel1.Controls.Add(this.lblEmployeeName);
            this.panel1.Controls.Add(this.txtEmployeeName);
            this.panel1.Controls.Add(this.lblSkill);
            this.panel1.Controls.Add(this.txtSkill);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 259);
            this.panel1.TabIndex = 13;
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAssignJob.Location = new System.Drawing.Point(661, 186);
            this.btnAssignJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(155, 36);
            this.btnAssignJob.TabIndex = 20;
            this.btnAssignJob.Text = "Assign Job";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            this.btnAssignJob.Click += new System.EventHandler(this.btnAssignJob_Click);
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
            // lstTechnicians
            // 
            this.lstTechnicians.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lstTechnicians.FormattingEnabled = true;
            this.lstTechnicians.ItemHeight = 19;
            this.lstTechnicians.Location = new System.Drawing.Point(7, 28);
            this.lstTechnicians.Name = "lstTechnicians";
            this.lstTechnicians.Size = new System.Drawing.Size(644, 194);
            this.lstTechnicians.TabIndex = 0;
            this.lstTechnicians.SelectedIndexChanged += new System.EventHandler(this.lstTechnicians_SelectedIndexChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblEmployeeName.Location = new System.Drawing.Point(657, 23);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(113, 19);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtEmployeeName.Location = new System.Drawing.Point(661, 46);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(155, 26);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblSkill.Location = new System.Drawing.Point(657, 72);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(38, 19);
            this.lblSkill.TabIndex = 4;
            this.lblSkill.Text = "Skill:";
            // 
            // txtSkill
            // 
            this.txtSkill.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSkill.Location = new System.Drawing.Point(661, 95);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.Size = new System.Drawing.Size(155, 26);
            this.txtSkill.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnHome.Location = new System.Drawing.Point(719, 293);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 36);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnBack.Location = new System.Drawing.Point(19, 293);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 36);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // AssignJobScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 341);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel1);
            this.Name = "AssignJobScreen";
            this.Text = "AssignJobScreen";
            this.Load += new System.EventHandler(this.AssignJobScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.Label lblTechnicians;
        private System.Windows.Forms.ListBox lstTechnicians;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.TextBox txtSkill;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
    }
}