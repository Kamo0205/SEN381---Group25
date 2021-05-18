
namespace Presentation_Layer
{
    partial class Clients_Screen
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblClientContracts = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.txtSearchParamater = new System.Windows.Forms.TextBox();
            this.pnlClientData = new System.Windows.Forms.Panel();
            this.cmbServiceChange = new System.Windows.Forms.ComboBox();
            this.btnJobScreen = new System.Windows.Forms.Button();
            this.lblExperationDate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.txtContractExperationDate = new System.Windows.Forms.TextBox();
            this.txtClientLocation = new System.Windows.Forms.TextBox();
            this.lblClientAdress = new System.Windows.Forms.Label();
            this.lblContractID = new System.Windows.Forms.Label();
            this.txtContractId = new System.Windows.Forms.TextBox();
            this.txtClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblServiceLevel = new System.Windows.Forms.Label();
            this.lblClientPhoneNumber = new System.Windows.Forms.Label();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.btnContractDelete = new System.Windows.Forms.Button();
            this.btnContractUpdate = new System.Windows.Forms.Button();
            this.btnContractAdd = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblSearchCLients = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.pnlClientData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(23, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lblClientContracts);
            this.pnlData.Controls.Add(this.lblService);
            this.pnlData.Controls.Add(this.lblSearchBy);
            this.pnlData.Controls.Add(this.cmbSearchBy);
            this.pnlData.Controls.Add(this.cmbService);
            this.pnlData.Controls.Add(this.txtSearchParamater);
            this.pnlData.Controls.Add(this.pnlClientData);
            this.pnlData.Controls.Add(this.lstData);
            this.pnlData.Controls.Add(this.btnNext);
            this.pnlData.Controls.Add(this.btnPrev);
            this.pnlData.Controls.Add(this.lblSearchCLients);
            this.pnlData.Location = new System.Drawing.Point(23, 42);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(755, 397);
            this.pnlData.TabIndex = 24;
            // 
            // lblClientContracts
            // 
            this.lblClientContracts.AutoSize = true;
            this.lblClientContracts.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientContracts.Location = new System.Drawing.Point(10, 121);
            this.lblClientContracts.Name = "lblClientContracts";
            this.lblClientContracts.Size = new System.Drawing.Size(150, 22);
            this.lblClientContracts.TabIndex = 12;
            this.lblClientContracts.Text = "Client Contracts:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(16, 55);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(96, 17);
            this.lblService.TabIndex = 11;
            this.lblService.Text = "Service Level:";
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(39, 82);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(73, 17);
            this.lblSearchBy.TabIndex = 9;
            this.lblSearchBy.Text = "Search by:";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Location = new System.Drawing.Point(118, 81);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(109, 21);
            this.cmbSearchBy.TabIndex = 8;
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(118, 53);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(109, 21);
            this.cmbService.TabIndex = 10;
            // 
            // txtSearchParamater
            // 
            this.txtSearchParamater.Location = new System.Drawing.Point(233, 82);
            this.txtSearchParamater.Name = "txtSearchParamater";
            this.txtSearchParamater.Size = new System.Drawing.Size(152, 20);
            this.txtSearchParamater.TabIndex = 7;
            this.txtSearchParamater.TextChanged += new System.EventHandler(this.txtSearchParamater_TextChanged);
            // 
            // pnlClientData
            // 
            this.pnlClientData.Controls.Add(this.cmbServiceChange);
            this.pnlClientData.Controls.Add(this.btnJobScreen);
            this.pnlClientData.Controls.Add(this.lblExperationDate);
            this.pnlClientData.Controls.Add(this.lblEmail);
            this.pnlClientData.Controls.Add(this.txtClientEmail);
            this.pnlClientData.Controls.Add(this.txtContractExperationDate);
            this.pnlClientData.Controls.Add(this.txtClientLocation);
            this.pnlClientData.Controls.Add(this.lblClientAdress);
            this.pnlClientData.Controls.Add(this.lblContractID);
            this.pnlClientData.Controls.Add(this.txtContractId);
            this.pnlClientData.Controls.Add(this.txtClientPhoneNumber);
            this.pnlClientData.Controls.Add(this.lblServiceLevel);
            this.pnlClientData.Controls.Add(this.lblClientPhoneNumber);
            this.pnlClientData.Controls.Add(this.txtClientLastName);
            this.pnlClientData.Controls.Add(this.lblClientLastName);
            this.pnlClientData.Controls.Add(this.txtClientFirstName);
            this.pnlClientData.Controls.Add(this.lblClientFirstName);
            this.pnlClientData.Controls.Add(this.btnContractDelete);
            this.pnlClientData.Controls.Add(this.btnContractUpdate);
            this.pnlClientData.Controls.Add(this.btnContractAdd);
            this.pnlClientData.Location = new System.Drawing.Point(451, 16);
            this.pnlClientData.Name = "pnlClientData";
            this.pnlClientData.Size = new System.Drawing.Size(287, 378);
            this.pnlClientData.TabIndex = 5;
            // 
            // cmbServiceChange
            // 
            this.cmbServiceChange.FormattingEnabled = true;
            this.cmbServiceChange.Location = new System.Drawing.Point(149, 215);
            this.cmbServiceChange.Name = "cmbServiceChange";
            this.cmbServiceChange.Size = new System.Drawing.Size(109, 21);
            this.cmbServiceChange.TabIndex = 13;
            // 
            // btnJobScreen
            // 
            this.btnJobScreen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnJobScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobScreen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobScreen.Location = new System.Drawing.Point(20, 329);
            this.btnJobScreen.Name = "btnJobScreen";
            this.btnJobScreen.Size = new System.Drawing.Size(237, 35);
            this.btnJobScreen.TabIndex = 27;
            this.btnJobScreen.Text = "Job Screen";
            this.btnJobScreen.UseVisualStyleBackColor = true;
            this.btnJobScreen.Click += new System.EventHandler(this.btnJobScreen_Click);
            // 
            // lblExperationDate
            // 
            this.lblExperationDate.AutoSize = true;
            this.lblExperationDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperationDate.Location = new System.Drawing.Point(20, 240);
            this.lblExperationDate.Name = "lblExperationDate";
            this.lblExperationDate.Size = new System.Drawing.Size(97, 15);
            this.lblExperationDate.TabIndex = 27;
            this.lblExperationDate.Text = "Experation Date:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email:";
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientEmail.Location = new System.Drawing.Point(20, 154);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.ReadOnly = true;
            this.txtClientEmail.Size = new System.Drawing.Size(111, 22);
            this.txtClientEmail.TabIndex = 24;
            // 
            // txtContractExperationDate
            // 
            this.txtContractExperationDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtContractExperationDate.Location = new System.Drawing.Point(20, 265);
            this.txtContractExperationDate.Name = "txtContractExperationDate";
            this.txtContractExperationDate.Size = new System.Drawing.Size(111, 22);
            this.txtContractExperationDate.TabIndex = 26;
            // 
            // txtClientLocation
            // 
            this.txtClientLocation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientLocation.Location = new System.Drawing.Point(149, 105);
            this.txtClientLocation.Name = "txtClientLocation";
            this.txtClientLocation.ReadOnly = true;
            this.txtClientLocation.Size = new System.Drawing.Size(109, 22);
            this.txtClientLocation.TabIndex = 19;
            // 
            // lblClientAdress
            // 
            this.lblClientAdress.AutoSize = true;
            this.lblClientAdress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAdress.Location = new System.Drawing.Point(146, 80);
            this.lblClientAdress.Name = "lblClientAdress";
            this.lblClientAdress.Size = new System.Drawing.Size(56, 15);
            this.lblClientAdress.TabIndex = 18;
            this.lblClientAdress.Text = "Address:";
            // 
            // lblContractID
            // 
            this.lblContractID.AutoSize = true;
            this.lblContractID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractID.Location = new System.Drawing.Point(20, 190);
            this.lblContractID.Name = "lblContractID";
            this.lblContractID.Size = new System.Drawing.Size(75, 15);
            this.lblContractID.TabIndex = 23;
            this.lblContractID.Text = "Contract ID:";
            // 
            // txtContractId
            // 
            this.txtContractId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtContractId.Location = new System.Drawing.Point(20, 215);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.ReadOnly = true;
            this.txtContractId.Size = new System.Drawing.Size(111, 22);
            this.txtContractId.TabIndex = 9;
            // 
            // txtClientPhoneNumber
            // 
            this.txtClientPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientPhoneNumber.Location = new System.Drawing.Point(20, 105);
            this.txtClientPhoneNumber.Name = "txtClientPhoneNumber";
            this.txtClientPhoneNumber.ReadOnly = true;
            this.txtClientPhoneNumber.Size = new System.Drawing.Size(111, 22);
            this.txtClientPhoneNumber.TabIndex = 17;
            // 
            // lblServiceLevel
            // 
            this.lblServiceLevel.AutoSize = true;
            this.lblServiceLevel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceLevel.Location = new System.Drawing.Point(146, 190);
            this.lblServiceLevel.Name = "lblServiceLevel";
            this.lblServiceLevel.Size = new System.Drawing.Size(84, 15);
            this.lblServiceLevel.TabIndex = 14;
            this.lblServiceLevel.Text = "Service Level:";
            // 
            // lblClientPhoneNumber
            // 
            this.lblClientPhoneNumber.AutoSize = true;
            this.lblClientPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPhoneNumber.Location = new System.Drawing.Point(17, 80);
            this.lblClientPhoneNumber.Name = "lblClientPhoneNumber";
            this.lblClientPhoneNumber.Size = new System.Drawing.Size(90, 15);
            this.lblClientPhoneNumber.TabIndex = 16;
            this.lblClientPhoneNumber.Text = "Phone number:";
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientLastName.Location = new System.Drawing.Point(149, 55);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.ReadOnly = true;
            this.txtClientLastName.Size = new System.Drawing.Size(108, 22);
            this.txtClientLastName.TabIndex = 13;
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientLastName.Location = new System.Drawing.Point(146, 30);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(106, 15);
            this.lblClientLastName.TabIndex = 12;
            this.lblClientLastName.Text = "Client Last Name:";
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientFirstName.Location = new System.Drawing.Point(20, 55);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.ReadOnly = true;
            this.txtClientFirstName.Size = new System.Drawing.Size(111, 22);
            this.txtClientFirstName.TabIndex = 11;
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientFirstName.Location = new System.Drawing.Point(17, 30);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(109, 15);
            this.lblClientFirstName.TabIndex = 10;
            this.lblClientFirstName.Text = "Client First Name:";
            // 
            // btnContractDelete
            // 
            this.btnContractDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContractDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractDelete.ForeColor = System.Drawing.Color.Red;
            this.btnContractDelete.Location = new System.Drawing.Point(181, 296);
            this.btnContractDelete.Name = "btnContractDelete";
            this.btnContractDelete.Size = new System.Drawing.Size(75, 23);
            this.btnContractDelete.TabIndex = 8;
            this.btnContractDelete.Text = "Delete";
            this.btnContractDelete.UseVisualStyleBackColor = true;
            this.btnContractDelete.Click += new System.EventHandler(this.btnContractDelete_Click);
            // 
            // btnContractUpdate
            // 
            this.btnContractUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContractUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractUpdate.ForeColor = System.Drawing.Color.Magenta;
            this.btnContractUpdate.Location = new System.Drawing.Point(100, 296);
            this.btnContractUpdate.Name = "btnContractUpdate";
            this.btnContractUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnContractUpdate.TabIndex = 7;
            this.btnContractUpdate.Text = "Update";
            this.btnContractUpdate.UseVisualStyleBackColor = true;
            this.btnContractUpdate.Click += new System.EventHandler(this.btnContractUpdate_Click);
            // 
            // btnContractAdd
            // 
            this.btnContractAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContractAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnContractAdd.Location = new System.Drawing.Point(19, 296);
            this.btnContractAdd.Name = "btnContractAdd";
            this.btnContractAdd.Size = new System.Drawing.Size(75, 23);
            this.btnContractAdd.TabIndex = 6;
            this.btnContractAdd.Text = "Add";
            this.btnContractAdd.UseVisualStyleBackColor = true;
            this.btnContractAdd.Click += new System.EventHandler(this.btnContractAdd_Click);
            // 
            // lstData
            // 
            this.lstData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstData.FormattingEnabled = true;
            this.lstData.HorizontalScrollbar = true;
            this.lstData.ItemHeight = 15;
            this.lstData.Location = new System.Drawing.Point(14, 161);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(431, 184);
            this.lstData.TabIndex = 6;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(370, 357);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(14, 357);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblSearchCLients
            // 
            this.lblSearchCLients.AutoSize = true;
            this.lblSearchCLients.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCLients.Location = new System.Drawing.Point(10, 16);
            this.lblSearchCLients.Name = "lblSearchCLients";
            this.lblSearchCLients.Size = new System.Drawing.Size(134, 22);
            this.lblSearchCLients.TabIndex = 1;
            this.lblSearchCLients.Text = "Search Clients:";
            // 
            // Clients_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlData);
            this.Name = "Clients_Screen";
            this.Text = "Clients_Screen";
            this.Load += new System.EventHandler(this.Contract_Screen_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlClientData.ResumeLayout(false);
            this.pnlClientData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlClientData;
        private System.Windows.Forms.TextBox txtClientLocation;
        private System.Windows.Forms.Label lblClientAdress;
        private System.Windows.Forms.TextBox txtClientPhoneNumber;
        private System.Windows.Forms.Label lblClientPhoneNumber;
        private System.Windows.Forms.Label lblServiceLevel;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.TextBox txtContractId;
        private System.Windows.Forms.Button btnContractDelete;
        private System.Windows.Forms.Button btnContractUpdate;
        private System.Windows.Forms.Button btnContractAdd;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblSearchCLients;
        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearchParamater;
        private System.Windows.Forms.Label lblExperationDate;
        private System.Windows.Forms.TextBox txtContractExperationDate;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label lblClientContracts;
        private System.Windows.Forms.Button btnJobScreen;
        private System.Windows.Forms.ComboBox cmbServiceChange;
    }
}