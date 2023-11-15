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
    public partial class TelaHorariosAgendados : Form
    {
        public TelaHorariosAgendados()
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
            //botao presença
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Ação";
            buttonColumn.Text = "Cliente Veio";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgv_HorariosAgendados.Columns.Add(buttonColumn);

            // Manipulador de evento para o clique no botão na grade de dados
            dgv_HorariosAgendados.CellContentClick += DataGridViewButtonClicked;


        }
       
        private void TelaHorariosAgendados_Load(object sender, EventArgs e)
        {
          
            string vquery = @"
        SELECT 
            N_IDFUNCIONARIO as 'ID',
            T_FUNCIONARIO as 'Funcionario',
            T_DIA as 'Dia',
            T_DESCRICAOHORARIO as 'Horários',
            T_SERVICO as 'Nagos',
            T_ADICIONAL as 'Box Braids',
            N_VALORTOTAL as 'Valor',
            T_NOMECLIENTE as 'Cliente',
            T_OBESERVACAOCLIENTE as 'Observação'
           
        FROM 
            Tb_AdicionarHorario
        WHERE T_STATUS = 'Indisponível';  -- Filtra somente horários disponíveis
    ";

            DataTable dt = Banco.consulta(vquery);
            dgv_HorariosAgendados.DataSource = dt;
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



            dgv_HorariosAgendados.DataSource = Banco.consulta(vquery);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorData(dateTimePicker1.Value);
        }
        private void FiltrarPorData2(DateTime data)
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



            dgv_HorariosAgendados.DataSource = Banco.consulta(vquery);
        }

      

        private void DataGridViewButtonClicked(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi na coluna do botão e faz algo
            int columnIndexAcao = dgv_HorariosAgendados.Columns["Ação"]?.Index ?? -1; // Obtém o índice da coluna "Ação" ou define -1 se não encontrar
            if (e.ColumnIndex == columnIndexAcao && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_HorariosAgendados.Rows[e.RowIndex];
                if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out int idCliente))
                {
                    AtualizarNumeroConsultasCliente(idCliente);
                }
                else
                {
                    MessageBox.Show("NULLLL");
                }
            }
        }

        private void AtualizarNumeroConsultasCliente(int idCliente)
        {
            string vquery = $"UPDATE tb_Usuarios SET N_Numero = N_Numero + 1 WHERE N_IDUSUARIO = {idCliente}";
            Banco.dml(vquery);



        }
    }
}
