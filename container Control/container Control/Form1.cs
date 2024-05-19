using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace container_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RollNo", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("FatherName", typeof(string));

            dt.Columns.Add("Class", typeof(string));
            dt.Columns.Add("Section", typeof(string));
            dt.Columns.Add("Subject", typeof(string));
            dt.Columns.Add("MatricMarks", typeof(string));
            dt.Columns.Add("ObtainMarks", typeof(string));



            dt.Rows.Add("14", "Ayesha","Mukhtar","Bscs 5th Semester", "B","Computer Science","1100","980");
            


              listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["RollNo"].ToString();
                item.SubItems.Add(row["Name"].ToString());
                item.SubItems.Add(row["FatherName"].ToString());

                item.SubItems.Add(row["Class"].ToString());
                item.SubItems.Add(row["Section"].ToString());
                item.SubItems.Add(row["Subject"].ToString());
                item.SubItems.Add(row["MatricMarks"].ToString());
                item.SubItems.Add(row["ObtainMarks"].ToString());

                listView1.Items.Add(item);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                txtRollNo.Text = itm.Text;
                txtName.Text = itm.SubItems[1].Text;
                txtFatherName.Text = itm.SubItems[2].Text;
                txtClass.Text = itm.SubItems[3].Text;
                txtSection.Text = itm.SubItems[4].Text;
                txtSubject.Text = itm.SubItems[5].Text;
                txtMatricMarks.Text = itm.SubItems[6].Text;
                txtObtainMarks.Text = itm.SubItems[7].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = txtRollNo.Text;
            item.SubItems.Add(txtName.Text);
            item.SubItems.Add(txtFatherName.Text);
            item.SubItems.Add(txtClass.Text);
            item.SubItems.Add(txtSection.Text);
            item.SubItems.Add(txtSubject.Text);
            item.SubItems.Add(txtMatricMarks.Text);
            item.SubItems.Add(txtObtainMarks.Text);

            listView1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRollNo.ReadOnly = false;
            txtName.ReadOnly = false;
            txtFatherName.ReadOnly = false;
            txtClass.ReadOnly = false;
            txtSection.ReadOnly = false;
            txtSubject.ReadOnly = false;
            txtMatricMarks.ReadOnly = false;
            txtObtainMarks.ReadOnly = false;

            txtRollNo.Text = "";
            txtName.Text = "";
            txtFatherName.Text = "";
            txtClass.Text = "";
            txtSection.Text = "";
            txtSubject.Text = "";
            txtMatricMarks.Text = "";
            txtObtainMarks.Text = "";
        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

  
    }
}
