namespace IIHT
{
    partial class BaseForm
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
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnCloseA = new System.Windows.Forms.Button();
            this.lblMainHead = new System.Windows.Forms.Label();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlmiddle = new System.Windows.Forms.Panel();
            this.pnltop.SuspendLayout();
            this.pnlbottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.SystemColors.Info;
            this.pnltop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnltop.Controls.Add(this.btnCloseA);
            this.pnltop.Controls.Add(this.lblMainHead);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(505, 27);
            this.pnltop.TabIndex = 0;
            // 
            // btnCloseA
            // 
            this.btnCloseA.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseA.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCloseA.Image = global::IIHT.Properties.Resources.close_box_red;
            this.btnCloseA.Location = new System.Drawing.Point(480, 0);
            this.btnCloseA.Name = "btnCloseA";
            this.btnCloseA.Size = new System.Drawing.Size(23, 25);
            this.btnCloseA.TabIndex = 1;
            this.btnCloseA.UseVisualStyleBackColor = true;
            this.btnCloseA.Click += new System.EventHandler(this.btnCloseA_Click);
            // 
            // lblMainHead
            // 
            this.lblMainHead.AutoSize = true;
            this.lblMainHead.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHead.Location = new System.Drawing.Point(0, 1);
            this.lblMainHead.Name = "lblMainHead";
            this.lblMainHead.Size = new System.Drawing.Size(127, 24);
            this.lblMainHead.TabIndex = 0;
            this.lblMainHead.Text = "IIHT Navsari";
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.SystemColors.Info;
            this.pnlbottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlbottom.Controls.Add(this.lblMessage);
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlbottom.Location = new System.Drawing.Point(0, 355);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(505, 23);
            this.pnlbottom.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(3, 1);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 5;
            // 
            // pnlmiddle
            // 
            this.pnlmiddle.BackColor = System.Drawing.Color.Transparent;
            this.pnlmiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmiddle.Location = new System.Drawing.Point(0, 27);
            this.pnlmiddle.Name = "pnlmiddle";
            this.pnlmiddle.Size = new System.Drawing.Size(505, 328);
            this.pnlmiddle.TabIndex = 2;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(505, 378);
            this.ControlBox = false;
            this.Controls.Add(this.pnlmiddle);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnltop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BaseForm_KeyDown);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlbottom.ResumeLayout(false);
            this.pnlbottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Label lblMainHead;
        public System.Windows.Forms.Label lblMessage;
        protected System.Windows.Forms.Panel pnlmiddle;
        private System.Windows.Forms.Button btnCloseA;
    }
}