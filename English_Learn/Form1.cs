using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;

namespace English_Learn
{
    public partial class Form1 : Form
    {
        Words words = new Words();
       public int index_word=0;
        private string name;
        private bool isRadiobuttonChecked = false;
        List<Word> Radio_Words = new List<Word>();
       private SpeechSynthesizer synth = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }
        public void Renew_list()
        {

            for (int i = listbox_word.Items.Count; i < words.List_Words.Count; i++)
            {
                listbox_word.Items.Add(words[i].ToString());
            }
        }
        public void Renew_All_list()
        {
            foreach (var word in words.List_Words)
            {
                listbox_word.Items.Add(word.ToString());
                
                dataGridView_words.Rows.Add(word.English_World, word.Ukraine_word);
                
            }
        }
        private void btn_add_word_Click(object sender, EventArgs e)
        {
            if (txt_box_english_word.Text != "" && txt_word_ukraine_word.Text != "")
            {
                Word word = new Word(txt_box_english_word.Text, txt_word_ukraine_word.Text);
                listbox_word.Items.Add(word.ToString());
                words.Add_Word(word);
                txt_box_english_word.Clear();
                txt_word_ukraine_word.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRadiobuttonChecked)
            {
                Word word = Radio_Words[index_word];

              
                try
                {
                    Radio_Words.RemoveAt(index_word);


                    if (words.FindIndexWord(word) != -1)
                    {
                        words.Delete_Word(words.FindIndexWord(word));
                        dataGridView_words.Rows.RemoveAt(index_word);
                    }
                    

                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    words.Delete_Word(index_word);
                    dataGridView_words.Rows.RemoveAt(index_word);
                    listbox_word.Items.RemoveAt(index_word);
                   
                }
                catch (Exception) { }
            }
        }

        private void listbox_word_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            index_word= listbox_word.SelectedIndex; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_Translator form_translator = new Form_Translator(words);
            form_translator.ShowDialog();
        }

        private void btn_Renew_list_Click(object sender, EventArgs e)
        {
            Renew_list();
        }
        private void Text_in_Words(string Text)
        {
            string ukr="";
            string eng="";
            bool isUkr=false;
            bool isEng=false;
            for(int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == '|')
                {
                    isUkr = true;
                    isEng = false;
                    continue;
                }
                if (Text[i] == '.')
                {
                    isEng = true;
                    isUkr = false;
                    if (ukr != "" && eng != "")
                    {
                        Word word = new Word(eng, ukr);
                        words.Add_Word(word);
                    }
                    ukr = "";
                    eng = "";
                    continue;
                }
                if (isUkr) ukr += Text[i];
                if (isEng) eng += Text[i];
                
            }
        }
        private string Words_in_Text()
        {
            string Text = "";
            foreach(var word in words.List_Words)
            {
                Text += word.ForText();
            }
            return Text;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
          /*  string Link = @"D:\Form\LearnTxt";


            try
            { //Підключаю бібліотеку StreamWriter
                using (StreamWriter sw = new StreamWriter(Link, false, Encoding.Default))
                {
                    //Зберігаю данні в .text файл
                    label_error.Text = "";
                    foreach (var word in words.List_Words)
                    {
                       
                        sw.WriteLine(word.ToString());
                       
                    }

                }
            }
            catch (Exception)//лове помилку в коді
            {

                label_error.Text = "Error";
            }*/
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, Words_in_Text());
                
            }
        }

        private void btn_open_txt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                listbox_word.Items.Clear();
                Text_in_Words(File.ReadAllText(name));
                
                Renew_All_list();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_go_to_learn_Click(object sender, EventArgs e)
        {
            if (words.List_Words.Count<7) { label_error_addwords.Text = "Додайте більше слів"; }
            else
            {
                label_error_addwords.Text = "";
                Form_Learn form_Learn = new Form_Learn(words);
                form_Learn.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_error_addwords.Text = "";
            
            dataGridView_words.Columns.Add("Tranclate", "Переклад");
            dataGridView_words.Columns.Add("Words","Слово");
            
        }

        private void txt_word_ukraine_word_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void txt_word_ukraine_word__KeyDown(object sender,KeyEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_word_Click(this, EventArgs.Empty);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            synth.SelectVoice("Microsoft David Desktop");

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            if(isRadiobuttonChecked)
                synth.Speak(Radio_Words[index_word].English_World);
            else
            synth.Speak(words[index_word].English_World);
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            Form_Find form_Find = new Form_Find(words);
            form_Find.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_alphavit.Checked)
            {
                Radio_Words = words.Sort();

                listbox_word.Items.Clear();
                foreach (var word in Radio_Words)
                {
                    listbox_word.Items.Add(word.ToString());
                }
                isRadiobuttonChecked = true;
            }
            else
            {
                isRadiobuttonChecked = false;
                listbox_word.Items.Clear();
                Renew_All_list();
            }
        }

        private void radioButton_just_CheckedChanged(object sender, EventArgs e)
        {
           /* isRadiobuttonChecked = false;
            listbox_word.Items.Clear();
            Renew_All_list(); */
        }

        private void label_error_addwords_Click(object sender, EventArgs e)
        {

        }
    }
}
