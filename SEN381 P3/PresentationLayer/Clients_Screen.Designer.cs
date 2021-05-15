
namespace PresentationLayer
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.txtSearchParamater = new System.Windows.Forms.TextBox();
            this.pnlClientData = new System.Windows.Forms.Panel();
            this.cmbServiceChange = new System.Windows.Forms.ComboBox();
            this.btnCreateJob = new System.Windows.Forms.Button();
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
            this.pnlEmployeeData = new System.Windows.Forms.Panel();
            this.cmbEmployeeClassificaion = new System.Windows.Forms.ComboBox();
            this.cmbEmployeeSkill = new System.Windows.Forms.ComboBox();
            this.chkEmployeeEdit = new System.Windows.Forms.CheckBox();
            this.btnEmployeeClear = new System.Windows.Forms.Button();
            this.txtEmployeeClassificaion = new System.Windows.Forms.TextBox();
            this.lblEmployeeClassification = new System.Windows.Forms.Label();
            this.txtEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeePhoneNumber = new System.Windows.Forms.Label();
            this.txtEmployeeSkill = new System.Windows.Forms.TextBox();
            this.lblEmployeeSkill = new System.Windows.Forms.Label();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.btnEmployeeRemove = new System.Windows.Forms.Button();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.pnlData.SuspendLayout();
            this.pnlClientData.SuspendLayout();
            this.pnlEmployeeData.SuspendLayout();
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
            this.pnlData.Controls.Add(this.label2);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search by:";
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
            this.pnlClientData.Controls.Add(this.btnCreateJob);
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
            // btnCreateJob
            // 
            this.btnCreateJob.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreateJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateJob.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateJob.Location = new System.Drawing.Point(20, 293);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(237, 35);
            this.btnCreateJob.TabIndex = 27;
            this.btnCreateJob.Text = "Create Job";
            this.btnCreateJob.UseVisualStyleBackColor = true;
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
            this.btnContractDelete.Location = new System.Drawing.Point(182, 334);
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
            this.btnContractUpdate.Location = new System.Drawing.Point(101, 334);
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
            this.btnContractAdd.Location = new System.Drawing.Point(20, 334);
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
            this.btnNext.Location = new System.Drawing.Point(370, 351);
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
            this.btnPrev.Location = new System.Drawing.Point(14, 351);
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
            // pnlEmployeeData
            // 
            this.pnlEmployeeData.Controls.Add(this.cmbEmployeeClassificaion);
            this.pnlEmployeeData.Controls.Add(this.cmbEmployeeSkill);
            this.pnlEmployeeData.Controls.Add(this.chkEmployeeEdit);
            this.pnlEmployeeData.Controls.Add(this.btnEmployeeClear);
            this.pnlEmployeeData.Controls.Add(this.txtEmployeeClassificaion);
            this.pnlEmployeeData.Controls.Add(this.lblEmployeeClassification);
            this.pnlEmployeeData.Controls.Add(this.txtEmployeePhoneNumber);
            this.pnlEmployeeData.Controls.Add(this.lblEmployeePhoneNumber);
            this.pnlEmployeeData.Controls.Add(this.txtEmployeeSkill);
            this.pnlEmployeeData.Controls.Add(this.lblEmployeeSkill);
            this.pnlEmployeeData.Controls.Add(this.txtEmployeeLastName);
            this.pnlEmployeeData.Controls.Add(this.lblEmployeeLastName);
            this.pnlEmployeeData.Controls.Add(this.txtEmployeeFirstName);
            this.pnlEmployeeData.Controls.Add(this.lblEmployeeFirstName);
            this.pnlEmployeeData.Controls.Add(this.txtEmployeeId);
            this.pnlEmployeeData.Controls.Add(this.lblEmployeeId);
            this.pnlEmployeeData.Controls.Add(this.btnEmployeeRemove);
            this.pnlEmployeeData.Controls.Add(this.btnEmployeeUpdate);
            this.pnlEmployeeData.Controls.Add(this.btnEmployeeAdd);
            this.pnlEmployeeData.Location = new System.Drawing.Point(474, 32);
            this.pnlEmployeeData.Name = "pnlEmployeeData";
            this.pnlEmployeeData.Size = new System.Drawing.Size(273, 362);
            this.pnlEmployeeData.TabIndex = 26;
            // 
            // cmbEmployeeClassificaion
            // 
            this.cmbEmployeeClassificaion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeClassificaion.FormattingEnabled = true;
            this.cmbEmployeeClassificaion.Location = new System.Drawing.Point(11, 219);
            this.cmbEmployeeClassificaion.Name = "cmbEmployeeClassificaion";
            this.cmbEmployeeClassificaion.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployeeClassificaion.TabIndex = 23;
            // 
            // cmbEmployeeSkill
            // 
            this.cmbEmployeeSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeSkill.FormattingEnabled = true;
            this.cmbEmployeeSkill.Location = new System.Drawing.Point(11, 192);
            this.cmbEmployeeSkill.Name = "cmbEmployeeSkill";
            this.cmbEmployeeSkill.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployeeSkill.TabIndex = 22;
            // 
            // chkEmployeeEdit
            // 
            this.chkEmployeeEdit.AutoSize = true;
            this.chkEmployeeEdit.Checked = true;
            this.chkEmployeeEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmployeeEdit.Location = new System.Drawing.Point(3, 302);
            this.chkEmployeeEdit.Name = "chkEmployeeEdit";
            this.chkEmployeeEdit.Size = new System.Drawing.Size(44, 17);
            this.chkEmployeeEdit.TabIndex = 21;
            this.chkEmployeeEdit.Text = "Edit";
            this.chkEmployeeEdit.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeClear
            // 
            this.btnEmployeeClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeClear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeClear.Location = new System.Drawing.Point(195, 302);
            this.btnEmployeeClear.Name = "btnEmployeeClear";
            this.btnEmployeeClear.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeClear.TabIndex = 20;
            this.btnEmployeeClear.Text = "Clear";
            this.btnEmployeeClear.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeClassificaion
            // 
            this.txtEmployeeClassificaion.Enabled = false;
            this.txtEmployeeClassificaion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeClassificaion.Location = new System.Drawing.Point(140, 163);
            this.txtEmployeeClassificaion.Name = "txtEmployeeClassificaion";
            this.txtEmployeeClassificaion.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeClassificaion.TabIndex = 19;
            // 
            // lblEmployeeClassification
            // 
            this.lblEmployeeClassification.AutoSize = true;
            this.lblEmployeeClassification.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeClassification.Location = new System.Drawing.Point(137, 138);
            this.lblEmployeeClassification.Name = "lblEmployeeClassification";
            this.lblEmployeeClassification.Size = new System.Drawing.Size(87, 15);
            this.lblEmployeeClassification.TabIndex = 18;
            this.lblEmployeeClassification.Text = "Classification:";
            // 
            // txtEmployeePhoneNumber
            // 
            this.txtEmployeePhoneNumber.Enabled = false;
            this.txtEmployeePhoneNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmployeePhoneNumber.Location = new System.Drawing.Point(11, 163);
            this.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            this.txtEmployeePhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeePhoneNumber.TabIndex = 17;
            // 
            // lblEmployeePhoneNumber
            // 
            this.lblEmployeePhoneNumber.AutoSize = true;
            this.lblEmployeePhoneNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePhoneNumber.Location = new System.Drawing.Point(8, 138);
            this.lblEmployeePhoneNumber.Name = "lblEmployeePhoneNumber";
            this.lblEmployeePhoneNumber.Size = new System.Drawing.Size(90, 15);
            this.lblEmployeePhoneNumber.TabIndex = 16;
            this.lblEmployeePhoneNumber.Text = "Phone number:";
            // 
            // txtEmployeeSkill
            // 
            this.txtEmployeeSkill.Enabled = false;
            this.txtEmployeeSkill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeSkill.Location = new System.Drawing.Point(140, 63);
            this.txtEmployeeSkill.Name = "txtEmployeeSkill";
            this.txtEmployeeSkill.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeSkill.TabIndex = 15;
            // 
            // lblEmployeeSkill
            // 
            this.lblEmployeeSkill.AutoSize = true;
            this.lblEmployeeSkill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSkill.Location = new System.Drawing.Point(137, 38);
            this.lblEmployeeSkill.Name = "lblEmployeeSkill";
            this.lblEmployeeSkill.Size = new System.Drawing.Size(39, 15);
            this.lblEmployeeSkill.TabIndex = 14;
            this.lblEmployeeSkill.Text = "Skill:";
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Enabled = false;
            this.txtEmployeeLastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeLastName.Location = new System.Drawing.Point(140, 113);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeLastName.TabIndex = 13;
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = true;
            this.lblEmployeeLastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLastName.Location = new System.Drawing.Point(137, 88);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(69, 15);
            this.lblEmployeeLastName.TabIndex = 12;
            this.lblEmployeeLastName.Text = "Last Name:";
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Enabled = false;
            this.txtEmployeeFirstName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(11, 113);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeFirstName.TabIndex = 11;
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.AutoSize = true;
            this.lblEmployeeFirstName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(8, 88);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(72, 15);
            this.lblEmployeeFirstName.TabIndex = 10;
            this.lblEmployeeFirstName.Text = "First Name:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Enabled = false;
            this.txtEmployeeId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeId.Location = new System.Drawing.Point(11, 63);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeId.TabIndex = 9;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(8, 38);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(24, 15);
            this.lblEmployeeId.TabIndex = 6;
            this.lblEmployeeId.Text = "ID:";
            // 
            // btnEmployeeRemove
            // 
            this.btnEmployeeRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeRemove.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRemove.Location = new System.Drawing.Point(195, 331);
            this.btnEmployeeRemove.Name = "btnEmployeeRemove";
            this.btnEmployeeRemove.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeRemove.TabIndex = 8;
            this.btnEmployeeRemove.Text = "Remove";
            this.btnEmployeeRemove.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(100, 331);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeUpdate.TabIndex = 7;
            this.btnEmployeeUpdate.Text = "Update";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployeeAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeAdd.Location = new System.Drawing.Point(3, 331);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeAdd.TabIndex = 6;
            this.btnEmployeeAdd.Text = "Add";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            // 
            // Clients_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlEmployeeData);
            this.Name = "Clients_Screen";
            this.Text = "Clients_Screen";
            this.Load += new System.EventHandler(this.Contract_Screen_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlClientData.ResumeLayout(false);
            this.pnlClientData.PerformLayout();
            this.pnlEmployeeData.ResumeLayout(false);
            this.pnlEmployeeData.PerformLayout();
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
        private System.Windows.Forms.Panel pnlEmployeeData;
        private System.Windows.Forms.ComboBox cmbEmployeeClassificaion;
        private System.Windows.Forms.ComboBox cmbEmployeeSkill;
        private System.Windows.Forms.CheckBox chkEmployeeEdit;
        private System.Windows.Forms.Button btnEmployeeClear;
        private System.Windows.Forms.TextBox txtEmployeeClassificaion;
        private System.Windows.Forms.Label lblEmployeeClassification;
        private System.Windows.Forms.TextBox txtEmployeePhoneNumber;
        private System.Windows.Forms.Label lblEmployeePhoneNumber;
        private System.Windows.Forms.TextBox txtEmployeeSkill;
        private System.Windows.Forms.Label lblEmployeeSkill;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Button btnEmployeeRemove;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearchParamater;
        private System.Windows.Forms.Label lblExperationDate;
        private System.Windows.Forms.TextBox txtContractExperationDate;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label lblClientContracts;
        private System.Windows.Forms.Button btnCreateJob;
        private System.Windows.Forms.ComboBox cmbServiceChange;
    }
}