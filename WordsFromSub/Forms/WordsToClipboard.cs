using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordsFromSub
{
    public partial class WordsToClipboard : Form
    {
        public WordsToClipboard()
        {
            InitializeComponent();
        }
        private void FormListToPuzzle_Load(object sender, EventArgs e)
        {
            comboBoxFileContainingWord.DataSource = MyDictionary.GetPathsToFilesContainingWords();
            comboBoxWordStatus.DataSource = Enum.GetValues(typeof(WordStatus));
            ShowWords();

            if (comboBoxFileContainingWord.Items.Count > 0) {
                toolTipForComboBoxFile.SetToolTip(comboBoxFileContainingWord, comboBoxFileContainingWord.SelectedItem.ToString());
            }
        }
 

        private void checkBoxAddress_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFileContainingWord.Enabled = (checkBoxAddress.Checked == true) ? true : false;


            if (checkBoxAddress.Checked == false)
            {
                comboBoxFileContainingWord.SelectedItem = 0;
            }
        }
        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxWordStatus.Enabled = (checkBoxStatus.Checked == true) ? true : false;
            if (checkBoxStatus.Checked == false)
            {
                comboBoxWordStatus.SelectedItem = 0;
            }
        }
        private void buttonToApplyFilter_Click(object sender, EventArgs e)
        {
            ShowWords();
        }
        private void ShowWords()
        {
            string combination = CombinationOfCheckBoxState();
            List<Word> words;
            switch (combination)
            {
                case "00":
                    words = MyDictionary.GetAllWords();// 00 - GetAllWords
                    break;
                case "01":
                    words = MyDictionary.GetFilteredWords((string)comboBoxFileContainingWord.SelectedItem);// 01- GetFilteredWords(string)
                    break;
                case "10":
                    words = MyDictionary.GetFilteredWords((WordStatus)comboBoxWordStatus.SelectedItem);// 10- GetFilteredWords(WordStatus)
                    break;
                case "11":
                    words = MyDictionary.GetFilteredWords((string)comboBoxFileContainingWord.SelectedItem,
                        (WordStatus)comboBoxWordStatus.SelectedItem);// 11- GetFilteredWords(string,WordStatus)
                    break;
                default:
                    MessageBox.Show("Что то не так!");
                    words = new List<Word>();
                    break;
            }
            if (words.Count != 0)
            {
                label1.Text = ("Состоит из " + words.Count + " элементов");
                List<string> list = new List<string>(words.Count);
                foreach (var word in words)
                {
                    list.Add(word.WordName);
                }
                textBox.Text = String.Join(Environment.NewLine, list);
            }
            else
            {
                MessageBox.Show("Слова не найдены. Попробуйте изменить параметры фильтра.", "Слова не найдены!");
            }
        }
        private string CombinationOfCheckBoxState()
        {
            string combination = String.Empty;
            CheckBox[] checkBoxNames = { checkBoxStatus, checkBoxAddress };// checkBoxAddress

            // получим комбинацию состояний нужных checkBox
            foreach (CheckBox checkBoxName in checkBoxNames) // перебираем указанные checkBox
            {
                if (checkBoxName.Checked) // если CheckBox помечен галочкой
                    combination += '1';
                else
                    combination += '0';
            }
            return combination;
        }
        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            checkBoxAddress.Checked = false;
            checkBoxStatus.Checked = false;
            ShowWords();
        }

        private void buttonToCopy_Click(object sender, EventArgs e)
        {
            if (textBox.Text != String.Empty && textBox.Text != null)
            {
                Clipboard.Clear();
                Clipboard.SetText(textBox.Text);
                MessageBox.Show("Скопировано");
            }
            else
            {
                MessageBox.Show("Не удалось скопировать. Слова не найдены.");
            }

        }

        private void comboBoxFileContainingWord_SelectedIndexChanged(object sender, EventArgs e) {
            toolTipForComboBoxFile.SetToolTip(comboBoxFileContainingWord, comboBoxFileContainingWord.SelectedItem.ToString());
        }
    }
}
