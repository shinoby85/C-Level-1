namespace Lesson_7
{
    partial class startForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWork1 = new System.Windows.Forms.Button();
            this.btnWork2 = new System.Windows.Forms.Button();
            this.btnQuite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWork1
            // 
            this.btnWork1.Location = new System.Drawing.Point(44, 38);
            this.btnWork1.Name = "btnWork1";
            this.btnWork1.Size = new System.Drawing.Size(193, 23);
            this.btnWork1.TabIndex = 0;
            this.btnWork1.Text = "Удвоитель";
            this.btnWork1.UseVisualStyleBackColor = true;
            this.btnWork1.Click += new System.EventHandler(this.btnWork1_Click);
            // 
            // btnWork2
            // 
            this.btnWork2.Location = new System.Drawing.Point(44, 101);
            this.btnWork2.Name = "btnWork2";
            this.btnWork2.Size = new System.Drawing.Size(193, 23);
            this.btnWork2.TabIndex = 0;
            this.btnWork2.Text = "Угадай число";
            this.btnWork2.UseVisualStyleBackColor = true;
            this.btnWork2.Click += new System.EventHandler(this.btnWork2_Click);
            // 
            // btnQuite
            // 
            this.btnQuite.Location = new System.Drawing.Point(44, 158);
            this.btnQuite.Name = "btnQuite";
            this.btnQuite.Size = new System.Drawing.Size(193, 23);
            this.btnQuite.TabIndex = 0;
            this.btnQuite.Text = "Выход";
            this.btnQuite.UseVisualStyleBackColor = true;
            this.btnQuite.Click += new System.EventHandler(this.btnQuite_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 228);
            this.Controls.Add(this.btnQuite);
            this.Controls.Add(this.btnWork2);
            this.Controls.Add(this.btnWork1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "startForm";
            this.Text = "Стартовое окно заданий";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWork1;
        private System.Windows.Forms.Button btnWork2;
        private System.Windows.Forms.Button btnQuite;
    }
}

