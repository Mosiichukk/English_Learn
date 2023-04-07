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
    public partial class Form_Find : Form
    {
        Words words;
        public Form_Find(Words words)
        {
            InitializeComponent();
            this.words = words;
        }

        private void txtbox_word_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                foreach (var Word in words.List_Words)
                {
                    if (Word == txtbox_word.Text)
                    {
                        label_bool.Text = Word.ToString();
                        break;
                    }
                    else { label_bool.Text = "Слова немає в наявності"; }
                   
                }
                
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Find_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_word_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
