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
    public partial class Form_Launcher : Form
    {
        Words words = new Words();
        int index_game;
        Words check_words = new Words();
        int word_which_checked = 0;

        public Form_Launcher(Words words,int index_game)
        {
            InitializeComponent();
            this.words = words;
            this.index_game = index_game;
        }

        private void Form_Launcher_Load(object sender, EventArgs e)
        {
            foreach(var word in words.List_Words)
            {
                checkedListBox_words.Items.Add(word);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_all_words.Checked==true)
            {
                for (int i = 0; i < words.List_Words.Count; i++)
                {
                    checkedListBox_words.SetItemCheckState(i, CheckState.Checked);
                }
            }
            else if (checkBox_all_words.Checked == false)
            {
                for (int i = 0; i < words.List_Words.Count; i++)
                {
                    checkedListBox_words.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
           
            
           foreach (var word in words.List_Words)
            {
                if (checkedListBox_words.CheckedItems.Contains(word))
                {
                    
                    check_words.Add_Word(word);
                    word_which_checked++;
                }
               
            }
            if (word_which_checked >= 10)
            {
                switch (index_game)
                {
                    case 1:
                        Form_Game1 form_Game1 = new Form_Game1(check_words);
                        form_Game1.Show();
                        Close();
                        break;
                    case 2:
                        Form_Game2 form_Game2 = new Form_Game2(check_words);
                        form_Game2.Show();
                        Close();
                        break;
                    case 3:
                        Form_Game3 form_Game3 = new Form_Game3(check_words);
                        form_Game3.Show();
                        Close();
                        break;
                }
            }

        }
    }
}
