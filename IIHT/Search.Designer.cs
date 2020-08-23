namespace IIHT
{
    partial class Search
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
            this.pnlFieldValue = new System.Windows.Forms.Panel();
            this.cmbFieldName = new System.Windows.Forms.ComboBox();
            this.txtFieldValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.pnlSearchGrid = new System.Windows.Forms.Panel();
            this.gridSearch = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlFieldValue.SuspendLayout();
            this.pnlSearchGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmiddle
            // 
            this.pnlmiddle.Size = new System.Drawing.Size(647, 328);
            // 
            // pnlFieldValue
            // 
            this.pnlFieldValue.BackColor = System.Drawing.Color.White;
            this.pnlFieldValue.Controls.Add(this.cmbFieldName);
            this.pnlFieldValue.Controls.Add(this.txtFieldValue);
            this.pnlFieldValue.Controls.Add(this.lblValue);
            this.pnlFieldValue.Controls.Add(this.lblFieldName);
            this.pnlFieldValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldValue.Location = new System.Drawing.Point(0, 0);
            this.pnlFieldValue.Name = "pnlFieldValue";
            this.pnlFieldValue.Size = new System.Drawing.Size(647, 52);
            this.pnlFieldValue.TabIndex = 0;
            // 
            // cmbFieldName
            // 
            this.cmbFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFieldName.FormattingEnabled = true;
            this.cmbFieldName.Location = new System.Drawing.Point(113, 12);
            this.cmbFieldName.Name = "cmbFieldName";
            this.cmbFieldName.Size = new System.Drawing.Size(196, 28);
            this.cmbFieldName.TabIndex = 4;
            this.cmbFieldName.SelectedValueChanged += new System.EventHandler(this.cmbFieldName_SelectedValueChanged);
            // 
            // txtFieldValue
            // 
            this.txtFieldValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldValue.Location = new System.Drawing.Point(400, 12);
            this.txtFieldValue.Name = "txtFieldValue";
            this.txtFieldValue.Size = new System.Drawing.Size(169, 26);
            this.txtFieldValue.TabIndex = 3;
            this.txtFieldValue.TextChanged += new System.EventHandler(this.txtFieldValue_TextChanged);
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
            // pnlSearchGrid
            // 
            this.pnlSearchGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchGrid.Controls.Add(this.gridSearch);
            this.pnlSearchGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearchGrid.Location = new System.Drawing.Point(0, 58);
            this.pnlSearchGrid.Name = "pnlSearchGrid";
            this.pnlSearchGrid.Size = new System.Drawing.Size(647, 270);
            this.pnlSearchGrid.TabIndex = 1;
            // 
            // gridSearch
            // 
            this.gridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSearch.Location = new System.Drawing.Point(0, 0);
            this.gridSearch.Name = "gridSearch";
            this.gridSearch.Size = new System.Drawing.Size(647, 270);
            this.gridSearch.TabIndex = 0;
            this.gridSearch.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSearch_RowEnter);
            this.gridSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridSearch_MouseDoubleClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.pnlFieldValue);
            this.pnlSearch.Controls.Add(this.pnlSearchGrid);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(0, 27);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(647, 328);
            this.pnlSearch.TabIndex = 2;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 378);
            this.Controls.Add(this.pnlSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Search_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            this.Controls.SetChildIndex(this.pnlmiddle, 0);
            this.Controls.SetChildIndex(this.pnlSearch, 0);
            this.pnlFieldValue.ResumeLayout(false);
            this.pnlFieldValue.PerformLayout();
            this.pnlSearchGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFieldValue;
        private System.Windows.Forms.TextBox txtFieldValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.ComboBox cmbFieldName;
        private System.Windows.Forms.Panel pnlSearchGrid;
        private System.Windows.Forms.DataGridView gridSearch;
        private System.Windows.Forms.Panel pnlSearch;
    }
}
