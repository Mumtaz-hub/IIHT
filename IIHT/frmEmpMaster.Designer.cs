namespace IIHT
{
    partial class frmEmpMaster
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
            this.dgvEmpMaster = new System.Windows.Forms.DataGridView();
            this.pnlmiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmiddle
            // 
            this.pnlmiddle.Controls.Add(this.dgvEmpMaster);
            this.pnlmiddle.Size = new System.Drawing.Size(1120, 426);
            // 
            // dgvEmpMaster
            // 
            this.dgvEmpMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpMaster.Name = "dgvEmpMaster";
            this.dgvEmpMaster.Size = new System.Drawing.Size(1118, 424);
            this.dgvEmpMaster.TabIndex = 1;
            this.dgvEmpMaster.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpMaster_RowValidated);
            this.dgvEmpMaster.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvEmpMaster_UserDeletedRow);
            // 
            // frmEmpMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 476);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmEmpMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Master";
            this.Load += new System.EventHandler(this.frmEmpMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmpMaster_KeyDown);
            this.pnlmiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpMaster;
    }
}