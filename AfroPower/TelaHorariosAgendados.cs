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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private bool filtroAtivo = false;
        public TelaHorariosAgendados()
        {
            InitializeComponent();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            Controls.Add(dateTimePicker1);

            // Configurar as propriedades do DateTimePicker conforme necessário
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Location = new System.Drawing.Point(60, 140);
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
            MostrarTodosHorariosIndisponiveis();
        }
        private void MostrarTodosHorariosIndisponiveis()
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
            WHERE T_STATUS = 'Indisponível';";

            DataTable dt = Banco.consulta(vquery);
            dgv_HorariosAgendados.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            filtroAtivo = true; // Ativa o filtro quando o valor do DateTimePicker é alterado
            FiltrarPorData2(dateTimePicker1.Value);
        }
        private void FiltrarPorData2(DateTime data)
        {
            string formattedDate = data.ToString("dd/MM/yyyy");

            // Verifica se o filtro está ativo para aplicar o filtro de data
            if (filtroAtivo)
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
                WHERE
                    T_DIA = '" + formattedDate + @"' AND
                    T_STATUS = 'Indisponível'";

                DataTable dt = Banco.consulta(vquery);
                dgv_HorariosAgendados.DataSource = dt;
            }
        }



        private void DataGridViewButtonClicked(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int columnIndex = dgv.Columns["Ação"]?.Index ?? -1;

            if (e.RowIndex >= 0 && e.ColumnIndex == columnIndex)
            {
                string idCliente = dgv.Rows[e.RowIndex].Cells["ID"].Value?.ToString();

                if (!string.IsNullOrEmpty(idCliente))
                {
                    // Converte o ID do cliente para um inteiro
                    if (int.TryParse(idCliente, out int parsedIdCliente))
                    {
                        // Atualiza o número de consultas do cliente
                        AtualizarNumeroConsultasCliente(parsedIdCliente);
                    }
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
