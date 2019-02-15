namespace Lesson_7
{
    partial class SerchNumber
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.btnAnsver = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(57, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(218, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт игры";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(31, 82);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(275, 13);
            this.lblText1.TabIndex = 1;
            this.lblText1.Text = "Число загадано. Для ввода ответа нажмите кнопку.";
            this.lblText1.Visible = false;
            // 
            // btnAnsver
            // 
            this.btnAnsver.Location = new System.Drawing.Point(57, 193);
            this.btnAnsver.Name = "btnAnsver";
            this.btnAnsver.Size = new System.Drawing.Size(218, 84);
            this.btnAnsver.TabIndex = 2;
            this.btnAnsver.Text = "Дать ответ";
            this.btnAnsver.UseVisualStyleBackColor = true;
            this.btnAnsver.Visible = false;
            this.btnAnsver.Click += new System.EventHandler(this.btnAnsver_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(12, 123);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 24);
            this.lblResult.TabIndex = 3;
            this.lblResult.Visible = false;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(55, 167);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(220, 20);
            this.tbAnswer.TabIndex = 4;
            this.tbAnswer.Visible = false;
            // 
            // SerchNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 289);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAnsver);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SerchNumber";
            this.Text = "Поиск числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Button btnAnsver;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbAnswer;
    }
}