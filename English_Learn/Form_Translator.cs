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
    public partial class Form_Translator : Form
    {
        Words words;
        public Form_Translator()
        {
            InitializeComponent();
            
        }
        public Form_Translator(Words words)
        {
            this.words = words;
            InitializeComponent();
        }

        private void Form_Translator_Load(object sender, EventArgs e)
        {
            webBrowser_translator.Navigate("https://translate.google.com/?hl=ru&sl=uk&tl=en&op=translate");
        }

        private void webBrowser_translator_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btn_addword_Click(object sender, EventArgs e)
        {
            Word word = new Word(txtbox_englword.Text, txtbox_ukrword.Text);
            words.Add_Word(word);
            txtbox_englword.Clear();
            txtbox_ukrword.Clear();
            
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbox_ukrword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
