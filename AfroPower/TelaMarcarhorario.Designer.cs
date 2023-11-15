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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horariosmarcar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_horariosmarcar
            // 
            this.dgv_horariosmarcar.AllowUserToAddRows = false;
            this.dgv_horariosmarcar.AllowUserToDeleteRows = false;
            this.dgv_horariosmarcar.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_horariosmarcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horariosmarcar.Location = new System.Drawing.Point(25, 68);
            this.dgv_horariosmarcar.MultiSelect = false;
            this.dgv_horariosmarcar.Name = "dgv_horariosmarcar";
            this.dgv_horariosmarcar.ReadOnly = true;
            this.dgv_horariosmarcar.RowHeadersWidth = 51;
            this.dgv_horariosmarcar.RowTemplate.Height = 24;
            this.dgv_horariosmarcar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horariosmarcar.Size = new System.Drawing.Size(1109, 148);
            this.dgv_horariosmarcar.TabIndex = 0;
            this.dgv_horariosmarcar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_horariosmarcar_CellContentClick);
            // 
            // cb_Servicos
            // 
            this.cb_Servicos.FormattingEnabled = true;
            this.cb_Servicos.Location = new System.Drawing.Point(502, 303);
            this.cb_Servicos.Name = "cb_Servicos";
            this.cb_Servicos.Size = new System.Drawing.Size(192, 24);
            this.cb_Servicos.TabIndex = 1;
            this.cb_Servicos.SelectedIndexChanged += new System.EventHandler(this.cb_Servicos_SelectedIndexChanged);
            // 
            // txt_Obeservacao
            // 
            this.txt_Obeservacao.BackColor = System.Drawing.Color.White;
            this.txt_Obeservacao.Location = new System.Drawing.Point(502, 390);
            this.txt_Obeservacao.Multiline = true;
            this.txt_Obeservacao.Name = "txt_Obeservacao";
            this.txt_Obeservacao.Size = new System.Drawing.Size(448, 67);
            this.txt_Obeservacao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agende seu horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nagos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Observação:";
            // 
            // txt_Funcionario
            // 
            this.txt_Funcionario.Enabled = false;
            this.txt_Funcionario.Location = new System.Drawing.Point(212, 357);
            this.txt_Funcionario.Name = "txt_Funcionario";
            this.txt_Funcionario.Size = new System.Drawing.Size(118, 22);
            this.txt_Funcionario.TabIndex = 8;
            // 
            // msk_Hora
            // 
            this.msk_Hora.Enabled = false;
            this.msk_Hora.Location = new System.Drawing.Point(212, 435);
            this.msk_Hora.Mask = "00:00";
            this.msk_Hora.Name = "msk_Hora";
            this.msk_Hora.Size = new System.Drawing.Size(89, 22);
            this.msk_Hora.TabIndex = 9;
            this.msk_Hora.ValidatingType = typeof(System.DateTime);
            // 
            // msk_Data
            // 
            this.msk_Data.Enabled = false;
            this.msk_Data.Location = new System.Drawing.Point(59, 435);
            this.msk_Data.Mask = "00/00/0000";
            this.msk_Data.Name = "msk_Data";
            this.msk_Data.Size = new System.Drawing.Size(82, 22);
            this.msk_Data.TabIndex = 10;
            this.msk_Data.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Agendar
            // 
            this.btn_Agendar.Location = new System.Drawing.Point(292, 475);
            this.btn_Agendar.Name = "btn_Agendar";
            this.btn_Agendar.Size = new System.Drawing.Size(215, 73);
            this.btn_Agendar.TabIndex = 11;
            this.btn_Agendar.Text = "Agendar";
            this.btn_Agendar.UseVisualStyleBackColor = true;
            this.btn_Agendar.Click += new System.EventHandler(this.btn_Agendar_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.Enabled = false;
            this.txt_Status.Location = new System.Drawing.Point(356, 435);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(100, 22);
            this.txt_Status.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Box Braids";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(932, 303);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 22);
            this.textBoxValor.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(929, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor Total:";
            // 
            // cb_Adicionais
            // 
            this.cb_Adicionais.FormattingEnabled = true;
            this.cb_Adicionais.Location = new System.Drawing.Point(725, 303);
            this.cb_Adicionais.Name = "cb_Adicionais";
            this.cb_Adicionais.Size = new System.Drawing.Size(173, 24);
            this.cb_Adicionais.TabIndex = 18;
            this.cb_Adicionais.SelectedIndexChanged += new System.EventHandler(this.cb_Adicionais_SelectedIndexChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(643, 475);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(187, 73);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.Enabled = false;
            this.txt_NomeCliente.Location = new System.Drawing.Point(59, 354);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.Size = new System.Drawing.Size(100, 22);
            this.txt_NomeCliente.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tracista:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Data:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Horário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Status:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TelaMarcarhorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 560);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Name = "TelaMarcarhorario";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}