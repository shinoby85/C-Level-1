using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7
{
    public partial class SerchNumber : Form
    {
        private static int schet;
        private static int number;
        private static int ansNumber;
        public SerchNumber()
        {
            InitializeComponent();
            schet = 0;
        }
        public static int Schet()
        {
            return schet;
        }
        public static void AnsNumber(int num)
        {
            ansNumber = num;
        }
        public bool Analiz()
        {
            if (ansNumber<number)
            {
                lblResult.Text = "Ваш ответ меньше заданного числа";
                lblResult.Visible = true;
                return true;
            }
            
            else if (ansNumber>number)
            {
                lblResult.Text = "Ваш ответ больше заданного числа";
                lblResult.Visible = true;
                return true;
            }
            else
            {
                lblResult.Text = "Вы выйграли. Ваш ответ верный.";
                
                lblText1.Visible = false;
                btnAnsver.Visible = false;
                btnStart.Enabled = true;
                
                lblResult.Visible = true;
                tbAnswer.Visible = false;
                return false;
            }

        }
         
        private void InitialGame()
        {
            schet = 0;
            Random rnd = new Random();
            number=rnd.Next(1, 100);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            InitialGame();
            lblText1.Visible = true;
            btnAnsver.Visible = true;
            btnStart.Enabled = false;
            lblResult.Text = "";
            lblResult.Visible = false;
            tbAnswer.Visible = true;
        }

        private void btnAnsver_Click(object sender, EventArgs e)
        {
            ansNumber = int.Parse(tbAnswer.Text);
            Analiz();
            tbAnswer.Text = "";
        }
    }
}
