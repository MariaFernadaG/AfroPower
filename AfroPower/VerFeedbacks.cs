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
    public partial class VerFeedbacks : Form
    {
        public VerFeedbacks()
        {
            InitializeComponent();

        }


       
        private void AtualizarListaFeedbacks()
        {
            try
            {
               
                var feedbacks = Banco.consulta("SELECT T_Feedbacks FROM tb_Feedbacks");

                foreach (DataRow row in feedbacks.Rows)
                {
                    string textoFeedback = row["T_Feedbacks"].ToString();
                    listBoxFeedbacks.Items.Add(textoFeedback);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter feedbacks do banco de dados: " + ex.Message);
            }

            

        }

        private void VerFeedbacks_Load(object sender, EventArgs e)
        {
            AtualizarListaFeedbacks();
        }
    }
}
