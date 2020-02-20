namespace WordsFromSub
{
    partial class WordsEditor
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelChangeStatus = new System.Windows.Forms.Panel();
            this.comboBoxChangeStatus = new System.Windows.Forms.ComboBox();
            this.buttonChangeSelected = new System.Windows.Forms.Button();
            this.checkBoxChangeStatus = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxWord = new System.Windows.Forms.CheckBox();
            this.checkBoxAddress = new System.Windows.Forms.CheckBox();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            this.buttonToApplyFilter = new System.Windows.Forms.Button();
            this.textBoxForFinding = new System.Windows.Forms.TextBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.comboBoxFileContainingWord = new System.Windows.Forms.ComboBox();
            this.comboBoxWordStatus = new System.Windows.Forms.ComboBox();
            this.buttonSaveBase = new System.Windows.Forms.Button();
            this.bindingSourceEnum = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wordNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fileContainingWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTipForComboBoxFile = new System.Windows.Forms.ToolTip(this.components);
            this.panelRight.SuspendLayout();
            this.panelChangeStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelChangeStatus);
            this.panelRight.Controls.Add(this.checkBoxChangeStatus);
            this.panelRight.Controls.Add(this.groupBox2);
            this.panelRight.Controls.Add(this.buttonSaveBase);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(786, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(198, 561);
            this.panelRight.TabIndex = 11;
            // 
            // panelChangeStatus
            // 
            this.panelChangeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChangeStatus.Controls.Add(this.comboBoxChangeStatus);
            this.panelChangeStatus.Controls.Add(this.buttonChangeSelected);
            this.panelChangeStatus.Enabled = false;
            this.panelChangeStatus.Location = new System.Drawing.Point(6, 197);
            this.panelChangeStatus.Name = "panelChangeStatus";
            this.panelChangeStatus.Size = new System.Drawing.Size(187, 66);
            this.panelChangeStatus.TabIndex = 15;
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
            // checkBoxChangeStatus
            // 
            this.checkBoxChangeStatus.AutoSize = true;
            this.checkBoxChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxChangeStatus.Location = new System.Drawing.Point(11, 171);
            this.checkBoxChangeStatus.Name = "checkBoxChangeStatus";
            this.checkBoxChangeStatus.Size = new System.Drawing.Size(157, 20);
            this.checkBoxChangeStatus.TabIndex = 14;
            this.checkBoxChangeStatus.Text = "Изменение статуса";
            this.checkBoxChangeStatus.UseVisualStyleBackColor = true;
            this.checkBoxChangeStatus.CheckedChanged += new System.EventHandler(this.checkBoxChangeStatus_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxWord);
            this.groupBox2.Controls.Add(this.checkBoxAddress);
            this.groupBox2.Controls.Add(this.buttonResetFilter);
            this.groupBox2.Controls.Add(this.buttonToApplyFilter);
            this.groupBox2.Controls.Add(this.textBoxForFinding);
            this.groupBox2.Controls.Add(this.checkBoxStatus);
            this.groupBox2.Controls.Add(this.comboBoxFileContainingWord);
            this.groupBox2.Controls.Add(this.comboBoxWordStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 162);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // checkBoxWord
            // 
            this.checkBoxWord.AutoSize = true;
            this.checkBoxWord.Location = new System.Drawing.Point(6, 84);
            this.checkBoxWord.Name = "checkBoxWord";
            this.checkBoxWord.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWord.TabIndex = 12;
            this.checkBoxWord.UseVisualStyleBackColor = true;
            this.checkBoxWord.CheckedChanged += new System.EventHandler(this.checkBoxWord_CheckedChanged);
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
            this.buttonResetFilter.Location = new System.Drawing.Point(96, 107);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(90, 48);
            this.buttonResetFilter.TabIndex = 14;
            this.buttonResetFilter.Text = "Сбросить";
            this.buttonResetFilter.UseVisualStyleBackColor = true;
            this.buttonResetFilter.Click += new System.EventHandler(this.buttonResetFilter_Click);
            // 
            // buttonToApplyFilter
            // 
            this.buttonToApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToApplyFilter.Location = new System.Drawing.Point(3, 107);
            this.buttonToApplyFilter.Name = "buttonToApplyFilter";
            this.buttonToApplyFilter.Size = new System.Drawing.Size(90, 48);
            this.buttonToApplyFilter.TabIndex = 14;
            this.buttonToApplyFilter.Text = "Применить фильтр";
            this.buttonToApplyFilter.UseVisualStyleBackColor = true;
            this.buttonToApplyFilter.Click += new System.EventHandler(this.buttonToApplyFilter_Click);
            // 
            // textBoxForFinding
            // 
            this.textBoxForFinding.Enabled = false;
            this.textBoxForFinding.Location = new System.Drawing.Point(27, 79);
            this.textBoxForFinding.Name = "textBoxForFinding";
            this.textBoxForFinding.Size = new System.Drawing.Size(155, 22);
            this.textBoxForFinding.TabIndex = 15;
            this.textBoxForFinding.Text = "Введите слово";
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
            this.comboBoxFileContainingWord.Size = new System.Drawing.Size(155, 24);
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
            this.comboBoxWordStatus.Size = new System.Drawing.Size(155, 24);
            this.comboBoxWordStatus.TabIndex = 9;
            // 
            // buttonSaveBase
            // 
            this.buttonSaveBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveBase.Location = new System.Drawing.Point(11, 511);
            this.buttonSaveBase.Name = "buttonSaveBase";
            this.buttonSaveBase.Size = new System.Drawing.Size(176, 40);
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
            this.wordNameDataGridViewTextBoxColumn,
            this.translationDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.fileContainingWordDataGridViewTextBoxColumn});
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 46;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 561);
            this.dataGridView1.TabIndex = 12;
            // 
            // wordNameDataGridViewTextBoxColumn
            // 
            this.wordNameDataGridViewTextBoxColumn.DataPropertyName = "WordName";
            this.wordNameDataGridViewTextBoxColumn.HeaderText = "Слово";
            this.wordNameDataGridViewTextBoxColumn.Name = "wordNameDataGridViewTextBoxColumn";
            this.wordNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.wordNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // translationDataGridViewTextBoxColumn
            // 
            this.translationDataGridViewTextBoxColumn.DataPropertyName = "Translation";
            this.translationDataGridViewTextBoxColumn.HeaderText = "Перевод";
            this.translationDataGridViewTextBoxColumn.Name = "translationDataGridViewTextBoxColumn";
            this.translationDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.bindingSourceEnum;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.Width = 200;
            // 
            // fileContainingWordDataGridViewTextBoxColumn
            // 
            this.fileContainingWordDataGridViewTextBoxColumn.DataPropertyName = "FileContainingWord";
            this.fileContainingWordDataGridViewTextBoxColumn.HeaderText = "Путь";
            this.fileContainingWordDataGridViewTextBoxColumn.Name = "fileContainingWordDataGridViewTextBoxColumn";
            this.fileContainingWordDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileContainingWordDataGridViewTextBoxColumn.Width = 200;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataSource = typeof(WordsFromSub.Word);
            // 
            // WordsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор слов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordsEditor_FormClosing);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelChangeStatus.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelChangeStatus;
        private System.Windows.Forms.ComboBox comboBoxChangeStatus;
        private System.Windows.Forms.Button buttonChangeSelected;
        private System.Windows.Forms.CheckBox checkBoxChangeStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxWord;
        private System.Windows.Forms.CheckBox checkBoxAddress;
        private System.Windows.Forms.Button buttonResetFilter;
        private System.Windows.Forms.Button buttonToApplyFilter;
        private System.Windows.Forms.TextBox textBoxForFinding;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxFileContainingWord;
        private System.Windows.Forms.ComboBox comboBoxWordStatus;
        private System.Windows.Forms.Button buttonSaveBase;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceEnum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileContainingWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTipForComboBoxFile;
    }
}