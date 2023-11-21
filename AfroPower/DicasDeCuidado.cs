using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace AfroPower
{
    public partial class DicasDeCuidado : Form
    {
        private DataTable dt = new DataTable();
        private BindingList<string> listaDicas = new BindingList<string>();

        public event EventHandler DicasAtualizadas;

        public DicasDeCuidado()
        {
            InitializeComponent();
            listBox1.DataSource = listaDicas;
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
                    listaDicas.Add(textoDica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dicas do banco de dados: " + ex.Message);
            }
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

                    AtualizarListBox();
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
            if (listBox1.SelectedItem != null)
            {
                string textoSelecionado = listBox1.SelectedItem.ToString();

                try
                {
                    string deleteQuery = $"DELETE FROM tb_Dicasdecuidado WHERE T_Dicas = '{textoSelecionado}'";
                    Banco.dml(deleteQuery, "Item removido com sucesso do banco de dados!", "Erro ao remover do banco de dados");

                    listaDicas.Remove(textoSelecionado);
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

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }
    }
}
