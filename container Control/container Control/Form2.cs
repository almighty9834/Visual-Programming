﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.TopLevel = false;
            panel1.Controls.Add(f);
            f.Show();
            panel2.Visible = true;
        }

      
           

        
    }
}
