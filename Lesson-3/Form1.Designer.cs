namespace Lesson_3
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
            this.tChisl1 = new System.Windows.Forms.TextBox();
            this.tZnam1 = new System.Windows.Forms.TextBox();
            this.tChisl2 = new System.Windows.Forms.TextBox();
            this.tZnam2 = new System.Windows.Forms.TextBox();
            this.tChislRez = new System.Windows.Forms.TextBox();
            this.tZnamRez = new System.Windows.Forms.TextBox();
            this.bSumm = new System.Windows.Forms.Button();
            this.bRazn = new System.Windows.Forms.Button();
            this.bProizv = new System.Windows.Forms.Button();
            this.bDelen = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.lCel1 = new System.Windows.Forms.Label();
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
            // tChisl1
            // 
            this.tChisl1.Location = new System.Drawing.Point(46, 52);
            this.tChisl1.Name = "tChisl1";
            this.tChisl1.Size = new System.Drawing.Size(43, 20);
            this.tChisl1.TabIndex = 7;
            // 
            // tZnam1
            // 
            this.tZnam1.Location = new System.Drawing.Point(46, 91);
            this.tZnam1.Name = "tZnam1";
            this.tZnam1.Size = new System.Drawing.Size(43, 20);
            this.tZnam1.TabIndex = 8;
            // 
            // tChisl2
            // 
            this.tChisl2.Location = new System.Drawing.Point(139, 52);
            this.tChisl2.Name = "tChisl2";
            this.tChisl2.Size = new System.Drawing.Size(43, 20);
            this.tChisl2.TabIndex = 9;
            // 
            // tZnam2
            // 
            this.tZnam2.Location = new System.Drawing.Point(139, 91);
            this.tZnam2.Name = "tZnam2";
            this.tZnam2.Size = new System.Drawing.Size(43, 20);
            this.tZnam2.TabIndex = 10;
            // 
            // tChislRez
            // 
            this.tChislRez.Enabled = false;
            this.tChislRez.Location = new System.Drawing.Point(256, 52);
            this.tChislRez.Name = "tChislRez";
            this.tChislRez.Size = new System.Drawing.Size(43, 20);
            this.tChislRez.TabIndex = 11;
            // 
            // tZnamRez
            // 
            this.tZnamRez.Enabled = false;
            this.tZnamRez.Location = new System.Drawing.Point(256, 91);
            this.tZnamRez.Name = "tZnamRez";
            this.tZnamRez.Size = new System.Drawing.Size(43, 20);
            this.tZnamRez.TabIndex = 12;
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
            this.bRazn.Click += new System.EventHandler(this.bRazn_Click);
            // 
            // bProizv
            // 
            this.bProizv.Location = new System.Drawing.Point(30, 192);
            this.bProizv.Name = "bProizv";
            this.bProizv.Size = new System.Drawing.Size(75, 23);
            this.bProizv.TabIndex = 15;
            this.bProizv.Text = "Умножить";
            this.bProizv.UseVisualStyleBackColor = true;
            this.bProizv.Click += new System.EventHandler(this.bProizv_Click);
            // 
            // bDelen
            // 
            this.bDelen.Location = new System.Drawing.Point(231, 192);
            this.bDelen.Name = "bDelen";
            this.bDelen.Size = new System.Drawing.Size(68, 23);
            this.bDelen.TabIndex = 16;
            this.bDelen.Text = "Деление";
            this.bDelen.UseVisualStyleBackColor = false;
            this.bDelen.Click += new System.EventHandler(this.bDelen_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(30, 236);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(269, 32);
            this.bExit.TabIndex = 17;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lCel1
            // 
            this.lCel1.AutoSize = true;
            this.lCel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCel1.Location = new System.Drawing.Point(223, 66);
            this.lCel1.Name = "lCel1";
            this.lCel1.Size = new System.Drawing.Size(0, 26);
            this.lCel1.TabIndex = 18;
            // 
            // dataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 309);
            this.Controls.Add(this.lCel1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bDelen);
            this.Controls.Add(this.bProizv);
            this.Controls.Add(this.bRazn);
            this.Controls.Add(this.bSumm);
            this.Controls.Add(this.tZnamRez);
            this.Controls.Add(this.tChislRez);
            this.Controls.Add(this.tZnam2);
            this.Controls.Add(this.tChisl2);
            this.Controls.Add(this.tZnam1);
            this.Controls.Add(this.tChisl1);
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
        private System.Windows.Forms.TextBox tChisl1;
        private System.Windows.Forms.TextBox tZnam1;
        private System.Windows.Forms.TextBox tChisl2;
        private System.Windows.Forms.TextBox tZnam2;
        private System.Windows.Forms.TextBox tChislRez;
        private System.Windows.Forms.TextBox tZnamRez;
        private System.Windows.Forms.Button bSumm;
        private System.Windows.Forms.Button bRazn;
        private System.Windows.Forms.Button bProizv;
        private System.Windows.Forms.Button bDelen;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lCel1;
    }
}