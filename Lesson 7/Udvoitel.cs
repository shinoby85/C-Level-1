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
        private static int schet;
        
        public formUdvoitel()
        {
            schet = 0;
            
            InitializeComponent();
            gbStatus.Visible = false;
            btnCommand1.Enabled = false;
            btnCommand2.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            gbStatus.Visible = true;
            lblSumm.Text = (int.Parse(lblSumm.Text) + 1).ToString();
            Analiz();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            gbStatus.Visible = true;
            lblSumm.Text = (int.Parse(lblSumm.Text) + 1).ToString();
            Analiz();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            gbStatus.Visible = false; ;
            lblSumm.Text = "0";
        }

        private void formUdvoitel_Load(object sender, EventArgs e)
        {

        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            gbStatus.Visible = false;
            lblSumm.Text = "0";
            Random rnd = new Random();
            schet=rnd.Next(1, 100);
            MessageBox.Show($"Для победы вам нужно набрать число: {schet}","" +
                "Условия игры");
            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
            btnReset.Enabled = true;
        }
        /// <summary>
        /// Проверка на совпадение с требуемым числом
        /// </summary>        
        private void Analiz()
        {
            if (int.Parse(lblNumber.Text)==schet)
            {
                btnCommand1.Enabled = false;
                btnCommand2.Enabled = false;
                btnReset.Enabled = false;
                MessageBox.Show($"Поздравляем вы выйграли!!!\n" +
                    $"Для достижения своей цели вы совершили {lblSumm.Text} хода(-ов)." +
                    $"","Информация",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else if (int.Parse(lblNumber.Text) > schet)
            {
                btnCommand1.Enabled = false;
                btnCommand2.Enabled = false;
                btnReset.Enabled = false;
                MessageBox.Show($"Ваше значение превышае требуемое число!!!\n" +
                    $"Для вас игра закончилась на {lblSumm.Text} ходу.","Информация",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }            
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
