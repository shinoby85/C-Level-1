﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8
{
    public partial class FZ2 : Form
    {
        public FZ2()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            textBox1.Text = (numericUpDown1.Value).ToString();
        }

        private void btnQuite_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
