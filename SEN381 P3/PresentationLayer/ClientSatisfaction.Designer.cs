namespace Presentation_Layer
{
    partial class FrmClientSatisfaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientSatisfaction));
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.btnContractScreen = new System.Windows.Forms.Button();
            this.btnPersonalDetails = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.pnlCaller = new System.Windows.Forms.Panel();
            this.lblCallLoad = new System.Windows.Forms.Label();
            this.btnLeaveCall = new System.Windows.Forms.Button();
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.lblCallerName = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.pnlClient.SuspendLayout();
            this.pnlCaller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSignOut.Location = new System.Drawing.Point(35, 469);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(120, 41);
            this.btnSignOut.TabIndex = 14;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlClient
            // 
            this.pnlClient.BackColor = System.Drawing.Color.White;
            this.pnlClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClient.Controls.Add(this.btnContractScreen);
            this.pnlClient.Controls.Add(this.btnPersonalDetails);
            this.pnlClient.Controls.Add(this.lblClientName);
            this.pnlClient.Location = new System.Drawing.Point(9, 20);
            this.pnlClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(671, 391);
            this.pnlClient.TabIndex = 13;
            // 
            // btnContractScreen
            // 
            this.btnContractScreen.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnContractScreen.Location = new System.Drawing.Point(23, 204);
            this.btnContractScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContractScreen.Name = "btnContractScreen";
            this.btnContractScreen.Size = new System.Drawing.Size(153, 41);
            this.btnContractScreen.TabIndex = 15;
            this.btnContractScreen.Text = "Contracts";
            this.btnContractScreen.UseVisualStyleBackColor = true;
            this.btnContractScreen.Click += new System.EventHandler(this.btnContractScreen_Click);
            // 
            // btnPersonalDetails
            // 
            this.btnPersonalDetails.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnPersonalDetails.Location = new System.Drawing.Point(23, 100);
            this.btnPersonalDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPersonalDetails.Name = "btnPersonalDetails";
            this.btnPersonalDetails.Size = new System.Drawing.Size(153, 64);
            this.btnPersonalDetails.TabIndex = 16;
            this.btnPersonalDetails.Text = "Personal Details";
            this.btnPersonalDetails.UseVisualStyleBackColor = true;
            this.btnPersonalDetails.Click += new System.EventHandler(this.btnPersonalDetails_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(15, 17);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(247, 48);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client Name:";
            // 
            // pnlCaller
            // 
            this.pnlCaller.BackColor = System.Drawing.Color.White;
            this.pnlCaller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCaller.Controls.Add(this.lblCallLoad);
            this.pnlCaller.Controls.Add(this.btnLeaveCall);
            this.pnlCaller.Controls.Add(this.btnMakeCall);
            this.pnlCaller.Controls.Add(this.lblCallerName);
            this.pnlCaller.Controls.Add(this.picAvatar);
            this.pnlCaller.Location = new System.Drawing.Point(719, 15);
            this.pnlCaller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCaller.Name = "pnlCaller";
            this.pnlCaller.Size = new System.Drawing.Size(339, 524);
            this.pnlCaller.TabIndex = 12;
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
            this.lblCallLoad.Text = "On standby...";
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
            // btnMakeCall
            // 
            this.btnMakeCall.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMakeCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeCall.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeCall.Location = new System.Drawing.Point(52, 379);
            this.btnMakeCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(237, 55);
            this.btnMakeCall.TabIndex = 3;
            this.btnMakeCall.Text = "Make Call";
            this.btnMakeCall.UseVisualStyleBackColor = false;
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // lblCallerName
            // 
            this.lblCallerName.AutoSize = true;
            this.lblCallerName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallerName.Location = new System.Drawing.Point(60, 302);
            this.lblCallerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCallerName.Name = "lblCallerName";
            this.lblCallerName.Size = new System.Drawing.Size(201, 38);
            this.lblCallerName.TabIndex = 2;
            this.lblCallerName.Text = "Caller Name";
            this.lblCallerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(81, 69);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(185, 214);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // FrmClientSatisfaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.pnlCaller);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmClientSatisfaction";
            this.ShowIcon = false;
            this.Text = "ClientSatisfaction";
            this.Load += new System.EventHandler(this.FrmClientSatisfaction_Load);
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.pnlCaller.ResumeLayout(false);
            this.pnlCaller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Panel pnlCaller;
        private System.Windows.Forms.Label lblCallLoad;
        private System.Windows.Forms.Button btnLeaveCall;
        private System.Windows.Forms.Button btnMakeCall;
        private System.Windows.Forms.Label lblCallerName;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Button btnPersonalDetails;
        private System.Windows.Forms.Button btnContractScreen;
    }
}