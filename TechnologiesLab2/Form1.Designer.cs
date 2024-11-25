namespace TechnologiesLab2
{
    partial class Form1
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
            this.labelTime = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxThreads = new System.Windows.Forms.TextBox();
            this.textBoxCountOfIntervals = new System.Windows.Forms.TextBox();
            this.labelThread = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxMaxCountThreads = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTime.Location = new System.Drawing.Point(161, 250);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 25);
            this.labelTime.TabIndex = 13;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult.Location = new System.Drawing.Point(171, 188);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 25);
            this.labelResult.TabIndex = 12;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCalculate.Location = new System.Drawing.Point(203, 122);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(106, 36);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Обчислити";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxThreads
            // 
            this.textBoxThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxThreads.Location = new System.Drawing.Point(175, 44);
            this.textBoxThreads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxThreads.Name = "textBoxThreads";
            this.textBoxThreads.Size = new System.Drawing.Size(352, 30);
            this.textBoxThreads.TabIndex = 10;
            // 
            // textBoxCountOfIntervals
            // 
            this.textBoxCountOfIntervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCountOfIntervals.Location = new System.Drawing.Point(192, 18);
            this.textBoxCountOfIntervals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCountOfIntervals.Name = "textBoxCountOfIntervals";
            this.textBoxCountOfIntervals.Size = new System.Drawing.Size(335, 30);
            this.textBoxCountOfIntervals.TabIndex = 9;
            // 
            // labelThread
            // 
            this.labelThread.AutoSize = true;
            this.labelThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelThread.Location = new System.Drawing.Point(8, 47);
            this.labelThread.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThread.Name = "labelThread";
            this.labelThread.Size = new System.Drawing.Size(244, 25);
            this.labelThread.TabIndex = 8;
            this.labelThread.Text = "Введіть кількість потоків";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelN.Location = new System.Drawing.Point(8, 20);
            this.labelN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(270, 25);
            this.labelN.TabIndex = 7;
            this.labelN.Text = "Введіть кількість інтервалів";
            // 
            // textBoxMaxCountThreads
            // 
            this.textBoxMaxCountThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMaxCountThreads.Location = new System.Drawing.Point(277, 74);
            this.textBoxMaxCountThreads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMaxCountThreads.Name = "textBoxMaxCountThreads";
            this.textBoxMaxCountThreads.Size = new System.Drawing.Size(249, 30);
            this.textBoxMaxCountThreads.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введіть обмеження на кількість потоків";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxCountThreads);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxThreads);
            this.Controls.Add(this.textBoxCountOfIntervals);
            this.Controls.Add(this.labelThread);
            this.Controls.Add(this.labelN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Технології розподілених систем та паралельних обчислень 2 лабараторна";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxThreads;
        private System.Windows.Forms.TextBox textBoxCountOfIntervals;
        private System.Windows.Forms.Label labelThread;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxMaxCountThreads;
        private System.Windows.Forms.Label label1;
    }
}

