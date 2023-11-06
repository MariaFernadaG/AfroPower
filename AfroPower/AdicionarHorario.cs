using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AfroPower
{
    public partial class AdicionarHorario : Form
    {
        public AdicionarHorario()
        {
            InitializeComponent();
        }

       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           

        }

       

        private void AdicionarHorario_Load(object sender, EventArgs e)
        {
            string vquery = @"
            SELECT 
                N_IDFUNCIONARIO as 'ID',
                T_FUNCIONARIO as 'Funcionario',
                T_DIA as 'Dia',
                T_DESCRICAOHORARIO as 'Horários',
                T_STATUS as 'Status'
                FROM 
            Tb_AdicionarHorario
            ";
            dgv_horarios.DataSource = Banco.consulta(vquery);
            /*dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 50;*/
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string funcionario = txt_Funcionario.Text;
            string data = msk_Data.Text;
            string horario = msk_horario.Text;
            string status = txt_Status.Text;

            
            string vquery = "INSERT INTO Tb_AdicionarHorario (T_FUNCIONARIO, T_DIA, T_DESCRICAOHORARIO,T_STATUS) VALUES ('" + funcionario + "', '" + data + "', '" + horario + "','"+status+"')";
            Banco.dml(vquery);
            vquery = @"
            SELECT 
                N_IDFUNCIONARIO as 'ID',
                T_FUNCIONARIO as 'Funcionario',
                T_DIA as 'Dia',
                T_DESCRICAOHORARIO as 'Horários',
                T_STATUS as 'Status'
                FROM 
            Tb_AdicionarHorario
            ";
            dgv_horarios.DataSource = Banco.consulta(vquery);

        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                  SELECT
                    *
                  FROM
                   Tb_AdicionarHorario
                 WHERE
                      N_IDFUNCIONARIO=" + vid;
                dt=Banco.dql(vquery);
               
                
                tb_idhorarios.Text = dt.Rows[0].Field<Int64>("N_IDFUNCIONARIO").ToString();
                txt_Funcionario.Text = dt.Rows[0].Field<string>("T_FUNCIONARIO").ToString();
                msk_Data.Text = dt.Rows[0].Field<string>("T_DIA").ToString();
                msk_horario.Text = dt.Rows[0].Field<string>("T_DESCRICAOHORARIO").ToString();
                txt_Status.Text = dt.Rows[0].Field<string>("T_STATUS").ToString();



            }
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_idhorarios.Clear();
            txt_Funcionario.Clear();    
            msk_Data.Clear();   
            msk_horario.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM Tb_AdicionarHorario WHERE N_IDFUNCIONARIO = '" + tb_idhorarios.Text + "'";
                Banco.dml(vquery);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
            }
        }
    }
}
