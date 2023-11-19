﻿using System;
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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }
       
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_senha.Text) || string.IsNullOrEmpty(txt_Data.Text) || string.IsNullOrEmpty(cb_Nivel.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos");
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.nome = txt_nome.Text;
                usuario.email = txt_Email.Text;
                usuario.senha = txt_senha.Text;
                usuario.data = txt_Data.Text;
                usuario.nivel = cb_Nivel.Text;
                Banco.NovoUsuario(usuario);
               
            }

            TelaPrincipal principal = new TelaPrincipal();  
            principal.Close();
            this.Close();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
