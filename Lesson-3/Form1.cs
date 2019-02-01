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
    public partial class dataForm : Form
    {
        
        public dataForm()
        {
            InitializeComponent();
        }

        private void bSumm_Click(object sender, EventArgs e)
        {
            Drob drb1 = new Drob(int.Parse(tChisl1.Text),int.Parse(tZnam1.Text));
            Drob drb2 = new Drob(int.Parse(tChisl2.Text), int.Parse(tZnam2.Text));
            lCel1.Text = Drob.Sum(drb1, drb2).Cel.ToString();
            tChislRez.Text = Drob.Sum(drb1, drb2).Chisl.ToString();
            tZnamRez.Text = Drob.Sum(drb1, drb2).Znam.ToString();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
         
        }

        private void bRazn_Click(object sender, EventArgs e)
        {
            Drob drb1 = new Drob(int.Parse(tChisl1.Text), int.Parse(tZnam1.Text));
            Drob drb2 = new Drob(int.Parse(tChisl2.Text), int.Parse(tZnam2.Text));
            lCel1.Text = Drob.Razn(drb1, drb2).Cel.ToString();
            tChislRez.Text = Drob.Razn(drb1, drb2).Chisl.ToString();
            tZnamRez.Text = Drob.Razn(drb1, drb2).Znam.ToString();
        }

        private void bProizv_Click(object sender, EventArgs e)
        {
            Drob drb1 = new Drob(int.Parse(tChisl1.Text), int.Parse(tZnam1.Text));
            Drob drb2 = new Drob(int.Parse(tChisl2.Text), int.Parse(tZnam2.Text));
            lCel1.Text = Drob.Umnoj(drb1, drb2).Cel.ToString();
            tChislRez.Text = Drob.Umnoj(drb1, drb2).Chisl.ToString();
            tZnamRez.Text = Drob.Umnoj(drb1, drb2).Znam.ToString();
        }

        private void bDelen_Click(object sender, EventArgs e)
        {
            Drob drb1 = new Drob(int.Parse(tChisl1.Text), int.Parse(tZnam1.Text));
            Drob drb2 = new Drob(int.Parse(tChisl2.Text), int.Parse(tZnam2.Text));
            lCel1.Text = Drob.Del(drb1, drb2).Cel.ToString();
            tChislRez.Text = Drob.Del(drb1, drb2).Chisl.ToString();
            tZnamRez.Text = Drob.Del(drb1, drb2).Znam.ToString();
        }
    }
    

}
