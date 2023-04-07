
namespace English_Learn
{
    partial class Form_Game3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_ukr_words = new System.Windows.Forms.ListBox();
            this.label_mistake = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::English_Learn.Properties.Resources.sound;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(376, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 77);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(318, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Далі";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_ukr_words
            // 
            this.listBox_ukr_words.BackColor = System.Drawing.Color.Black;
            this.listBox_ukr_words.ForeColor = System.Drawing.Color.DarkCyan;
            this.listBox_ukr_words.FormattingEnabled = true;
            this.listBox_ukr_words.ItemHeight = 24;
            this.listBox_ukr_words.Location = new System.Drawing.Point(608, 48);
            this.listBox_ukr_words.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_ukr_words.Name = "listBox_ukr_words";
            this.listBox_ukr_words.Size = new System.Drawing.Size(394, 388);
            this.listBox_ukr_words.TabIndex = 3;
            this.listBox_ukr_words.SelectedIndexChanged += new System.EventHandler(this.listBox_ukr_words_SelectedIndexChanged);
            // 
            // label_mistake
            // 
            this.label_mistake.AutoSize = true;
            this.label_mistake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_mistake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mistake.ForeColor = System.Drawing.Color.Red;
            this.label_mistake.Location = new System.Drawing.Point(372, 218);
            this.label_mistake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mistake.Name = "label_mistake";
            this.label_mistake.Size = new System.Drawing.Size(83, 20);
            this.label_mistake.TabIndex = 4;
            this.label_mistake.Text = "Помилка";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(44, 442);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(255, 99);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form_Game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1081, 585);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label_mistake);
            this.Controls.Add(this.listBox_ukr_words);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Game3";
            this.Text = "Game3";
            this.Load += new System.EventHandler(this.Form_Game3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox_ukr_words;
        private System.Windows.Forms.Label label_mistake;
        private System.Windows.Forms.Button btn_Back;
    }
}