using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfroPower
{
   
    public partial class TelaPrincipal : Form
    {
        DataTable dt = new DataTable();
        public TelaPrincipal()
        {
            InitializeComponent();
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

                // Limpa a listPrincipal antes de adicionar novos itens
                listPrincipal.Items.Clear();

                // Itera sobre o DataTable e adiciona os valores da coluna T_Dicas à listPrincipal
                foreach (DataRow row in dicas.Rows)
                {
                    string textoDica = row["T_Dicas"].ToString(); // Supondo que "T_Dicas" é o nome da coluna que contém o texto da dica
                    listPrincipal.Items.Add(textoDica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dicas do banco de dados: " + ex.Message);
            }
        }


        private void agendarHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globais.nivel==trancistaToolStripMenuItem.Text)
            {
                AdicionarHorario t = new  AdicionarHorario();
                t.Show();
            }
            else
            {
                MessageBox.Show("Usuario nao permitido");
            }
        }

        private void agendarHorárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaMarcarhorario marcarhorario = new TelaMarcarhorario();
            marcarhorario.Show();   
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == trancistaToolStripMenuItem.Text)
            {
               TelaHorariosAgendados a = new TelaHorariosAgendados();
               a.Show();
            }
            else
            {
                MessageBox.Show("Usuario nao permitido");
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == trancistaToolStripMenuItem.Text)
            {
                Cliente cliente = new Cliente();
                cliente.Show();
            }
          
        }

        private void dicasDeCuidadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == trancistaToolStripMenuItem.Text)
            {
                DicasDeCuidado dicas = new DicasDeCuidado();
                dicas.DicasAtualizadas += AtualizarListBoxPrincipal; 
                dicas.Show();
            }
        }

        private void listPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
              CarregarDicasNaListBoxPrincipal();
        }

        private void manutençõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdiocionarFeedbacks f = new AdiocionarFeedbacks();
            f.Show();
           
        }

        private void verFeedbacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
        VerFeedbacks v = new VerFeedbacks();
        v.Show();
        }
    }
}
