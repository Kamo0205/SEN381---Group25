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
            this.btnPersonalDetails = new System.Windows.Forms.Button();
            this.grbRating = new System.Windows.Forms.GroupBox();
            this.rdFiveStar = new System.Windows.Forms.RadioButton();
            this.rdFourStar = new System.Windows.Forms.RadioButton();
            this.rdThreeStar = new System.Windows.Forms.RadioButton();
            this.rdTwoStar = new System.Windows.Forms.RadioButton();
            this.rdOneStar = new System.Windows.Forms.RadioButton();
            this.lblClientName = new System.Windows.Forms.Label();
            this.pnlCaller = new System.Windows.Forms.Panel();
            this.lblCallLoad = new System.Windows.Forms.Label();
            this.btnLeaveCall = new System.Windows.Forms.Button();
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.lblCallerName = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.btnContractScreen = new System.Windows.Forms.Button();
            this.pnlClient.SuspendLayout();
            this.grbRating.SuspendLayout();
            this.pnlCaller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSignOut.Location = new System.Drawing.Point(26, 381);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(90, 33);
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
            this.pnlClient.Controls.Add(this.grbRating);
            this.pnlClient.Controls.Add(this.lblClientName);
            this.pnlClient.Location = new System.Drawing.Point(7, 16);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(504, 318);
            this.pnlClient.TabIndex = 13;
            // 
            // btnPersonalDetails
            // 
            this.btnPersonalDetails.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnPersonalDetails.Location = new System.Drawing.Point(18, 155);
            this.btnPersonalDetails.Name = "btnPersonalDetails";
            this.btnPersonalDetails.Size = new System.Drawing.Size(115, 52);
            this.btnPersonalDetails.TabIndex = 16;
            this.btnPersonalDetails.Text = "Personal Details";
            this.btnPersonalDetails.UseVisualStyleBackColor = true;
            this.btnPersonalDetails.Click += new System.EventHandler(this.btnPersonalDetails_Click);
            // 
            // grbRating
            // 
            this.grbRating.Controls.Add(this.rdFiveStar);
            this.grbRating.Controls.Add(this.rdFourStar);
            this.grbRating.Controls.Add(this.rdThreeStar);
            this.grbRating.Controls.Add(this.rdTwoStar);
            this.grbRating.Controls.Add(this.rdOneStar);
            this.grbRating.Location = new System.Drawing.Point(18, 83);
            this.grbRating.Name = "grbRating";
            this.grbRating.Size = new System.Drawing.Size(224, 44);
            this.grbRating.TabIndex = 12;
            this.grbRating.TabStop = false;
            this.grbRating.Text = "Rating";
            // 
            // rdFiveStar
            // 
            this.rdFiveStar.AutoSize = true;
            this.rdFiveStar.Location = new System.Drawing.Point(178, 19);
            this.rdFiveStar.Name = "rdFiveStar";
            this.rdFiveStar.Size = new System.Drawing.Size(37, 17);
            this.rdFiveStar.TabIndex = 15;
            this.rdFiveStar.TabStop = true;
            this.rdFiveStar.Text = "🌟";
            this.rdFiveStar.UseVisualStyleBackColor = true;
            this.rdFiveStar.CheckedChanged += new System.EventHandler(this.rdFiveStar_CheckedChanged);
            // 
            // rdFourStar
            // 
            this.rdFourStar.AutoSize = true;
            this.rdFourStar.Location = new System.Drawing.Point(135, 19);
            this.rdFourStar.Name = "rdFourStar";
            this.rdFourStar.Size = new System.Drawing.Size(37, 17);
            this.rdFourStar.TabIndex = 14;
            this.rdFourStar.TabStop = true;
            this.rdFourStar.Text = "🌟";
            this.rdFourStar.UseVisualStyleBackColor = true;
            this.rdFourStar.CheckedChanged += new System.EventHandler(this.rdFourStar_CheckedChanged);
            // 
            // rdThreeStar
            // 
            this.rdThreeStar.AutoSize = true;
            this.rdThreeStar.Location = new System.Drawing.Point(92, 19);
            this.rdThreeStar.Name = "rdThreeStar";
            this.rdThreeStar.Size = new System.Drawing.Size(37, 17);
            this.rdThreeStar.TabIndex = 13;
            this.rdThreeStar.TabStop = true;
            this.rdThreeStar.Text = "🌟";
            this.rdThreeStar.UseVisualStyleBackColor = true;
            this.rdThreeStar.CheckedChanged += new System.EventHandler(this.rdThreeStar_CheckedChanged);
            // 
            // rdTwoStar
            // 
            this.rdTwoStar.AutoSize = true;
            this.rdTwoStar.Location = new System.Drawing.Point(49, 19);
            this.rdTwoStar.Name = "rdTwoStar";
            this.rdTwoStar.Size = new System.Drawing.Size(37, 17);
            this.rdTwoStar.TabIndex = 12;
            this.rdTwoStar.TabStop = true;
            this.rdTwoStar.Text = "🌟";
            this.rdTwoStar.UseVisualStyleBackColor = true;
            this.rdTwoStar.CheckedChanged += new System.EventHandler(this.rdTwoStar_CheckedChanged);
            // 
            // rdOneStar
            // 
            this.rdOneStar.AutoSize = true;
            this.rdOneStar.Location = new System.Drawing.Point(6, 19);
            this.rdOneStar.Name = "rdOneStar";
            this.rdOneStar.Size = new System.Drawing.Size(37, 17);
            this.rdOneStar.TabIndex = 11;
            this.rdOneStar.TabStop = true;
            this.rdOneStar.Text = "🌟";
            this.rdOneStar.UseVisualStyleBackColor = true;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(11, 14);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(197, 39);
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
            this.pnlCaller.Location = new System.Drawing.Point(539, 12);
            this.pnlCaller.Name = "pnlCaller";
            this.pnlCaller.Size = new System.Drawing.Size(255, 426);
            this.pnlCaller.TabIndex = 12;
            // 
            // lblCallLoad
            // 
            this.lblCallLoad.AutoSize = true;
            this.lblCallLoad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallLoad.Location = new System.Drawing.Point(7, 18);
            this.lblCallLoad.Name = "lblCallLoad";
            this.lblCallLoad.Size = new System.Drawing.Size(117, 22);
            this.lblCallLoad.TabIndex = 3;
            this.lblCallLoad.Text = "On standby...";
            this.lblCallLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLeaveCall
            // 
            this.btnLeaveCall.BackColor = System.Drawing.Color.Red;
            this.btnLeaveCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeaveCall.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveCall.Location = new System.Drawing.Point(46, 366);
            this.btnLeaveCall.Name = "btnLeaveCall";
            this.btnLeaveCall.Size = new System.Drawing.Size(161, 35);
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
            this.btnMakeCall.Location = new System.Drawing.Point(39, 308);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(178, 45);
            this.btnMakeCall.TabIndex = 3;
            this.btnMakeCall.Text = "Make Call";
            this.btnMakeCall.UseVisualStyleBackColor = false;
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // lblCallerName
            // 
            this.lblCallerName.AutoSize = true;
            this.lblCallerName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallerName.Location = new System.Drawing.Point(45, 245);
            this.lblCallerName.Name = "lblCallerName";
            this.lblCallerName.Size = new System.Drawing.Size(163, 31);
            this.lblCallerName.TabIndex = 2;
            this.lblCallerName.Text = "Caller Name";
            this.lblCallerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(61, 56);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(139, 174);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // btnContractScreen
            // 
            this.btnContractScreen.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnContractScreen.Location = new System.Drawing.Point(18, 225);
            this.btnContractScreen.Name = "btnContractScreen";
            this.btnContractScreen.Size = new System.Drawing.Size(115, 33);
            this.btnContractScreen.TabIndex = 15;
            this.btnContractScreen.Text = "Contracts";
            this.btnContractScreen.UseVisualStyleBackColor = true;
            this.btnContractScreen.Click += new System.EventHandler(this.btnContractScreen_Click);
            // 
            // FrmClientSatisfaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.pnlCaller);
            this.Name = "FrmClientSatisfaction";
            this.ShowIcon = false;
            this.Text = "ClientSatisfaction";
            this.Load += new System.EventHandler(this.FrmClientSatisfaction_Load);
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.grbRating.ResumeLayout(false);
            this.grbRating.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbRating;
        private System.Windows.Forms.RadioButton rdFiveStar;
        private System.Windows.Forms.RadioButton rdFourStar;
        private System.Windows.Forms.RadioButton rdThreeStar;
        private System.Windows.Forms.RadioButton rdTwoStar;
        private System.Windows.Forms.RadioButton rdOneStar;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Button btnPersonalDetails;
        private System.Windows.Forms.Button btnContractScreen;
    }
}