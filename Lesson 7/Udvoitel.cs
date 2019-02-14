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
        private static bool flag;
        private Stack<int> myStack;


        public formUdvoitel()
        {
            schet = 0;
            flag = false;
            InitializeComponent();
            gbStatus.Visible = false;
            btnCommand1.Enabled = false;
            btnCommand2.Enabled = false;
            btnBackUP.Enabled = false;
            myStack = new Stack<int>();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            
            flag = true;
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            gbStatus.Visible = true;
            lblSumm.Text = (int.Parse(lblSumm.Text) + 1).ToString();
            myStack.Push(int.Parse(lblNumber.Text));
            Analiz();
            if (lblSumm.Text != "0") btnBackUP.Enabled = true;
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            
            flag = true;
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            gbStatus.Visible = true;
            lblSumm.Text = (int.Parse(lblSumm.Text) + 1).ToString();
            myStack.Push(int.Parse(lblNumber.Text));
            Analiz();
            if (lblSumm.Text != "0") btnBackUP.Enabled = true;
        }

        private void btnBackUP_Click(object sender, EventArgs e)
        {
            if (flag==true)
            {
                flag = false;
                lblNumber.Text = myStack.Pop().ToString();

            }
            if (myStack.Count != 0)
            {
                lblNumber.Text = myStack.Pop().ToString();
            }
            else lblNumber.Text = "0";

            lblSumm.Text = (int.Parse(lblSumm.Text) - 1).ToString();
            if (lblSumm.Text == "0") btnBackUP.Enabled = false;
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
            btnBackUP.Enabled = true;
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
                btnBackUP.Enabled = false;
                MessageBox.Show($"Поздравляем вы выйграли!!!\n" +
                    $"Для достижения своей цели вы совершили {lblSumm.Text} хода(-ов)." +
                    $"","Информация",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else if (int.Parse(lblNumber.Text) > schet)
            {
                btnCommand1.Enabled = false;
                btnCommand2.Enabled = false;
                btnBackUP.Enabled = false;
                MessageBox.Show($"Ваше значение превышае требуемое число!!!\n" +
                    $"Для вас игра закончилась на {lblSumm.Text} ходу.","Информация",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }            
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            gbStatus.Visible = false; ;
            lblSumm.Text = "0";
        }
    }
}
