namespace WordsFromSub
{
    partial class WordsFromFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonBackToSourceFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFileContainingWord = new System.Windows.Forms.ComboBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.checkBoxChangeStatus = new System.Windows.Forms.CheckBox();
            this.panelChangeStatus = new System.Windows.Forms.Panel();
            this.comboBoxChangeStatus = new System.Windows.Forms.ComboBox();
            this.buttonChangeSelected = new System.Windows.Forms.Button();
            this.buttonSaveBase = new System.Windows.Forms.Button();
            this.bindingSourceEnum = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wordNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTipForFileComboBox = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelChangeStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonBackToSourceFile);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.comboBoxFileContainingWord);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(384, 38);
            this.panelTop.TabIndex = 15;
            // 
            // buttonBackToSourceFile
            // 
            this.buttonBackToSourceFile.Location = new System.Drawing.Point(307, 7);
            this.buttonBackToSourceFile.Name = "buttonBackToSourceFile";
            this.buttonBackToSourceFile.Size = new System.Drawing.Size(65, 24);
            this.buttonBackToSourceFile.TabIndex = 14;
            this.buttonBackToSourceFile.Text = "Сбросить";
            this.buttonBackToSourceFile.UseVisualStyleBackColor = true;
            this.buttonBackToSourceFile.Click += new System.EventHandler(this.buttonBackToSourceFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Путь:";
            // 
            // comboBoxFileContainingWord
            // 
            this.comboBoxFileContainingWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileContainingWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFileContainingWord.FormattingEnabled = true;
            this.comboBoxFileContainingWord.Location = new System.Drawing.Point(57, 7);
            this.comboBoxFileContainingWord.Name = "comboBoxFileContainingWord";
            this.comboBoxFileContainingWord.Size = new System.Drawing.Size(244, 24);
            this.comboBoxFileContainingWord.TabIndex = 12;
            this.comboBoxFileContainingWord.TabStop = false;
            this.comboBoxFileContainingWord.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileContainingWord_SelectedIndexChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.checkBoxChangeStatus);
            this.panelBottom.Controls.Add(this.panelChangeStatus);
            this.panelBottom.Controls.Add(this.buttonSaveBase);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 568);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(384, 93);
            this.panelBottom.TabIndex = 16;
            // 
            // checkBoxChangeStatus
            // 
            this.checkBoxChangeStatus.AutoSize = true;
            this.checkBoxChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxChangeStatus.Location = new System.Drawing.Point(19, 3);
            this.checkBoxChangeStatus.Name = "checkBoxChangeStatus";
            this.checkBoxChangeStatus.Size = new System.Drawing.Size(157, 20);
            this.checkBoxChangeStatus.TabIndex = 17;
            this.checkBoxChangeStatus.Text = "Изменение статуса";
            this.checkBoxChangeStatus.UseVisualStyleBackColor = true;
            this.checkBoxChangeStatus.CheckedChanged += new System.EventHandler(this.checkBoxChangeStatus_CheckedChanged);
            // 
            // panelChangeStatus
            // 
            this.panelChangeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChangeStatus.Controls.Add(this.comboBoxChangeStatus);
            this.panelChangeStatus.Controls.Add(this.buttonChangeSelected);
            this.panelChangeStatus.Enabled = false;
            this.panelChangeStatus.Location = new System.Drawing.Point(4, 24);
            this.panelChangeStatus.Name = "panelChangeStatus";
            this.panelChangeStatus.Size = new System.Drawing.Size(187, 66);
            this.panelChangeStatus.TabIndex = 16;
            // 
            // comboBoxChangeStatus
            // 
            this.comboBoxChangeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChangeStatus.FormattingEnabled = true;
            this.comboBoxChangeStatus.Location = new System.Drawing.Point(5, 6);
            this.comboBoxChangeStatus.Name = "comboBoxChangeStatus";
            this.comboBoxChangeStatus.Size = new System.Drawing.Size(175, 24);
            this.comboBoxChangeStatus.TabIndex = 10;
            // 
            // buttonChangeSelected
            // 
            this.buttonChangeSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeSelected.Location = new System.Drawing.Point(5, 36);
            this.buttonChangeSelected.Name = "buttonChangeSelected";
            this.buttonChangeSelected.Size = new System.Drawing.Size(175, 24);
            this.buttonChangeSelected.TabIndex = 5;
            this.buttonChangeSelected.Text = "Изменить";
            this.buttonChangeSelected.UseVisualStyleBackColor = true;
            this.buttonChangeSelected.Click += new System.EventHandler(this.buttonChangeSelected_Click);
            // 
            // buttonSaveBase
            // 
            this.buttonSaveBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveBase.Location = new System.Drawing.Point(222, 37);
            this.buttonSaveBase.Name = "buttonSaveBase";
            this.buttonSaveBase.Size = new System.Drawing.Size(150, 40);
            this.buttonSaveBase.TabIndex = 4;
            this.buttonSaveBase.Text = "Save";
            this.buttonSaveBase.UseVisualStyleBackColor = true;
            this.buttonSaveBase.Click += new System.EventHandler(this.buttonSaveBase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.wordNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wordBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 46;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(384, 530);
            this.dataGridView1.TabIndex = 17;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.FalseValue = "0";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Знаю";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.TrueValue = "2";
            this.statusDataGridViewTextBoxColumn.Width = 120;
            // 
            // wordNameDataGridViewTextBoxColumn
            // 
            this.wordNameDataGridViewTextBoxColumn.DataPropertyName = "WordName";
            this.wordNameDataGridViewTextBoxColumn.HeaderText = "Слово";
            this.wordNameDataGridViewTextBoxColumn.Name = "wordNameDataGridViewTextBoxColumn";
            this.wordNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.wordNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataSource = typeof(WordsFromSub.Word);
            // 
            // WordsFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordsFromFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Слова из файла";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormList_FormClosing);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelChangeStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonBackToSourceFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFileContainingWord;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.CheckBox checkBoxChangeStatus;
        private System.Windows.Forms.Panel panelChangeStatus;
        private System.Windows.Forms.ComboBox comboBoxChangeStatus;
        private System.Windows.Forms.Button buttonChangeSelected;
        private System.Windows.Forms.Button buttonSaveBase;
        private System.Windows.Forms.BindingSource bindingSourceEnum;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTipForFileComboBox;
    }
}