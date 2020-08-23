using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IIHT
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void btnCloseA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowMessagePrompt(string Msg, string PromptMsg)
        {
            switch (PromptMsg)
            {
                case "S":
                    lblMessage.ForeColor = Color.Lime;
                    break;
                default:
                    lblMessage.ForeColor = Color.Red;
                    break;
            }
            lblMessage.Text = Msg;
        }

        private void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
