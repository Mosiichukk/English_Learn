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
    public partial class Form_Game2 : Form
    {
        Words words;
        Word word;
        bool isChecked=false;
        public Form_Game2(Words words)
        {
            InitializeComponent();
            this.words = words;
        }
        public void NewLevel()
        {
            
            
            word = words.Random_Word();
            if (isChecked)
            {
                char first_number = word.English_World[0];
                txt_box_engword.Text = first_number.ToString();
            }
            else txt_box_engword.Text = "";
            label_error1.Text = "";
            label_ukrword.Text = word.Ukraine_word;

        }
        
        private void Form_Game2_Load(object sender, EventArgs e)
        {
            NewLevel();
        }

        private void Form_Game2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter && label_ukrword.Text!="")
            {
                if (word.English_World == txt_box_engword.Text)
                {
                    NewLevel();
                }
                else
                {
                    label_error1.Text = word.English_World;
                    
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isChecked = true;
                txt_box_engword.Text = word.English_World[0].ToString();
            }
            else
            {
                isChecked = false;
                txt_box_engword.Text = "";
            }
        }
    }
}
