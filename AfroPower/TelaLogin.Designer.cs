namespace AfroPower
{
    partial class TelaLogin
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(618, 555);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.BurlyWood;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Location = new System.Drawing.Point(658, 339);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(241, 15);
            this.txt_Email.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.BackColor = System.Drawing.Color.BurlyWood;
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Senha.Location = new System.Drawing.Point(672, 424);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(227, 15);
            this.txt_Senha.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AfroPower.Properties.Resources.Tela_de_Login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1450, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLogin";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}