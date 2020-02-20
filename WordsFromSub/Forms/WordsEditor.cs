using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordsFromSub
    {
    public partial class WordsEditor : Form
        {
        private bool baseSaved;
        private const string strForFilter = "Слова не найдены. Попробуйте изменить параметры фильтра.";
        public WordsEditor()
            {
            InitializeComponent();
            SetDataSourceForComboBox();
            ShowWords();
            MessageBox.Show("Слова загружаются");
            if (comboBoxFileContainingWord.Items.Count>0) {
                toolTipForComboBoxFile.SetToolTip(comboBoxFileContainingWord, comboBoxFileContainingWord.SelectedItem.ToString()); 
            }
        }
        private void SetDataSourceForComboBox()
            {
            
           //bindingSourceEnum используется wordBindingSource для столбца comboBox 
           bindingSourceEnum.DataSource = Enum.GetValues(typeof(WordStatus));
            //фильтры
            comboBoxFileContainingWord.DataSource = MyDictionary.GetPathsToFilesContainingWords();
            comboBoxWordStatus.DataSource = Enum.GetValues(typeof(WordStatus));
            //для изменений
            comboBoxChangeStatus.DataSource = Enum.GetValues(typeof(WordStatus));
            }
        #region фильтры и получение слов
        private void ShowWords()
            {
            baseSaved = false;// упращение. если получены слова, значит они могли измениться => нужно сохраниться
            string combination = CombinationOfCheckBoxState();
            switch(combination)
                {
                case "00":
                GetWordsFromBase();// 00 - GetAllWords
                break;
                case "01":
                GetWordsFromBase((string)comboBoxFileContainingWord.SelectedItem);// 01- GetFilteredWords(string)
                break;
                case "10":
                GetWordsFromBase((WordStatus)comboBoxWordStatus.SelectedItem);// 10- GetFilteredWords(WordStatus)
                break;
                case "11":
                GetWordsFromBase((string)comboBoxFileContainingWord.SelectedItem,
                    (WordStatus)comboBoxWordStatus.SelectedItem);// 11- GetFilteredWords(string,WordStatus)
                break;
                default:
                MessageBox.Show("Что то не так!");
                break;
                }
            }
        private string CombinationOfCheckBoxState()
            {
            string combination = String.Empty;
            CheckBox[] checkBoxNames = { checkBoxStatus, checkBoxAddress };// checkBoxAddress

            // получим комбинацию состояний нужных checkBox
            foreach(CheckBox checkBoxName in checkBoxNames) // перебираем указанные checkBox
                {
                if(checkBoxName.Checked) // если CheckBox помечен галочкой
                    combination += '1';
                else
                    combination += '0';
                }
            return combination;
            }

        #region GetWordsFromBase
        private void GetWordsFromBase()
            {
            var list = ( checkBoxWord.Checked == true )
                         ? FindWordsByCharacters(MyDictionary.GetAllWords())
                         : MyDictionary.GetAllWords();

            if(list.Count > 0)
                { wordBindingSource.DataSource = list; }
            else
                { MessageBox.Show(strForFilter); }
            }
        private void GetWordsFromBase(WordStatus status)
            {
            var list = ( checkBoxWord.Checked == true )
                               ? FindWordsByCharacters(MyDictionary.GetFilteredWords(status))
                               : MyDictionary.GetFilteredWords(status);

            if(list.Count > 0)
                { wordBindingSource.DataSource = list; }
            else
                { MessageBox.Show(strForFilter); }
            }
        private void GetWordsFromBase(string filePath)
            {

            var list = ( checkBoxWord.Checked == true )
                            ? FindWordsByCharacters(MyDictionary.GetFilteredWords(filePath))
                            : MyDictionary.GetFilteredWords(filePath);

            if(list.Count > 0)
                { wordBindingSource.DataSource = list; }
            else
                { MessageBox.Show(strForFilter); }
            }
        private void GetWordsFromBase(string filePath, WordStatus status)
            {
            var list = ( checkBoxWord.Checked == true )
                            ? FindWordsByCharacters(MyDictionary.GetFilteredWords(filePath, status))
                            : MyDictionary.GetFilteredWords(filePath, status);

            if(list.Count > 0)
                { wordBindingSource.DataSource = list; }
            else
                { MessageBox.Show(strForFilter); }
            }

        /// <summary>
        /// Все GetWordsFromBase используют этот метод если checkBoxWord.Checked == true
        /// </summary>
        /// <param name="list">Список слов с первичным фильтром</param>
        /// <returns>Список слов, соответствующих указанной строке(characters)
        /// </returns>
        private List<Word> FindWordsByCharacters(List<Word> list) {
            List<Word> foundWords = new List<Word>();
            string characters = textBoxForFinding.Text.ToLower();
            foreach (var item in list) {
                if (item.WordName.StartsWith(characters))
                    foundWords.Add(item);
            }
            return foundWords;
        }
        #endregion

        #region CheckBoxes
        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e) {
            comboBoxWordStatus.Enabled = ( checkBoxStatus.Checked == true ) ? true : false;
            if (checkBoxStatus.Checked == false) {
                comboBoxWordStatus.SelectedItem = 0;
            }

        }
        private void checkBoxAddress_CheckedChanged(object sender, EventArgs e) {
            comboBoxFileContainingWord.Enabled = ( checkBoxAddress.Checked == true ) ? true : false;
            if (checkBoxAddress.Checked == false) {
                comboBoxFileContainingWord.SelectedItem = 0;
            }
        }
        private void checkBoxWord_CheckedChanged(object sender, EventArgs e) {
            textBoxForFinding.Enabled = ( checkBoxWord.Checked == true ) ? true : false;
            textBoxForFinding.Text = ( checkBoxWord.Checked == true ) ? String.Empty : "Введите слово";
        } 
        #endregion

        private void buttonToApplyFilter_Click(object sender, EventArgs e)
            {
            ShowWords();
            }
        private void buttonResetFilter_Click(object sender, EventArgs e)
            {
            checkBoxStatus.Checked = false;
            checkBoxAddress.Checked = false;
            checkBoxWord.Checked = false;
            }
        #endregion

        private void buttonChangeSelected_Click(object sender, EventArgs e)
            {
            WordStatus statusForChange = (WordStatus)comboBoxChangeStatus.SelectedItem;
            if(dataGridView1.SelectedRows.Count == 1)
                {
                dataGridView1.CurrentRow.Cells[2].Value = statusForChange;
                }
            else if(dataGridView1.SelectedRows.Count > 1)
                {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                    dataGridView1.Rows[row.Index].Cells[2].Value = statusForChange;
                    }
                }
            else
                {
                MessageBox.Show("NO ROWS, CARL!!!");
                //throw new Exception("No rows, CARL !!!");
                }


            }
        private void checkBoxChangeStatus_CheckedChanged(object sender, EventArgs e)
            {
            dataGridView1.SelectionMode = ( checkBoxChangeStatus.Checked == true ) ? DataGridViewSelectionMode.FullRowSelect : DataGridViewSelectionMode.CellSelect;
            panelChangeStatus.Enabled = ( checkBoxChangeStatus.Checked == true ) ? true : false;
            }

        #region Сохранение и предупреждения
        private void WordsEditor_FormClosing(object sender, FormClosingEventArgs e)
            {
            dataGridView1.ClearSelection();
            if(baseSaved == false)
                {
                DialogResult dialogResult = MessageBox.Show("Результаты будут потеряны! Выйти?", "Save!", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                    {
                    wordBindingSource = null;
                    dataGridView1.DataSource = null;
                    e.Cancel = false;
                    }
                else if(dialogResult == DialogResult.No)
                    {

                    e.Cancel = true;
                    }

                }
            }
        private void buttonSaveBase_Click(object sender, EventArgs e)
            {
            MyDictionary.SaveBase();
            baseSaved = true;
            DialogResult dialogResult = MessageBox.Show("База сохранена! Выйти?", "Ok!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {

                try {
                    wordBindingSource = null;
                    dataGridView1.DataSource = null;
                    this.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void comboBoxFileContainingWord_SelectedIndexChanged(object sender, EventArgs e) {
            toolTipForComboBoxFile.SetToolTip(comboBoxFileContainingWord, comboBoxFileContainingWord.SelectedItem.ToString());
        }
    }
    }
