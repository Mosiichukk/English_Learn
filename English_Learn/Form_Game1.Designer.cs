
namespace English_Learn
{
    partial class Form_Game1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_word_eng = new System.Windows.Forms.Label();
            this.checkedListBox_words = new System.Windows.Forms.CheckedListBox();
            this.btn_choose = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_word_eng
            // 
            this.label_word_eng.AutoSize = true;
            this.label_word_eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_word_eng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_word_eng.Location = new System.Drawing.Point(59, 112);
            this.label_word_eng.Name = "label_word_eng";
            this.label_word_eng.Size = new System.Drawing.Size(103, 32);
            this.label_word_eng.TabIndex = 0;
            this.label_word_eng.Text = "Слово";
            // 
            // checkedListBox_words
            // 
            this.checkedListBox_words.BackColor = System.Drawing.Color.PaleTurquoise;
            this.checkedListBox_words.FormattingEnabled = true;
            this.checkedListBox_words.Location = new System.Drawing.Point(349, 34);
            this.checkedListBox_words.Name = "checkedListBox_words";
            this.checkedListBox_words.Size = new System.Drawing.Size(261, 208);
            this.checkedListBox_words.TabIndex = 1;
            this.checkedListBox_words.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_words_SelectedIndexChanged);
            // 
            // btn_choose
            // 
            this.btn_choose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_choose.Location = new System.Drawing.Point(147, 252);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(170, 46);
            this.btn_choose.TabIndex = 2;
            this.btn_choose.Text = "Вибрати";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(446, 210);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 24);
            this.label_error.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(459, 343);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(172, 39);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form_Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(640, 391);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.checkedListBox_words);
            this.Controls.Add(this.label_word_eng);
            this.Name = "Form_Game1";
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Form_Game1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_word_eng;
        private System.Windows.Forms.CheckedListBox checkedListBox_words;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button btn_back;
    }
}