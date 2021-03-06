namespace Presentation_Layer
{
    partial class FrmCallCenter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCallCenter));
            this.pnlCaller = new System.Windows.Forms.Panel();
            this.lblCallLoad = new System.Windows.Forms.Label();
            this.btnLeaveCall = new System.Windows.Forms.Button();
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.lblCallerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientScreen = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.pnlCaller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCaller
            // 
            this.pnlCaller.BackColor = System.Drawing.Color.White;
            this.pnlCaller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCaller.Controls.Add(this.lblCallLoad);
            this.pnlCaller.Controls.Add(this.btnLeaveCall);
            this.pnlCaller.Controls.Add(this.btnAnswerCall);
            this.pnlCaller.Controls.Add(this.lblCallerName);
            this.pnlCaller.Controls.Add(this.pictureBox1);
            this.pnlCaller.Location = new System.Drawing.Point(716, 5);
            this.pnlCaller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCaller.Name = "pnlCaller";
            this.pnlCaller.Size = new System.Drawing.Size(339, 524);
            this.pnlCaller.TabIndex = 0;
            // 
            // lblCallLoad
            // 
            this.lblCallLoad.AutoSize = true;
            this.lblCallLoad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallLoad.Location = new System.Drawing.Point(9, 22);
            this.lblCallLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCallLoad.Name = "lblCallLoad";
            this.lblCallLoad.Size = new System.Drawing.Size(147, 26);
            this.lblCallLoad.TabIndex = 3;
            this.lblCallLoad.Text = "Connecting...";
            this.lblCallLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLeaveCall
            // 
            this.btnLeaveCall.BackColor = System.Drawing.Color.Red;
            this.btnLeaveCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeaveCall.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveCall.Location = new System.Drawing.Point(61, 450);
            this.btnLeaveCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeaveCall.Name = "btnLeaveCall";
            this.btnLeaveCall.Size = new System.Drawing.Size(215, 43);
            this.btnLeaveCall.TabIndex = 4;
            this.btnLeaveCall.Text = "Leave Call";
            this.btnLeaveCall.UseVisualStyleBackColor = false;
            this.btnLeaveCall.Click += new System.EventHandler(this.btnLeaveCall_Click);
            // 
            // btnAnswerCall
            // 
            this.btnAnswerCall.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAnswerCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswerCall.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerCall.Location = new System.Drawing.Point(52, 379);
            this.btnAnswerCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.Size = new System.Drawing.Size(237, 55);
            this.btnAnswerCall.TabIndex = 3;
            this.btnAnswerCall.Text = "Answer Call";
            this.btnAnswerCall.UseVisualStyleBackColor = false;
            this.btnAnswerCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // lblCallerName
            // 
            this.lblCallerName.AutoSize = true;
            this.lblCallerName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallerName.Location = new System.Drawing.Point(4, 299);
            this.lblCallerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCallerName.Name = "lblCallerName";
            this.lblCallerName.Size = new System.Drawing.Size(201, 38);
            this.lblCallerName.TabIndex = 2;
            this.lblCallerName.Text = "Caller Name";
            this.lblCallerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(19, 17);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(282, 48);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "employee name";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(19, 96);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(95, 22);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(19, 124);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(265, 22);
            this.dtStartDate.TabIndex = 4;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Enabled = false;
            this.dtEndDate.Location = new System.Drawing.Point(293, 124);
            this.dtEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(265, 22);
            this.dtEndDate.TabIndex = 6;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(293, 96);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(89, 22);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClientScreen);
            this.panel1.Controls.Add(this.lblEmployeeName);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.dtStartDate);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.dtEndDate);
            this.panel1.Location = new System.Drawing.Point(7, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 391);
            this.panel1.TabIndex = 7;
            // 
            // btnClientScreen
            // 
            this.btnClientScreen.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnClientScreen.Location = new System.Drawing.Point(19, 180);
            this.btnClientScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientScreen.Name = "btnClientScreen";
            this.btnClientScreen.Size = new System.Drawing.Size(184, 41);
            this.btnClientScreen.TabIndex = 12;
            this.btnClientScreen.Text = "Client Screen";
            this.btnClientScreen.UseVisualStyleBackColor = true;
            this.btnClientScreen.Click += new System.EventHandler(this.btnClientScreen_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSignOut.Location = new System.Drawing.Point(36, 459);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(149, 41);
            this.btnSignOut.TabIndex = 11;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnAddEmployee.Location = new System.Drawing.Point(494, 459);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(184, 41);
            this.btnAddEmployee.TabIndex = 13;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // FrmCallCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1067, 537);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCaller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCallCenter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallCenter";
            this.Load += new System.EventHandler(this.FrmCallCenter_Load);
            this.pnlCaller.ResumeLayout(false);
            this.pnlCaller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCaller;
        private System.Windows.Forms.Label lblCallerName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCallLoad;
        private System.Windows.Forms.Button btnLeaveCall;
        private System.Windows.Forms.Button btnAnswerCall;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Button btnClientScreen;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}