namespace AfroPower
{
    partial class TelaMarcarhorario
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
            this.dgv_horariosmarcar = new System.Windows.Forms.DataGridView();
            this.cb_Servicos = new System.Windows.Forms.ComboBox();
            this.txt_Obeservacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Funcionario = new System.Windows.Forms.TextBox();
            this.msk_Hora = new System.Windows.Forms.MaskedTextBox();
            this.msk_Data = new System.Windows.Forms.MaskedTextBox();
            this.btn_Agendar = new System.Windows.Forms.Button();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Adicionais = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horariosmarcar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_horariosmarcar
            // 
            this.dgv_horariosmarcar.AllowUserToAddRows = false;
            this.dgv_horariosmarcar.AllowUserToDeleteRows = false;
            this.dgv_horariosmarcar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_horariosmarcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horariosmarcar.Location = new System.Drawing.Point(288, 114);
            this.dgv_horariosmarcar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_horariosmarcar.MultiSelect = false;
            this.dgv_horariosmarcar.Name = "dgv_horariosmarcar";
            this.dgv_horariosmarcar.ReadOnly = true;
            this.dgv_horariosmarcar.RowHeadersWidth = 51;
            this.dgv_horariosmarcar.RowTemplate.Height = 24;
            this.dgv_horariosmarcar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horariosmarcar.Size = new System.Drawing.Size(562, 258);
            this.dgv_horariosmarcar.TabIndex = 0;
            this.dgv_horariosmarcar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_horariosmarcar_CellContentClick);
            // 
            // cb_Servicos
            // 
            this.cb_Servicos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Servicos.FormattingEnabled = true;
            this.cb_Servicos.Location = new System.Drawing.Point(581, 422);
            this.cb_Servicos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Servicos.Name = "cb_Servicos";
            this.cb_Servicos.Size = new System.Drawing.Size(145, 21);
            this.cb_Servicos.TabIndex = 1;
            this.cb_Servicos.SelectedIndexChanged += new System.EventHandler(this.cb_Servicos_SelectedIndexChanged);
            // 
            // txt_Obeservacao
            // 
            this.txt_Obeservacao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Obeservacao.Location = new System.Drawing.Point(581, 512);
            this.txt_Obeservacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Obeservacao.Multiline = true;
            this.txt_Obeservacao.Name = "txt_Obeservacao";
            this.txt_Obeservacao.Size = new System.Drawing.Size(337, 55);
            this.txt_Obeservacao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agende seu horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nagos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 474);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Observação:";
            // 
            // txt_Funcionario
            // 
            this.txt_Funcionario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Funcionario.Enabled = false;
            this.txt_Funcionario.Location = new System.Drawing.Point(260, 445);
            this.txt_Funcionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Funcionario.Name = "txt_Funcionario";
            this.txt_Funcionario.Size = new System.Drawing.Size(90, 20);
            this.txt_Funcionario.TabIndex = 8;
            // 
            // msk_Hora
            // 
            this.msk_Hora.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msk_Hora.Enabled = false;
            this.msk_Hora.Location = new System.Drawing.Point(260, 547);
            this.msk_Hora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msk_Hora.Mask = "00:00";
            this.msk_Hora.Name = "msk_Hora";
            this.msk_Hora.Size = new System.Drawing.Size(68, 20);
            this.msk_Hora.TabIndex = 9;
            this.msk_Hora.ValidatingType = typeof(System.DateTime);
            // 
            // msk_Data
            // 
            this.msk_Data.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msk_Data.Enabled = false;
            this.msk_Data.Location = new System.Drawing.Point(135, 547);
            this.msk_Data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msk_Data.Mask = "00/00/0000";
            this.msk_Data.Name = "msk_Data";
            this.msk_Data.Size = new System.Drawing.Size(62, 20);
            this.msk_Data.TabIndex = 10;
            this.msk_Data.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Agendar
            // 
            this.btn_Agendar.Location = new System.Drawing.Point(409, 650);
            this.btn_Agendar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Agendar.Name = "btn_Agendar";
            this.btn_Agendar.Size = new System.Drawing.Size(161, 59);
            this.btn_Agendar.TabIndex = 11;
            this.btn_Agendar.Text = "Agendar";
            this.btn_Agendar.UseVisualStyleBackColor = true;
            this.btn_Agendar.Click += new System.EventHandler(this.btn_Agendar_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Status.Enabled = false;
            this.txt_Status.Location = new System.Drawing.Point(380, 547);
            this.txt_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(76, 20);
            this.txt_Status.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(788, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Box Braids";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Enabled = false;
            this.textBoxValor.Location = new System.Drawing.Point(962, 514);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(76, 20);
            this.textBoxValor.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 498);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor Total:";
            // 
            // cb_Adicionais
            // 
            this.cb_Adicionais.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Adicionais.FormattingEnabled = true;
            this.cb_Adicionais.Location = new System.Drawing.Point(788, 422);
            this.cb_Adicionais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Adicionais.Name = "cb_Adicionais";
            this.cb_Adicionais.Size = new System.Drawing.Size(131, 21);
            this.cb_Adicionais.TabIndex = 18;
            this.cb_Adicionais.SelectedIndexChanged += new System.EventHandler(this.cb_Adicionais_SelectedIndexChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(745, 650);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(140, 59);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_NomeCliente.Enabled = false;
            this.txt_NomeCliente.Location = new System.Drawing.Point(135, 444);
            this.txt_NomeCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.Size = new System.Drawing.Size(76, 20);
            this.txt_NomeCliente.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 428);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tracista:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 531);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Data:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 531);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Horário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 531);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Selecione uma data:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(922, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaMarcarhorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NomeCliente);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.cb_Adicionais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.btn_Agendar);
            this.Controls.Add(this.msk_Data);
            this.Controls.Add(this.msk_Hora);
            this.Controls.Add(this.txt_Funcionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Obeservacao);
            this.Controls.Add(this.cb_Servicos);
            this.Controls.Add(this.dgv_horariosmarcar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaMarcarhorario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaMarcarhorario";
            this.Load += new System.EventHandler(this.TelaMarcarhorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horariosmarcar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_horariosmarcar;
        private System.Windows.Forms.ComboBox cb_Servicos;
        private System.Windows.Forms.TextBox txt_Obeservacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Funcionario;
        private System.Windows.Forms.MaskedTextBox msk_Hora;
        private System.Windows.Forms.MaskedTextBox msk_Data;
        private System.Windows.Forms.Button btn_Agendar;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Adicionais;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_NomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}