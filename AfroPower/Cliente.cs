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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            CarregarDadosDoDataGridView();
        }
        private void CarregarDadosDoDataGridView()
        {
            string vquery = @"
                SELECT 
                    N_IDUSUARIO as 'ID',
                    N_NOMEUSUARIO as 'Usuarios',
                    N_EMAILUSUARIO as 'Email',
                    N_NIVEL as 'Nivel'
                   
                FROM 
                  tb_Usuarios                      
            ";

            DataTable dt = Banco.consulta(vquery);
            dgv_Clientes.DataSource = dt;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int idUsuario = Convert.ToInt32(dgv_Clientes.CurrentRow.Cells["ID"].Value); 

                string vquery = $"DELETE FROM Tb_Usuarios WHERE N_IDUSUARIO = '{idUsuario}'";
                Banco.dml(vquery);
                dgv_Clientes.Rows.Remove(dgv_Clientes.CurrentRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }
    }
}
