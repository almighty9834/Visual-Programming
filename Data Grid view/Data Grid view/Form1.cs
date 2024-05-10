using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Grid_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bhtload_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RollNo", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Father Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("E-Mial", typeof(string));
            dt.Columns.Add("Phone No.", typeof(string));

            dt.Columns.Add("Class", typeof(string));
            dt.Columns.Add("Session", typeof(string));

            dt.Columns.Add("Inter Marks", typeof(string));
            dt.Columns.Add("Obtain Marks", typeof(string));
            dt.Columns.Add("Grade", typeof(string));

            dt.Rows.Add(2, "Ayesha", "Mukhtar", "BScs 5th Semester", "Arif town, street#07", "Ayesha@gmail.com", "03038-343434", "2023-2025", "1100", "850", "A");
            dt.Rows.Add(1, "Sehar", "Mukhtar", "BS 1st Semester", "Arif town, street#07", "Sehar@gmail.com", "03038-343434", "2023-2025", "1100", "980", "A+");
            dt.Rows.Add(4, "Ushna", "Hafeez", " BScs 5th Semester", "", "Ushna@gmail.com", "03038-343434", "2023-2025", "1100", "896", "A");

            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"E:\netflix_titles";
            string[] lines = File.ReadAllLines(path);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("col1", "id");
            dataGridView1.Columns.Add("col2", "type");
            dataGridView1.Columns.Add("col3", "title");
            dataGridView1.Columns.Add("col4", "director");
            dataGridView1.Columns.Add("col5", "cast");
            dataGridView1.Columns.Add("col6", "country");
            dataGridView1.Columns.Add("col7", "data_added");
            dataGridView1.Columns.Add("col8", "release year");
            dataGridView1.Columns.Add("col9", "rating ");
            dataGridView1.Columns.Add("col10", "duration");
            dataGridView1.Columns.Add("col11", "Listed _in");
            dataGridView1.Columns.Add("col12", "description");

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                string id = columns[0];
                string type = columns[1];
                string title = columns[2];
                string director = columns[3];
                string cast= columns[4];
                string country = columns[5];
                string data_added = columns[6];
                string releaseyear = columns[7];
                string rating = columns[8];
                string duration  = columns[9];
                string listed_in = columns[10];
                string description  = columns[11];






                dataGridView1.Rows.Add(id, type, title, director, cast, country, data_added, releaseyear, rating, duration, listed_in, description);
            }
        }
    }
}
