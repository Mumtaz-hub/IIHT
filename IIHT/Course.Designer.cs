namespace IIHT
{
    partial class frmCourse
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
            this.cmbCourseCategory = new System.Windows.Forms.ComboBox();
            this.lblCourseCategory = new System.Windows.Forms.Label();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.gridCourse = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCourseCategory
            // 
            this.cmbCourseCategory.FormattingEnabled = true;
            this.cmbCourseCategory.Location = new System.Drawing.Point(277, 136);
            this.cmbCourseCategory.Name = "cmbCourseCategory";
            this.cmbCourseCategory.Size = new System.Drawing.Size(138, 21);
            this.cmbCourseCategory.TabIndex = 0;
            this.cmbCourseCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCourseCategory_SelectedIndexChanged);
            this.cmbCourseCategory.SelectedValueChanged += new System.EventHandler(this.cmbCourseCategory_SelectedValueChanged);
            // 
            // lblCourseCategory
            // 
            this.lblCourseCategory.AutoSize = true;
            this.lblCourseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCategory.Location = new System.Drawing.Point(139, 136);
            this.lblCourseCategory.Name = "lblCourseCategory";
            this.lblCourseCategory.Size = new System.Drawing.Size(132, 20);
            this.lblCourseCategory.TabIndex = 1;
            this.lblCourseCategory.Text = "Course Category:";
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCourses.Location = new System.Drawing.Point(209, 199);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(179, 25);
            this.btnViewCourses.TabIndex = 11;
            this.btnViewCourses.Text = "Click to view course detail";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // gridCourse
            // 
            this.gridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourse.Location = new System.Drawing.Point(102, 228);
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.Size = new System.Drawing.Size(438, 150);
            this.gridCourse.TabIndex = 12;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(424, 199);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(106, 23);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(294, 384);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(64, 23);
            this.btnAddNew.TabIndex = 17;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(364, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 438);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gridCourse);
            this.Controls.Add(this.btnViewCourses);
            this.Controls.Add(this.lblCourseCategory);
            this.Controls.Add(this.cmbCourseCategory);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Course_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCourseCategory;
        private System.Windows.Forms.Label lblCourseCategory;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.DataGridView gridCourse;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
    }
}