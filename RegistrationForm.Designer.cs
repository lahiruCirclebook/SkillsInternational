namespace SkillsInternational
{
    partial class RegistrationForm
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
            this.grpStudentRegistration = new System.Windows.Forms.GroupBox();
            this.linklblExit = new System.Windows.Forms.LinkLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpParentDetails = new System.Windows.Forms.GroupBox();
            this.mtxtContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNIC = new System.Windows.Forms.MaskedTextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.grpContactDetails = new System.Windows.Forms.GroupBox();
            this.mtxtHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtMobilePhone = new System.Windows.Forms.MaskedTextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grpBasicDetails = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblTitleSR = new System.Windows.Forms.Label();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNIC = new System.Windows.Forms.ErrorProvider(this.components);
            this.linklblLogout = new System.Windows.Forms.LinkLabel();
            this.grpStudentRegistration.SuspendLayout();
            this.grpParentDetails.SuspendLayout();
            this.grpContactDetails.SuspendLayout();
            this.grpBasicDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStudentRegistration
            // 
            this.grpStudentRegistration.BackColor = System.Drawing.Color.White;
            this.grpStudentRegistration.Controls.Add(this.linklblExit);
            this.grpStudentRegistration.Controls.Add(this.btnClear);
            this.grpStudentRegistration.Controls.Add(this.btnDelete);
            this.grpStudentRegistration.Controls.Add(this.btnUpdate);
            this.grpStudentRegistration.Controls.Add(this.btnRegister);
            this.grpStudentRegistration.Controls.Add(this.grpParentDetails);
            this.grpStudentRegistration.Controls.Add(this.grpContactDetails);
            this.grpStudentRegistration.Controls.Add(this.grpBasicDetails);
            this.grpStudentRegistration.Controls.Add(this.cmbRegNo);
            this.grpStudentRegistration.Controls.Add(this.lblRegNo);
            this.grpStudentRegistration.Location = new System.Drawing.Point(12, 66);
            this.grpStudentRegistration.Name = "grpStudentRegistration";
            this.grpStudentRegistration.Size = new System.Drawing.Size(445, 605);
            this.grpStudentRegistration.TabIndex = 0;
            this.grpStudentRegistration.TabStop = false;
            this.grpStudentRegistration.Text = "Student Registration";
            // 
            // linklblExit
            // 
            this.linklblExit.AutoSize = true;
            this.linklblExit.Location = new System.Drawing.Point(415, 580);
            this.linklblExit.Name = "linklblExit";
            this.linklblExit.Size = new System.Drawing.Size(24, 13);
            this.linklblExit.TabIndex = 9;
            this.linklblExit.TabStop = true;
            this.linklblExit.Text = "Exit";
            this.linklblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblExit_LinkClicked);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 541);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(357, 541);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(112, 541);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(20, 541);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpParentDetails
            // 
            this.grpParentDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpParentDetails.Controls.Add(this.mtxtContactNumber);
            this.grpParentDetails.Controls.Add(this.mtxtNIC);
            this.grpParentDetails.Controls.Add(this.txtParentName);
            this.grpParentDetails.Controls.Add(this.lblContactNumber);
            this.grpParentDetails.Controls.Add(this.lblNIC);
            this.grpParentDetails.Controls.Add(this.lblParentName);
            this.grpParentDetails.Location = new System.Drawing.Point(20, 408);
            this.grpParentDetails.Name = "grpParentDetails";
            this.grpParentDetails.Size = new System.Drawing.Size(412, 114);
            this.grpParentDetails.TabIndex = 4;
            this.grpParentDetails.TabStop = false;
            this.grpParentDetails.Text = "Parent Details";
            // 
            // mtxtContactNumber
            // 
            this.mtxtContactNumber.Location = new System.Drawing.Point(102, 85);
            this.mtxtContactNumber.Mask = "(999) 000-0000";
            this.mtxtContactNumber.Name = "mtxtContactNumber";
            this.mtxtContactNumber.Size = new System.Drawing.Size(143, 20);
            this.mtxtContactNumber.TabIndex = 5;
            // 
            // mtxtNIC
            // 
            this.mtxtNIC.Location = new System.Drawing.Point(102, 56);
            this.mtxtNIC.Name = "mtxtNIC";
            this.mtxtNIC.Size = new System.Drawing.Size(143, 20);
            this.mtxtNIC.TabIndex = 4;
            this.mtxtNIC.MaskChanged += new System.EventHandler(this.mtxtNIC_MaskChanged);
            this.mtxtNIC.TextChanged += new System.EventHandler(this.mtxtNIC_TextChanged);
            this.mtxtNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtNIC_KeyPress);
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(102, 28);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(304, 20);
            this.txtParentName.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(19, 85);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 2;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(19, 56);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(25, 13);
            this.lblNIC.TabIndex = 1;
            this.lblNIC.Text = "NIC";
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(19, 28);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(69, 13);
            this.lblParentName.TabIndex = 0;
            this.lblParentName.Text = "Parent Name";
            // 
            // grpContactDetails
            // 
            this.grpContactDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpContactDetails.Controls.Add(this.mtxtHomePhone);
            this.grpContactDetails.Controls.Add(this.mtxtMobilePhone);
            this.grpContactDetails.Controls.Add(this.lblHomePhone);
            this.grpContactDetails.Controls.Add(this.lblMobilePhone);
            this.grpContactDetails.Controls.Add(this.txtEmail);
            this.grpContactDetails.Controls.Add(this.lblEmail);
            this.grpContactDetails.Controls.Add(this.txtAddress);
            this.grpContactDetails.Controls.Add(this.lblAddress);
            this.grpContactDetails.Location = new System.Drawing.Point(20, 246);
            this.grpContactDetails.Name = "grpContactDetails";
            this.grpContactDetails.Size = new System.Drawing.Size(412, 144);
            this.grpContactDetails.TabIndex = 3;
            this.grpContactDetails.TabStop = false;
            this.grpContactDetails.Text = "Contact Details";
            // 
            // mtxtHomePhone
            // 
            this.mtxtHomePhone.Location = new System.Drawing.Point(299, 110);
            this.mtxtHomePhone.Mask = "(999) 000-0000";
            this.mtxtHomePhone.Name = "mtxtHomePhone";
            this.mtxtHomePhone.Size = new System.Drawing.Size(107, 20);
            this.mtxtHomePhone.TabIndex = 7;
            this.mtxtHomePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtHomePhone_KeyPress);
            // 
            // mtxtMobilePhone
            // 
            this.mtxtMobilePhone.Location = new System.Drawing.Point(102, 110);
            this.mtxtMobilePhone.Mask = "(999) 000-0000";
            this.mtxtMobilePhone.Name = "mtxtMobilePhone";
            this.mtxtMobilePhone.Size = new System.Drawing.Size(115, 20);
            this.mtxtMobilePhone.TabIndex = 6;
            this.mtxtMobilePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtMobilePhone_KeyPress);
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(223, 113);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(69, 13);
            this.lblHomePhone.TabIndex = 5;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(21, 113);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(75, 13);
            this.lblMobilePhone.TabIndex = 4;
            this.lblMobilePhone.Text = "Mobile  Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 79);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 29);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(304, 37);
            this.txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(19, 32);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // grpBasicDetails
            // 
            this.grpBasicDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBasicDetails.Controls.Add(this.rbFemale);
            this.grpBasicDetails.Controls.Add(this.rbMale);
            this.grpBasicDetails.Controls.Add(this.dtpDOB);
            this.grpBasicDetails.Controls.Add(this.txtLastName);
            this.grpBasicDetails.Controls.Add(this.txtFirstName);
            this.grpBasicDetails.Controls.Add(this.lblGender);
            this.grpBasicDetails.Controls.Add(this.lblDOB);
            this.grpBasicDetails.Controls.Add(this.lblLastName);
            this.grpBasicDetails.Controls.Add(this.lblFirstName);
            this.grpBasicDetails.Location = new System.Drawing.Point(20, 80);
            this.grpBasicDetails.Name = "grpBasicDetails";
            this.grpBasicDetails.Size = new System.Drawing.Size(412, 150);
            this.grpBasicDetails.TabIndex = 2;
            this.grpBasicDetails.TabStop = false;
            this.grpBasicDetails.Text = "Basic Details";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(156, 110);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(102, 110);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarForeColor = System.Drawing.Color.Coral;
            this.dtpDOB.Location = new System.Drawing.Point(102, 84);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(192, 20);
            this.dtpDOB.TabIndex = 6;
            this.dtpDOB.Value = new System.DateTime(2025, 2, 26, 19, 37, 7, 0);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(102, 58);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(304, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(102, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(304, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(16, 114);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(16, 90);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(16, 65);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(16, 39);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.AllowDrop = true;
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(88, 39);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(121, 21);
            this.cmbRegNo.TabIndex = 1;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);
            this.cmbRegNo.Click += new System.EventHandler(this.cmbRegNo_Click);
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(27, 39);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(44, 13);
            this.lblRegNo.TabIndex = 0;
            this.lblRegNo.Text = "Reg No";
            // 
            // lblTitleSR
            // 
            this.lblTitleSR.AutoSize = true;
            this.lblTitleSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSR.Location = new System.Drawing.Point(168, 20);
            this.lblTitleSR.Name = "lblTitleSR";
            this.lblTitleSR.Size = new System.Drawing.Size(158, 20);
            this.lblTitleSR.TabIndex = 1;
            this.lblTitleSR.Text = "Skills International";
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            this.errorProviderEmail.RightToLeft = true;
            // 
            // errorProviderNIC
            // 
            this.errorProviderNIC.ContainerControl = this;
            // 
            // linklblLogout
            // 
            this.linklblLogout.AutoSize = true;
            this.linklblLogout.Location = new System.Drawing.Point(9, 9);
            this.linklblLogout.Name = "linklblLogout";
            this.linklblLogout.Size = new System.Drawing.Size(40, 13);
            this.linklblLogout.TabIndex = 2;
            this.linklblLogout.TabStop = true;
            this.linklblLogout.Text = "Logout";
            this.linklblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogout_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SkillsInternational.Properties.Resources.skills_2_removebg_preview;
            this.CancelButton = this.linklblExit;
            this.ClientSize = new System.Drawing.Size(471, 683);
            this.Controls.Add(this.linklblLogout);
            this.Controls.Add(this.lblTitleSR);
            this.Controls.Add(this.grpStudentRegistration);
            this.Name = "RegistrationForm";
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.grpStudentRegistration.ResumeLayout(false);
            this.grpStudentRegistration.PerformLayout();
            this.grpParentDetails.ResumeLayout(false);
            this.grpParentDetails.PerformLayout();
            this.grpContactDetails.ResumeLayout(false);
            this.grpContactDetails.PerformLayout();
            this.grpBasicDetails.ResumeLayout(false);
            this.grpBasicDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStudentRegistration;
        private System.Windows.Forms.Label lblTitleSR;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.GroupBox grpBasicDetails;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox grpContactDetails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.MaskedTextBox mtxtMobilePhone;
        private System.Windows.Forms.MaskedTextBox mtxtHomePhone;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.GroupBox grpParentDetails;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.MaskedTextBox mtxtNIC;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.ErrorProvider errorProviderNIC;
        private System.Windows.Forms.MaskedTextBox mtxtContactNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linklblLogout;
        private System.Windows.Forms.LinkLabel linklblExit;
    }
}