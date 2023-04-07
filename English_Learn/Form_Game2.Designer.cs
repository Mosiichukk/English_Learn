
namespace English_Learn
{
    partial class Form_Game2
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
            this.btn_back = new System.Windows.Forms.Button();
            this.label_ukrword = new System.Windows.Forms.Label();
            this.txt_box_engword = new System.Windows.Forms.TextBox();
            this.label_error = new System.Windows.Forms.Label();
            this.label_error1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(104, 241);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(392, 49);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label_ukrword
            // 
            this.label_ukrword.AutoSize = true;
            this.label_ukrword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ukrword.Location = new System.Drawing.Point(27, 118);
            this.label_ukrword.Name = "label_ukrword";
            this.label_ukrword.Size = new System.Drawing.Size(91, 29);
            this.label_ukrword.TabIndex = 1;
            this.label_ukrword.Text = "Слово";
            // 
            // txt_box_engword
            // 
            this.txt_box_engword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_box_engword.Location = new System.Drawing.Point(370, 117);
            this.txt_box_engword.Name = "txt_box_engword";
            this.txt_box_engword.Size = new System.Drawing.Size(213, 30);
            this.txt_box_engword.TabIndex = 2;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(337, 128);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 17);
            this.label_error.TabIndex = 3;
            // 
            // label_error1
            // 
            this.label_error1.AutoSize = true;
            this.label_error1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_error1.ForeColor = System.Drawing.Color.Red;
            this.label_error1.Location = new System.Drawing.Point(246, 77);
            this.label_error1.Name = "label_error1";
            this.label_error1.Size = new System.Drawing.Size(60, 24);
            this.label_error1.TabIndex = 4;
            this.label_error1.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(370, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 26);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Перша буква";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(614, 318);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label_error1);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.txt_box_engword);
            this.Controls.Add(this.label_ukrword);
            this.Controls.Add(this.btn_back);
            this.KeyPreview = true;
            this.Name = "Form_Game2";
            this.Text = "Form_Game2";
            this.Load += new System.EventHandler(this.Form_Game2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Game2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label_ukrword;
        private System.Windows.Forms.TextBox txt_box_engword;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label_error1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}