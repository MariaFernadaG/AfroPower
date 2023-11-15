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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public AdicionarHorario()
        {
            InitializeComponent();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            Controls.Add(dateTimePicker1);

            // Configurar as propriedades do DateTimePicker conforme necessário
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Location = new System.Drawing.Point(20, 20);
            // ... outras configurações

            // Adicionar um manipulador de eventos para lidar com a mudança de valor
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorData(dateTimePicker1.Value);

        }

        private void FiltrarPorData(DateTime data)
        {
            string formattedDate = data.ToString("dd/MM/yyyy");
           

            // Certifique-se de que está usando DateTime como tipo de dado
            if (data is DateTime)
            {
                formattedDate = ((DateTime)data).ToString("dd/MM/yyyy");
            }

            string vquery = @"
                SELECT 
                    N_IDFUNCIONARIO as 'ID',
                    T_FUNCIONARIO as 'Funcionario',
                    T_DIA as 'Dia',
                    T_DESCRICAOHORARIO as 'Horários',
                    T_STATUS as 'Status'
                FROM 
                    Tb_AdicionarHorario
                WHERE
                    T_DIA = '" + formattedDate + "'";
           


            dgv_horarios.DataSource = Banco.consulta(vquery);
        }

        private void AdicionarHorario_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            FiltrarPorData(dateTimePicker1.Value);

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
