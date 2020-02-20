namespace WordsFromSub
{
    partial class WordsToClipboard
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
            this.components = new System.ComponentModel.Container();
            this.buttonToCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxAddress = new System.Windows.Forms.CheckBox();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            this.buttonToApplyFilter = new System.Windows.Forms.Button();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.comboBoxFileContainingWord = new System.Windows.Forms.ComboBox();
            this.comboBoxWordStatus = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.toolTipForComboBoxFile = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonToCopy
            // 
            this.buttonToCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToCopy.Location = new System.Drawing.Point(42, 502);
            this.buttonToCopy.Name = "buttonToCopy";
            this.buttonToCopy.Size = new System.Drawing.Size(150, 50);
            this.buttonToCopy.TabIndex = 6;
            this.buttonToCopy.Text = "Копировать";
            this.buttonToCopy.UseVisualStyleBackColor = true;
            this.buttonToCopy.Click += new System.EventHandler(this.buttonToCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Состоит из 1000 элементов";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxAddress);
            this.groupBox2.Controls.Add(this.buttonResetFilter);
            this.groupBox2.Controls.Add(this.buttonToApplyFilter);
            this.groupBox2.Controls.Add(this.checkBoxStatus);
            this.groupBox2.Controls.Add(this.comboBoxFileContainingWord);
            this.groupBox2.Controls.Add(this.comboBoxWordStatus);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 110);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // checkBoxAddress
            // 
            this.checkBoxAddress.AutoSize = true;
            this.checkBoxAddress.Location = new System.Drawing.Point(6, 54);
            this.checkBoxAddress.Name = "checkBoxAddress";
            this.checkBoxAddress.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAddress.TabIndex = 12;
            this.checkBoxAddress.UseVisualStyleBackColor = true;
            this.checkBoxAddress.CheckedChanged += new System.EventHandler(this.checkBoxAddress_CheckedChanged);
            // 
            // buttonResetFilter
            // 
            this.buttonResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetFilter.Location = new System.Drawing.Point(122, 79);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(100, 24);
            this.buttonResetFilter.TabIndex = 14;
            this.buttonResetFilter.Text = "Сбросить";
            this.buttonResetFilter.UseVisualStyleBackColor = true;
            this.buttonResetFilter.Click += new System.EventHandler(this.buttonResetFilter_Click);
            // 
            // buttonToApplyFilter
            // 
            this.buttonToApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToApplyFilter.Location = new System.Drawing.Point(6, 79);
            this.buttonToApplyFilter.Name = "buttonToApplyFilter";
            this.buttonToApplyFilter.Size = new System.Drawing.Size(100, 24);
            this.buttonToApplyFilter.TabIndex = 14;
            this.buttonToApplyFilter.Text = "Применить";
            this.buttonToApplyFilter.UseVisualStyleBackColor = true;
            this.buttonToApplyFilter.Click += new System.EventHandler(this.buttonToApplyFilter_Click);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(6, 24);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStatus.TabIndex = 11;
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            this.checkBoxStatus.CheckedChanged += new System.EventHandler(this.checkBoxStatus_CheckedChanged);
            // 
            // comboBoxFileContainingWord
            // 
            this.comboBoxFileContainingWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileContainingWord.Enabled = false;
            this.comboBoxFileContainingWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFileContainingWord.FormattingEnabled = true;
            this.comboBoxFileContainingWord.Location = new System.Drawing.Point(27, 49);
            this.comboBoxFileContainingWord.Name = "comboBoxFileContainingWord";
            this.comboBoxFileContainingWord.Size = new System.Drawing.Size(195, 24);
            this.comboBoxFileContainingWord.TabIndex = 10;
            this.comboBoxFileContainingWord.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileContainingWord_SelectedIndexChanged);
            // 
            // comboBoxWordStatus
            // 
            this.comboBoxWordStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWordStatus.Enabled = false;
            this.comboBoxWordStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWordStatus.FormattingEnabled = true;
            this.comboBoxWordStatus.Location = new System.Drawing.Point(27, 19);
            this.comboBoxWordStatus.Name = "comboBoxWordStatus";
            this.comboBoxWordStatus.Size = new System.Drawing.Size(195, 24);
            this.comboBoxWordStatus.TabIndex = 9;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 132);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(210, 364);
            this.textBox.TabIndex = 15;
            // 
            // WordsToClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 561);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonToCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordsToClipboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нажми \"Копировать\"";
            this.Load += new System.EventHandler(this.FormListToPuzzle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonToCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxAddress;
        private System.Windows.Forms.Button buttonResetFilter;
        private System.Windows.Forms.Button buttonToApplyFilter;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxFileContainingWord;
        private System.Windows.Forms.ComboBox comboBoxWordStatus;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolTip toolTipForComboBoxFile;
    }
}