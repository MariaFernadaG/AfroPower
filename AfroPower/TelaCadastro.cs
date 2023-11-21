using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace AfroPower
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }
       
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_senha.Text) || string.IsNullOrEmpty(maskedData.Text) || string.IsNullOrEmpty(cb_Nivel.Text))
            {
                Regex regex = new Regex(@"^([\w.\-]+)@([\w\-]+)(\.\w{2,3})?((\.com\.br)?)?$");
                if (regex.IsMatch(txt_Email.Text))
                {
                    Usuario usuario = new Usuario();
                    usuario.nome = txt_nome.Text;
                    usuario.email = txt_Email.Text;
                    usuario.senha = txt_senha.Text;
                    usuario.data = maskedData.Text;
                    usuario.nivel = cb_Nivel.Text;

                    if (Banco.ExisteUsername(usuario))
                    {
                        MessageBox.Show("E-mail já cadastrado");
                        return; // Não prossegue para a tela inicial se o e-mail já estiver cadastrado
                    }
                    Banco.NovoUsuario(usuario);
                    TelaBoasVindasCliente telaBoasVindasCliente = new TelaBoasVindasCliente();
                    telaBoasVindasCliente.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email não corresponde ao formato!");
                }
            }
           
            else
                {

                MessageBox.Show("Por favor, preencha todos os campos");
               

                }
            
            
        }


       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
