﻿namespace AfroPower
{
    partial class AdicionarHorario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.txt_Funcionario = new System.Windows.Forms.TextBox();
            this.msk_horario = new System.Windows.Forms.MaskedTextBox();
            this.msk_Data = new System.Windows.Forms.MaskedTextBox();
            this.tb_idhorarios = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            this.dgv_horarios.AllowUserToResizeColumns = false;
            this.dgv_horarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_horarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_horarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_horarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_horarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_horarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(335, 84);
            this.dgv_horarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.RowHeadersWidth = 51;
            this.dgv_horarios.RowTemplate.Height = 24;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(516, 225);
            this.dgv_horarios.TabIndex = 0;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // txt_Funcionario
            // 
            this.txt_Funcionario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Funcionario.Location = new System.Drawing.Point(566, 348);
            this.txt_Funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Funcionario.Name = "txt_Funcionario";
            this.txt_Funcionario.Size = new System.Drawing.Size(76, 20);
            this.txt_Funcionario.TabIndex = 2;
            // 
            // msk_horario
            // 
            this.msk_horario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msk_horario.Location = new System.Drawing.Point(552, 431);
            this.msk_horario.Margin = new System.Windows.Forms.Padding(2);
            this.msk_horario.Mask = "00:00";
            this.msk_horario.Name = "msk_horario";
            this.msk_horario.Size = new System.Drawing.Size(90, 20);
            this.msk_horario.TabIndex = 6;
            this.msk_horario.ValidatingType = typeof(System.DateTime);
            // 
            // msk_Data
            // 
            this.msk_Data.BackColor = System.Drawing.Color.WhiteSmoke;
            this.msk_Data.Location = new System.Drawing.Point(298, 431);
            this.msk_Data.Margin = new System.Windows.Forms.Padding(2);
            this.msk_Data.Mask = "00/00/0000";
            this.msk_Data.Name = "msk_Data";
            this.msk_Data.Size = new System.Drawing.Size(74, 20);
            this.msk_Data.TabIndex = 7;
            this.msk_Data.ValidatingType = typeof(System.DateTime);
            // 
            // tb_idhorarios
            // 
            this.tb_idhorarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_idhorarios.Enabled = false;
            this.tb_idhorarios.Location = new System.Drawing.Point(530, 348);
            this.tb_idhorarios.Margin = new System.Windows.Forms.Padding(2);
            this.tb_idhorarios.Name = "tb_idhorarios";
            this.tb_idhorarios.Size = new System.Drawing.Size(18, 20);
            this.tb_idhorarios.TabIndex = 8;
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Status.Location = new System.Drawing.Point(823, 431);
            this.txt_Status.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(76, 20);
            this.txt_Status.TabIndex = 10;
            this.txt_Status.Text = "Disponível";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 55);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adicionar Horários:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Funcionario(a):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(820, 405);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AfroPower.Properties.Resources.BotaoVoltar;
            this.button1.Location = new System.Drawing.Point(1100, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Limpar.Image = global::AfroPower.Properties.Resources.BotaoLimpar;
            this.bt_Limpar.Location = new System.Drawing.Point(786, 489);
            this.bt_Limpar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(188, 65);
            this.bt_Limpar.TabIndex = 9;
            this.bt_Limpar.UseVisualStyleBackColor = false;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Excluir.Image = global::AfroPower.Properties.Resources.BotaoExcluir;
            this.btn_Excluir.Location = new System.Drawing.Point(520, 489);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(177, 65);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Image = global::AfroPower.Properties.Resources.BotaoSalvar;
            this.btn_salvar.Location = new System.Drawing.Point(243, 489);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(171, 65);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // AdicionarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.tb_idhorarios);
            this.Controls.Add(this.msk_Data);
            this.Controls.Add(this.msk_horario);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_Funcionario);
            this.Controls.Add(this.dgv_horarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarHorario";
            this.Load += new System.EventHandler(this.AdicionarHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Funcionario;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.MaskedTextBox msk_horario;
        private System.Windows.Forms.MaskedTextBox msk_Data;
        private System.Windows.Forms.TextBox tb_idhorarios;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}