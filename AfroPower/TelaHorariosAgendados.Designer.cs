namespace AfroPower
{
    partial class TelaHorariosAgendados
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
            this.dgv_HorariosAgendados = new System.Windows.Forms.DataGridView();
            this.Horários = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HorariosAgendados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HorariosAgendados
            // 
            this.dgv_HorariosAgendados.AllowUserToAddRows = false;
            this.dgv_HorariosAgendados.AllowUserToDeleteRows = false;
            this.dgv_HorariosAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HorariosAgendados.Location = new System.Drawing.Point(57, 179);
            this.dgv_HorariosAgendados.Name = "dgv_HorariosAgendados";
            this.dgv_HorariosAgendados.ReadOnly = true;
            this.dgv_HorariosAgendados.RowHeadersWidth = 51;
            this.dgv_HorariosAgendados.RowTemplate.Height = 24;
            this.dgv_HorariosAgendados.Size = new System.Drawing.Size(1431, 250);
            this.dgv_HorariosAgendados.TabIndex = 0;
            // 
            // Horários
            // 
            this.Horários.AutoSize = true;
            this.Horários.Location = new System.Drawing.Point(34, 79);
            this.Horários.Name = "Horários";
            this.Horários.Size = new System.Drawing.Size(44, 16);
            this.Horários.TabIndex = 1;
            this.Horários.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 609);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TelaHorariosAgendados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Horários);
            this.Controls.Add(this.dgv_HorariosAgendados);
            this.Name = "TelaHorariosAgendados";
            this.Text = "TelaHorariosAgendados";
            this.Load += new System.EventHandler(this.TelaHorariosAgendados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HorariosAgendados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HorariosAgendados;
        private System.Windows.Forms.Label Horários;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}