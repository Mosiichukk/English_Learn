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
    public partial class Form_Learn : Form
    {
        Words words;
     
        public Form_Learn(Words words)
        {
            this.words = words;
            InitializeComponent();
        }
        private void Form_Learn_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_game1_Click(object sender, EventArgs e)
        {
            Form_Launcher form_launcher = new Form_Launcher(words,1);
            form_launcher.Show();
           

        }

        private void btn_game2_Click(object sender, EventArgs e)
        {
            Form_Launcher form_launcher = new Form_Launcher(words, 2);
            form_launcher.Show();
        }

        private void btn_game3_Click(object sender, EventArgs e)
        {
            Form_Launcher form_launcher = new Form_Launcher(words, 3);
            form_launcher.Show();
        }
    }
}
