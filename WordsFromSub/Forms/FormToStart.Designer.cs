namespace WordsFromSub
{
    partial class FormToStart
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
            this.label2 = new System.Windows.Forms.Label();
            this.txAddressSub = new System.Windows.Forms.TextBox();
            this.buttonGetList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonOpenFileD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите адрес субтитров:";
            // 
            // txAddressSub
            // 
            this.txAddressSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txAddressSub.Location = new System.Drawing.Point(17, 47);
            this.txAddressSub.Name = "txAddressSub";
            this.txAddressSub.Size = new System.Drawing.Size(261, 38);
            this.txAddressSub.TabIndex = 1;
            this.txAddressSub.Text = "D:\\2.srt";
            // 
            // buttonGetList
            // 
            this.buttonGetList.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonGetList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetList.Location = new System.Drawing.Point(17, 211);
            this.buttonGetList.Name = "buttonGetList";
            this.buttonGetList.Size = new System.Drawing.Size(336, 33);
            this.buttonGetList.TabIndex = 10;
            this.buttonGetList.TabStop = false;
            this.buttonGetList.Text = "Дай список";
            this.buttonGetList.UseVisualStyleBackColor = false;
            this.buttonGetList.Click += new System.EventHandler(this.buttonGetList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Например: D:\\2.srt";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 94);
            this.button2.TabIndex = 7;
            this.button2.TabStop = false;
            this.button2.Text = "Слова из субтитров";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(247, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 94);
            this.button3.TabIndex = 8;
            this.button3.TabStop = false;
            this.button3.Text = "Открыть  редактор";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonOpenFileD
            // 
            this.buttonOpenFileD.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenFileD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFileD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFileD.Location = new System.Drawing.Point(284, 47);
            this.buttonOpenFileD.Name = "buttonOpenFileD";
            this.buttonOpenFileD.Size = new System.Drawing.Size(69, 38);
            this.buttonOpenFileD.TabIndex = 8;
            this.buttonOpenFileD.TabStop = false;
            this.buttonOpenFileD.Text = "Обзор";
            this.buttonOpenFileD.UseVisualStyleBackColor = false;
            this.buttonOpenFileD.Click += new System.EventHandler(this.buttonOpenFileD_Click);
            // 
            // FormToStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 256);
            this.Controls.Add(this.buttonOpenFileD);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txAddressSub);
            this.Controls.Add(this.buttonGetList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormToStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txAddressSub;
        private System.Windows.Forms.Button buttonGetList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonOpenFileD;
    }
}

