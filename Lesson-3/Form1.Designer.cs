﻿namespace Lesson_3
{
    partial class dataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lOperation = new System.Windows.Forms.Label();
            this.lZnak = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.bSumm = new System.Windows.Forms.Button();
            this.bRazn = new System.Windows.Forms.Button();
            this.bProizv = new System.Windows.Forms.Button();
            this.bDelen = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заполните значения выражения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "-------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "-------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "==";
            // 
            // lOperation
            // 
            this.lOperation.AutoSize = true;
            this.lOperation.Location = new System.Drawing.Point(108, 75);
            this.lOperation.Name = "lOperation";
            this.lOperation.Size = new System.Drawing.Size(13, 13);
            this.lOperation.TabIndex = 5;
            this.lOperation.Text = "+";
            // 
            // lZnak
            // 
            this.lZnak.AutoSize = true;
            this.lZnak.Location = new System.Drawing.Point(237, 75);
            this.lZnak.Name = "lZnak";
            this.lZnak.Size = new System.Drawing.Size(0, 13);
            this.lZnak.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(256, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(256, 91);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(43, 20);
            this.textBox6.TabIndex = 12;
            // 
            // bSumm
            // 
            this.bSumm.Location = new System.Drawing.Point(30, 150);
            this.bSumm.Name = "bSumm";
            this.bSumm.Size = new System.Drawing.Size(75, 23);
            this.bSumm.TabIndex = 13;
            this.bSumm.Text = "Сумма";
            this.bSumm.UseVisualStyleBackColor = true;
            this.bSumm.Click += new System.EventHandler(this.bSumm_Click);
            // 
            // bRazn
            // 
            this.bRazn.Location = new System.Drawing.Point(231, 150);
            this.bRazn.Name = "bRazn";
            this.bRazn.Size = new System.Drawing.Size(68, 23);
            this.bRazn.TabIndex = 14;
            this.bRazn.Text = "Разность";
            this.bRazn.UseVisualStyleBackColor = true;
            // 
            // bProizv
            // 
            this.bProizv.Location = new System.Drawing.Point(30, 192);
            this.bProizv.Name = "bProizv";
            this.bProizv.Size = new System.Drawing.Size(75, 23);
            this.bProizv.TabIndex = 15;
            this.bProizv.Text = "Умножить";
            this.bProizv.UseVisualStyleBackColor = true;
            // 
            // bDelen
            // 
            this.bDelen.Location = new System.Drawing.Point(231, 192);
            this.bDelen.Name = "bDelen";
            this.bDelen.Size = new System.Drawing.Size(68, 23);
            this.bDelen.TabIndex = 16;
            this.bDelen.Text = "Деление";
            this.bDelen.UseVisualStyleBackColor = false;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(30, 236);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(269, 32);
            this.bExit.TabIndex = 17;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // dataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 309);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bDelen);
            this.Controls.Add(this.bProizv);
            this.Controls.Add(this.bRazn);
            this.Controls.Add(this.bSumm);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lZnak);
            this.Controls.Add(this.lOperation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dataForm";
            this.Text = "Вычисление значения выражений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lOperation;
        private System.Windows.Forms.Label lZnak;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button bSumm;
        private System.Windows.Forms.Button bRazn;
        private System.Windows.Forms.Button bProizv;
        private System.Windows.Forms.Button bDelen;
        private System.Windows.Forms.Button bExit;
    }
}