
namespace English_Learn
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox_word = new System.Windows.Forms.ListBox();
            this.txt_box_english_word = new System.Windows.Forms.TextBox();
            this.txt_word_ukraine_word = new System.Windows.Forms.TextBox();
            this.btn_add_word = new System.Windows.Forms.Button();
            this.btn_delete_word = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_open_translator = new System.Windows.Forms.Button();
            this.btn_Renew_list = new System.Windows.Forms.Button();
            this.btn_save_in_txt = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_open_txt = new System.Windows.Forms.Button();
            this.btn_go_to_learn = new System.Windows.Forms.Button();
            this.btn_Sound = new System.Windows.Forms.Button();
            this.radioButton_alphavit = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_just = new System.Windows.Forms.RadioButton();
            this.label_error_addwords = new System.Windows.Forms.Label();
            this.dataGridView_words = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_words)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_word
            // 
            this.listbox_word.BackColor = System.Drawing.Color.Black;
            this.listbox_word.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_word.ForeColor = System.Drawing.Color.DarkCyan;
            this.listbox_word.FormattingEnabled = true;
            this.listbox_word.ItemHeight = 22;
            this.listbox_word.Location = new System.Drawing.Point(30, 148);
            this.listbox_word.Name = "listbox_word";
            this.listbox_word.Size = new System.Drawing.Size(294, 598);
            this.listbox_word.TabIndex = 0;
            this.listbox_word.SelectedIndexChanged += new System.EventHandler(this.listbox_word_SelectedIndexChanged);
            // 
            // txt_box_english_word
            // 
            this.txt_box_english_word.Location = new System.Drawing.Point(359, 214);
            this.txt_box_english_word.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_box_english_word.Name = "txt_box_english_word";
            this.txt_box_english_word.Size = new System.Drawing.Size(270, 22);
            this.txt_box_english_word.TabIndex = 1;
            // 
            // txt_word_ukraine_word
            // 
            this.txt_word_ukraine_word.Location = new System.Drawing.Point(750, 214);
            this.txt_word_ukraine_word.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_word_ukraine_word.Name = "txt_word_ukraine_word";
            this.txt_word_ukraine_word.Size = new System.Drawing.Size(270, 22);
            this.txt_word_ukraine_word.TabIndex = 2;
            this.txt_word_ukraine_word.TextChanged += new System.EventHandler(this.txt_word_ukraine_word_TextChanged);
            // 
            // btn_add_word
            // 
            this.btn_add_word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_word.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_word.Location = new System.Drawing.Point(766, 276);
            this.btn_add_word.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_add_word.Name = "btn_add_word";
            this.btn_add_word.Size = new System.Drawing.Size(254, 42);
            this.btn_add_word.TabIndex = 3;
            this.btn_add_word.Text = "Додати слово";
            this.btn_add_word.UseVisualStyleBackColor = true;
            this.btn_add_word.Click += new System.EventHandler(this.btn_add_word_Click);
            // 
            // btn_delete_word
            // 
            this.btn_delete_word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_word.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_word.Location = new System.Drawing.Point(220, 115);
            this.btn_delete_word.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delete_word.Name = "btn_delete_word";
            this.btn_delete_word.Size = new System.Drawing.Size(105, 27);
            this.btn_delete_word.TabIndex = 4;
            this.btn_delete_word.Text = "Delete";
            this.btn_delete_word.UseVisualStyleBackColor = true;
            this.btn_delete_word.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(823, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Переклад";
            // 
            // btn_open_translator
            // 
            this.btn_open_translator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open_translator.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_translator.Location = new System.Drawing.Point(359, 276);
            this.btn_open_translator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_open_translator.Name = "btn_open_translator";
            this.btn_open_translator.Size = new System.Drawing.Size(224, 42);
            this.btn_open_translator.TabIndex = 7;
            this.btn_open_translator.Text = "Онлайн-перекладач";
            this.btn_open_translator.UseVisualStyleBackColor = true;
            this.btn_open_translator.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Renew_list
            // 
            this.btn_Renew_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Renew_list.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Renew_list.Location = new System.Drawing.Point(133, 115);
            this.btn_Renew_list.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Renew_list.Name = "btn_Renew_list";
            this.btn_Renew_list.Size = new System.Drawing.Size(80, 27);
            this.btn_Renew_list.TabIndex = 8;
            this.btn_Renew_list.Text = "Оновити";
            this.btn_Renew_list.UseVisualStyleBackColor = true;
            this.btn_Renew_list.Click += new System.EventHandler(this.btn_Renew_list_Click);
            // 
            // btn_save_in_txt
            // 
            this.btn_save_in_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_in_txt.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_in_txt.Location = new System.Drawing.Point(11, 22);
            this.btn_save_in_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_save_in_txt.Name = "btn_save_in_txt";
            this.btn_save_in_txt.Size = new System.Drawing.Size(148, 27);
            this.btn_save_in_txt.TabIndex = 9;
            this.btn_save_in_txt.Text = "Зберегти слова";
            this.btn_save_in_txt.UseVisualStyleBackColor = true;
            this.btn_save_in_txt.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(989, 330);
            this.label_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 17);
            this.label_error.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            this.openFileDialog1.InitialDirectory = "D:\\Form";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.InitialDirectory = "D:\\Form";
            // 
            // btn_open_txt
            // 
            this.btn_open_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open_txt.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_txt.Location = new System.Drawing.Point(163, 24);
            this.btn_open_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_open_txt.Name = "btn_open_txt";
            this.btn_open_txt.Size = new System.Drawing.Size(148, 25);
            this.btn_open_txt.TabIndex = 11;
            this.btn_open_txt.Text = "Відкрити .txt";
            this.btn_open_txt.UseVisualStyleBackColor = true;
            this.btn_open_txt.Click += new System.EventHandler(this.btn_open_txt_Click);
            // 
            // btn_go_to_learn
            // 
            this.btn_go_to_learn.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_go_to_learn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_go_to_learn.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go_to_learn.Location = new System.Drawing.Point(359, 395);
            this.btn_go_to_learn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_go_to_learn.Name = "btn_go_to_learn";
            this.btn_go_to_learn.Size = new System.Drawing.Size(661, 101);
            this.btn_go_to_learn.TabIndex = 12;
            this.btn_go_to_learn.Text = "LEARN";
            this.btn_go_to_learn.UseVisualStyleBackColor = false;
            this.btn_go_to_learn.Click += new System.EventHandler(this.btn_go_to_learn_Click);
            // 
            // btn_Sound
            // 
            this.btn_Sound.BackgroundImage = global::English_Learn.Properties.Resources.sound;
            this.btn_Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sound.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sound.Location = new System.Drawing.Point(30, 105);
            this.btn_Sound.Name = "btn_Sound";
            this.btn_Sound.Size = new System.Drawing.Size(58, 41);
            this.btn_Sound.TabIndex = 13;
            this.btn_Sound.UseVisualStyleBackColor = true;
            this.btn_Sound.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // radioButton_alphavit
            // 
            this.radioButton_alphavit.AutoSize = true;
            this.radioButton_alphavit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_alphavit.Location = new System.Drawing.Point(12, 70);
            this.radioButton_alphavit.Name = "radioButton_alphavit";
            this.radioButton_alphavit.Size = new System.Drawing.Size(243, 26);
            this.radioButton_alphavit.TabIndex = 14;
            this.radioButton_alphavit.TabStop = true;
            this.radioButton_alphavit.Text = "Сортувати по алфавіту";
            this.radioButton_alphavit.UseVisualStyleBackColor = true;
            this.radioButton_alphavit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(588, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Пошук слова";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // radioButton_just
            // 
            this.radioButton_just.AutoSize = true;
            this.radioButton_just.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_just.Location = new System.Drawing.Point(270, 70);
            this.radioButton_just.Name = "radioButton_just";
            this.radioButton_just.Size = new System.Drawing.Size(154, 26);
            this.radioButton_just.TabIndex = 16;
            this.radioButton_just.TabStop = true;
            this.radioButton_just.Text = "Не сортувати";
            this.radioButton_just.UseVisualStyleBackColor = true;
            this.radioButton_just.CheckedChanged += new System.EventHandler(this.radioButton_just_CheckedChanged);
            // 
            // label_error_addwords
            // 
            this.label_error_addwords.AutoSize = true;
            this.label_error_addwords.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error_addwords.ForeColor = System.Drawing.Color.Red;
            this.label_error_addwords.Location = new System.Drawing.Point(612, 357);
            this.label_error_addwords.Name = "label_error_addwords";
            this.label_error_addwords.Size = new System.Drawing.Size(219, 26);
            this.label_error_addwords.TabIndex = 17;
            this.label_error_addwords.Text = "Додайте більше слів";
            this.label_error_addwords.Click += new System.EventHandler(this.label_error_addwords_Click);
            // 
            // dataGridView_words
            // 
            this.dataGridView_words.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_words.Location = new System.Drawing.Point(359, 541);
            this.dataGridView_words.Name = "dataGridView_words";
            this.dataGridView_words.RowHeadersWidth = 51;
            this.dataGridView_words.RowTemplate.Height = 24;
            this.dataGridView_words.Size = new System.Drawing.Size(661, 256);
            this.dataGridView_words.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1198, 809);
            this.Controls.Add(this.dataGridView_words);
            this.Controls.Add(this.label_error_addwords);
            this.Controls.Add(this.radioButton_just);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_alphavit);
            this.Controls.Add(this.btn_Sound);
            this.Controls.Add(this.btn_go_to_learn);
            this.Controls.Add(this.btn_open_txt);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.btn_save_in_txt);
            this.Controls.Add(this.btn_Renew_list);
            this.Controls.Add(this.btn_open_translator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete_word);
            this.Controls.Add(this.btn_add_word);
            this.Controls.Add(this.txt_word_ukraine_word);
            this.Controls.Add(this.txt_box_english_word);
            this.Controls.Add(this.listbox_word);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Словник для навчання";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_words)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_word;
        private System.Windows.Forms.TextBox txt_box_english_word;
        private System.Windows.Forms.TextBox txt_word_ukraine_word;
        private System.Windows.Forms.Button btn_add_word;
        private System.Windows.Forms.Button btn_delete_word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_open_translator;
        private System.Windows.Forms.Button btn_Renew_list;
        private System.Windows.Forms.Button btn_save_in_txt;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_open_txt;
        private System.Windows.Forms.Button btn_go_to_learn;
        private System.Windows.Forms.Button btn_Sound;
        private System.Windows.Forms.RadioButton radioButton_alphavit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_just;
        private System.Windows.Forms.Label label_error_addwords;
        private System.Windows.Forms.DataGridView dataGridView_words;
    }
}

