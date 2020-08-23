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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.Copy;
            //textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //textBox1.SelectAll();
            //textBox1.DoDragDrop(textBox1.Text, DragDropEffects.All);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstDept.Items.Add(txtDept.Text);
            txtDept.Clear();
            txtDept.Focus();
        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Price";

            string[] row = new string[] { "1", "Pen", "10" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "2", "Pencil", "5" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "3", "Book", "50" };
            dataGridView1.Rows.Add(row);

            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Rows[1].Visible = false;

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dataGridView1.Columns.Add(btn);
            //btn.HeaderText = "Click Data";
            //btn.Text = "Click Here";
            //btn.Name = "btn";
            //btn.UseColumnTextForButtonValue = true;


            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //dataGridView1.Columns.Add(chk);
            //chk.HeaderText = "Check Data";
            //chk.Name = "chk";
            //dataGridView1.Rows[2].Cells[3].Value = true;

            //DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            //cmb.HeaderText = "Select Data";
            //cmb.Name = "cmb";
            //cmb.MaxDropDownItems = 2;
            //cmb.Items.Add("True");
            //cmb.Items.Add("False");
            //dataGridView1.Columns.Add(cmb);

            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            //Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\rid\\Chrysanthemum.jpg");
            //img.Image = image;
            //dataGridView1.Columns.Add(img);
            //img.HeaderText = "Image";
            //img.Name = "img";

            DataGridViewLinkColumn lnk = new DataGridViewLinkColumn();
            dataGridView1.Columns.Add(lnk);
            lnk.HeaderText = "Link Data";
            lnk.Name="C:\\Users\\Admin\\Desktop\\rid\\Chrysanthemum.jpg";
            lnk.Text = "C:\\Users\\Admin\\Desktop\\rid\\Chrysanthemum.jpg";
            
            lnk.UseColumnTextForLinkValue = true;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 3)
                //MessageBox.Show((e.RowIndex + 1) + " Row" + (e.ColumnIndex + 1) + " Column button clicked");
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Link Clicked....");
            
        }

        //private void textBox2_DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Move;
        //    textBox2.Text = e.Data.GetData(DataFormats.Text).ToString();
        //}
    }
}
