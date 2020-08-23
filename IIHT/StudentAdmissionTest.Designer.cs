namespace IIHT
{
    partial class StudentAdmission
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnok = new System.Windows.Forms.Button();
            this.txtFieldValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.cmbFieldName = new System.Windows.Forms.ComboBox();
            this.lblFieldname = new System.Windows.Forms.Label();
            this.dgvName = new System.Windows.Forms.DataGridView();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlmiddle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvName)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmiddle
            // 
            this.pnlmiddle.Controls.Add(this.btnNameSearch);
            this.pnlmiddle.Controls.Add(this.btnSave);
            this.pnlmiddle.Controls.Add(this.panel1);
            this.pnlmiddle.Size = new System.Drawing.Size(1164, 568);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.txtFieldValue);
            this.panel1.Controls.Add(this.lblValue);
            this.panel1.Controls.Add(this.cmbFieldName);
            this.panel1.Controls.Add(this.lblFieldname);
            this.panel1.Controls.Add(this.dgvName);
            this.panel1.Location = new System.Drawing.Point(50, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 262);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(716, 20);
            this.btnok.Margin = new System.Windows.Forms.Padding(4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(112, 28);
            this.btnok.TabIndex = 52;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtFieldValue
            // 
            this.txtFieldValue.Location = new System.Drawing.Point(405, 20);
            this.txtFieldValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldValue.Name = "txtFieldValue";
            this.txtFieldValue.Size = new System.Drawing.Size(282, 22);
            this.txtFieldValue.TabIndex = 51;
            this.txtFieldValue.TextChanged += new System.EventHandler(this.txtFieldValue_TextChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(345, 23);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(48, 16);
            this.lblValue.TabIndex = 50;
            this.lblValue.Text = "Value";
            // 
            // cmbFieldName
            // 
            this.cmbFieldName.FormattingEnabled = true;
            this.cmbFieldName.Location = new System.Drawing.Point(111, 20);
            this.cmbFieldName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFieldName.Name = "cmbFieldName";
            this.cmbFieldName.Size = new System.Drawing.Size(212, 24);
            this.cmbFieldName.TabIndex = 49;
            this.cmbFieldName.SelectedValueChanged += new System.EventHandler(this.cmbFieldName_SelectedValueChanged);
            // 
            // lblFieldname
            // 
            this.lblFieldname.AutoSize = true;
            this.lblFieldname.Location = new System.Drawing.Point(15, 23);
            this.lblFieldname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFieldname.Name = "lblFieldname";
            this.lblFieldname.Size = new System.Drawing.Size(88, 16);
            this.lblFieldname.TabIndex = 48;
            this.lblFieldname.Text = "Field Name";
            // 
            // dgvName
            // 
            this.dgvName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvName.Location = new System.Drawing.Point(0, 64);
            this.dgvName.Margin = new System.Windows.Forms.Padding(4);
            this.dgvName.Name = "dgvName";
            this.dgvName.Size = new System.Drawing.Size(896, 198);
            this.dgvName.TabIndex = 0;
            this.dgvName.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvName_RowEnter);
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameSearch.Location = new System.Drawing.Point(343, 6);
            this.btnNameSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(256, 30);
            this.btnNameSearch.TabIndex = 46;
            this.btnNameSearch.Text = "Click to Search From Visitors";
            this.btnNameSearch.UseVisualStyleBackColor = true;
            this.btnNameSearch.Click += new System.EventHandler(this.btnNameSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1021, 190);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 43);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // StudentAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 618);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmStudentAdmission";
            this.Load += new System.EventHandler(this.frmStudentAdmission_Load);
            this.pnlmiddle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvName;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.Label lblFieldname;
        private System.Windows.Forms.ComboBox cmbFieldName;
        private System.Windows.Forms.TextBox txtFieldValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnSave;
    }
}