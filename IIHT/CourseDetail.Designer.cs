namespace IIHT
{
    partial class CourseDetail
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
            this.grpCourseCategory = new System.Windows.Forms.GroupBox();
            this.gridCourseCategory = new System.Windows.Forms.DataGridView();
            this.grpbxCourseDetail = new System.Windows.Forms.GroupBox();
            this.gridCourseDetail = new System.Windows.Forms.DataGridView();
            this.grpbxModule = new System.Windows.Forms.GroupBox();
            this.gridCourseModule = new System.Windows.Forms.DataGridView();
            this.pnlmiddle.SuspendLayout();
            this.grpCourseCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseCategory)).BeginInit();
            this.grpbxCourseDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseDetail)).BeginInit();
            this.grpbxModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseModule)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmiddle
            // 
            this.pnlmiddle.Controls.Add(this.grpbxModule);
            this.pnlmiddle.Controls.Add(this.grpbxCourseDetail);
            this.pnlmiddle.Controls.Add(this.grpCourseCategory);
            this.pnlmiddle.Size = new System.Drawing.Size(676, 621);
            // 
            // grpCourseCategory
            // 
            this.grpCourseCategory.Controls.Add(this.gridCourseCategory);
            this.grpCourseCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCourseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCourseCategory.Location = new System.Drawing.Point(0, 0);
            this.grpCourseCategory.Name = "grpCourseCategory";
            this.grpCourseCategory.Size = new System.Drawing.Size(674, 173);
            this.grpCourseCategory.TabIndex = 0;
            this.grpCourseCategory.TabStop = false;
            this.grpCourseCategory.Text = "Course Category";
            // 
            // gridCourseCategory
            // 
            this.gridCourseCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCourseCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridCourseCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourseCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCourseCategory.GridColor = System.Drawing.Color.White;
            this.gridCourseCategory.Location = new System.Drawing.Point(3, 27);
            this.gridCourseCategory.Name = "gridCourseCategory";
            this.gridCourseCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourseCategory.Size = new System.Drawing.Size(668, 143);
            this.gridCourseCategory.TabIndex = 0;
            this.gridCourseCategory.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCourseCategory_RowEnter);
            this.gridCourseCategory.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCourseCategory_RowValidated);
            this.gridCourseCategory.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridCourseCategory_UserDeletedRow);
            this.gridCourseCategory.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridCourseCategory_UserDeletingRow);
            this.gridCourseCategory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCourseCategory_MouseDoubleClick);
            // 
            // grpbxCourseDetail
            // 
            this.grpbxCourseDetail.Controls.Add(this.gridCourseDetail);
            this.grpbxCourseDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxCourseDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxCourseDetail.Location = new System.Drawing.Point(0, 173);
            this.grpbxCourseDetail.Name = "grpbxCourseDetail";
            this.grpbxCourseDetail.Size = new System.Drawing.Size(674, 446);
            this.grpbxCourseDetail.TabIndex = 1;
            this.grpbxCourseDetail.TabStop = false;
            this.grpbxCourseDetail.Text = "Course Detail";
            // 
            // gridCourseDetail
            // 
            this.gridCourseDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCourseDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridCourseDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourseDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCourseDetail.GridColor = System.Drawing.Color.White;
            this.gridCourseDetail.Location = new System.Drawing.Point(3, 27);
            this.gridCourseDetail.Name = "gridCourseDetail";
            this.gridCourseDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourseDetail.Size = new System.Drawing.Size(668, 416);
            this.gridCourseDetail.TabIndex = 0;
            this.gridCourseDetail.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridCourseDetail_DefaultValuesNeeded);
            this.gridCourseDetail.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCourseDetail_RowEnter);
            this.gridCourseDetail.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCourseDetail_RowValidated);
            this.gridCourseDetail.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gridCourseDetail_RowValidating);
            this.gridCourseDetail.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridCourseDetail_UserDeletedRow);
            this.gridCourseDetail.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridCourseDetail_UserDeletingRow);
            this.gridCourseDetail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCourseDetail_MouseDoubleClick);
            // 
            // grpbxModule
            // 
            this.grpbxModule.Controls.Add(this.gridCourseModule);
            this.grpbxModule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbxModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxModule.Location = new System.Drawing.Point(0, 446);
            this.grpbxModule.Name = "grpbxModule";
            this.grpbxModule.Size = new System.Drawing.Size(674, 173);
            this.grpbxModule.TabIndex = 2;
            this.grpbxModule.TabStop = false;
            this.grpbxModule.Text = "Course Modules";
            // 
            // gridCourseModule
            // 
            this.gridCourseModule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCourseModule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridCourseModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourseModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCourseModule.GridColor = System.Drawing.Color.White;
            this.gridCourseModule.Location = new System.Drawing.Point(3, 27);
            this.gridCourseModule.Name = "gridCourseModule";
            this.gridCourseModule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourseModule.Size = new System.Drawing.Size(668, 143);
            this.gridCourseModule.TabIndex = 0;
            this.gridCourseModule.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridCourseModule_DefaultValuesNeeded);
            this.gridCourseModule.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCourseModule_RowValidated);
            this.gridCourseModule.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridCourseModule_UserDeletedRow);
            // 
            // CourseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.ClientSize = new System.Drawing.Size(676, 671);
            this.Name = "CourseDetail";
            this.Load += new System.EventHandler(this.CourseDetail_Load);
            this.pnlmiddle.ResumeLayout(false);
            this.grpCourseCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseCategory)).EndInit();
            this.grpbxCourseDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseDetail)).EndInit();
            this.grpbxModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseModule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCourseCategory;
        private System.Windows.Forms.DataGridView gridCourseCategory;
        private System.Windows.Forms.GroupBox grpbxCourseDetail;
        private System.Windows.Forms.DataGridView gridCourseDetail;
        private System.Windows.Forms.GroupBox grpbxModule;
        private System.Windows.Forms.DataGridView gridCourseModule;
    }
}
