
namespace English_Learn
{
    partial class Form_Launcher
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
            this.checkedListBox_words = new System.Windows.Forms.CheckedListBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.checkBox_all_words = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkedListBox_words
            // 
            this.checkedListBox_words.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkedListBox_words.ForeColor = System.Drawing.Color.DarkCyan;
            this.checkedListBox_words.FormattingEnabled = true;
            this.checkedListBox_words.Location = new System.Drawing.Point(34, 44);
            this.checkedListBox_words.Name = "checkedListBox_words";
            this.checkedListBox_words.Size = new System.Drawing.Size(359, 769);
            this.checkedListBox_words.TabIndex = 0;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_next.Location = new System.Drawing.Point(508, 321);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(174, 63);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Далі";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // checkBox_all_words
            // 
            this.checkBox_all_words.AutoSize = true;
            this.checkBox_all_words.Location = new System.Drawing.Point(34, 17);
            this.checkBox_all_words.Name = "checkBox_all_words";
            this.checkBox_all_words.Size = new System.Drawing.Size(107, 21);
            this.checkBox_all_words.TabIndex = 2;
            this.checkBox_all_words.Text = "Вибрати всі";
            this.checkBox_all_words.UseVisualStyleBackColor = true;
            this.checkBox_all_words.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 887);
            this.Controls.Add(this.checkBox_all_words);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.checkedListBox_words);
            this.Name = "Form_Launcher";
            this.Text = "Form_Launcher";
            this.Load += new System.EventHandler(this.Form_Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_words;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.CheckBox checkBox_all_words;
    }
}