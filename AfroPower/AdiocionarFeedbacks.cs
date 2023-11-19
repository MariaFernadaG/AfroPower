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
    public partial class AdiocionarFeedbacks : Form
    {
        public event EventHandler NovoFeedbackAdicionado;

        public AdiocionarFeedbacks()
        {
            InitializeComponent();

        }

        private void bnt_Adcionar_Click(object sender, EventArgs e)
        {
            string novofeedback = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(novofeedback))
            {
                try
                {
                    string insertQuery = "INSERT INTO tb_Feedbacks (T_Feedbacks) VALUES ('" + novofeedback + "')";
                    Banco.dml(insertQuery, "FeedBack Adicionado com sucesso!", "Erro ao adicionar feedback");

                    // Após adicionar, atualize o ListBox na tela de VerFeedbacks
                    var VerFeedbacks = Application.OpenForms["VerFeedbacks"] as VerFeedbacks;
                   //  VerFeedbacks?.AtualizarListaFeedbacks();

                    textBox1.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar ao banco de dados: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um feedback.");
            }
        }
        protected virtual void OnNovoFeedbackAdicionado(EventArgs e)
        {
            NovoFeedbackAdicionado?.Invoke(this, e);
        }
    }
}