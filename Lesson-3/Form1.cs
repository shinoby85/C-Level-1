using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3
{
    class Drob
    {
        //Числитель
        int chisl;
        //Знаменатель
        int znam;

        public int Chisl
        {
            get { return chisl; }
            set { chisl = value; }
        }
        public int Znam
        {
            get { return znam; }
            set { znam = value; }
        }
        public void Drop(int _chisl, int _znam)
        {
            this.chisl = _chisl;
            this.znam = _znam;
        }

    }
    public partial class dataForm : Form
    {
        public dataForm()
        {
            InitializeComponent();
        }

        private void bSumm_Click(object sender, EventArgs e)
        {

        }
    }
}
