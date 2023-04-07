using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_Learn
{
    public partial class Form_Game1 : Form
    {
        Words words = new Words();
        Word true_word;
       List <Word> list_word = new List<Word>();
        Random rnd = new Random();
        int choose_index;
        int right_index;
        public Form_Game1(Words words)
        {
            InitializeComponent();
            this.words = words;
        }
        private void StartLevel()
        {  
            
                list_word = words.Random_Words(5);
            
            right_index = rnd.Next(list_word.Count);
            true_word = list_word[right_index];
            label_word_eng.Text = true_word.English_World;
            for(int i = 0; i < 5; i++)
            {
                checkedListBox_words.Items.Add(list_word[i].Ukraine_word);
            }
        }
        private void EndLevel()
        {
            checkedListBox_words.Items.Clear();
            label_error.Text = "";
        }
        private void Form_Game1_Load(object sender, EventArgs e)
        {
            StartLevel();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            if (choose_index == right_index)
            {
                EndLevel();
                StartLevel();
            }
            else
            {
                label_error.Text = "Помилка! :(";
            }
        }

        private void checkedListBox_words_SelectedIndexChanged(object sender, EventArgs e)
        {
            choose_index = checkedListBox_words.SelectedIndex;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
