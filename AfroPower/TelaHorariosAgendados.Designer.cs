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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HorariosAgendados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HorariosAgendados
            // 
            this.dgv_HorariosAgendados.AllowUserToAddRows = false;
            this.dgv_HorariosAgendados.AllowUserToDeleteRows = false;
            this.dgv_HorariosAgendados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_HorariosAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HorariosAgendados.Location = new System.Drawing.Point(82, 218);
            this.dgv_HorariosAgendados.Name = "dgv_HorariosAgendados";
            this.dgv_HorariosAgendados.ReadOnly = true;
            this.dgv_HorariosAgendados.RowHeadersWidth = 51;
            this.dgv_HorariosAgendados.RowTemplate.Height = 24;
            this.dgv_HorariosAgendados.Size = new System.Drawing.Size(1424, 625);
            this.dgv_HorariosAgendados.TabIndex = 0;
            // 
            // Horários
            // 
            this.Horários.AutoSize = true;
            this.Horários.Font = new System.Drawing.Font("Lucida Handwriting", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horários.Location = new System.Drawing.Point(238, 41);
            this.Horários.Name = "Horários";
            this.Horários.Size = new System.Drawing.Size(973, 104);
            this.Horários.TabIndex = 1;
            this.Horários.Text = "Horários Agendados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione uma data:";
            // 
            // TelaHorariosAgendados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1600, 1102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Horários);
            this.Controls.Add(this.dgv_HorariosAgendados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaHorariosAgendados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaHorariosAgendados";
            this.Load += new System.EventHandler(this.TelaHorariosAgendados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HorariosAgendados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HorariosAgendados;
        private System.Windows.Forms.Label Horários;
        private System.Windows.Forms.Label label1;
    }
}