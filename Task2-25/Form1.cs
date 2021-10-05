using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Task2_25
{
    public partial class Form1 : Form
    {
        private string filePath;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Текстовые документы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые документы(*.txt)|*.txt|Все файлы(*.*)|*.*";
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            filePath = filename;
            string fileText = File.ReadAllText(filename);
            textBox.Text = fileText;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, textBox.Text);
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textBox.Text);
            MessageBox.Show(
                "Файл сохранен",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string replaceWord = replaceWordTextBox.Text;
            string replaceBy = replaceByTextBox.Text;
            string text = textBox.Text;

            textBox.Text = ReplaceWords(text, replaceWord, replaceBy);

        }

        private void openWithReplacementButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            string text = fileText;

            string replaceWord = replaceWordTextBox.Text;
            string replaceBy = replaceByTextBox.Text;

            textBox.Text = ReplaceWords(text, replaceWord, replaceBy);
        }

        private void overwriteButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            string text = fileText;

            string replaceWord = replaceWordTextBox.Text;
            string replaceBy = replaceByTextBox.Text;

            string s = ReplaceWords(text, replaceWord, replaceBy);
            textBox.Text = s;

            File.WriteAllText(filename, s);
            MessageBox.Show(
                "Файл сохранен",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private string ReplaceWords(string text, string replaceWord, string replaceBy)
        {
            string s = Regex.Replace(text, @"\b" + replaceWord + @"\b", @"" + replaceBy + "", RegexOptions.IgnoreCase);
            return s;
        }
    }
}
