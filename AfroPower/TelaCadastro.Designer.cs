namespace AfroPower
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.cb_Nivel = new System.Windows.Forms.ComboBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.Tan;
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senha.Location = new System.Drawing.Point(657, 414);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(195, 15);
            this.txt_senha.TabIndex = 2;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.Tan;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Location = new System.Drawing.Point(645, 338);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(195, 15);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_Data
            // 
            this.txt_Data.BackColor = System.Drawing.Color.Tan;
            this.txt_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Data.Location = new System.Drawing.Point(721, 497);
            this.txt_Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(131, 15);
            this.txt_Data.TabIndex = 4;
            // 
            // cb_Nivel
            // 
            this.cb_Nivel.BackColor = System.Drawing.Color.Tan;
            this.cb_Nivel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_Nivel.FormattingEnabled = true;
            this.cb_Nivel.Items.AddRange(new object[] {
            "Cliente ",
            "Trancista"});
            this.cb_Nivel.Location = new System.Drawing.Point(612, 553);
            this.cb_Nivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Nivel.Name = "cb_Nivel";
            this.cb_Nivel.Size = new System.Drawing.Size(197, 24);
            this.cb_Nivel.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.Tan;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Location = new System.Drawing.Point(657, 254);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome.MaxLength = 32769;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(195, 15);
            this.txt_nome.TabIndex = 6;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cadastrar.BackgroundImage")));
            this.btn_Cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cadastrar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cadastrar.Image")));
            this.btn_Cadastrar.Location = new System.Drawing.Point(593, 613);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(259, 39);
            this.btn_Cadastrar.TabIndex = 1;
            this.btn_Cadastrar.UseCompatibleTextRendering = true;
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AfroPower.Properties.Resources.Tela_de_Cadastro__3_;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1450, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.cb_Nivel);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.ComboBox cb_Nivel;
        public System.Windows.Forms.TextBox txt_nome;
    }
}