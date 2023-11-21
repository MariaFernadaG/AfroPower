namespace AfroPower
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Cadas = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AfroPower.Properties.Resources.BotaoSair;
            this.button1.Location = new System.Drawing.Point(961, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 40);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Cadas
            // 
            this.btn_Cadas.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cadas.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Cadas.Image = global::AfroPower.Properties.Resources.BotaoCadastro;
            this.btn_Cadas.Location = new System.Drawing.Point(614, 421);
            this.btn_Cadas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cadas.Name = "btn_Cadas";
            this.btn_Cadas.Size = new System.Drawing.Size(262, 64);
            this.btn_Cadas.TabIndex = 1;
            this.btn_Cadas.Text = "\r\n";
            this.btn_Cadas.UseVisualStyleBackColor = false;
            this.btn_Cadas.Click += new System.EventHandler(this.btn_Cadas_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Login.Image = global::AfroPower.Properties.Resources.BotaoEntrar;
            this.btn_Login.Location = new System.Drawing.Point(347, 421);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(240, 64);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Cadas);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cadas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

