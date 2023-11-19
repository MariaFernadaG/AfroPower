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
    public partial class TelaLogin : Form
    {

        DataTable dt = new DataTable();
        
        public TelaLogin()
        {
            InitializeComponent();
            
    }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            string senha = txt_Senha.Text;
            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos");
                txt_Email.Focus();
                return;
            }
            string sql = "SELECT * FROM tb_Usuarios WHERE N_EMAILUSUARIO= '" + email + "'AND N_SENHAUSUARIO='" + senha + "'";
            dt = Banco.consulta(sql);
            if (dt.Rows.Count == 1)
            {
                Globais.nome= dt.Rows[0].Field<string>("N_NOMEUSUARIO");
                Globais.nivel = dt.Rows[0].Field<string>("N_NIVEL");
                TelaBoasVindasCliente telaBoasVindasCliente = new TelaBoasVindasCliente();
                telaBoasVindasCliente.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.ShowDialog();
            this.Close();

        }
    }
}
