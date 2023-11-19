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
    public partial class DicasDeCuidado : Form
    {
        DataTable dt = new DataTable();
        public event EventHandler DicasAtualizadas;
        public DicasDeCuidado()
        {
            InitializeComponent();
        }

        private void DicasDeCuidado_Load(object sender, EventArgs e)
        {
            AtualizarListBox(); // Chama o método para carregar os dados na inicialização do formulário
        }

        private void AtualizarListBox()
        {
            try
            {
                DataTable dicas = Banco.consulta("SELECT T_Dicas FROM tb_Dicasdecuidado");

                listBox1.Items.Clear();

                foreach (DataRow row in dicas.Rows)
                {
                    string textoDica = row["T_Dicas"].ToString();
                    listBox1.Items.Add(textoDica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dicas do banco de dados: " + ex.Message);
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {

            string novaDica = txtNovaDica.Text.Trim(); // Obtém a nova dica do TextBox

            if (!string.IsNullOrEmpty(novaDica))
            {
                try
                {
                    // Adiciona a nova dica ao banco de dados
                    string insertQuery = "INSERT INTO tb_Dicasdecuidado (T_Dicas) VALUES ('" + novaDica + "')";
                    Banco.dml(insertQuery, "Nova dica adicionada com sucesso ao banco de dados!", "Erro ao adicionar ao banco de dados");

                    // Adiciona a nova dica à listBox1
                    listBox1.Items.Add(novaDica);
                    OnDicasAtualizadas();
                    txtNovaDica.Text = ""; // Limpa o TextBox após adicionar
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
            if (listBox1.SelectedItem != null)
            {
                string textoSelecionado = listBox1.SelectedItem.ToString(); // Obtém o texto do item selecionado na listBox1

                try
                {
                    // Remove o item do banco de dados
                    string deleteQuery = $"DELETE FROM tb_Dicasdecuidado WHERE T_Dicas = '{textoSelecionado}'";
                    Banco.dml(deleteQuery, "Item removido com sucesso do banco de dados!", "Erro ao remover do banco de dados");

                    // Remove o item da listBox1
                    listBox1.Items.Remove(textoSelecionado);
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
        protected virtual void OnDicasAtualizadas()
        {
            DicasAtualizadas?.Invoke(this, EventArgs.Empty);
        }
    }
}



