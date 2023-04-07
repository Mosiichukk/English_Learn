
namespace English_Learn
{
    partial class Form_Translator
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
            this.webBrowser_translator = new System.Windows.Forms.WebBrowser();
            this.txtbox_englword = new System.Windows.Forms.TextBox();
            this.txtbox_ukrword = new System.Windows.Forms.TextBox();
            this.btn_addword = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser_translator
            // 
            this.webBrowser_translator.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.webBrowser_translator.Location = new System.Drawing.Point(12, 12);
            this.webBrowser_translator.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_translator.Name = "webBrowser_translator";
            this.webBrowser_translator.Size = new System.Drawing.Size(1322, 679);
            this.webBrowser_translator.TabIndex = 0;
            this.webBrowser_translator.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_translator_DocumentCompleted);
            // 
            // txtbox_englword
            // 
            this.txtbox_englword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_englword.Location = new System.Drawing.Point(27, 715);
            this.txtbox_englword.Name = "txtbox_englword";
            this.txtbox_englword.Size = new System.Drawing.Size(317, 34);
            this.txtbox_englword.TabIndex = 1;
            // 
            // txtbox_ukrword
            // 
            this.txtbox_ukrword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbox_ukrword.Location = new System.Drawing.Point(366, 715);
            this.txtbox_ukrword.Name = "txtbox_ukrword";
            this.txtbox_ukrword.Size = new System.Drawing.Size(304, 34);
            this.txtbox_ukrword.TabIndex = 2;
            this.txtbox_ukrword.TextChanged += new System.EventHandler(this.txtbox_ukrword_TextChanged);
            // 
            // btn_addword
            // 
            this.btn_addword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addword.Location = new System.Drawing.Point(27, 758);
            this.btn_addword.Name = "btn_addword";
            this.btn_addword.Size = new System.Drawing.Size(643, 39);
            this.btn_addword.TabIndex = 3;
            this.btn_addword.Text = "Додати слово";
            this.btn_addword.UseVisualStyleBackColor = true;
            this.btn_addword.Click += new System.EventHandler(this.btn_addword_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_GoBack.Location = new System.Drawing.Point(749, 715);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(576, 82);
            this.btn_GoBack.TabIndex = 4;
            this.btn_GoBack.Text = "Назад";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // Form_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1346, 852);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_addword);
            this.Controls.Add(this.txtbox_ukrword);
            this.Controls.Add(this.txtbox_englword);
            this.Controls.Add(this.webBrowser_translator);
            this.Name = "Form_Translator";
            this.Text = "Перекладач";
            this.Load += new System.EventHandler(this.Form_Translator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_translator;
        private System.Windows.Forms.TextBox txtbox_englword;
        private System.Windows.Forms.TextBox txtbox_ukrword;
        private System.Windows.Forms.Button btn_addword;
        private System.Windows.Forms.Button btn_GoBack;
    }
}