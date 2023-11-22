// TelaPrincipal
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AfroPower
{
    public partial class TelaPrincipal : Form
    {
        DataTable dt = new DataTable();

        public TelaPrincipal()
        {
            InitializeComponent();
            listPrincipal.DrawMode = DrawMode.OwnerDrawVariable;
            listPrincipal.MeasureItem += ListPrincipal_MeasureItem;
            listPrincipal.DrawItem += ListPrincipal_DrawItem;
        }

        private void ListPrincipal_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index >= 0 && e.Index < listPrincipal.Items.Count)
            {
                e.ItemHeight = (int)e.Graphics.MeasureString(listPrincipal.Items[e.Index].ToString(), listPrincipal.Font, listPrincipal.Width).Height;
            }
        }

        private void ListPrincipal_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(listPrincipal.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
        private void AbrirFormDicas()
        {
            DicasDeCuidado formDicas = new DicasDeCuidado();
            formDicas.DicasAtualizadas += AtualizarListBoxPrincipal;
            formDicas.ShowDialog();
        }

        private void AtualizarListBoxPrincipal(object sender, EventArgs e)
        {
            CarregarDicasNaListBoxPrincipal();
        }

        private void CarregarDicasNaListBoxPrincipal()
        {
            try
            {
                DataTable dicas = Banco.consulta("SELECT T_Dicas FROM tb_Dicasdecuidado");

                listPrincipal.Items.Clear();

                foreach (DataRow row in dicas.Rows)
                {
                    string textoDica = row["T_Dicas"].ToString();

                    // Adiciona a dica com quebra de linha automática
                    listPrincipal.Items.Add(textoDica + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dicas do banco de dados: " + ex.Message);
            }
        }

        private void agendarHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implemente a lógica necessária
        }

        private void adicionarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == trancistaToolStripMenuItem.Text)
            {
                AdicionarHorario t = new AdicionarHorario();
                t.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso não permitido");
            }
        }

        private void agendarHorárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaMarcarhorario marcarhorario = new TelaMarcarhorario();
            marcarhorario.Show();
            this.Close();
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == trancistaToolStripMenuItem.Text)
            {
                TelaHorariosAgendados a = new TelaHorariosAgendados();
                a.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso não permitido");
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == trancistaToolStripMenuItem.Text)
            {
                Cliente cliente = new Cliente();
                cliente.Show();
                this.Close();
            }
        }

        private void dicasDeCuidadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == trancistaToolStripMenuItem.Text)
            {
                DicasDeCuidado dicas = new DicasDeCuidado();
                dicas.DicasAtualizadas += AtualizarListBoxPrincipal;
                dicas.Show();
                this.Close();
            }
        }

        private void listPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implemente a lógica necessária
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            CarregarDicasNaListBoxPrincipal();
        }

        private void manutençõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdiocionarFeedbacks f = new AdiocionarFeedbacks();
            f.Show();
            this.Close();
        }

        public void CopiarItens(ListBox sourceListBox, ListBox destinationListBox)
        {
            // Limpa os itens existentes no ListBox de destino
            destinationListBox.Items.Clear();

            // Adiciona os itens do ListBox de origem para o ListBox de destino
            foreach (var item in sourceListBox.Items)
            {
                destinationListBox.Items.Add(item);
            }
        }

        private void verFeedbacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == trancistaToolStripMenuItem.Text)
            {
                VerFeedbacks v = new VerFeedbacks();
                v.Show();
                this.Close();
            }
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairDaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        public ListBox ListPrincipal
        {
            get { return listPrincipal; }
        }
    }
}
