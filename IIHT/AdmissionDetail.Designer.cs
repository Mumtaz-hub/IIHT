namespace IIHT
{
    partial class AdmissionDetail
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpStudPersonal = new System.Windows.Forms.GroupBox();
            this.pnlSearchGrid = new System.Windows.Forms.Panel();
            this.gridStudent = new System.Windows.Forms.DataGridView();
            this.pnlFieldValue = new System.Windows.Forms.Panel();
            this.cmbFieldName = new System.Windows.Forms.ComboBox();
            this.txtFieldValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.pnlStudCourse = new System.Windows.Forms.Panel();
            this.txtCourseFees = new System.Windows.Forms.TextBox();
            this.lblCourseFees = new System.Windows.Forms.Label();
            this.dgvStudCourse = new System.Windows.Forms.DataGridView();
            this.pnlStudentCourseDetail = new System.Windows.Forms.Panel();
            this.dgvStudentCourseModuleDetail = new System.Windows.Forms.DataGridView();
            this.pnlFees = new System.Windows.Forms.Panel();
            this.gridFees = new System.Windows.Forms.DataGridView();
            this.pnlFeesDetail = new System.Windows.Forms.Panel();
            this.txtTotalRemaining = new System.Windows.Forms.TextBox();
            this.lblTotalRemaining = new System.Windows.Forms.Label();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.gridFeesDetail = new System.Windows.Forms.DataGridView();
            this.pnlmiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpStudPersonal.SuspendLayout();
            this.pnlSearchGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            this.pnlFieldValue.SuspendLayout();
            this.pnlStudCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudCourse)).BeginInit();
            this.pnlStudentCourseDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCourseModuleDetail)).BeginInit();
            this.pnlFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFees)).BeginInit();
            this.pnlFeesDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFeesDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmiddle
            // 
            this.pnlmiddle.Controls.Add(this.pnlFeesDetail);
            this.pnlmiddle.Controls.Add(this.pnlFees);
            this.pnlmiddle.Controls.Add(this.pnlStudentCourseDetail);
            this.pnlmiddle.Controls.Add(this.splitContainer1);
            this.pnlmiddle.Size = new System.Drawing.Size(1067, 709);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpStudPersonal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlStudCourse);
            this.splitContainer1.Size = new System.Drawing.Size(1065, 229);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.TabIndex = 3;
            // 
            // grpStudPersonal
            // 
            this.grpStudPersonal.Controls.Add(this.pnlSearchGrid);
            this.grpStudPersonal.Controls.Add(this.pnlFieldValue);
            this.grpStudPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStudPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudPersonal.Location = new System.Drawing.Point(0, 0);
            this.grpStudPersonal.Name = "grpStudPersonal";
            this.grpStudPersonal.Size = new System.Drawing.Size(800, 229);
            this.grpStudPersonal.TabIndex = 2;
            this.grpStudPersonal.TabStop = false;
            this.grpStudPersonal.Text = "Student Admission Information";
            // 
            // pnlSearchGrid
            // 
            this.pnlSearchGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchGrid.Controls.Add(this.gridStudent);
            this.pnlSearchGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearchGrid.Location = new System.Drawing.Point(3, 97);
            this.pnlSearchGrid.Name = "pnlSearchGrid";
            this.pnlSearchGrid.Size = new System.Drawing.Size(794, 129);
            this.pnlSearchGrid.TabIndex = 2;
            // 
            // gridStudent
            // 
            this.gridStudent.AllowUserToAddRows = false;
            this.gridStudent.AllowUserToDeleteRows = false;
            this.gridStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudent.BackgroundColor = System.Drawing.Color.White;
            this.gridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStudent.Location = new System.Drawing.Point(0, 0);
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudent.Size = new System.Drawing.Size(794, 129);
            this.gridStudent.TabIndex = 3;
            // 
            // pnlFieldValue
            // 
            this.pnlFieldValue.BackColor = System.Drawing.Color.White;
            this.pnlFieldValue.Controls.Add(this.cmbFieldName);
            this.pnlFieldValue.Controls.Add(this.txtFieldValue);
            this.pnlFieldValue.Controls.Add(this.lblValue);
            this.pnlFieldValue.Controls.Add(this.lblFieldName);
            this.pnlFieldValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldValue.Location = new System.Drawing.Point(3, 20);
            this.pnlFieldValue.Name = "pnlFieldValue";
            this.pnlFieldValue.Size = new System.Drawing.Size(794, 55);
            this.pnlFieldValue.TabIndex = 1;
            // 
            // cmbFieldName
            // 
            this.cmbFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFieldName.FormattingEnabled = true;
            this.cmbFieldName.Location = new System.Drawing.Point(113, 12);
            this.cmbFieldName.Name = "cmbFieldName";
            this.cmbFieldName.Size = new System.Drawing.Size(196, 28);
            this.cmbFieldName.TabIndex = 4;
            // 
            // txtFieldValue
            // 
            this.txtFieldValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldValue.Location = new System.Drawing.Point(400, 12);
            this.txtFieldValue.Name = "txtFieldValue";
            this.txtFieldValue.Size = new System.Drawing.Size(169, 26);
            this.txtFieldValue.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.Navy;
            this.lblValue.Location = new System.Drawing.Point(340, 15);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(60, 20);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Value:";
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldName.ForeColor = System.Drawing.Color.Navy;
            this.lblFieldName.Location = new System.Drawing.Point(3, 18);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(104, 20);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field Name:";
            // 
            // pnlStudCourse
            // 
            this.pnlStudCourse.Controls.Add(this.txtCourseFees);
            this.pnlStudCourse.Controls.Add(this.lblCourseFees);
            this.pnlStudCourse.Controls.Add(this.dgvStudCourse);
            this.pnlStudCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudCourse.Location = new System.Drawing.Point(0, 0);
            this.pnlStudCourse.Name = "pnlStudCourse";
            this.pnlStudCourse.Size = new System.Drawing.Size(261, 229);
            this.pnlStudCourse.TabIndex = 4;
            // 
            // txtCourseFees
            // 
            this.txtCourseFees.Location = new System.Drawing.Point(105, 205);
            this.txtCourseFees.Name = "txtCourseFees";
            this.txtCourseFees.Size = new System.Drawing.Size(145, 22);
            this.txtCourseFees.TabIndex = 4;
            // 
            // lblCourseFees
            // 
            this.lblCourseFees.AutoSize = true;
            this.lblCourseFees.Location = new System.Drawing.Point(3, 208);
            this.lblCourseFees.Name = "lblCourseFees";
            this.lblCourseFees.Size = new System.Drawing.Size(100, 16);
            this.lblCourseFees.TabIndex = 3;
            this.lblCourseFees.Text = "Course Fees:";
            // 
            // dgvStudCourse
            // 
            this.dgvStudCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudCourse.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStudCourse.Location = new System.Drawing.Point(0, 0);
            this.dgvStudCourse.Name = "dgvStudCourse";
            this.dgvStudCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudCourse.Size = new System.Drawing.Size(261, 161);
            this.dgvStudCourse.TabIndex = 2;
            this.dgvStudCourse.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudCourse_RowEnter);
            this.dgvStudCourse.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvStudCourse_MouseDoubleClick);
            // 
            // pnlStudentCourseDetail
            // 
            this.pnlStudentCourseDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnlStudentCourseDetail.Controls.Add(this.dgvStudentCourseModuleDetail);
            this.pnlStudentCourseDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentCourseDetail.Location = new System.Drawing.Point(0, 229);
            this.pnlStudentCourseDetail.Name = "pnlStudentCourseDetail";
            this.pnlStudentCourseDetail.Size = new System.Drawing.Size(1065, 169);
            this.pnlStudentCourseDetail.TabIndex = 4;
            // 
            // dgvStudentCourseModuleDetail
            // 
            this.dgvStudentCourseModuleDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentCourseModuleDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentCourseModuleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentCourseModuleDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentCourseModuleDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentCourseModuleDetail.Name = "dgvStudentCourseModuleDetail";
            this.dgvStudentCourseModuleDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentCourseModuleDetail.Size = new System.Drawing.Size(1065, 169);
            this.dgvStudentCourseModuleDetail.TabIndex = 3;
            this.dgvStudentCourseModuleDetail.DataSourceChanged += new System.EventHandler(this.dgvStudentCourseModuleDetail_DataSourceChanged);
            this.dgvStudentCourseModuleDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvStudentCourseModuleDetail_DataError);
            // 
            // pnlFees
            // 
            this.pnlFees.Controls.Add(this.gridFees);
            this.pnlFees.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFees.Location = new System.Drawing.Point(0, 398);
            this.pnlFees.Name = "pnlFees";
            this.pnlFees.Size = new System.Drawing.Size(1065, 75);
            this.pnlFees.TabIndex = 5;
            // 
            // gridFees
            // 
            this.gridFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFees.BackgroundColor = System.Drawing.Color.White;
            this.gridFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFees.Location = new System.Drawing.Point(0, 0);
            this.gridFees.Name = "gridFees";
            this.gridFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFees.Size = new System.Drawing.Size(1065, 75);
            this.gridFees.TabIndex = 5;
            this.gridFees.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFees_CellValueChanged);
            this.gridFees.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridFees_DataError);
            this.gridFees.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridFees_DefaultValuesNeeded);
            this.gridFees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFees_RowEnter);
            this.gridFees.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFees_RowValidated);
            // 
            // pnlFeesDetail
            // 
            this.pnlFeesDetail.Controls.Add(this.txtTotalRemaining);
            this.pnlFeesDetail.Controls.Add(this.lblTotalRemaining);
            this.pnlFeesDetail.Controls.Add(this.txtTotalPaid);
            this.pnlFeesDetail.Controls.Add(this.lblTotalPaid);
            this.pnlFeesDetail.Controls.Add(this.gridFeesDetail);
            this.pnlFeesDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFeesDetail.Location = new System.Drawing.Point(0, 473);
            this.pnlFeesDetail.Name = "pnlFeesDetail";
            this.pnlFeesDetail.Size = new System.Drawing.Size(1065, 235);
            this.pnlFeesDetail.TabIndex = 6;
            // 
            // txtTotalRemaining
            // 
            this.txtTotalRemaining.Location = new System.Drawing.Point(421, 210);
            this.txtTotalRemaining.Name = "txtTotalRemaining";
            this.txtTotalRemaining.Size = new System.Drawing.Size(148, 22);
            this.txtTotalRemaining.TabIndex = 8;
            // 
            // lblTotalRemaining
            // 
            this.lblTotalRemaining.AutoSize = true;
            this.lblTotalRemaining.Location = new System.Drawing.Point(289, 213);
            this.lblTotalRemaining.Name = "lblTotalRemaining";
            this.lblTotalRemaining.Size = new System.Drawing.Size(126, 16);
            this.lblTotalRemaining.TabIndex = 7;
            this.lblTotalRemaining.Text = "Total Remaining:";
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(97, 210);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(148, 22);
            this.txtTotalPaid.TabIndex = 5;
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Location = new System.Drawing.Point(7, 216);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(84, 16);
            this.lblTotalPaid.TabIndex = 6;
            this.lblTotalPaid.Text = "Total Paid:";
            // 
            // gridFeesDetail
            // 
            this.gridFeesDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFeesDetail.BackgroundColor = System.Drawing.Color.White;
            this.gridFeesDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFeesDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridFeesDetail.Location = new System.Drawing.Point(0, 0);
            this.gridFeesDetail.Name = "gridFeesDetail";
            this.gridFeesDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFeesDetail.Size = new System.Drawing.Size(1065, 142);
            this.gridFeesDetail.TabIndex = 5;
            // 
            // AdmissionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 759);
            this.Name = "AdmissionDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdmissionDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdmissionDetail_KeyDown);
            this.pnlmiddle.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpStudPersonal.ResumeLayout(false);
            this.pnlSearchGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            this.pnlFieldValue.ResumeLayout(false);
            this.pnlFieldValue.PerformLayout();
            this.pnlStudCourse.ResumeLayout(false);
            this.pnlStudCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudCourse)).EndInit();
            this.pnlStudentCourseDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCourseModuleDetail)).EndInit();
            this.pnlFees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFees)).EndInit();
            this.pnlFeesDetail.ResumeLayout(false);
            this.pnlFeesDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFeesDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpStudPersonal;
        private System.Windows.Forms.Panel pnlSearchGrid;
        private System.Windows.Forms.Panel pnlFieldValue;
        private System.Windows.Forms.ComboBox cmbFieldName;
        private System.Windows.Forms.TextBox txtFieldValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Panel pnlStudCourse;
        private System.Windows.Forms.DataGridView dgvStudCourse;
        private System.Windows.Forms.DataGridView gridStudent;
        private System.Windows.Forms.Panel pnlStudentCourseDetail;
        private System.Windows.Forms.DataGridView dgvStudentCourseModuleDetail;
        private System.Windows.Forms.Panel pnlFeesDetail;
        private System.Windows.Forms.DataGridView gridFeesDetail;
        private System.Windows.Forms.Panel pnlFees;
        private System.Windows.Forms.DataGridView gridFees;
        private System.Windows.Forms.TextBox txtCourseFees;
        private System.Windows.Forms.Label lblCourseFees;
        private System.Windows.Forms.TextBox txtTotalRemaining;
        private System.Windows.Forms.Label lblTotalRemaining;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label lblTotalPaid;




    }
}
