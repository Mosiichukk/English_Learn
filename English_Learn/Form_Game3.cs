using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace English_Learn
{
    public partial class Form_Game3 : Form
    {
        private Words words;
        private Word word;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        
        private int index_ukr_word;
        private int right_index;
        List<Word> list_ukr_words = new List<Word>();
        Random rnd = new Random();
        public Form_Game3(Words words)
        {
            InitializeComponent();
            this.words = words;
        }
        void NewWord()
        {
            label_mistake.Text = "";
            listBox_ukr_words.Items.Clear();
            list_ukr_words = words.Random_Words(6);
            right_index = rnd.Next(6);
            word = list_ukr_words[right_index];
            foreach(var word in list_ukr_words)
            {
                listBox_ukr_words.Items.Add(word.Ukraine_word);
            }
            
        }
        //Озвучую текст англійською
        private void button1_Click(object sender, EventArgs e)
        {
            synth.SelectVoice("Microsoft David Desktop");
            
            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();
            
            // Speak a string.  
            synth.Speak(word.English_World);
        }

        void GetVoices()
        {
            string names ="" ;
            foreach (var voice in synth.GetInstalledVoices())
            {
                string name = voice.VoiceInfo.Name; //получить название голоса
                names += name;
                 //вывести в консоль название голоса
            }
            

            
        }
        private void Form_Game3_Load(object sender, EventArgs e)
        {
            NewWord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (right_index == index_ukr_word)
            {
                NewWord();
                button1_Click(sender, e);
            }
            else
            {
                label_mistake.Text = "Помилка(";
            }
        }

        private void listBox_ukr_words_SelectedIndexChanged(object sender, EventArgs e)
        {
            index_ukr_word = listBox_ukr_words.SelectedIndex;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
