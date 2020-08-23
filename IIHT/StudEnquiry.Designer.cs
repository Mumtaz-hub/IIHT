namespace IIHT
{
    partial class frmStudEnquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudEnquiry));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbEmpName = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.Course = new System.Windows.Forms.Label();
            this.lblCounsName = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRefBy = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRefBy = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblWhatsApp = new System.Windows.Forms.Label();
            this.txtWhatsApp = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblEducation = new System.Windows.Forms.Label();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntryDate = new System.Windows.Forms.TextBox();
            this.lblVisitorId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAdmission = new System.Windows.Forms.Panel();
            this.lblStudId = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnImgUpload = new System.Windows.Forms.Button();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDOA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileStudImg = new System.Windows.Forms.OpenFileDialog();
            this.pnlmiddle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAdmission.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmiddle
            // 
            this.pnlmiddle.Controls.Add(this.pnlAdmission);
            this.pnlmiddle.Location = new System.Drawing.Point(0, 291);
            this.pnlmiddle.Size = new System.Drawing.Size(882, 143);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbEmpName);
            this.panel2.Controls.Add(this.cmbCourse);
            this.panel2.Controls.Add(this.Course);
            this.panel2.Controls.Add(this.lblCounsName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 51);
            this.panel2.TabIndex = 25;
            // 
            // cmbEmpName
            // 
            this.cmbEmpName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmpName.FormattingEnabled = true;
            this.cmbEmpName.Location = new System.Drawing.Point(621, 12);
            this.cmbEmpName.Name = "cmbEmpName";
            this.cmbEmpName.Size = new System.Drawing.Size(177, 23);
            this.cmbEmpName.TabIndex = 14;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(165, 15);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(228, 24);
            this.cmbCourse.TabIndex = 13;
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.Location = new System.Drawing.Point(69, 16);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(76, 18);
            this.Course.TabIndex = 12;
            this.Course.Text = "Course:";
            // 
            // lblCounsName
            // 
            this.lblCounsName.AutoSize = true;
            this.lblCounsName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounsName.Location = new System.Drawing.Point(455, 16);
            this.lblCounsName.Name = "lblCounsName";
            this.lblCounsName.Size = new System.Drawing.Size(162, 18);
            this.lblCounsName.TabIndex = 11;
            this.lblCounsName.Text = "Counsellor Name:";
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlButton.Controls.Add(this.btn_New);
            this.pnlButton.Controls.Add(this.btn_Clear);
            this.pnlButton.Controls.Add(this.btn_Find);
            this.pnlButton.Controls.Add(this.btn_last);
            this.pnlButton.Controls.Add(this.btn_next);
            this.pnlButton.Controls.Add(this.btn_previous);
            this.pnlButton.Controls.Add(this.btn_First);
            this.pnlButton.Controls.Add(this.btn_Edit);
            this.pnlButton.Controls.Add(this.btn_Cancel);
            this.pnlButton.Controls.Add(this.btn_Close);
            this.pnlButton.Controls.Add(this.btn_Save);
            this.pnlButton.Controls.Add(this.btn_Delete);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 434);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(882, 64);
            this.pnlButton.TabIndex = 37;
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_New.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_New.Image = global::IIHT.Properties.Resources.btn_New_Image;
            this.btn_New.Location = new System.Drawing.Point(3, 1);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(91, 63);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&New";
            this.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_New.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.Location = new System.Drawing.Point(458, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(91, 63);
            this.btn_Clear.TabIndex = 15;
            this.btn_Clear.TabStop = false;
            this.btn_Clear.Text = "Clea&r";
            this.btn_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Find.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Image = global::IIHT.Properties.Resources.btn_Find_Image;
            this.btn_Find.Location = new System.Drawing.Point(738, 2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(47, 60);
            this.btn_Find.TabIndex = 19;
            this.btn_Find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Find.UseVisualStyleBackColor = true;
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_last.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Image = ((System.Drawing.Image)(resources.GetObject("btn_last.Image")));
            this.btn_last.Location = new System.Drawing.Point(832, 2);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(47, 60);
            this.btn_last.TabIndex = 21;
            this.btn_last.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_last.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_next.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(785, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(47, 60);
            this.btn_next.TabIndex = 20;
            this.btn_next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_previous.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_previous.Image")));
            this.btn_previous.Location = new System.Drawing.Point(691, 2);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(47, 60);
            this.btn_previous.TabIndex = 18;
            this.btn_previous.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_previous.UseVisualStyleBackColor = true;
            // 
            // btn_First
            // 
            this.btn_First.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_First.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_First.Image = ((System.Drawing.Image)(resources.GetObject("btn_First.Image")));
            this.btn_First.Location = new System.Drawing.Point(644, 2);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(47, 60);
            this.btn_First.TabIndex = 17;
            this.btn_First.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_First.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Edit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.Location = new System.Drawing.Point(94, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(91, 63);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "&Edit";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(367, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 63);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "C&ancel";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(549, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(91, 62);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.TabStop = false;
            this.btn_Close.Text = "&Close";
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(185, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 63);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "&Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(276, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 63);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "&Delete";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Navy;
            this.lblName.Location = new System.Drawing.Point(80, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 18);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(60, 69);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 18);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(526, 19);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(82, 18);
            this.lblContact.TabIndex = 29;
            this.lblContact.Text = "Contact:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(544, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 18);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:";
            // 
            // lblRefBy
            // 
            this.lblRefBy.AutoSize = true;
            this.lblRefBy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefBy.ForeColor = System.Drawing.Color.Navy;
            this.lblRefBy.Location = new System.Drawing.Point(460, 130);
            this.lblRefBy.Name = "lblRefBy";
            this.lblRefBy.Size = new System.Drawing.Size(144, 18);
            this.lblRefBy.TabIndex = 33;
            this.lblRefBy.Text = "Referenced By:";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(151, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(151, 53);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(231, 58);
            this.txtAddress.TabIndex = 1;
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(609, 15);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(228, 26);
            this.txtContact.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(604, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtRefBy
            // 
            this.txtRefBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefBy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefBy.Location = new System.Drawing.Point(604, 128);
            this.txtRefBy.Name = "txtRefBy";
            this.txtRefBy.Size = new System.Drawing.Size(228, 26);
            this.txtRefBy.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(98, 119);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 18);
            this.lblCity.TabIndex = 38;
            this.lblCity.Text = "City:";
            // 
            // lblWhatsApp
            // 
            this.lblWhatsApp.AutoSize = true;
            this.lblWhatsApp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatsApp.Location = new System.Drawing.Point(500, 53);
            this.lblWhatsApp.Name = "lblWhatsApp";
            this.lblWhatsApp.Size = new System.Drawing.Size(104, 18);
            this.lblWhatsApp.TabIndex = 39;
            this.lblWhatsApp.Text = "WhatsApp:";
            // 
            // txtWhatsApp
            // 
            this.txtWhatsApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWhatsApp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhatsApp.Location = new System.Drawing.Point(604, 51);
            this.txtWhatsApp.Name = "txtWhatsApp";
            this.txtWhatsApp.Size = new System.Drawing.Size(228, 26);
            this.txtWhatsApp.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(151, 127);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(231, 26);
            this.txtCity.TabIndex = 2;
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducation.Location = new System.Drawing.Point(45, 169);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(100, 18);
            this.lblEducation.TabIndex = 40;
            this.lblEducation.Text = "Education:";
            // 
            // txtEducation
            // 
            this.txtEducation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEducation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEducation.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEducation.Location = new System.Drawing.Point(151, 169);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(231, 26);
            this.txtEducation.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(525, 176);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(79, 18);
            this.lblGender.TabIndex = 41;
            this.lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(604, 171);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(89, 26);
            this.cmbGender.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Date:";
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEntryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryDate.Location = new System.Drawing.Point(756, 170);
            this.txtEntryDate.Name = "txtEntryDate";
            this.txtEntryDate.Size = new System.Drawing.Size(92, 26);
            this.txtEntryDate.TabIndex = 42;
            // 
            // lblVisitorId
            // 
            this.lblVisitorId.AutoSize = true;
            this.lblVisitorId.Location = new System.Drawing.Point(388, 26);
            this.lblVisitorId.Name = "lblVisitorId";
            this.lblVisitorId.Size = new System.Drawing.Size(0, 15);
            this.lblVisitorId.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblVisitorId);
            this.panel1.Controls.Add(this.txtEntryDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.txtEducation);
            this.panel1.Controls.Add(this.lblEducation);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtWhatsApp);
            this.panel1.Controls.Add(this.lblWhatsApp);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.txtRefBy);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblRefBy);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 213);
            this.panel1.TabIndex = 24;
            // 
            // pnlAdmission
            // 
            this.pnlAdmission.AutoSize = true;
            this.pnlAdmission.Controls.Add(this.lblStudId);
            this.pnlAdmission.Controls.Add(this.lblStudentId);
            this.pnlAdmission.Controls.Add(this.btnAdmission);
            this.pnlAdmission.Controls.Add(this.btnImgUpload);
            this.pnlAdmission.Controls.Add(this.txtPhoto);
            this.pnlAdmission.Controls.Add(this.label4);
            this.pnlAdmission.Controls.Add(this.txtDOA);
            this.pnlAdmission.Controls.Add(this.label3);
            this.pnlAdmission.Controls.Add(this.txtDOB);
            this.pnlAdmission.Controls.Add(this.label2);
            this.pnlAdmission.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmission.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmission.Name = "pnlAdmission";
            this.pnlAdmission.Size = new System.Drawing.Size(880, 99);
            this.pnlAdmission.TabIndex = 0;
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.Location = new System.Drawing.Point(242, 72);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.Size = new System.Drawing.Size(0, 15);
            this.lblStudId.TabIndex = 52;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(25, 63);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(0, 20);
            this.lblStudentId.TabIndex = 51;
            // 
            // btnAdmission
            // 
            this.btnAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmission.Location = new System.Drawing.Point(617, 63);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(252, 33);
            this.btnAdmission.TabIndex = 50;
            this.btnAdmission.Text = "Confirm Admission";
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // btnImgUpload
            // 
            this.btnImgUpload.Location = new System.Drawing.Point(810, 20);
            this.btnImgUpload.Name = "btnImgUpload";
            this.btnImgUpload.Size = new System.Drawing.Size(59, 28);
            this.btnImgUpload.TabIndex = 49;
            this.btnImgUpload.Text = "Browse";
            this.btnImgUpload.UseVisualStyleBackColor = true;
            this.btnImgUpload.Click += new System.EventHandler(this.btnImgUpload_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(657, 20);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(147, 21);
            this.txtPhoto.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Photo:";
            // 
            // txtDOA
            // 
            this.txtDOA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDOA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOA.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOA.Location = new System.Drawing.Point(458, 15);
            this.txtDOA.Name = "txtDOA";
            this.txtDOA.Size = new System.Drawing.Size(92, 26);
            this.txtDOA.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Admission Date:";
            // 
            // txtDOB
            // 
            this.txtDOB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(152, 15);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(92, 26);
            this.txtDOB.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Birth Date:";
            // 
            // openFileStudImg
            // 
            this.openFileStudImg.FileName = "openFileDialog1";
            // 
            // frmStudEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(882, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudEnquiry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Enquiry";
            this.Load += new System.EventHandler(this.frmStudEnquiry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStudEnquiry_KeyDown);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pnlmiddle, 0);
            this.pnlmiddle.ResumeLayout(false);
            this.pnlmiddle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAdmission.ResumeLayout(false);
            this.pnlAdmission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.Label lblCounsName;
        internal System.Windows.Forms.Panel pnlButton;
        internal System.Windows.Forms.Button btn_Clear;
        internal System.Windows.Forms.Button btn_Find;
        internal System.Windows.Forms.Button btn_last;
        internal System.Windows.Forms.Button btn_next;
        internal System.Windows.Forms.Button btn_previous;
        internal System.Windows.Forms.Button btn_First;
        internal System.Windows.Forms.Button btn_Edit;
        internal System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.Button btn_Save;
        internal System.Windows.Forms.Button btn_Delete;
        internal System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.ComboBox cmbEmpName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRefBy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRefBy;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblWhatsApp;
        private System.Windows.Forms.TextBox txtWhatsApp;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntryDate;
        private System.Windows.Forms.Label lblVisitorId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAdmission;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDOA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImgUpload;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileStudImg;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Label lblStudId;
    }
}