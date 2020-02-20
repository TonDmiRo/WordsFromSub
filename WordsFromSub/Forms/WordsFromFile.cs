using System;
using System.Windows.Forms;

namespace WordsFromSub
    {
    public partial class WordsFromFile : Form
        {
        private bool baseSaved;
        private string _sourcePath;
        public WordsFromFile(string filePath)
            {
            _sourcePath = filePath;
            InitializeComponent();
            MyDictionary.AddWordsFromFile(filePath);
            SetDataSourceForComboBox();
            SelectToSourceFile();
            toolTipForFileComboBox.SetToolTip(comboBoxFileContainingWord, comboBoxFileContainingWord.SelectedItem.ToString());
            }
        private void SetDataSourceForComboBox()
            {
            comboBoxChangeStatus.DataSource = new WordStatus[2] { WordStatus.newWord, WordStatus.InVocabulary };
            comboBoxChangeStatus.DataSource = new WordStatus[2] { WordStatus.newWord, WordStatus.InVocabulary };

            comboBoxFileContainingWord.DataSource = MyDictionary.GetPathsToFilesContainingWords();
            }
        private void SelectToSourceFile()
            {
            comboBoxFileContainingWord.SelectedIndex = comboBoxFileContainingWord.FindStringExact(_sourcePath);
            if (comboBoxFileContainingWord.SelectedIndex == -1)
                MessageBox.Show("В файле нет подходящих слов. Выберете другой файл.");
            }
        private void comboBoxFileContainingWord_SelectedIndexChanged(object sender, EventArgs e)
            {
            string filePath = (string)comboBoxFileContainingWord.SelectedItem;
            wordBindingSource.DataSource = MyDictionary.GetFilteredWords(filePath);
            toolTipForFileComboBox.SetToolTip(comboBoxFileContainingWord, comboBoxFileContainingWord.SelectedItem.ToString());
        }

        //изменение статуса нескольких элементов
        private void checkBoxChangeStatus_CheckedChanged(object sender, EventArgs e)
            {
            dataGridView1.SelectionMode = (checkBoxChangeStatus.Checked == true) ? DataGridViewSelectionMode.FullRowSelect : DataGridViewSelectionMode.CellSelect;
            panelChangeStatus.Enabled = (checkBoxChangeStatus.Checked == true) ? true : false;
            }
        private void buttonChangeSelected_Click(object sender, EventArgs e)
            {
            WordStatus statusForChange = (WordStatus)comboBoxChangeStatus.SelectedItem;
            if (dataGridView1.SelectedRows.Count == 1)
                {
                dataGridView1.CurrentRow.Cells[0].Value = statusForChange;
                }
            else if (dataGridView1.SelectedRows.Count > 1)
                {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                    dataGridView1.Rows[row.Index].Cells[0].Value = statusForChange;
                    }
                dataGridView1.Update();
                }
            else
                {
                MessageBox.Show("NO ROWS, CARL!!!");
                //throw new Exception("No rows, CARL !!!");
                }
            }
        private void buttonBackToSourceFile_Click(object sender, EventArgs e)
            {
            SelectToSourceFile();
            }


        private void buttonSaveBase_Click(object sender, EventArgs e)
            {
            MyDictionary.SaveBase();
            MessageBox.Show("База сохранена");
            baseSaved = true;
            }
        private void FormList_FormClosing(object sender, FormClosingEventArgs e)
            {
            if (baseSaved == false)
                {
                DialogResult dialogResult = MessageBox.Show("Результаты будут потеряны! Выйти?", "Save!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    {
                    wordBindingSource = null;
                    dataGridView1.DataSource = null;
                    e.Cancel = false;
                    }
                else if (dialogResult == DialogResult.No)
                    {
                    e.Cancel = true;

                    }
                }
            }
        }
    }
