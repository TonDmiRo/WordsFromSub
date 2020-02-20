using System;
using System.IO;
using System.Windows.Forms;

namespace WordsFromSub
{
    public partial class FormToStart : Form
    {
        public FormToStart()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string path = txAddressSub.Text;
            if (File.Exists(path))
            {
                WordsFromFile newForm1 = new WordsFromFile(path);
                newForm1.Show();
            }

            else
            {
                MessageBox.Show("Файл не найден!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WordsEditor newForm = new WordsEditor();
            newForm.Show();
        }

        private void buttonGetList_Click(object sender, EventArgs e)
        {
            WordsToClipboard newForm = new WordsToClipboard();
            newForm.Show();
        }

        private void buttonOpenFileD_Click(object sender, EventArgs e)
        {
            string StartDirectory = Application.StartupPath;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = StartDirectory;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txAddressSub.Text = openFileDialog.FileName;
                }
            }
        }
    }
}

