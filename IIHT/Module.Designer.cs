namespace IIHT
{
    partial class frmModule
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
            this.lblCourseCategory = new System.Windows.Forms.Label();
            this.cmbCourseCategory = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.pnlAddModule = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lstModules = new System.Windows.Forms.ListBox();
            this.lblModuleList = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.pnlAddModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourseCategory
            // 
            this.lblCourseCategory.AutoSize = true;
            this.lblCourseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCategory.Location = new System.Drawing.Point(12, 25);
            this.lblCourseCategory.Name = "lblCourseCategory";
            this.lblCourseCategory.Size = new System.Drawing.Size(132, 20);
            this.lblCourseCategory.TabIndex = 0;
            this.lblCourseCategory.Text = "Course Category:";
            // 
            // cmbCourseCategory
            // 
            this.cmbCourseCategory.FormattingEnabled = true;
            this.cmbCourseCategory.Location = new System.Drawing.Point(150, 25);
            this.cmbCourseCategory.Name = "cmbCourseCategory";
            this.cmbCourseCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCourseCategory.TabIndex = 1;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(324, 23);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(64, 20);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Course:";
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(394, 22);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(121, 21);
            this.cmbCourseName.TabIndex = 3;
            // 
            // pnlAddModule
            // 
            this.pnlAddModule.AccessibleName = "";
            this.pnlAddModule.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAddModule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddModule.Controls.Add(this.btnEdit);
            this.pnlAddModule.Controls.Add(this.cmbCourseName);
            this.pnlAddModule.Controls.Add(this.lstModules);
            this.pnlAddModule.Controls.Add(this.lblCourse);
            this.pnlAddModule.Controls.Add(this.lblModuleList);
            this.pnlAddModule.Controls.Add(this.cmbCourseCategory);
            this.pnlAddModule.Controls.Add(this.btnAdd);
            this.pnlAddModule.Controls.Add(this.lblCourseCategory);
            this.pnlAddModule.Controls.Add(this.txtModule);
            this.pnlAddModule.Controls.Add(this.lblModule);
            this.pnlAddModule.Location = new System.Drawing.Point(27, 79);
            this.pnlAddModule.Name = "pnlAddModule";
            this.pnlAddModule.Size = new System.Drawing.Size(554, 310);
            this.pnlAddModule.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(229, 135);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(44, 39);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "<<";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lstModules
            // 
            this.lstModules.FormattingEnabled = true;
            this.lstModules.Location = new System.Drawing.Point(322, 106);
            this.lstModules.Name = "lstModules";
            this.lstModules.Size = new System.Drawing.Size(120, 56);
            this.lstModules.TabIndex = 4;
            this.lstModules.SelectedIndexChanged += new System.EventHandler(this.lstModules_SelectedIndexChanged);
            this.lstModules.SelectedValueChanged += new System.EventHandler(this.lstModules_SelectedValueChanged);
            // 
            // lblModuleList
            // 
            this.lblModuleList.AutoSize = true;
            this.lblModuleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleList.Location = new System.Drawing.Point(319, 67);
            this.lblModuleList.Name = "lblModuleList";
            this.lblModuleList.Size = new System.Drawing.Size(69, 18);
            this.lblModuleList.TabIndex = 3;
            this.lblModuleList.Text = "Modules:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(229, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(87, 156);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(100, 20);
            this.txtModule.TabIndex = 1;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.Location = new System.Drawing.Point(3, 156);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(61, 18);
            this.lblModule.TabIndex = 0;
            this.lblModule.Text = "Module:";
            // 
            // frmModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 429);
            this.Controls.Add(this.pnlAddModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Module";
            this.pnlAddModule.ResumeLayout(false);
            this.pnlAddModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCourseCategory;
        private System.Windows.Forms.ComboBox cmbCourseCategory;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Panel pnlAddModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblModuleList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.ListBox lstModules;
        private System.Windows.Forms.Button btnEdit;
    }
}