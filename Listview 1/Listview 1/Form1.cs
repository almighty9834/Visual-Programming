using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listview_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Roll No", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Father Name", typeof(string));
            dt.Columns.Add("Class", typeof(Int32));
            dt.Columns.Add("Section", typeof(Int32));
            dt.Columns.Add("Inter. Marks", typeof(double));
            dt.Columns.Add("Obtain Marks", typeof(double));
            dt.Columns.Add("Grade", typeof(string));
            dt.Columns.Add("Matric Marks", typeof(double));
            dt.Columns.Add("Obtain Marks", typeof(double));
            dt.Columns.Add("Grade", typeof(string));



            dt.Rows.Add("1", "Aisha", "Mukhtar", "BS 5th semester", "A", "1100", "850", "A", "1100", "734", "B");
            dt.Rows.Add("2", "Sehar", "Mukhtar", "BS 1st semester", "A", "1100", "750", "A", "1100", "980", "A+");
            dt.Rows.Add("3", "Ushna", "Hafeez", "BS 5th semester", "A", "1100", "890", "A", "1100", "734", "B");

            dt.Rows.Add("4", "Muqadas", "Nazeer", "BS 5th semester", "A", "1100", "890", "A", "1100", "750", "B");



            listView1.Items.Clear();
            foreach  (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();

                item.Text = row["RollNo"].ToString();
                item.SubItems.Add(row["Name"].ToString());
                item.SubItems.Add(row["Father Name"].ToString());

                item.SubItems.Add(row["Class"].ToString());
                item.SubItems.Add(row["Section"].ToString());
                item.SubItems.Add(row["Inter. Marks"].ToString());
                item.SubItems.Add(row["Obtain Marks"].ToString());
                item.SubItems.Add(row["Grade"].ToString());
                item.SubItems.Add(row["Matric Marks"].ToString());
                item.SubItems.Add(row["Obtain Marks"].ToString());
                item.SubItems.Add(row["Grade"].ToString());

                listView1.Items.Add(item);




            }

        }
    }
}
