namespace WindowsFormsApp1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnP1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl1.Location = new System.Drawing.Point(291, 135);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(522, 136);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Курсовая работа:\r\n\"Крестики-нолики\"\r\n";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnP1
            // 
            this.btnP1.BackColor = System.Drawing.Color.Coral;
            this.btnP1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnP1.Location = new System.Drawing.Point(406, 532);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(286, 113);
            this.btnP1.TabIndex = 2;
            this.btnP1.Text = "Переход к программе";
            this.btnP1.UseVisualStyleBackColor = false;
            this.btnP1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(789, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 78);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выполнил: Битков Д.Э.\r\nСтудент 1 курса\r\nгр. ПРОГ-С-19\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1072, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnP1);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приветственная форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnP1;
        private System.Windows.Forms.Label label2;
    }
}

