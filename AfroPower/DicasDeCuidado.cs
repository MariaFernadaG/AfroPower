using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AfroPower
{
    public partial class DicasDeCuidado : Form
    {
        private BindingList<string> listaDicas = new BindingList<string>();

        public event EventHandler DicasAtualizadas;

        private ListBox listBox2 = new ListBox();
        public ListBox ListPrincipal { get; set; }

        public DicasDeCuidado()
        {
            InitializeComponent();
            listBox1.DataSource = listaDicas;
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            listBox1.MeasureItem += ListBox1_MeasureItem;
            listBox1.DrawItem += ListBox1_DrawItem;
        }

        private void DicasDeCuidado_Load(object sender, EventArgs e)
        {
            AtualizarListBox();
        }

        private void AtualizarListBox()
        {
            try
            {
                DataTable dicas = Banco.consulta("SELECT T_Dicas FROM tb_Dicasdecuidado");

                listaDicas.Clear();

                foreach (DataRow row in dicas.Rows)
                {
                    string textoDica = row["T_Dicas"].ToString();
                    listaDicas.Add(textoDica + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dicas do banco de dados: " + ex.Message);
            }
        }

        public void AtualizarListBox2(List<string> itens)
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(itens.ToArray());
        }

        public ListBox ListBoxDicas
        {
            get { return listBox1; }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            string novaDica = txtNovaDica.Text.Trim();

            if (!string.IsNullOrEmpty(novaDica))
            {
                try
                {
                    string insertQuery = $"INSERT INTO tb_Dicasdecuidado (T_Dicas) VALUES ('{novaDica}')";
                    Banco.dml(insertQuery, "Nova dica adicionada com sucesso ao banco de dados!", "Erro ao adicionar ao banco de dados");

                    // Adiciona a nova dica à lista com quebra de linha automática
                    listaDicas.Add(novaDica + Environment.NewLine);

                    OnDicasAtualizadas();
                    txtNovaDica.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar ao banco de dados: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira uma nova dica.");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedIndex < listaDicas.Count)
            {
                string textoSelecionado = listaDicas[listBox1.SelectedIndex];

                try
                {
                    string deleteQuery = $"DELETE FROM tb_Dicasdecuidado WHERE T_Dicas = '{textoSelecionado.Trim()}'";
                    Banco.dml(deleteQuery, "Item removido com sucesso do banco de dados!", "Erro ao remover do banco de dados");

                    listaDicas.RemoveAt(listBox1.SelectedIndex);
                    OnDicasAtualizadas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir do banco de dados: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir.");
            }
        }

        private void dicasDeCuidadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == "trancista")
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Show();

                // Copia os itens da ListBoxDicas para a ListBox no formulário TelaPrincipal
                telaPrincipal.CopiarItens(listBox1, telaPrincipal.ListPrincipal);

                this.Close();
            }
        }

        protected virtual void OnDicasAtualizadas()
        {
            DicasAtualizadas?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }

        private void ListBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index >= 0 && e.Index < listaDicas.Count)
            {
                e.ItemHeight = (int)e.Graphics.MeasureString(listaDicas[e.Index], listBox1.Font, listBox1.Width).Height;
            }
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0 && e.Index < listaDicas.Count)
            {
                e.DrawBackground();
                e.Graphics.DrawString(listaDicas[e.Index], e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }
    }
}
