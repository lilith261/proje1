﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();
        }
    }
}
