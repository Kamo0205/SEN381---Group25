namespace PresentationLayer
{
    partial class FrmEditCompanyData
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
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlEmployeeData = new System.Windows.Forms.Panel();
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
            this.lstData = new System.Windows.Forms.ListBox();
            this.pnlClientData = new System.Windows.Forms.Panel();
            this.chkClientEdit = new System.Windows.Forms.CheckBox();
            this.btnClientClear = new System.Windows.Forms.Button();
            this.txtClientLocation = new System.Windows.Forms.TextBox();
            this.lblClientLocation = new System.Windows.Forms.Label();
            this.txtClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblClientPhoneNumber = new System.Windows.Forms.Label();
            this.txtClientContractType = new System.Windows.Forms.TextBox();
            this.lblClientContractType = new System.Windows.Forms.Label();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnClientRemove = new System.Windows.Forms.Button();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblChoice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbClientContractType = new System.Windows.Forms.ComboBox();
            this.cmbEmployeeSkill = new System.Windows.Forms.ComboBox();
            this.cmbEmployeeClassificaion = new System.Windows.Forms.ComboBox();
            this.pnlData.SuspendLayout();
            this.pnlEmployeeData.SuspendLayout();
            this.pnlClientData.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbChoice
            // 
            this.cmbChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Location = new System.Drawing.Point(157, 10);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(148, 25);
            this.cmbChoice.TabIndex = 0;
            this.cmbChoice.SelectedIndexChanged += new System.EventHandler(this.cmbChoice_SelectedIndexChanged);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.pnlClientData);
            this.pnlData.Controls.Add(this.lstData);
            this.pnlData.Controls.Add(this.btnNext);
            this.pnlData.Controls.Add(this.btnPrev);
            this.pnlData.Controls.Add(this.lblChoice);
            this.pnlData.Location = new System.Drawing.Point(13, 41);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(755, 397);
            this.pnlData.TabIndex = 1;
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
            this.pnlEmployeeData.Location = new System.Drawing.Point(464, 31);
            this.pnlEmployeeData.Name = "pnlEmployeeData";
            this.pnlEmployeeData.Size = new System.Drawing.Size(273, 362);
            this.pnlEmployeeData.TabIndex = 22;
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
            this.chkEmployeeEdit.CheckStateChanged += new System.EventHandler(this.chkEmployeeEdit_CheckStateChanged);
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
            this.btnEmployeeClear.Click += new System.EventHandler(this.btnEmployeeClear_Click);
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
            this.btnEmployeeRemove.Click += new System.EventHandler(this.btnEmployeeRemove_Click);
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
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
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
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // lstData
            // 
            this.lstData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstData.FormattingEnabled = true;
            this.lstData.HorizontalScrollbar = true;
            this.lstData.ItemHeight = 15;
            this.lstData.Location = new System.Drawing.Point(14, 41);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(431, 334);
            this.lstData.TabIndex = 6;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // pnlClientData
            // 
            this.pnlClientData.Controls.Add(this.cmbClientContractType);
            this.pnlClientData.Controls.Add(this.chkClientEdit);
            this.pnlClientData.Controls.Add(this.btnClientClear);
            this.pnlClientData.Controls.Add(this.txtClientLocation);
            this.pnlClientData.Controls.Add(this.lblClientLocation);
            this.pnlClientData.Controls.Add(this.txtClientPhoneNumber);
            this.pnlClientData.Controls.Add(this.lblClientPhoneNumber);
            this.pnlClientData.Controls.Add(this.txtClientContractType);
            this.pnlClientData.Controls.Add(this.lblClientContractType);
            this.pnlClientData.Controls.Add(this.txtClientLastName);
            this.pnlClientData.Controls.Add(this.lblClientLastName);
            this.pnlClientData.Controls.Add(this.txtClientFirstName);
            this.pnlClientData.Controls.Add(this.lblClientFirstName);
            this.pnlClientData.Controls.Add(this.txtClientId);
            this.pnlClientData.Controls.Add(this.lblClientID);
            this.pnlClientData.Controls.Add(this.btnClientRemove);
            this.pnlClientData.Controls.Add(this.btnClientUpdate);
            this.pnlClientData.Controls.Add(this.btnClientAdd);
            this.pnlClientData.Location = new System.Drawing.Point(451, 16);
            this.pnlClientData.Name = "pnlClientData";
            this.pnlClientData.Size = new System.Drawing.Size(287, 341);
            this.pnlClientData.TabIndex = 5;
            // 
            // chkClientEdit
            // 
            this.chkClientEdit.AutoSize = true;
            this.chkClientEdit.Checked = true;
            this.chkClientEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClientEdit.Location = new System.Drawing.Point(3, 276);
            this.chkClientEdit.Name = "chkClientEdit";
            this.chkClientEdit.Size = new System.Drawing.Size(44, 17);
            this.chkClientEdit.TabIndex = 21;
            this.chkClientEdit.Text = "Edit";
            this.chkClientEdit.UseVisualStyleBackColor = true;
            this.chkClientEdit.CheckStateChanged += new System.EventHandler(this.chkEdit_CheckStateChanged);
            // 
            // btnClientClear
            // 
            this.btnClientClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientClear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientClear.Location = new System.Drawing.Point(195, 276);
            this.btnClientClear.Name = "btnClientClear";
            this.btnClientClear.Size = new System.Drawing.Size(75, 23);
            this.btnClientClear.TabIndex = 20;
            this.btnClientClear.Text = "Clear";
            this.btnClientClear.UseVisualStyleBackColor = true;
            this.btnClientClear.Click += new System.EventHandler(this.btnClientClear_Click);
            // 
            // txtClientLocation
            // 
            this.txtClientLocation.Enabled = false;
            this.txtClientLocation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientLocation.Location = new System.Drawing.Point(140, 137);
            this.txtClientLocation.Name = "txtClientLocation";
            this.txtClientLocation.Size = new System.Drawing.Size(100, 22);
            this.txtClientLocation.TabIndex = 19;
            // 
            // lblClientLocation
            // 
            this.lblClientLocation.AutoSize = true;
            this.lblClientLocation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientLocation.Location = new System.Drawing.Point(137, 112);
            this.lblClientLocation.Name = "lblClientLocation";
            this.lblClientLocation.Size = new System.Drawing.Size(58, 15);
            this.lblClientLocation.TabIndex = 18;
            this.lblClientLocation.Text = "Location:";
            // 
            // txtClientPhoneNumber
            // 
            this.txtClientPhoneNumber.Enabled = false;
            this.txtClientPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientPhoneNumber.Location = new System.Drawing.Point(11, 137);
            this.txtClientPhoneNumber.Name = "txtClientPhoneNumber";
            this.txtClientPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtClientPhoneNumber.TabIndex = 17;
            // 
            // lblClientPhoneNumber
            // 
            this.lblClientPhoneNumber.AutoSize = true;
            this.lblClientPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPhoneNumber.Location = new System.Drawing.Point(8, 112);
            this.lblClientPhoneNumber.Name = "lblClientPhoneNumber";
            this.lblClientPhoneNumber.Size = new System.Drawing.Size(90, 15);
            this.lblClientPhoneNumber.TabIndex = 16;
            this.lblClientPhoneNumber.Text = "Phone number:";
            // 
            // txtClientContractType
            // 
            this.txtClientContractType.Enabled = false;
            this.txtClientContractType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientContractType.Location = new System.Drawing.Point(140, 37);
            this.txtClientContractType.Name = "txtClientContractType";
            this.txtClientContractType.Size = new System.Drawing.Size(100, 22);
            this.txtClientContractType.TabIndex = 15;
            // 
            // lblClientContractType
            // 
            this.lblClientContractType.AutoSize = true;
            this.lblClientContractType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientContractType.Location = new System.Drawing.Point(137, 12);
            this.lblClientContractType.Name = "lblClientContractType";
            this.lblClientContractType.Size = new System.Drawing.Size(84, 15);
            this.lblClientContractType.TabIndex = 14;
            this.lblClientContractType.Text = "Contract type:";
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Enabled = false;
            this.txtClientLastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientLastName.Location = new System.Drawing.Point(140, 87);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(100, 22);
            this.txtClientLastName.TabIndex = 13;
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientLastName.Location = new System.Drawing.Point(137, 62);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(69, 15);
            this.lblClientLastName.TabIndex = 12;
            this.lblClientLastName.Text = "Last Name:";
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Enabled = false;
            this.txtClientFirstName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientFirstName.Location = new System.Drawing.Point(11, 87);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtClientFirstName.TabIndex = 11;
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientFirstName.Location = new System.Drawing.Point(8, 62);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(72, 15);
            this.lblClientFirstName.TabIndex = 10;
            this.lblClientFirstName.Text = "First Name:";
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtClientId.Location = new System.Drawing.Point(11, 37);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(100, 22);
            this.txtClientId.TabIndex = 9;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(8, 12);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(24, 15);
            this.lblClientID.TabIndex = 6;
            this.lblClientID.Text = "ID:";
            // 
            // btnClientRemove
            // 
            this.btnClientRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientRemove.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientRemove.Location = new System.Drawing.Point(195, 305);
            this.btnClientRemove.Name = "btnClientRemove";
            this.btnClientRemove.Size = new System.Drawing.Size(75, 23);
            this.btnClientRemove.TabIndex = 8;
            this.btnClientRemove.Text = "Remove";
            this.btnClientRemove.UseVisualStyleBackColor = true;
            this.btnClientRemove.Click += new System.EventHandler(this.btnClientRemove_Click);
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientUpdate.Location = new System.Drawing.Point(100, 305);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnClientUpdate.TabIndex = 7;
            this.btnClientUpdate.Text = "Update";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientAdd.Location = new System.Drawing.Point(3, 305);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClientAdd.TabIndex = 6;
            this.btnClientAdd.Text = "Add";
            this.btnClientAdd.UseVisualStyleBackColor = true;
            this.btnClientAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(663, 361);
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
            this.btnPrev.Location = new System.Drawing.Point(465, 361);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice.Location = new System.Drawing.Point(10, 16);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(67, 22);
            this.lblChoice.TabIndex = 1;
            this.lblChoice.Text = "Choice";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbClientContractType
            // 
            this.cmbClientContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientContractType.FormattingEnabled = true;
            this.cmbClientContractType.Items.AddRange(new object[] {
            "S",
            "A",
            "B"});
            this.cmbClientContractType.Location = new System.Drawing.Point(140, 178);
            this.cmbClientContractType.Name = "cmbClientContractType";
            this.cmbClientContractType.Size = new System.Drawing.Size(121, 21);
            this.cmbClientContractType.TabIndex = 22;
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
            // cmbEmployeeClassificaion
            // 
            this.cmbEmployeeClassificaion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeClassificaion.FormattingEnabled = true;
            this.cmbEmployeeClassificaion.Location = new System.Drawing.Point(11, 219);
            this.cmbEmployeeClassificaion.Name = "cmbEmployeeClassificaion";
            this.cmbEmployeeClassificaion.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployeeClassificaion.TabIndex = 23;
            // 
            // FrmEditCompanyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 445);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.cmbChoice);
            this.Controls.Add(this.pnlEmployeeData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditCompanyData";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Company Data";
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlEmployeeData.ResumeLayout(false);
            this.pnlEmployeeData.PerformLayout();
            this.pnlClientData.ResumeLayout(false);
            this.pnlClientData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChoice;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel pnlClientData;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Button btnClientRemove;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.Button btnClientAdd;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtClientContractType;
        private System.Windows.Forms.Label lblClientContractType;
        private System.Windows.Forms.TextBox txtClientLocation;
        private System.Windows.Forms.Label lblClientLocation;
        private System.Windows.Forms.TextBox txtClientPhoneNumber;
        private System.Windows.Forms.Label lblClientPhoneNumber;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnClientClear;
        private System.Windows.Forms.CheckBox chkClientEdit;
        private System.Windows.Forms.Panel pnlEmployeeData;
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
        private System.Windows.Forms.ComboBox cmbClientContractType;
        private System.Windows.Forms.ComboBox cmbEmployeeClassificaion;
        private System.Windows.Forms.ComboBox cmbEmployeeSkill;
    }
}

