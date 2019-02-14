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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
            
        }

        private void btnQuite_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWork1_Click(object sender, EventArgs e)
        {
            formUdvoitel f2 = new formUdvoitel();
            f2.Show();
        }
    }
}
