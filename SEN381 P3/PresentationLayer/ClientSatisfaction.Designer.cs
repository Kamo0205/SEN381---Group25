namespace PresentationLayer
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlCaller = new System.Windows.Forms.Panel();
            this.lblCallLoad = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnLeaveCall = new System.Windows.Forms.Button();
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.lblCallerName = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.rdOneStar = new System.Windows.Forms.RadioButton();
            this.grbRating = new System.Windows.Forms.GroupBox();
            this.rdTwoStar = new System.Windows.Forms.RadioButton();
            this.rdThreeStar = new System.Windows.Forms.RadioButton();
            this.rdFourStar = new System.Windows.Forms.RadioButton();
            this.rdFiveStar = new System.Windows.Forms.RadioButton();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.pnlClient.SuspendLayout();
            this.pnlCaller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.grbRating.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnBack.Location = new System.Drawing.Point(22, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlClient
            // 
            this.pnlClient.BackColor = System.Drawing.Color.White;
            this.pnlClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClient.Controls.Add(this.grbRating);
            this.pnlClient.Controls.Add(this.lblClientName);
            this.pnlClient.Controls.Add(this.btnClear);
            this.pnlClient.Controls.Add(this.cmbClientName);
            this.pnlClient.Controls.Add(this.btnSave);
            this.pnlClient.Controls.Add(this.txtDetails);
            this.pnlClient.Controls.Add(this.lblDetails);
            this.pnlClient.Location = new System.Drawing.Point(7, 16);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(504, 318);
            this.pnlClient.TabIndex = 13;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(14, 14);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(88, 19);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client Name:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnClear.Location = new System.Drawing.Point(110, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbClientName
            // 
            this.cmbClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Location = new System.Drawing.Point(14, 37);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(145, 27);
            this.cmbClientName.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.Location = new System.Drawing.Point(18, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(14, 163);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(406, 73);
            this.txtDetails.TabIndex = 8;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(10, 140);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(53, 19);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "Details:";
            // 
            // pnlCaller
            // 
            this.pnlCaller.BackColor = System.Drawing.Color.White;
            this.pnlCaller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCaller.Controls.Add(this.lblCallLoad);
            this.pnlCaller.Controls.Add(this.btnNext);
            this.pnlCaller.Controls.Add(this.btnPrev);
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
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(210, 134);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(34, 33);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(11, 134);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(38, 33);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
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
            // FrmClientSatisfaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.pnlCaller);
            this.Name = "FrmClientSatisfaction";
            this.ShowIcon = false;
            this.Text = "ClientSatisfaction";
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.pnlCaller.ResumeLayout(false);
            this.pnlCaller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.grbRating.ResumeLayout(false);
            this.grbRating.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Panel pnlCaller;
        private System.Windows.Forms.Label lblCallLoad;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
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
    }
}