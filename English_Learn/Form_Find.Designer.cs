
namespace English_Learn
{
    partial class Form_Find
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
            this.txtbox_word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_bool = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_word
            // 
            this.txtbox_word.Location = new System.Drawing.Point(115, 78);
            this.txtbox_word.Name = "txtbox_word";
            this.txtbox_word.Size = new System.Drawing.Size(246, 22);
            this.txtbox_word.TabIndex = 0;
            this.txtbox_word.TextChanged += new System.EventHandler(this.txtbox_word_TextChanged);
            this.txtbox_word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_word_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть слово яке хочете знайти";
            // 
            // label_bool
            // 
            this.label_bool.AutoSize = true;
            this.label_bool.Location = new System.Drawing.Point(145, 130);
            this.label_bool.Name = "label_bool";
            this.label_bool.Size = new System.Drawing.Size(0, 17);
            this.label_bool.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Back.Location = new System.Drawing.Point(115, 194);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(246, 41);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form_Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(489, 247);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label_bool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_word);
            this.KeyPreview = true;
            this.Name = "Form_Find";
            this.Text = "Form_Find";
            this.Load += new System.EventHandler(this.Form_Find_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_bool;
        private System.Windows.Forms.Button btn_Back;
    }
}