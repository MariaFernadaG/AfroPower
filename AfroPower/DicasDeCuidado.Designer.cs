namespace AfroPower
{
    partial class DicasDeCuidado
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
            this.txtNovaDica = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNovaDica
            // 
            this.txtNovaDica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNovaDica.Location = new System.Drawing.Point(271, 445);
            this.txtNovaDica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNovaDica.Multiline = true;
            this.txtNovaDica.Name = "txtNovaDica";
            this.txtNovaDica.Size = new System.Drawing.Size(513, 72);
            this.txtNovaDica.TabIndex = 0;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Location = new System.Drawing.Point(683, 458);
            this.btn_Adicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(85, 43);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "ENVIAR";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(271, 131);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(513, 277);
            this.listBox1.TabIndex = 2;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Location = new System.Drawing.Point(468, 541);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(128, 49);
            this.btn_Excluir.TabIndex = 3;
            this.btn_Excluir.Text = "button1";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(916, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DicasDeCuidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1024, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txtNovaDica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DicasDeCuidado";
            this.Text = "DicasDeCuidado";
            this.Load += new System.EventHandler(this.DicasDeCuidado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNovaDica;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button button1;
    }
}