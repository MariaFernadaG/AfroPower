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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HorariosAgendados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HorariosAgendados
            // 
            this.dgv_HorariosAgendados.AllowUserToAddRows = false;
            this.dgv_HorariosAgendados.AllowUserToDeleteRows = false;
            this.dgv_HorariosAgendados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_HorariosAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HorariosAgendados.Location = new System.Drawing.Point(62, 177);
            this.dgv_HorariosAgendados.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_HorariosAgendados.Name = "dgv_HorariosAgendados";
            this.dgv_HorariosAgendados.ReadOnly = true;
            this.dgv_HorariosAgendados.RowHeadersWidth = 51;
            this.dgv_HorariosAgendados.RowTemplate.Height = 24;
            this.dgv_HorariosAgendados.Size = new System.Drawing.Size(946, 359);
            this.dgv_HorariosAgendados.TabIndex = 0;
            // 
            // Horários
            // 
            this.Horários.AutoSize = true;
            this.Horários.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horários.Location = new System.Drawing.Point(232, 12);
            this.Horários.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Horários.Name = "Horários";
            this.Horários.Size = new System.Drawing.Size(618, 73);
            this.Horários.TabIndex = 1;
            this.Horários.Text = "Horários Agendados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione uma data:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AfroPower.Properties.Resources.BotaoVoltar;
            this.button1.Location = new System.Drawing.Point(1113, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaHorariosAgendados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Horários);
            this.Controls.Add(this.dgv_HorariosAgendados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button1;
    }
}