using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7
{
    public partial class formUdvoitel : Form
    {
        public formUdvoitel()
        {
            InitializeComponent();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
        }
    }
}
