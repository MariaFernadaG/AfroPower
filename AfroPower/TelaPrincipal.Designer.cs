namespace AfroPower
{
    partial class TelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agendarHorárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarHorárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trancistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dicasDeCuidadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFeedbacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPrincipal = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(90, 90, 0, 90);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarHorárioToolStripMenuItem,
            this.trancistaToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(170, 1055);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agendarHorárioToolStripMenuItem
            // 
            this.agendarHorárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarHorárioToolStripMenuItem1,
            this.manutençõesToolStripMenuItem});
            this.agendarHorárioToolStripMenuItem.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendarHorárioToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.agendarHorárioToolStripMenuItem.Name = "agendarHorárioToolStripMenuItem";
            this.agendarHorárioToolStripMenuItem.Size = new System.Drawing.Size(148, 48);
            this.agendarHorárioToolStripMenuItem.Text = "Cliente ";
            this.agendarHorárioToolStripMenuItem.Click += new System.EventHandler(this.agendarHorárioToolStripMenuItem_Click);
            // 
            // agendarHorárioToolStripMenuItem1
            // 
            this.agendarHorárioToolStripMenuItem1.Name = "agendarHorárioToolStripMenuItem1";
            this.agendarHorárioToolStripMenuItem1.Size = new System.Drawing.Size(358, 48);
            this.agendarHorárioToolStripMenuItem1.Text = "Agendar Horário";
            this.agendarHorárioToolStripMenuItem1.Click += new System.EventHandler(this.agendarHorárioToolStripMenuItem1_Click);
            // 
            // manutençõesToolStripMenuItem
            // 
            this.manutençõesToolStripMenuItem.Name = "manutençõesToolStripMenuItem";
            this.manutençõesToolStripMenuItem.Size = new System.Drawing.Size(358, 48);
            this.manutençõesToolStripMenuItem.Text = "Adicionar Feedback";
            this.manutençõesToolStripMenuItem.Click += new System.EventHandler(this.manutençõesToolStripMenuItem_Click);
            // 
            // trancistaToolStripMenuItem
            // 
            this.trancistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarHorarioToolStripMenuItem,
            this.horáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.dicasDeCuidadosToolStripMenuItem,
            this.verFeedbacksToolStripMenuItem});
            this.trancistaToolStripMenuItem.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trancistaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.trancistaToolStripMenuItem.Name = "trancistaToolStripMenuItem";
            this.trancistaToolStripMenuItem.Size = new System.Drawing.Size(148, 48);
            this.trancistaToolStripMenuItem.Text = "Trancista";
            // 
            // adicionarHorarioToolStripMenuItem
            // 
            this.adicionarHorarioToolStripMenuItem.Name = "adicionarHorarioToolStripMenuItem";
            this.adicionarHorarioToolStripMenuItem.Size = new System.Drawing.Size(369, 48);
            this.adicionarHorarioToolStripMenuItem.Text = "Adicionar horario";
            this.adicionarHorarioToolStripMenuItem.Click += new System.EventHandler(this.adicionarHorarioToolStripMenuItem_Click);
            // 
            // horáriosToolStripMenuItem
            // 
            this.horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            this.horáriosToolStripMenuItem.Size = new System.Drawing.Size(369, 48);
            this.horáriosToolStripMenuItem.Text = "Horários Agendados";
            this.horáriosToolStripMenuItem.Click += new System.EventHandler(this.horáriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(369, 48);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // dicasDeCuidadosToolStripMenuItem
            // 
            this.dicasDeCuidadosToolStripMenuItem.Name = "dicasDeCuidadosToolStripMenuItem";
            this.dicasDeCuidadosToolStripMenuItem.Size = new System.Drawing.Size(369, 48);
            this.dicasDeCuidadosToolStripMenuItem.Text = "Dicas de Cuidados";
            this.dicasDeCuidadosToolStripMenuItem.Click += new System.EventHandler(this.dicasDeCuidadosToolStripMenuItem_Click);
            // 
            // verFeedbacksToolStripMenuItem
            // 
            this.verFeedbacksToolStripMenuItem.Name = "verFeedbacksToolStripMenuItem";
            this.verFeedbacksToolStripMenuItem.Size = new System.Drawing.Size(369, 48);
            this.verFeedbacksToolStripMenuItem.Text = "Ver Feedbacks";
            this.verFeedbacksToolStripMenuItem.Click += new System.EventHandler(this.verFeedbacksToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharProgramaToolStripMenuItem,
            this.sairDaContaToolStripMenuItem});
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(163, 48);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(318, 48);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar Programa";
            // 
            // sairDaContaToolStripMenuItem
            // 
            this.sairDaContaToolStripMenuItem.Name = "sairDaContaToolStripMenuItem";
            this.sairDaContaToolStripMenuItem.Size = new System.Drawing.Size(318, 48);
            this.sairDaContaToolStripMenuItem.Text = "Sair da conta";
            // 
            // listPrincipal
            // 
            this.listPrincipal.BackColor = System.Drawing.Color.Tan;
            this.listPrincipal.FormattingEnabled = true;
            this.listPrincipal.ItemHeight = 16;
            this.listPrincipal.Location = new System.Drawing.Point(223, 200);
            this.listPrincipal.Name = "listPrincipal";
            this.listPrincipal.Size = new System.Drawing.Size(846, 436);
            this.listPrincipal.TabIndex = 1;
            this.listPrincipal.SelectedIndexChanged += new System.EventHandler(this.listPrincipal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dicas de cuidados ";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1582, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendarHorárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarHorárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manutençõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trancistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dicasDeCuidadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDaContaToolStripMenuItem;
        private System.Windows.Forms.ListBox listPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem verFeedbacksToolStripMenuItem;
    }
}