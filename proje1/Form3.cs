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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
        }
    }
}
