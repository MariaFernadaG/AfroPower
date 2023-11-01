namespace AfroPower
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
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(31, 337);
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.RowHeadersWidth = 51;
            this.dgv_horarios.RowTemplate.Height = 24;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(301, 101);
            this.dgv_horarios.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(47, 239);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(276, 262);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 10, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 10, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 31, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(47, 298);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // AdicionarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_horarios);
            this.Name = "AdicionarHorario";
            this.Text = "AdicionarHorario";
            this.Load += new System.EventHandler(this.AdicionarHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Excluir;
    }
}