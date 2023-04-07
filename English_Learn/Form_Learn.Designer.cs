
namespace English_Learn
{
    partial class Form_Learn
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
            this.btn_game1 = new System.Windows.Forms.Button();
            this.btn_game2 = new System.Windows.Forms.Button();
            this.btn_game3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_game1
            // 
            this.btn_game1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_game1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game1.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_game1.Location = new System.Drawing.Point(34, 48);
            this.btn_game1.Name = "btn_game1";
            this.btn_game1.Size = new System.Drawing.Size(94, 81);
            this.btn_game1.TabIndex = 0;
            this.btn_game1.Text = "Гра №1";
            this.btn_game1.UseVisualStyleBackColor = true;
            this.btn_game1.Click += new System.EventHandler(this.btn_game1_Click);
            // 
            // btn_game2
            // 
            this.btn_game2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_game2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game2.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_game2.Location = new System.Drawing.Point(195, 49);
            this.btn_game2.Name = "btn_game2";
            this.btn_game2.Size = new System.Drawing.Size(94, 80);
            this.btn_game2.TabIndex = 1;
            this.btn_game2.Text = "Гра №2";
            this.btn_game2.UseVisualStyleBackColor = true;
            this.btn_game2.Click += new System.EventHandler(this.btn_game2_Click);
            // 
            // btn_game3
            // 
            this.btn_game3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_game3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game3.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_game3.Location = new System.Drawing.Point(357, 48);
            this.btn_game3.Name = "btn_game3";
            this.btn_game3.Size = new System.Drawing.Size(94, 80);
            this.btn_game3.TabIndex = 2;
            this.btn_game3.Text = "Гра №3";
            this.btn_game3.UseVisualStyleBackColor = true;
            this.btn_game3.Click += new System.EventHandler(this.btn_game3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(146, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(500, 345);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_game3);
            this.Controls.Add(this.btn_game2);
            this.Controls.Add(this.btn_game1);
            this.Name = "Form_Learn";
            this.Text = "Games";
            this.Load += new System.EventHandler(this.Form_Learn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_game1;
        private System.Windows.Forms.Button btn_game2;
        private System.Windows.Forms.Button btn_game3;
        private System.Windows.Forms.Button button4;
    }
}