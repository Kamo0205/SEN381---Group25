namespace PresentationLayer
{
    partial class FrmChooseDepartments
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
            this.btnCallCenter = new System.Windows.Forms.Button();
            this.btnServiceDepartment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallCenter
            // 
            this.btnCallCenter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCallCenter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCallCenter.Location = new System.Drawing.Point(50, 31);
            this.btnCallCenter.Name = "btnCallCenter";
            this.btnCallCenter.Size = new System.Drawing.Size(128, 74);
            this.btnCallCenter.TabIndex = 2;
            this.btnCallCenter.Text = "Call Center";
            this.btnCallCenter.UseVisualStyleBackColor = true;
            // 
            // btnServiceDepartment
            // 
            this.btnServiceDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServiceDepartment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnServiceDepartment.Location = new System.Drawing.Point(50, 131);
            this.btnServiceDepartment.Name = "btnServiceDepartment";
            this.btnServiceDepartment.Size = new System.Drawing.Size(128, 74);
            this.btnServiceDepartment.TabIndex = 3;
            this.btnServiceDepartment.Text = "Service Department";
            this.btnServiceDepartment.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(50, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "Client Functions";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(74, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmChooseDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(232, 374);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnServiceDepartment);
            this.Controls.Add(this.btnCallCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmChooseDepartments";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseDepartments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCallCenter;
        private System.Windows.Forms.Button btnServiceDepartment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
    }
}