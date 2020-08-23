namespace IIHT
{
    partial class frmReport
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
            this.rgbDatewiseVisitorList = new System.Windows.Forms.RadioButton();
            this.grpVisitorDate = new System.Windows.Forms.GroupBox();
            this.txtTDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpVisitorDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmiddle
            // 
            this.pnlmiddle.Size = new System.Drawing.Size(939, 502);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rgbDatewiseVisitorList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpVisitorDate);
            this.splitContainer1.Panel2.Controls.Add(this.btnOk);
            this.splitContainer1.Size = new System.Drawing.Size(939, 502);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 3;
            // 
            // rgbDatewiseVisitorList
            // 
            this.rgbDatewiseVisitorList.AutoSize = true;
            this.rgbDatewiseVisitorList.Location = new System.Drawing.Point(3, 7);
            this.rgbDatewiseVisitorList.Name = "rgbDatewiseVisitorList";
            this.rgbDatewiseVisitorList.Size = new System.Drawing.Size(164, 20);
            this.rgbDatewiseVisitorList.TabIndex = 0;
            this.rgbDatewiseVisitorList.TabStop = true;
            this.rgbDatewiseVisitorList.Text = "Date wise visitor list";
            this.rgbDatewiseVisitorList.UseVisualStyleBackColor = true;
            // 
            // grpVisitorDate
            // 
            this.grpVisitorDate.Controls.Add(this.txtTDate);
            this.grpVisitorDate.Controls.Add(this.label2);
            this.grpVisitorDate.Controls.Add(this.txtFDate);
            this.grpVisitorDate.Controls.Add(this.label1);
            this.grpVisitorDate.Location = new System.Drawing.Point(37, 345);
            this.grpVisitorDate.Name = "grpVisitorDate";
            this.grpVisitorDate.Size = new System.Drawing.Size(311, 51);
            this.grpVisitorDate.TabIndex = 2;
            this.grpVisitorDate.TabStop = false;
            this.grpVisitorDate.Text = "Date";
            // 
            // txtTDate
            // 
            this.txtTDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTDate.Location = new System.Drawing.Point(201, 19);
            this.txtTDate.Name = "txtTDate";
            this.txtTDate.Size = new System.Drawing.Size(95, 22);
            this.txtTDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // txtFDate
            // 
            this.txtFDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFDate.Location = new System.Drawing.Point(60, 19);
            this.txtFDate.Name = "txtFDate";
            this.txtFDate.Size = new System.Drawing.Size(95, 22);
            this.txtFDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(519, 458);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 40);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.ClientSize = new System.Drawing.Size(939, 552);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.pnlmiddle, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpVisitorDate.ResumeLayout(false);
            this.grpVisitorDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rgbDatewiseVisitorList;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpVisitorDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFDate;
        private System.Windows.Forms.TextBox txtTDate;
        private System.Windows.Forms.Label label2;
    }
}
